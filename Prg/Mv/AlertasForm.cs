using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TNGS.NetRoutines;
using TNGS.NetApp;

namespace Mrln.Mv
{
    public partial class AlertasForm : UserControl
    {
        //miembros
        private StatMsg m_smResult;
        private Bel.LEDestinatariosMails m_leGruposDestinatarios;
        private Bel.LEMoviles m_leMoviles;
        private Bel.LEControles m_leControles;
        private Bel.LEReparaciones m_leReparaciones;
        private Bel.LEMovilesAlertas m_leMovilesAlertas;

        //constructor principal
        public AlertasForm()
        {
            InitializeComponent();

            m_smResult = new StatMsg();
        }

        private void Alertas_Load(object sender, EventArgs e)
        {
            m_leMoviles = Bll.Moviles.UpFull(true, m_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), m_smResult)) return;

            cdcMoviles.FillFromStrLEntidad(m_leMoviles, Bel.EMovil.PatenteCmp, Bel.EMovil.DesCmp, "deleted");

            m_leGruposDestinatarios = Bll.Tablas.DemUpFull(true, m_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), m_smResult)) return;

            m_leControles = Bll.Controles.UpFull(true, m_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), m_smResult)) return;

            m_leReparaciones = Bll.Tablas.RepUpFull(true, m_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), m_smResult)) return;

            cdcControlesEspecifico.FillFromStrLEntidad(m_leControles, Bel.EControl.CodCmp, Bel.EControl.DesCmp, "deleted");
            cdcControlesPeriodicos.FillFromStrLEntidad(m_leControles, Bel.EControl.CodCmp, Bel.EControl.DesCmp, "deleted");
            cdcControlesPostReparacion.FillFromStrLEntidad(m_leControles, Bel.EControl.CodCmp, Bel.EControl.DesCmp, "deleted");

            cdcReparacionesPostReparacion.FillFromStrLEntidad(m_leReparaciones, Bel.EReparacion.CodCmp, Bel.EReparacion.DesCmp, "deleted");

            cdcGruposDestinatarios.FillFromStrLEntidad(m_leGruposDestinatarios, Bel.EDestinatariosMail.CodigoCmp, Bel.EDestinatariosMail.DescripcionCmp, "deleted");
            cdcGruposDestinatarios.AddStrCD("", "", 0);

            if (m_leGruposDestinatarios.Count == 1)
                cdcGruposDestinatarios.SelectedStrCode = m_leGruposDestinatarios[0].Codigo;
        }

        #region Eventos de los controles

        private void cdcGruposDestinatarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            cdListaDestinatarios.Clear();

            if (cdcGruposDestinatarios.SelectedStrCode.Trim() == "")
                return;

            Bel.EDestinatariosMail grupo = m_leGruposDestinatarios.Where(grupoDest => grupoDest.Codigo == cdcGruposDestinatarios.SelectedStrCode).First();

            string[] destinatarios = grupo.Destinatarios.Split(new char[] { ',' });
            foreach (string destinatario in destinatarios)
                if (destinatario.Trim() != "")
                    cdListaDestinatarios.AddStrCD(destinatario, destinatario, 0);
        }

        private void gbAgregarEspecifico_Click(object sender, EventArgs e)
        {
            grabarConfigAlerta(neEnkmEspecifico.Numero, "", cdcControlesEspecifico.SelectedStrCode);

            limpiarDestinatarios();
        }

        private void gbAgregarPeriodicos_Click(object sender, EventArgs e)
        {
            int kmsInicial = neDesdeKmsPeriodicos.Numero;

            // Creamos N alertas hasta alcanzar el kilometraje especificado cada X kilometros.
            for (int kmsActual = kmsInicial; kmsActual <= neHastaKmsPeriodicos.Numero; kmsActual += neCadaKmsPeriodicos.Numero)
            {
                grabarConfigAlerta(kmsActual, "", cdcControlesPeriodicos.SelectedStrCode);
            }


            limpiarDestinatarios();
        }

        private void gbAgregarPostReparacion_Click(object sender, EventArgs e)
        {
            grabarConfigAlerta(neEnkmPostReparacion.Numero, cdcReparacionesPostReparacion.SelectedStrCode, cdcControlesPostReparacion.SelectedStrCode);

            limpiarDestinatarios();
        }

        private void cdcMoviles_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarGrillaAlertas();
        }

        private void cargarGrillaAlertas()
        {
            m_leMovilesAlertas = Bll.Moviles.MvalFGet(m_leMoviles[cdcMoviles.SelectedStrCode].Patente.Trim(), true, m_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), m_smResult)) return;

            if (m_leMovilesAlertas != null)
            {
                m_leMovilesAlertas.ChangeCaption("deleted", "");
                fgConfigAlertas.FillFromLEntidad(m_leMovilesAlertas);
            }
        }

        private void gbBorrarSeleccionados_Click(object sender, EventArgs e)
        {
            Bel.LEMovilesAlertas alertasABorrar = Bel.LEMovilesAlertas.NewEmpty();

            // Recorremos todas las entidades para ver cuales estan chequeadas y las agregamos a la lista a borrar.
            for (int index = 0; index < fgConfigAlertas.Count; index++)
                if (fgConfigAlertas.GetCheckState(index))
                    alertasABorrar.AddEntity(m_leMovilesAlertas[index]);


            if (alertasABorrar.Count == 0)
            {
                MsgRuts.ShowMsg(App.GetMainWindow(), "No hay ninguna configuracion de alerta seleccionada para borrar.");
                return;
            }

            // Removemos todas las alertas seleccionadas
            foreach (Bel.EMovilAlerta alertaBorrar in alertasABorrar)
            {
                Bll.Moviles.MvalRemove(alertaBorrar.Patente, alertaBorrar.Nroconfigalerta, alertaBorrar.FxdVersion, m_smResult);
                if (MsgRuts.AnalizeError(App.GetMainWindow(), m_smResult)) return;
            }

            cargarGrillaAlertas();
        }

        #endregion

        #region Metodos privados de la UIL

        private void limpiarDestinatarios()
        {
            cdListaDestinatarios.Clear();
            cdcGruposDestinatarios.SelectedStrCode = "";
        }

        private void grabarConfigAlerta(int kilometros, string codReparacion, string codControl)
        {
            ETalonario taloConfigAlerta = App.TaloGet("ConfAlerta", m_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), m_smResult)) return;

            Bel.EMovilAlerta alertaNueva = Bel.EMovilAlerta.NewEmpty();
            alertaNueva.Patente = cdcMoviles.SelectedStrCode;
            alertaNueva.Nroconfigalerta = taloConfigAlerta.Valor;
            alertaNueva.Kilometros = kilometros;
            alertaNueva.Codreparacion = codReparacion;
            alertaNueva.Codcontrol = codControl;
            alertaNueva.Coddestinatarios = cdcGruposDestinatarios.SelectedStrCode;
            Bll.Moviles.MvalSave(alertaNueva, m_smResult);
            if (MsgRuts.AnalizeError(App.GetMainWindow(), m_smResult)) return;

            cargarGrillaAlertas();
        }

        #endregion
    }
}
