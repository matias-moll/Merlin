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


        public CierreOT()
        {
            InitializeComponent();
            // Obtenemos los permisos ACL
            m_aclInfo = App.ACLInfo;

            // Aplicamos los nieves de seguridad
            App.ApplySecurity(this);

            // Iniciamos los objetos de la clase
            m_smResult = new StatMsg("CierreOT");

            LlenarCombo();


        }

        private void LlenarCombo()
        {
            m_smResult.UilReset("LlenarCombo");
            m_LEMoviles = Bll.Moviles.UpFull(true, ref m_smResult);
            cdcMoviles.FillFromStrLEntidad(m_LEMoviles, "mov_ecd_patente", "mov_des_des", "deleted");
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            
        }

        private void gbBuscar_Click(object sender, EventArgs e)
        {
            m_smResult.UilReset("Buscar");
        }


    }
}
