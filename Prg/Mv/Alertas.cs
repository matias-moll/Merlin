using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mrln.Bll;
using TNGS;
using TNGS.NetApp;
using TNGS.NetRoutines;
using TNGS.NetControls;
using WeifenLuo.WinFormsUI.Docking;


namespace Mrln.Mv
{
    public partial class Alertas : DockContent
    {

        //miembros
        private StatMsg m_smResult;
        private Bel.LEDestinatariosMails m_leGruposDestinatarios;
        private Bel.LEMoviles m_leMoviles;
        private Bel.LEControles m_leControles;
        private Bel.LEReparaciones m_leReparaciones;

        //constructor principal
        public Alertas()
        {
            InitializeComponent();
           
            m_smResult = new StatMsg();

            // Dockeamos el formulario
            ((MainFrame)App.GetMainWindow()).AddContent(this);
        }

        private void Alertas_Load(object sender, EventArgs e)
        {
            m_leMoviles = Bll.Moviles.UpFull(true, ref m_smResult);
            MsgRuts.AnalizeError(this, m_smResult);

            cdcMoviles.FillFromStrLEntidad(m_leMoviles, Bel.EMovil.PatenteCmp, Bel.EMovil.DesCmp, "deleted");

            m_leGruposDestinatarios = Bll.Tablas.DemUpFull(true, ref m_smResult);
            MsgRuts.AnalizeError(this, m_smResult);

            m_leControles = Bll.Controles.UpFull(true, ref m_smResult);
            MsgRuts.AnalizeError(this, m_smResult);

            m_leReparaciones = Bll.Tablas.RepUpFull(true, ref m_smResult);
            MsgRuts.AnalizeError(this, m_smResult);

            cdcControlesEspecifico.FillFromStrLEntidad(m_leControles, Bel.EControl.CodCmp, Bel.EControl.DesCmp, "deleted");
            cdcControlesPeriodicos.FillFromStrLEntidad(m_leControles, Bel.EControl.CodCmp, Bel.EControl.DesCmp, "deleted");
            cdcControlesPostReparacion.FillFromStrLEntidad(m_leControles, Bel.EControl.CodCmp, Bel.EControl.DesCmp, "deleted");

            cdcReparacionesPostReparacion.FillFromStrLEntidad(m_leReparaciones, Bel.EReparacion.CodCmp, Bel.EReparacion.DesCmp, "deleted");

            cdcGruposDestinatarios.FillFromStrLEntidad(m_leGruposDestinatarios, Bel.EDestinatariosMail.CodigoCmp, Bel.EDestinatariosMail.DescripcionCmp, "deleted");
        }

        #region Eventos de los controles


        private void cdcGruposDestinatarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            cdListaDestinatarios.Clear();

            string[] destinatarios = m_leGruposDestinatarios[cdcGruposDestinatarios.SelectedStrCode].Destinatarios.Split(new char[] { ',' });
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
            ListaEntidades alertasMoviles = m_leMoviles[cdcMoviles.SelectedStrCode].MovilesAlertas;

            if (alertasMoviles != null)
                fgConfigAlertas.FillFromLEntidad(alertasMoviles);
        }

        private void gbBorrarSeleccionados_Click(object sender, EventArgs e)
        {

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
            // TODO: Documentar y traer el talonario de config alerta. Grabar con ese valor mas los tres parametros.
        }

        #endregion

    }
}
