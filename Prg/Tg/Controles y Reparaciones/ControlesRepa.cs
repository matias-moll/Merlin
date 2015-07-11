#region Usings
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using WeifenLuo.WinFormsUI.Docking;
using TNGS.NetRoutines;
using TNGS.NetControls;
using TNGS.NetApp;
using Rivn;
#endregion

namespace Rivn.Tg
{
    //----------------------------------------------------------------------------
    //                         TNG Software UIL Generator
    //----------------------------------------------------------------------------
    // Fecha                     : 30/10/2013 17:05
    // Sistema                   : Rivn
    // Interface para la Entidad : ControlRepa
    // Tipo de Interface         : Mantenimiento de Tabla Padre-Hijo
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    /// <summary>
    /// Formulario para Mantenimiento de la Tabla:ControlesReparations
    /// </summary>
    public partial class ControlesRepa : DockContent
    {
        #region Miembros de la Clase
            private Bel.EControlRepa m_entControlRepa= null;
            private StatMsg m_smResult= null;
            private ACLInfo m_aclInfo= null;
            private string m_strSort= "";
            private int m_nroItemAGrabar = 1;
        #endregion

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public ControlesRepa()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            // Obtenemos los permisos ACL
            m_aclInfo= App.ACLInfo;

            // Aplicamos los nieves de seguridad
            App.ApplySecurity(this);

            // Iniciamos los objetos de la clase
            m_smResult= new StatMsg();

            // Fijamos el modo Skin
            xpnlBase.SkinFixed= App.WithSkin;
            frmEdicion.SkinFixed= App.WithSkin;

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
        private void ControlesRepa_Load(object sender, System.EventArgs e)
        {
            // Inicializamos el form
            App.ShowMsg("Inicializando el formulario...");

            Bel.LEControles l_lentControles= Bll.Controles.UpFull(true, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cmbControl.FillFromStrLEntidad(l_lentControles, "ctl_cod_cod", "ctl_des_des", "deleted");
            Bel.LEReparaciones l_lentReparaciones = Bll.Tablas.RepUpFull(true, ref m_smResult);
            cdcCodRep.FillFromStrLEntidad(l_lentReparaciones, "rep_cd6_cod", "rep_xde_des", "deleted");

            // Pasamos a modo Operaciones, llenamos la grilla y 
            // damos foco al primer campo
            SwitchTo(FormModes.Operations, GridOps.Fill);
            grdDatos.Focus();

            // Todo listo
            App.HideMsg();
        }

        /// <summary>
        /// Cierre del formulario
        /// </summary>
        private void ControlesRepa_Closed(object sender, System.EventArgs e)
        {
            // Liberamos el menu
            App.LockMenu(false);
        }

        /// <summary>
        /// Reporte del estado de avance de la grilla
        /// </summary>
        private void grdDatos_Advance(object sender, TNGS.NetRoutines.AdvanceEventArgs e)
        {
            // Marcamos el estado de avance de la operacion en la grilla
            App.Advance(e.Percent);
        }

        /// <summary>
        /// Dobleclick en la grilla
        /// </summary>
        private void grdDatos_DataDClick(object sender, DataDClicEventArgs e)
        {
            // Simulamos modificar
            cmdModificar_Click(this, EventArgs.Empty);
        }

        /// <summary>
        /// Dieron click en el header de la grilla
        /// </summary>
        private void grdDatos_HeaderClick(object sender, MouseEventArgs e)
        {
            // Si es boton izquierdo
            if (e.Button == MouseButtons.Left) {
                // Si cambio el sort simple
                if (m_strSort != grdDatos.GridOrder) {
                    // Grabamos el nuevo sort
                    m_strSort= grdDatos.GridOrder;
                    App.SetStrURegistry(false, "GridFormat", "ControlesRepaGrdSort", m_strSort);
                    return;
                }
            }

            // Si es boton derecho
            if (e.Button == MouseButtons.Right) {
                // Si cambio el sort simple
                if (m_strSort != "") {
                    // Quitamos el orden, grabamos y recargamos
                    m_strSort= "";
                    App.SetStrURegistry(false, "GridFormat", "ControlesRepaGrdSort", m_strSort);
                    FillGrid();
                    return;
                }
            }
        }

        /// <summary>
        /// Cambio el ancho de la columnas
        /// </summary>
        private void GrdColumn_WidthChanged(object sender, EventArgs e)
        {
            // Guardamos el ancho de las columnas
            App.SetStrURegistry(false, "GridFormat", "ControlesRepaGrdWidths", grdDatos.ColWitdhs);
        }

        /// <summary>
        /// Cambio la combo con codigos Padre
        /// </summary>
        private void cmbControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Si se selecciono un codigo
            if (cmbControl.SelectedIndex != -1) {
                // Llenamos la grilla
                FillGrid();
            }
            else {
                // Limpiamos la grilla
                grdDatos.Clear();
            }

            // Damos foco a la grilla
            grdDatos.Focus();
        }

