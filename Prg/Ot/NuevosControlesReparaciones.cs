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
        // Instanciamos el StatMsg de la clase 
        private StatMsg m_smResult = new StatMsg("NuevosControlesReparaciones");
        //private Bel. m_leReparacionesSeleccionadas;
        //private Entidad 

        // Constructor Inicial
        public NuevosControlesReparaciones()
        {
            InitializeComponent();
            ((MainFrame)App.GetMainWindow()).AddContent(this);
        }
        
        #endregion

        #region Metodos Privados

        private void LLenarComboPatentesMoviles(CDCombo p_cdcCombo)
        {
            // reseteamos el statmsg
            m_smResult.UilReset("LLenarComboPatentesMoviles");
            // llenamos la combo con los moviles
            p_cdcCombo.FillFromStrLEntidad(Bll.Moviles.UpFull(true, ref m_smResult), "mov_ecd_patente", "mov_ecd_patente", "deleted");
            // chequeamos que haya salido todo bien
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            //seteamos en el null para que se vea fancy
            p_cdcCombo.SelectedIndex = -1;
        }

        #endregion

        #region Eventos de los Controles

        private void rbControles_CheckedChanged(object sender, EventArgs e)
        {
            //si no esta seleccionado volvemos.
            if (!rbControles.Checked)
                return;
            // nos aseguramos de que haya un movil seleccionado
            if (cdcPatente.SelectedIndex == -1)
            {
                MsgRuts.ShowMsg(this, "No hay ningun Movil seleccionado");
                return;
            }
            //cambiamos el nombre del ImgGroup
            igControlReparacion.GroupTitle = "Controles";
            // reseteamos al statmsg
            m_smResult.UilReset("rbControles_CheckedChanged");
            //llenamos la lista con los controles de la tabla
            cdlControlesReparaciones.FillFromStrLEntidad(Bll.Controles.UpFull(true, ref m_smResult), "ctl_cod_cod", "ctl_des_des", "deleted");
            // chequeamos que haya salido todo bien
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
        }

        private void rbReparaciones_CheckedChanged(object sender, EventArgs e)
           {
                // si no esta chequeado hacemos un return
               if (!rbReparaciones.Checked)
                   return;
                // nos aseguramos de que haya un movil seleccionado
                if (cdcPatente.SelectedIndex == -1)
                {
                    MsgRuts.ShowMsg(this, "No hay ningun Movil seleccionado");
                    return;
                }
                //cambiamos el nombre del ImgGroup
                igControlReparacion.GroupTitle = "Reparaciones";    
                // reseteamos al statmsg
                m_smResult.UilReset("rbControles_CheckedChanged");
                //llenamos la lista con los controles de la tabla
                cdlControlesReparaciones.FillFromStrLEntidad(Bll.Tablas.RepUpFull(true, ref m_smResult), "rep_cd6_cod", "rep_xde_des", "deleted");
                // chequeamos que haya salido todo bien
                if (MsgRuts.AnalizeError(this, m_smResult)) return;
            }
        
        private void NuevosControlesReparaciones_Load(object sender, EventArgs e)
        {
            // LLenamos Las patentes que hay en la tabla.
            LLenarComboPatentesMoviles(cdcPatente);
        }

        private void gbCancel_Click(object sender, EventArgs e)
        {
            // mostramos un mensaje si esta seguro de cerrar
            if (MsgRuts.ShowMsg(this, 
                "Si cierra la pantalla perdera todo lo hecho en ella", 
                MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            // si el dialog es OK cerramos.
            this.Close();
        }



        #endregion




    }
}
