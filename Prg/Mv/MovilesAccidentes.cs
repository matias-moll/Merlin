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

namespace Mrln.Mv
{
    //----------------------------------------------------------------------------
    //                         TNG Software UIL Generator
    //----------------------------------------------------------------------------
    // Fecha                     : 25/06/2018 15:43
    // Sistema                   : Mrln
    // Interface para la Entidad : MvlAccidente
    // Tipo de Interface         : Mantenimiento de Tabla Clasificadora
    //----------------------------------------------------------------------------
    // � 1996-2018 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    /// <summary>
    /// Formulario para Mantenimiento de la Tabla:MvlAccidentes
    /// </summary>
    public partial class MovilesAccidentes : Form
    {
        #region Miembros de la Clase
            private Bel.EMvlAccidente m_entMvlAccidente= null;
            private string m_strPatenteMovilElegido = "";
            private StatMsg m_smResult= null;
            private string m_strSort= "";
        #endregion

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public MovilesAccidentes(string p_strPatenteMovil)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();


            // Iniciamos los objetos de la clase
            m_smResult= new StatMsg();

            m_strPatenteMovilElegido = p_strPatenteMovil;

            // Fijamos el modo Skin
            xpnlBase.SkinFixed= App.WithSkin;
            frmEdicion.SkinFixed= App.WithSkin;
            grdDatos.SkinFixed= App.WithSkin;
        }

        //--------------------------------------------------------------
        // Eventos del formulario y los controles
        //--------------------------------------------------------------

