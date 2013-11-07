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

namespace Rivn.Ot
{
    public partial class NuevosControlesReparaciones:DockContent
    {

        #region Miembros y Contructores
        // Variables Miembro
        private StatMsg m_smResult;

        // Constructor Inicial
        public NuevosControlesReparaciones()
        {
            InitializeComponent();
            m_smResult = new StatMsg("NuevosControlesReparaciones");
        }
        
        #endregion

        #region Metodos Privados

        private void LLenarComboPatentesMoviles(CDCombo p_cdcCombo)
        {
            // reseteamos el statmsg
            m_smResult.UilReset("LLenarComboPatentesMoviles");
            // llenamos la combo con los moviles
            p_cdcCombo.FillFromStrLEntidad(Bll.Moviles.UpFull(true, ref m_smResult), "mov_ecd_patente", "mov_des_des", "deleted");
            // chequeamos que haya salido todo bien
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
        }

        #endregion

        #region Eventos de los Controles

        private void rbControles_CheckedChanged(object sender, EventArgs e)
        {
            // nos aseguramos de que haya un movil seleccionado
            if (cdcPatente.SelectedIndex == -1)
            {
                MsgRuts.ShowMsg(this, "No hay ningun Movil seleccionado");
                return;
            }

            // reseteamos al statmsg
            m_smResult.UilReset("rbControles_CheckedChanged");
            //llenamos la lista con los controles de la tabla
            cdlControlesReparaciones.FillFromStrLEntidad(Bll.Controles.UpFull(true, ref m_smResult), "ctl_cod_cod", "ctl_des_des", "deleted");
            // chequeamos que haya salido todo bien
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
        }

        private void rbReparaciones_CheckedChanged(object sender, EventArgs e)
           {
                // nos aseguramos de que haya un movil seleccionado
                if (cdcPatente.SelectedIndex == -1)
                {
                    MsgRuts.ShowMsg(this, "No hay ningun Movil seleccionado");
                    return;
                }

                // reseteamos al statmsg
                m_smResult.UilReset("rbControles_CheckedChanged");
                //llenamos la lista con los controles de la tabla
                cdlControlesReparaciones.FillFromStrLEntidad(Bll.Controles.UpFull(true, ref m_smResult), "ctl_cod_cod", "ctl_des_des", "deleted");
                // chequeamos que haya salido todo bien
                if (MsgRuts.AnalizeError(this, m_smResult)) return;
            }

        #endregion

       
      
    }
}