        //--------------------------------------------------------------
        // Operaciones
        //--------------------------------------------------------------

        /// <summary>
        /// Llama al formulario de mantenimiento de la tabla Padre
        /// </summary>
        private void cmdModPadre_Click(object sender, System.EventArgs e)
        {
            // Mostramos el formulario de ABM del padre
            App.SetACL(m_aclInfo);
            Controles l_frmPadre= new Controles();

            l_frmPadre.MdiParent = null;
            l_frmPadre.StartPosition = FormStartPosition.CenterParent;
            l_frmPadre.ShowDialog(this);
            App.SetACL(null);

            // Bloqueamos el menu
            App.LockMenu(true);

            // Recargamos la combo
            App.ShowMsg("Recargando los datos...");

            Bel.LEControles l_lentControles= Bll.Controles.UpFull(true, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cmbControl.FillFromStrLEntidad(l_lentControles, "ctl_cod_cod", "ctl_des_des", "deleted");
            cmbControl.Focus();
            App.HideMsg();
        }

        /// <summary>
        /// Exporta la grilla en Excel
        /// </summary>
        private void cmdExcel_Click(object sender, System.EventArgs e)
        {
            App.ShowMsg("Generando planilla...");
            App.InitAdvance("Excel:");
            grdDatos.ExportToExcel(false, false, "", "ControlesRepa", ref m_smResult);
            App.EndAdvance();
            App.HideMsg();
        }

        /// <summary>
        /// Imprime la grilla
        /// </summary>
        private void cmdPrint_Click(object sender, System.EventArgs e)
        {
            App.ShowMsg("Imprimiendo datos...");
            App.InitAdvance("Imprimiendo:");
            grdDatos.Print(App.ROParams["EMPRESA"].VStr, App.Programa.Nombre,
                           "Lista de ControlesRepa", "");
            App.EndAdvance();
            App.HideMsg();
        }

        /// <summary>
        /// Genera un Nuevo registro en la tabla
        /// </summary>
        private void cmdNuevo_Click(object sender, System.EventArgs e)
        {
            // Si no hay padre -> salimos
            if (cmbControl.SelectedIndex == -1) return;

            // Creamos una nueva entidad, pasamos a modo de edicion y
            // damos foco al primer campo
            m_entControlRepa= Bel.EControlRepa.NewEmpty();
            m_entControlRepa.Codctl= cmbControl.SelectedStrCode;
            SwitchTo(FormModes.Edit, GridOps.DontFill);
            txtNroitem.Focus();
        }

        /// <summary>
        /// Modifica el registro seleccionado de la grilla
        /// </summary>
        private void cmdModificar_Click(object sender, System.EventArgs e)
        {
            // Si no hay item seleccionado -> salimos
            int l_iRow= grdDatos.CurrentRowIndex;
            if (l_iRow == -1) return;

            // Obtenemos la entidad del item seleccionado en la grilla
            App.ShowMsg("Recuperando Datos...");
            m_entControlRepa= Bll.Controles.CrepGet(cmbControl.SelectedStrCode,
                                                    (int) grdDatos.GetMatrixValueObj(l_iRow, 2),
                                                    false, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Tenemos la entidad. Pasamos a modo de edicion y damos foco
            // al campo que corresponda
            SwitchTo(FormModes.Edit, GridOps.DontFill);
            if (m_entControlRepa.EstaBorrada) {
                cmdCancelar.Focus();
            }
            else {
            }
            App.HideMsg();
        }

        /// <summary>
        /// Purga los registros deshabilitados
        /// </summary>
        private void cmdPurgar_Click(object sender, EventArgs e)
        {
            // Pedimos una confirmacion
            if (MsgRuts.AskUser(this, "Atención!!!!\r\n" +
                                      "La compactación de la tabla borra en forma " +
                                      "definitiva los items deshabilitados. " +
                                      "¿Confirma la compactación?",
                                      /*App.Usuario.Usuario +*/ "ControlesRepaPurge") == DialogResult.No) return;

            // Purgamos la tabla
            App.ShowMsg("Compactando la tabla...");
            Bll.Controles.CrepPurge(ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Terminamos
            App.HideMsg();
            MsgRuts.ShowMsg(this, "La tabla ha sido compactada.");
            FillGrid();
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
            // Pasamos a modo Operaciones y damos foco a la grilla
            SwitchTo(FormModes.Operations, GridOps.DontFill);
            grdDatos.Focus();
        }

        /// <summary>
        /// Habilita/Deshabilita el registro
        /// </summary>
        private void cmdDesHab_Click(object sender, System.EventArgs e)
        {
            // Realizamos la operacion
            App.ShowMsg("Procesando...");
            Bll.Controles.CrepEnabled(m_entControlRepa.EstaBorrada,
                                      m_entControlRepa.Codctl,
                                      m_entControlRepa.Nroitem,
                                      m_entControlRepa.FxdVersion,
                                      ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Pasamos a modo Operaciones, rellenamos la grilla y 
            // le damos foco
            SwitchTo(FormModes.Operations, GridOps.Fill);
            grdDatos.Focus();
            App.HideMsg();
        }

        /// <summary>
        /// Graba el registro en edicion
        /// </summary>
        private void cmdGrabar_Click(object sender, System.EventArgs e)
        {
            // Pasamos los datos a la Entidad
            m_entControlRepa.Codctl= cmbControl.SelectedStrCode;
            m_entControlRepa.Nroitem= txtNroitem.Numero;
            m_entControlRepa.Codrep= cdcCodRep.SelectedStrCode;

            // Tratamos de grabar la entidad
            App.ShowMsg("Grabando...");
            Bll.Controles.CrepSave(m_entControlRepa, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Pasamos a modo Operaciones, rellenamos la grilla y 
            // le damos foco
            SwitchTo(FormModes.Operations, GridOps.Fill);
            grdDatos.Focus();
            App.HideMsg();
        }

        //--------------------------------------------------------------
        // Metodos privados
        //--------------------------------------------------------------

        /// <summary>
        /// Llena la grilla con los datos de la tabla
        /// </summary>
        private void FillGrid()
        {
            // Recuperamos los datos para la grilla
            App.ShowMsg("Recuperando datos...");
            Bel.LEControlesRepa l_lentControlesRepa= Bll.Controles.CrepFGet(cmbControl.SelectedStrCode,
                                                                            false, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Asignamos a la grilla
            App.InitAdvance("Cargando:");
            grdDatos.Focus();
            grdDatos.FillFromLEntidad(l_lentControlesRepa, "deleted");
            grdDatos.ColWitdhs= App.GetStrURegistry(false, "GridFormat", "ControlesRepaGrdWidths", "");
            grdDatos.GridOrder= App.GetStrURegistry(false, "GridFormat", "ControlesRepaGrdSort", "");
            App.EndAdvance();

            // Fijamos el evento de cambio de ancho de la grilla
            if (l_lentControlesRepa.Count > 0)
                foreach (DataGridColumnStyle l_dcsItem in grdDatos.TableStyles[0].GridColumnStyles)
                    l_dcsItem.WidthChanged += new EventHandler(GrdColumn_WidthChanged);
            txtNroitem.Numero = 1;
            if (l_lentControlesRepa.Count != 0)
            {
                m_nroItemAGrabar = l_lentControlesRepa[l_lentControlesRepa.Count - 1].Nroitem + 1;
                txtNroitem.Numero = m_nroItemAGrabar;
            }

            // Ya la llenamos
            App.HideMsg();
        }

        /// <summary>
        /// Cambia el modo del formulario
        /// </summary>
        private void SwitchTo(FormModes p_fmNewMode, GridOps p_goNewGState)
        {
            // Fijamos el nuevo modo del formulario
            switch (p_fmNewMode) {
                case FormModes.Operations   : {OperationMode(); break;}
                case FormModes.Edit         : {EditMode(); break;}
                default                     : {MsgRuts.ShowMsg(this, "Invalid mode"); break;}
            }

            // Fijamos el nuevo estado de la grilla
            switch (p_goNewGState) {
                case GridOps.Fill   : {FillGrid(); break;}
                default             : {break;}
            }
        }

        /// <summary>
        /// Pone el formulario en modo: Operaciones
        /// </summary>
        private void OperationMode()
        {
            // Deshabilitamos el frame
            txtNroitem.NormalDisable= true;
            txtNroitem.Enabled= false;
            cdcCodRep.NormalDisable = true;
            cdcCodRep.Enabled = false;
            cmdCancelar.Enabled= false;
            cmdGrabar.Enabled= false;
            cmdDesHab.Enabled= false;
            cmdHab.Enabled= false;

            // Blanqueamos los campos
            txtNroitem.Numero= m_nroItemAGrabar;
            cdcCodRep.SelectedIndex = -1;

            // Habilitamos la grilla y los controles operativos
            cmbControl.Enabled= true;
            cmdModPadre.Enabled= true;
            cmdNuevo.Enabled= true;
            cmdModificar.Enabled= true;
            cmdSalir.Enabled= true;
            cmdPrint.Enabled= true;
            cmdExcel.Enabled= true;
            grdDatos.Enabled= true;

            // Procesamos los comandos ACL
            cmdNuevo.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[1].VStr == "S"));
            cmdModificar.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[3].VStr == "S"));

            // El ESC sale del formulario
            CancelButton= cmdSalir;
        }

        /// <summary>
        /// Pone el formulario en modo: Edicion
        /// </summary>
        private void EditMode()
        {
            // Llenamos los campos a partir de la entidad a editar
            cdcCodRep.SelectedStrCode = m_entControlRepa.Codrep;
            if (!m_entControlRepa.EsNueva) txtNroitem.Numero = m_entControlRepa.Nroitem;
            // Habilitamos el frame
            txtNroitem.NormalDisable= false;
            txtNroitem.Enabled= m_entControlRepa.EsNueva;
            cdcCodRep.NormalDisable = false;
            //todo ver esto
            cdcCodRep.Enabled = m_entControlRepa.EsNueva;
            cmdCancelar.Enabled= true;
            cmdGrabar.Enabled= !m_entControlRepa.EstaBorrada;
            cmdDesHab.FixedImage= (m_entControlRepa.EstaBorrada) ? FixedGlassButtons.Enable 
                                                                 : FixedGlassButtons.Disable;
            cmdDesHab.Enabled= ((!m_entControlRepa.EsNueva) && (!m_entControlRepa.EstaBorrada));
            cmdHab.Enabled= !cmdDesHab.Enabled;

            // Procesamos los comandos ACL
            cmdHab.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[4].VStr == "S"));
            cmdDesHab.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[2].VStr == "S"));

            // Dehabilitamos la grilla y los controles operativos
            cmbControl.Enabled= false;
            cmdModPadre.Enabled= false;
            cmdNuevo.Enabled= false;
            cmdModificar.Enabled= false;
            cmdSalir.Enabled= false;
            cmdPrint.Enabled= false;
            cmdExcel.Enabled= false;
            grdDatos.Enabled= false;

            // El ESC sale de la edicion
            CancelButton= cmdCancelar;
        }
    }
}