        /// <summary>
        /// Carga del Formulario
        /// </summary>
        private void MovilesAccidentes_Load(object sender, System.EventArgs e)
        {
            // Inicializamos el form
            App.ShowMsg("Inicializando el formulario...");

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
        private void MovilesAccidentes_FormClosed(object sender, FormClosedEventArgs e)
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
                    App.SetStrURegistry(false, "GridFormat", "MovilesAccidentesGrdSort", m_strSort);
                    return;
                }
            }

            // Si es boton derecho
            if (e.Button == MouseButtons.Right) {
                // Si cambio el sort simple
                if (m_strSort != "") {
                    // Quitamos el orden, grabamos y recargamos
                    m_strSort= "";
                    App.SetStrURegistry(false, "GridFormat", "MovilesAccidentesGrdSort", m_strSort);
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
            App.SetStrURegistry(false, "GridFormat", "MovilesAccidentesGrdWidths", grdDatos.ColWitdhs);
        }

        //--------------------------------------------------------------
        // Operaciones
        //--------------------------------------------------------------

        /// <summary>
        /// Exporta la grilla en Excel
        /// </summary>
        private void cmdExcel_Click(object sender, System.EventArgs e)
        {
            App.ShowMsg("Generando planilla...");
            App.InitAdvance("Excel:");
            grdDatos.ExportToExcel(false, false, "", "MovilesAccidentes", ref m_smResult);
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
                           "Lista de MovilesAccidentes", "");
            App.EndAdvance();
            App.HideMsg();
        }

        /// <summary>
        /// Genera un Nuevo registro en la tabla
        /// </summary>
        private void cmdNuevo_Click(object sender, System.EventArgs e)
        {
            // Creamos una nueva entidad, pasamos a modo de edicion y
            // damos foco al primer campo
            m_entMvlAccidente= Bel.EMvlAccidente.NewEmpty();
            m_entMvlAccidente.Fecha = DateTime.Now;
            SwitchTo(FormModes.Edit, GridOps.DontFill);
            txtPatente.Focus();
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
            m_entMvlAccidente= Bll.Moviles.MvacGet((string) grdDatos.GetMatrixValueObj(l_iRow, 1),
                                                   (DateTime) grdDatos.GetMatrixValueObj(l_iRow, 2),
                                                   false, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Tenemos la entidad. Pasamos a modo de edicion y damos foco
            // al campo que corresponda
            SwitchTo(FormModes.Edit, GridOps.DontFill);
            if (m_entMvlAccidente.EstaBorrada) {
                cmdCancelar.Focus();
            }
            else {
                txtDireccion.Focus();
            }
            App.HideMsg();
        }

        /// <summary>
        /// Purga los registros deshabilitados
        /// </summary>
        private void cmdPurgar_Click(object sender, EventArgs e)
        {
            // Pedimos una confirmacion
            if (MsgRuts.AskUser(this, "Atenci�n!!!!\r\n" +
                                      "La compactaci�n de la tabla borra en forma " +
                                      "definitiva los items deshabilitados. " +
                                      "�Confirma la compactaci�n?",
                                      /*App.Usuario.Usuario +*/ "MovilesAccidentesPurge") == DialogResult.No) return;

            // Purgamos la tabla
            App.ShowMsg("Compactando la tabla...");
            Bll.Moviles.MvacPurge(ref m_smResult);
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
            Bll.Moviles.MvacEnabled(m_entMvlAccidente.EstaBorrada,
                                    m_entMvlAccidente.Patente,
                                    m_entMvlAccidente.Fecha,
                                    m_entMvlAccidente.FxdVersion,
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
            m_entMvlAccidente.Patente= txtPatente.Text;
            m_entMvlAccidente.Fecha= txtFecha.FechaHora;
            m_entMvlAccidente.Localidad= txtLocalidad.Text;
            m_entMvlAccidente.Direccion= txtDireccion.Text;
            m_entMvlAccidente.Motivo= txtMotivo.Text;
            m_entMvlAccidente.Detalle= txtDetalle.Text;
            m_entMvlAccidente.Dotacion= txtDotacion.Text;

            // Tratamos de grabar la entidad
            App.ShowMsg("Grabando...");
            Bll.Moviles.MvacSave(m_entMvlAccidente, ref m_smResult);
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
            Bel.LEMovilesAccidentes l_lentMovilesAccidentes= Bll.Moviles.MvacFGet(m_strPatenteMovilElegido, false, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Asignamos a la grilla
            App.InitAdvance("Cargando:");
            grdDatos.Focus();
            grdDatos.FillFromLEntidad(l_lentMovilesAccidentes, "deleted");
            grdDatos.ColWitdhs= App.GetStrURegistry(false, "GridFormat", "MovilesAccidentesGrdWidths", "");
            grdDatos.GridOrder= App.GetStrURegistry(false, "GridFormat", "MovilesAccidentesGrdSort", "");
            App.EndAdvance();

            // Fijamos el evento de cambio de ancho de la grilla
            if (l_lentMovilesAccidentes.Count > 0)
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
            txtPatente.NormalDisable= true;
            txtPatente.Enabled= false;
            txtFecha.NormalDisable= true;
            txtFecha.Enabled= false;
            txtLocalidad.NormalDisable= true;
            txtLocalidad.Enabled= false;
            txtDireccion.NormalDisable= true;
            txtDireccion.Enabled= false;
            txtMotivo.NormalDisable= true;
            txtMotivo.Enabled= false;
            txtDetalle.NormalDisable= true;
            txtDetalle.Enabled= false;
            txtDotacion.NormalDisable= true;
            txtDotacion.Enabled= false;
            cmdCancelar.Enabled= false;
            cmdGrabar.Enabled= false;
            cmdDesHab.Enabled= false;
            cmdHab.Enabled= false;

            // Blanqueamos los campos
            txtPatente.Text= "";
            txtFecha.FechaHora= new DateTime(1900,1,1,0,0,0);
            txtLocalidad.Text= "";
            txtDireccion.Text= "";
            txtMotivo.Text= "";
            txtDetalle.Text= "";
            txtDotacion.Text= "";

            // Habilitamos la grilla y los controles operativos
            cmdNuevo.Enabled= true;
            cmdModificar.Enabled= true;
            cmdPurgar.Enabled= true;
            cmdSalir.Enabled= true;
            cmdPrint.Enabled= true;
            cmdExcel.Enabled= true;
            grdDatos.Enabled= true;

            // El ESC sale del formulario
            CancelButton= cmdSalir;
        }

        /// <summary>
        /// Pone el formulario en modo: Edicion
        /// </summary>
        private void EditMode()
        {
            // Llenamos los campos a partir de la entidad a editar
            txtPatente.Text= m_strPatenteMovilElegido;
            txtFecha.FechaHora= m_entMvlAccidente.Fecha;
            txtLocalidad.Text= m_entMvlAccidente.Localidad;
            txtDireccion.Text= m_entMvlAccidente.Direccion;
            txtMotivo.Text= m_entMvlAccidente.Motivo;
            txtDetalle.Text= m_entMvlAccidente.Detalle;
            txtDotacion.Text= m_entMvlAccidente.Dotacion;

            // Habilitamos el frame
            txtPatente.NormalDisable= false;
            txtPatente.Enabled= false;
            txtFecha.NormalDisable= false;
            txtFecha.Enabled= m_entMvlAccidente.EsNueva;
            txtLocalidad.NormalDisable= false;
            txtLocalidad.Enabled= m_entMvlAccidente.EsNueva;
            txtDireccion.NormalDisable= false;
            txtDireccion.Enabled= !m_entMvlAccidente.EstaBorrada;
            txtMotivo.NormalDisable= false;
            txtMotivo.Enabled= !m_entMvlAccidente.EstaBorrada;
            txtDetalle.NormalDisable= false;
            txtDetalle.Enabled= !m_entMvlAccidente.EstaBorrada;
            txtDotacion.NormalDisable= false;
            txtDotacion.Enabled= !m_entMvlAccidente.EstaBorrada;
            cmdCancelar.Enabled= true;
            cmdGrabar.Enabled= !m_entMvlAccidente.EstaBorrada;
            cmdDesHab.Enabled= ((!m_entMvlAccidente.EsNueva) &&(!m_entMvlAccidente.EstaBorrada));
            cmdHab.Enabled= !cmdDesHab.Enabled;

            // Dehabilitamos la grilla y los controles operativos
            cmdNuevo.Enabled= false;
            cmdModificar.Enabled= false;
            cmdPurgar.Enabled= false;
            cmdSalir.Enabled= false;
            cmdPrint.Enabled= false;
            cmdExcel.Enabled= false;
            grdDatos.Enabled= false;

            // El ESC sale de la edicion
            CancelButton= cmdCancelar;
        }
    }
}
