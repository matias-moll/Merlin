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
using Mrln;
#endregion

namespace Mrln.Tg
{
    //----------------------------------------------------------------------------
    //                         TNG Software UIL Generator
    //----------------------------------------------------------------------------
    // Fecha                     : 06/06/2018 02:33
    // Sistema                   : Mrln
    // Interface para la Entidad : TallerCategoria
    // Tipo de Interface         : Mantenimiento de Tabla Padre-Hijo
    //----------------------------------------------------------------------------
    // © 1996-2018 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    /// <summary>
    /// Formulario para Mantenimiento de la Tabla:TallerCategoria
    /// </summary>
    public partial class TalleresCategorias : DockContent
    {
        #region Miembros de la Clase
            private Bel.ETallerCategoria m_entTallerCategoria= null;
            private StatMsg m_smResult= null;
            private ACLInfo m_aclInfo= null;
            private string m_strSort= "";
        #endregion

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public TalleresCategorias()
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
        private void TalleresCategorias_Load(object sender, System.EventArgs e)
        {
            // Inicializamos el form
            App.ShowMsg("Inicializando el formulario...");

            Bel.LETalleres l_lentTalleres= Bll.Talleres.UpFull(true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cmbTalleres.FillFromStrLEntidad(l_lentTalleres, "tll_cod_codigo", "tll_ede_descripcion", "deleted");

            Bel.LECategorias l_lentCategorias= Bll.Tablas.CatUpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cmbCodigocategoria.FillFromStrLEntidad(l_lentCategorias, "cat_rcd_cod", "cat_des_des", "deleted");

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
        private void TalleresCategorias_Closed(object sender, System.EventArgs e)
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
            gbModificar_Click(this, EventArgs.Empty);
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
                    App.SetStrURegistry(false, "GridFormat", "TalleresCategoriasGrdSort", m_strSort);
                    return;
                }
            }

