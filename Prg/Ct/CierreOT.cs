using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rivn.Bll;
using Rivn.Bll.ObjetosSoporte;
using Rivn.Bel;
using TNGS;
using TNGS.NetApp;
using TNGS.NetRoutines;
using TNGS.NetControls;

namespace Rivn.Ct
{
    /// <summary>
    /// Formulario para consulta de datos del oficina
    /// </summary>
    public partial class CierreOT : Form
    {
        #region
        private LEMoviles m_LEMoviles = null;
        private LEOTItems m_LEOTitems = null;
        private LEOrdenesTrabajo m_LEOTTrabajos = null;
        private EOTItem m_EOTitemSeleccionado = null;
        private StatMsg m_smResult = null;
        private ACLInfo m_aclInfo = null;
        #endregion
            

        /// <summary>
        /// Constuctor
        /// </summary>
        public CierreOT()
        {
            InitializeComponent();

            // Inicializar variables
            m_smResult = new StatMsg();

            // Fijamos el formulario de la aplicacion
            App.SetMainWindow(this, mnuMain, null, sbpMensaje, sbpConexion, sbpUsuario, sbpPercent, sbpAvance);

            LlenarCombo();
        }


        private void LlenarCombo()
        {
            m_LEMoviles = Bll.Moviles.UpFull(true, ref m_smResult);
            cdcMoviles.FillFromStrLEntidad(m_LEMoviles, "mov_ecd_patente", "mov_des_des", "deleted");
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

        }

        private void gbBuscar_Click(object sender, EventArgs e)
        {
            m_LEOTTrabajos = Bll.OrdenesTrabajo.ObtenerOTsPorPatente(cdcMoviles.SelectedStrCode, ref m_smResult);
            if (m_LEOTTrabajos.Count == 0)
            {
                MsgRuts.ShowMsg(this,"El Movil elegido no tiene ordenes de trabajo asociadas");
                return;
            }
            fgGrillaOT.FillFromLEntidad(m_LEOTTrabajos);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

        }


        


    }
}
