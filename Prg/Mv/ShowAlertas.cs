using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mrln.Bll;
using Mrln.Bel;
using TNGS;
using TNGS.NetApp;
using TNGS.NetRoutines;
using TNGS.NetControls;
using WeifenLuo.WinFormsUI.Docking;

namespace Mrln.Mv
{
    public partial class ShowAlertas : Form
    {
        List<EAlerta> m_lsAlertas = null;
        private StatMsg m_smResult = null;
        Bel.EAlerta m_eAlertaEnPantalla = null;

        public ShowAlertas(List<EAlerta> alertasAMostrar)
        {
            InitializeComponent();
            m_smResult = new StatMsg();
            m_lsAlertas = alertasAMostrar;
        }

        private void ShowAlertas_Load(object sender, EventArgs e)
        {
            mostrarAlertaEnPantalla();
        }

        #region Eventos 

        private void gbVisto_Click(object sender, EventArgs e)
        {
            marcarAlertaEnPantallaVista();

            Bll.Alertas.AleSave(m_eAlertaEnPantalla, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            removerAlertaActualYMostrarSiguiente();
        }

        private void gbFinalizarAlerta_Click(object sender, EventArgs e)
        {
            marcarAlertaEnPantallaVista();
            m_eAlertaEnPantalla.Finalizada = "S";

            Bll.Alertas.AleSave(m_eAlertaEnPantalla, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            removerAlertaActualYMostrarSiguiente();
        }

        private void gbConfirmarRecordarEn_Click(object sender, EventArgs e)
        {
            if (neRepetirEn.Numero == 0)
            {
                MsgRuts.ShowMsg(this, "No se puede repetir el alerta en 0 dias.");
                return;
            }

            marcarAlertaEnPantallaVista();
            m_eAlertaEnPantalla.Repetirendias = neRepetirEn.Numero;

            Bll.Alertas.AleSave(m_eAlertaEnPantalla, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            removerAlertaActualYMostrarSiguiente();
        }

        private void gbAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }


        #endregion

        #region Metodos Privados

        private void mostrarAlertaEnPantalla()
        {
            neRepetirEn.Numero = 0;

            m_eAlertaEnPantalla = m_lsAlertas[0];
            lblTotalAlertas.Text = m_lsAlertas.Count.ToString();

            lblNroAlerta.Text = m_eAlertaEnPantalla.Nroalerta.ToString();
            lblDescripcion.Text = m_eAlertaEnPantalla.Descripcion;
            lblDetalle.Text = m_eAlertaEnPantalla.Detalle;
            cambiarColorFondo(m_eAlertaEnPantalla.Importancia);
        }
        private void marcarAlertaEnPantallaVista()
        {
            // Si el alerta ya fue vista no hay que hacer nada
            if (m_eAlertaEnPantalla.Usuariovista.Trim() != "")
                return;

            DateTime fechaActual = Bll.Moviles.fGetDate(ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            m_eAlertaEnPantalla.Fechavista = fechaActual;
            m_eAlertaEnPantalla.Usuariovista = App.Usuario.Usuario;
            // El default es resetear este campo, si el usuario clickeo el repetir con un valor valido se va a llenar luego.
            m_eAlertaEnPantalla.Repetirendias = 0; 
        }

        private void removerAlertaActualYMostrarSiguiente()
        {
            m_lsAlertas.Remove(m_eAlertaEnPantalla);

            // Si no quedan mas alertas cerramos el formulario, sino mostramos la siguiente en pantalla
            if (m_lsAlertas.Count == 0)
                gbAceptar_Click(this, null);
            else
                mostrarAlertaEnPantalla();
        }

        private void cambiarColorFondo(string importancia)
        {
            if (importancia == "R")
            {
                // Pintar fondo de rojo.
            }
            else
            {
                // Meh
            }
        }

        #endregion

    }
}