            // Si es boton derecho
            if (e.Button == MouseButtons.Right) {
                // Si cambio el sort simple
                if (m_strSort != "") {
                    // Quitamos el orden, grabamos y recargamos
                    m_strSort= "";
                    App.SetStrURegistry(false, "GridFormat", "TalleresCategoriasGrdSort", m_strSort);
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
            App.SetStrURegistry(false, "GridFormat", "TalleresCategoriasGrdWidths", grdDatos.ColWitdhs);
        }

        /// <summary>
        /// Cambio la combo con codigos Padre
        /// </summary>
        private void cmbTalleres_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Si se selecciono un codigo
            if (cmbTalleres.SelectedIndex != -1) {
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
            Talleres l_frmPadre= new Talleres();

            l_frmPadre.MdiParent= null;
            l_frmPadre.StartPosition= FormStartPosition.CenterParent;
            l_frmPadre.ShowDialog(this);
            App.SetACL(null);

            // Bloqueamos el menu
            App.LockMenu(true);

            // Recargamos la combo
            App.ShowMsg("Recargando los datos...");

            Bel.LETalleres l_lentTalleres= Bll.Talleres.UpFull(true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cmbTalleres.FillFromStrLEntidad(l_lentTalleres, "tll_cod_codigo", "tll_ede_descripcion", "deleted");
            cmbTalleres.Focus();
            App.HideMsg();
        }

        /// <summary>
        /// Exporta la grilla en Excel
        /// </summary>
        private void gbExcel_Click(object sender, System.EventArgs e)
        {
            App.ShowMsg("Generando planilla...");
            App.InitAdvance("Excel:");
            grdDatos.ExportToExcel(false, false, "", "TalleresCategorias", m_smResult);
            App.EndAdvance();
            App.HideMsg();
        }

        /// <summary>
        /// Imprime la grilla
        /// </summary>
        private void gbPrint_Click(object sender, System.EventArgs e)
        {
            App.ShowMsg("Imprimiendo datos...");
            App.InitAdvance("Imprimiendo:");
            grdDatos.Print(Shr.ROParam.Empresa.VStr, App.Programa.Nombre,
                           "Lista de TalleresCategorias", "");
            App.EndAdvance();
            App.HideMsg();
        }

        /// <summary>
        /// Genera un Nuevo registro en la tabla
        /// </summary>
        private void gbNuevo_Click(object sender, System.EventArgs e)
        {
            // Si no hay padre -> salimos
            if (cmbTalleres.SelectedIndex == -1) return;

            // Creamos una nueva entidad, pasamos a modo de edicion y
            // damos foco al primer campo
            m_entTallerCategoria= Bel.ETallerCategoria.NewEmpty();
            m_entTallerCategoria.Codigotaller= cmbTalleres.SelectedStrCode;
            SwitchTo(FormModes.Edit, GridOps.DontFill);

            cmbCodigocategoria.Focus();
        }

        /// <summary>
        /// Modifica el registro seleccionado de la grilla
        /// </summary>
        private void gbModificar_Click(object sender, System.EventArgs e)
        {
            // Si no hay item seleccionado -> salimos
            int l_iRow= grdDatos.CurrentRowIndex;
            if (l_iRow == -1) return;

            // Obtenemos la entidad del item seleccionado en la grilla
            App.ShowMsg("Recuperando Datos...");
            m_entTallerCategoria= Bll.Talleres.TalCGet(cmbTalleres.SelectedStrCode,
                                                       (string) grdDatos.GetMatrixValueObj(l_iRow, 2),
                                                       false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Tenemos la entidad. Pasamos a modo de edicion y damos foco
            // al campo que corresponda
            SwitchTo(FormModes.Edit, GridOps.DontFill);
            if (m_entTallerCategoria.EstaBorrada) {
                cmdCancelar.Focus();
            }
            else {
                cmdCancelar.Focus();
            }
            App.HideMsg();
        }

        /// <summary>
        /// Purga los registros deshabilitados
        /// </summary>
        private void gbCompactar_Click(object sender, EventArgs e)
        {
            // Pedimos una confirmacion
            if (MsgRuts.AskUser(this, "Atención!!!!\r\n" +
                                      "La compactación de la tabla borra en forma " +
                                      "definitiva los items deshabilitados. " +
                                      "¿Confirma la compactación?",
                                      /*App.Usuario.Usuario +*/ "TalleresCategoriasPurge") == DialogResult.No) return;

            // Purgamos la tabla
            App.ShowMsg("Compactando la tabla...");
            Bll.Talleres.TalCPurge(m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Terminamos
            App.HideMsg();
            MsgRuts.ShowMsg(this, "La tabla ha sido compactada.");
            FillGrid();
        }

        /// <summary>
        /// Finaliza el formulario
        /// </summary>
        private void gbSalir_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Cancela la edicion
        /// </summary>
        private void gbCancelar_Click(object sender, System.EventArgs e)
        {
            // Pasamos a modo Operaciones y damos foco a la grilla
            SwitchTo(FormModes.Operations, GridOps.DontFill);
            grdDatos.Focus();
        }

        /// <summary>
        /// Habilita/Deshabilita el registro
        /// </summary>
        private void gbChangeHabilitado_Click(object sender, System.EventArgs e)
        {
            // Realizamos la operacion
            App.ShowMsg("Procesando...");
            Bll.Talleres.TalCEnabled(m_entTallerCategoria.EstaBorrada,
                                     m_entTallerCategoria.Codigotaller,
                                     m_entTallerCategoria.Codigocategoria,
                                     m_entTallerCategoria.FxdVersion,
                                     m_smResult);
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
        private void gbGrabar_Click(object sender, System.EventArgs e)
        {
            // Pasamos los datos a la Entidad
            m_entTallerCategoria.Codigotaller= cmbTalleres.SelectedStrCode;
            m_entTallerCategoria.Codigocategoria= cmbCodigocategoria.SelectedStrCode;

            // Tratamos de grabar la entidad
            App.ShowMsg("Grabando...");
            Bll.Talleres.TalCSave(m_entTallerCategoria, m_smResult);
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
            Bel.LETalleresCategorias l_lentTalleresCategorias= Bll.Talleres.TalCFGet(cmbTalleres.SelectedStrCode,
                                                                                     false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Asignamos a la grilla
            App.InitAdvance("Cargando:");
            grdDatos.Focus();
            grdDatos.FillFromLEntidad(l_lentTalleresCategorias, "deleted");
            grdDatos.ColWitdhs= App.GetStrURegistry(false, "GridFormat", "TalleresCategoriasGrdWidths", "");
            grdDatos.GridOrder= App.GetStrURegistry(false, "GridFormat", "TalleresCategoriasGrdSort", "");
            App.EndAdvance();

            // Fijamos el evento de cambio de ancho de la grilla
            if (l_lentTalleresCategorias.Count > 0)
                foreach (DataGridColumnStyle l_dcsItem in grdDatos.TableStyles[0].GridColumnStyles)
                    l_dcsItem.WidthChanged += new EventHandler(GrdColumn_WidthChanged);

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
            cmbCodigocategoria.NormalDisable= true;
            cmbCodigocategoria.Enabled= false;
            cmdCancelar.Enabled= false;
            cmdGrabar.Enabled= false;
            gbDeshabilitar.Enabled= false;
            gbHabilitar.Enabled= false;

            // Blanqueamos los campos
            cmbCodigocategoria.SelectedStrCode= "";

            // Habilitamos la grilla y los controles operativos
            cmbTalleres.Enabled= true;
            cmdNuevo.Enabled= true;
            cmdModificar.Enabled= true;
            gbSalir.Enabled= true;
            cmdPrint.Enabled= true;
            cmdExcel.Enabled= true;
            grdDatos.Enabled= true;

            // Procesamos los comandos ACL
            cmdNuevo.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[1].VStr == "S"));
            cmdModificar.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[3].VStr == "S"));

            // El ESC sale del formulario
            CancelButton= gbSalir;
        }

        /// <summary>
        /// Pone el formulario en modo: Edicion
        /// </summary>
        private void EditMode()
        {
            // Llenamos los campos a partir de la entidad a editar
            cmbCodigocategoria.SelectedStrCode= m_entTallerCategoria.Codigocategoria;

            // Habilitamos el frame
            cmbCodigocategoria.NormalDisable= false;
            cmbCodigocategoria.Enabled= m_entTallerCategoria.EsNueva;
            cmdCancelar.Enabled= true;
            cmdGrabar.Enabled= !m_entTallerCategoria.EstaBorrada;
            gbDeshabilitar.FixedImage= (m_entTallerCategoria.EstaBorrada) ? FixedGlassButtons.Enable 
                                                                     : FixedGlassButtons.Disable;
            gbDeshabilitar.Enabled= ((!m_entTallerCategoria.EsNueva) && (!m_entTallerCategoria.EstaBorrada));
            gbHabilitar.Enabled= !gbDeshabilitar.Enabled;

            // Procesamos los comandos ACL
            gbHabilitar.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[4].VStr == "S"));
            gbDeshabilitar.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[2].VStr == "S"));

            // Dehabilitamos la grilla y los controles operativos
            cmbTalleres.Enabled= false;
            cmdNuevo.Enabled= false;
            cmdModificar.Enabled= false;
            gbSalir.Enabled= false;
            cmdPrint.Enabled= false;
            cmdExcel.Enabled= false;
            grdDatos.Enabled= false;

            // El ESC sale de la edicion
            CancelButton= cmdCancelar;
        }
    }
}
