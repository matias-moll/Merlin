using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TNGS;
using TNGS.NetControls;
using TNGS.NetRoutines;
using TNGS.NetApp;
using WeifenLuo.WinFormsUI.Docking;
using Mrln.Bel;

namespace Mrln.Ot
{
    public partial class CierreOrdenes:Form
    {
        // Variables Miembro
        private StatMsg m_smResult = new StatMsg();
        private EOrdenTrabajo m_eOrdenACerrar = null;

        // Constructor Edit
        public CierreOrdenes(int p_iNumeroOrdenTrabajo)
        {
            InitializeComponent();

            m_eOrdenACerrar = Bll.OrdenesTrabajo.Get(p_iNumeroOrdenTrabajo, true, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
        }

        #region Metodos Privados

        #endregion

        #region Eventos de los Controles

        // Cierra el formulario
        private void gbCancel_Click(object sender, EventArgs e)
        {
            // TODO: Agregar if de que todos los items tengan un estado asociado.

            // mostramos un mensaje si esta seguro de cerrar
            if (MsgRuts.ShowMsg(this,
                "Si cierra la pantalla perdera todo lo hecho en ella",
                MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            
            this.Close();
        }

        #endregion
    }
}