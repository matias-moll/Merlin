#region Usings
using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using TNGS.NetRoutines;
using TNGS.NetControls;
using TNGS.NetApp;
using Rivn;
#endregion

namespace Rivn.Mv
{
    //----------------------------------------------------------------------------
    //                         TNG Software UIL Generator
    //----------------------------------------------------------------------------
    // Fecha                     : 30/10/2013 17:05
    // Sistema                   : Rivn
    // Interface para la Entidad : Control
    // Tipo de Interface         : Mantenimiento de Controles
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    /// <summary>
    /// Formulario para Mantenimiento de la Tabla:Controles
    /// </summary>
    public partial class Controles : DockContent
    {
        #region Miembros de la Clase
            private Bel.EControl m_entControl= null;
            private StatMsg m_smResult= null;
            private ACLInfo m_aclInfo= null;
        #endregion


        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Controles()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            // Iniciamos los objetos de la clase
            m_smResult= new StatMsg("Controles           ");

            // Obtenemos los permisos ACL
            m_aclInfo= App.ACLInfo;

            // Aplicamos los nieves de seguridad
            App.ApplySecurity(this);

            // Fijamos el modo Skin
            xpnlBase.SkinFixed= App.WithSkin;
            frmEdicion.SkinFixed= App.WithSkin;
            frmOper.SkinFixed= App.WithSkin;

            // Dockeamos el formulario
            ((MainFrame) App.GetMainWindow()).AddContent(this);

            // Fijamos la imagen del Frm de edicion
            frmEdicion.GroupImage= Icon.ToBitmap();
        }


        //--------------------------------------------------------------
        // Eventos del formulario y los controles
        //--------------------------------------------------------------

        /// <summary>
        /// Carga del Formulario
        /// </summary>
        private void Controles_Load(object sender, System.EventArgs e)
        {
            // Inicializamos el form
            App.ShowMsg("Inicializando el formulario...");

            // Llenamos las Combos (por Lista)
            cmbCrit.AddStrCD("S", "SI", 0);
            cmbCrit.AddStrCD("N", "NO", 0);

            // Pasamos a modo Operaciones, y damos foco al primer campo
            SwitchTo(FormModes.Operations);
            cmdBuscar.Focus();

            // Todo listo
            App.HideMsg();
        }

        /// <summary>
        /// Cierre del formulario
        /// </summary>
        private void Controles_Closed(object sender, System.EventArgs e)
        {
            // Liberamos el menu
            App.LockMenu(false);
        }


        //--------------------------------------------------------------
        // Operaciones
        //--------------------------------------------------------------

        /// <summary>
        /// Genera un Nuevo registro en la tabla
        /// </summary>
        private void cmdNuevo_Click(object sender, System.EventArgs e)
        {
            // Creamos una nueva entidad, pasamos a modo de edicion y
            // damos foco al primer campo
            m_entControl= Bel.EControl.NewEmpty();
            SwitchTo(FormModes.Edit);
            txtCod.Focus();
        }

        /// <summary>
        /// Busca una entidad: Controles
        /// </summary>
        private void cmdBuscar_Click(object sender, System.EventArgs e) 
        {
            // Buscamos una entidad para modificar
            ControlesBus l_fndControles= new ControlesBus();
            if (l_fndControles.ShowDialog() == DialogResult.Cancel) return;

            // Recuperamos la entidad a partir de su clave
            m_smResult.UilReset("cmdBuscar_Click");
            m_entControl= Bll.Controles.Get(l_fndControles.Cod,
                                            false, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Pasamos a modo de edicion y damos foco al segundo campo
            SwitchTo(FormModes.Edit);
            if (!m_entControl.EstaBorrada)
                cmdCancelar.Focus();
            else
                txtDes.Focus();
        }

        /// <summary>
        /// Finaliza el formulario
        /// </summary>
        private void cmdSalir_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Cancela la edicion
        /// </summary>
        private void cmdCancelar_Click(object sender, System.EventArgs e)
        {
            // Pasamos a modo Operaciones y damos foco a buscar
            SwitchTo(FormModes.Operations);
            cmdBuscar.Focus();
        }

        /// <summary>
        /// Graba el registro en edicion
        /// </summary>
        private void cmdGrabar_Click(object sender, System.EventArgs e)
        {
            // Pasamos los datos a la Entidad
            m_entControl.Cod= txtCod.Text;
            m_entControl.Des= txtDes.Text;
            m_entControl.Crit= cmbCrit.SelectedStrCode;

            // Tratamos de grabar la entidad
            App.ShowMsg("Grabando...");
            m_smResult.UilReset("cmdGrabar_Click");
            Bll.Controles.Save(m_entControl, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Pasamos a modo Operaciones, y damos foco a buscar
            SwitchTo(FormModes.Operations);
            cmdBuscar.Focus();
            App.HideMsg();
        }

        //--------------------------------------------------------------
        // Metodos privados
        //--------------------------------------------------------------

        /// <summary>
        /// Cambia el modo del formulario
        /// </summary>
        private void SwitchTo(FormModes p_fmNewMode)
        {
            // Fijamos el nuevo modo del formulario
            switch (p_fmNewMode) {
                case FormModes.Operations   : {OperationMode(); break;}
                case FormModes.Edit         : {EditMode(); break;}
                default                     : {MsgRuts.ShowMsg(this, "Invalid mode"); break;}
            }
        }

        /// <summary>
        /// Pone el formulario en modo: Operaciones
        /// </summary>
        private void OperationMode()
        {
            // Deshabilitamos el frame
            txtCod.Enabled= false;
            txtDes.Enabled= false;
            cmbCrit.Enabled= false;
            cmdCancelar.Enabled= false;
            cmdGrabar.Enabled= false;

            // Blanqueamos los campos
            txtCod.Text= "";
            txtDes.Text= "";
            cmbCrit.SelectedStrCode= "";

            // Habilitamos los controles operativos
            cmdNuevo.Enabled= true;
            cmdBuscar.Enabled= true;
            cmdSalir.Enabled= true;

            // El ESC sale del formulario
            CancelButton= cmdSalir;
        }

        /// <summary>
        /// Pone el formulario en modo: Edicion
        /// </summary>
        private void EditMode()
        {
            // Llenamos los campos a partir de la entidad a editar
            txtCod.Text= m_entControl.Cod;
            txtDes.Text= m_entControl.Des;
            cmbCrit.SelectedStrCode= m_entControl.Crit;

            // Habilitamos el frame
            txtCod.Enabled= m_entControl.EsNueva;
            txtDes.Enabled= !m_entControl.EstaBorrada;
            cmbCrit.Enabled= !m_entControl.EstaBorrada;
            cmdCancelar.Enabled= true;
            cmdGrabar.Enabled= !m_entControl.EstaBorrada;

            // Dehabilitamos los controles operativos
            cmdNuevo.Enabled= false;
            cmdBuscar.Enabled= false;
            cmdSalir.Enabled= false;

            // El ESC sale de la edicion
            CancelButton= cmdCancelar;
        }
    }
}
