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
    // Interface para la Entidad : MvlInfraccion
    // Tipo de Interface         : Mantenimiento de Tabla Clasificadora
    //----------------------------------------------------------------------------
    // © 1996-2018 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    /// <summary>
    /// Formulario para Mantenimiento de la Tabla:MvlInfracciones
    /// </summary>
    public partial class MovilesInfracciones : Form
    {
        #region Miembros de la Clase
            private Bel.EMovilInfraccion m_entMvlInfraccion= null;
            private string m_strPatenteMovilSeleccionado = "";
            private StatMsg m_smResult= null;
            private string m_strSort= "";
        #endregion

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public MovilesInfracciones(string p_strPatenteMovilSeleccionado)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            m_strPatenteMovilSeleccionado = p_strPatenteMovilSeleccionado;


            // Iniciamos los objetos de la clase
            m_smResult= new StatMsg();

            // Fijamos el modo Skin
            xpnlBase.SkinFixed= App.WithSkin;
            frmEdicion.SkinFixed= App.WithSkin;
            grdDatos.SkinFixed= App.WithSkin;

            // Fijamos la imagen del Frm de edicion
            frmEdicion.GroupImage= Icon.ToBitmap();
        }

        //--------------------------------------------------------------
        // Eventos del formulario y los controles
        //--------------------------------------------------------------

        /// <summary>
        /// Carga del Formulario
        /// </summary>
        private void MovilesInfracciones_Load(object sender, System.EventArgs e)
        {
            // Llenamos las Combos (por Lista)
            cmbPagada.AddStrCD("S", "SI", 0);
            cmbPagada.AddStrCD(" N", "NO", 0);

            // Llenamos las Combos (por Lista)
            cdcAnulada.AddStrCD("S", "SI", 0);
            cdcAnulada.AddStrCD(" N", "NO", 0);

            // Llenamos las Combos (por Tablas)
            Bel.LEMotivosInfracciones l_lentMotivosInfracciones= Bll.Tablas.MtiUpFull(false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cmbCodmotivo.FillFromStrLEntidad(l_lentMotivosInfracciones, Bel.EMotivoInfraccion.CodigoCmp, Bel.EMotivoInfraccion.DescripcionCmp, "deleted");

            // Pasamos a modo Operaciones, llenamos la grilla y 
            // damos foco al primer campo
            SwitchTo(FormModes.Operations, GridOps.Fill);
            grdDatos.Focus();
        }

        /// <summary>
        /// Dobleclick en la grilla
        /// </summary>
        private void grdDatos_DataDClick(object sender, DataDClicEventArgs e)
        {
            // Simulamos modificar
            gbModificar_Click(this, EventArgs.Empty);
        }

        //--------------------------------------------------------------
        // Operaciones
        //--------------------------------------------------------------

        /// <summary>
        /// Exporta la grilla en Excel
        /// </summary>
        private void gbExcel_Click(object sender, System.EventArgs e)
        {
            grdDatos.ExportToExcel(false, false, "", "MovilesInfracciones", m_smResult);
        }

        /// <summary>
        /// Imprime la grilla
        /// </summary>
        private void gbPrint_Click(object sender, System.EventArgs e)
        {
            grdDatos.Print(Shr.ROParam.Empresa.VStr, App.Programa.Nombre,
                           "Lista de MovilesInfracciones", "");
        }

        /// <summary>
        /// Genera un Nuevo registro en la tabla
        /// </summary>
        private void gbNuevo_Click(object sender, System.EventArgs e)
        {
            // Creamos una nueva entidad, pasamos a modo de edicion y
            // damos foco al primer campo
            m_entMvlInfraccion= Bel.EMovilInfraccion.NewEmpty();
            m_entMvlInfraccion.Fecha = DateTime.Now;
            SwitchTo(FormModes.Edit, GridOps.DontFill);
            txtPatente.Focus();
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
            m_entMvlInfraccion= Bll.Moviles.MvifGet((string) grdDatos.GetMatrixValueObj(l_iRow, 1),
                                                    (DateTime) grdDatos.GetMatrixValueObj(l_iRow, 2),
                                                    false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Tenemos la entidad. Pasamos a modo de edicion y damos foco
            // al campo que corresponda
            SwitchTo(FormModes.Edit, GridOps.DontFill);
            if (m_entMvlInfraccion.EstaBorrada) {
                cmdCancelar.Focus();
            }
            else {
                txtLugar.Focus();
            }
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
                                      /*App.Usuario.Usuario +*/ "MovilesInfraccionesPurge") == DialogResult.No) return;

            // Purgamos la tabla
            Bll.Moviles.MvifPurge(m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Terminamos
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
            Bll.Moviles.MvifEnabled(m_entMvlInfraccion.EstaBorrada,
                                    m_entMvlInfraccion.Patente,
                                    m_entMvlInfraccion.Fecha,
                                    m_entMvlInfraccion.FxdVersion,
                                    m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Pasamos a modo Operaciones, rellenamos la grilla y 
            // le damos foco
            SwitchTo(FormModes.Operations, GridOps.Fill);
            grdDatos.Focus();
        }

        /// <summary>
        /// Graba el registro en edicion
        /// </summary>
        private void gbGrabar_Click(object sender, System.EventArgs e)
        {
            // Pasamos los datos a la Entidad
            m_entMvlInfraccion.Patente= txtPatente.Text;
            m_entMvlInfraccion.Fecha= txtFecha.FechaHora;
            m_entMvlInfraccion.Codmotivo= cmbCodmotivo.SelectedStrCode;
            m_entMvlInfraccion.Lugar= txtLugar.Text;
            m_entMvlInfraccion.Pagada= cmbPagada.SelectedStrCode;
            m_entMvlInfraccion.Importe= txtImporte.Decimal;
            m_entMvlInfraccion.Comentario= txtComentario.Text;
            m_entMvlInfraccion.Anulada = cdcAnulada.SelectedItem.ToString();

            // Tratamos de grabar la entidad
            Bll.Moviles.MvifSave(m_entMvlInfraccion, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Pasamos a modo Operaciones, rellenamos la grilla y 
            // le damos foco
            SwitchTo(FormModes.Operations, GridOps.Fill);
            grdDatos.Focus();
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
            Bel.LEMovilesInfracciones l_lentMovilesInfracciones= Bll.Moviles.MvifFGet(m_strPatenteMovilSeleccionado, false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Asignamos a la grilla
            grdDatos.Focus();
            grdDatos.FillFromLEntidad(l_lentMovilesInfracciones, "deleted");
            grdDatos.ColWitdhs= App.GetStrURegistry(false, "GridFormat", "MovilesInfraccionesGrdWidths", "");
            grdDatos.GridOrder= App.GetStrURegistry(false, "GridFormat", "MovilesInfraccionesGrdSort", "");
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
            cmbCodmotivo.NormalDisable= true;
            cmbCodmotivo.Enabled= false;
            txtLugar.NormalDisable= true;
            txtLugar.Enabled= false;
            cmbPagada.NormalDisable= true;
            cmbPagada.Enabled= false;
            txtImporte.NormalDisable= true;
            txtImporte.Enabled= false;
            txtComentario.NormalDisable= true;
            txtComentario.Enabled= false;
            cdcAnulada.NormalDisable= true;
            cdcAnulada.Enabled= false;
            cmdCancelar.Enabled= false;
            cmdGrabar.Enabled= false;
            gbDeshabilitar.Enabled= false;
            gbHabilitar.Enabled= false;

            // Blanqueamos los campos
            txtPatente.Text= "";
            txtFecha.FechaHora = new DateTime(1900,1,1,0,0,0);
            cmbCodmotivo.SelectedStrCode= "";
            txtLugar.Text= "";
            cmbPagada.SelectedStrCode= "";
            txtImporte.Decimal= 0;
            txtComentario.Text= "";
            cdcAnulada.SelectedStrCode= "";

            // Habilitamos la grilla y los controles operativos
            cmdNuevo.Enabled= true;
            cmdModificar.Enabled= true;
            gbCompactar.Enabled= true;
            btnExit.Enabled= true;
            cmdPrint.Enabled= true;
            cmdExcel.Enabled= true;
            grdDatos.Enabled= true;
        }

        /// <summary>
        /// Pone el formulario en modo: Edicion
        /// </summary>
        private void EditMode()
        {
            // Llenamos los campos a partir de la entidad a editar
            txtPatente.Text= m_strPatenteMovilSeleccionado;
            txtFecha.FechaHora = m_entMvlInfraccion.Fecha;
            cmbCodmotivo.SelectedStrCode= m_entMvlInfraccion.Codmotivo;
            txtLugar.Text= m_entMvlInfraccion.Lugar;
            cmbPagada.SelectedStrCode= m_entMvlInfraccion.Pagada;
            txtImporte.Decimal= m_entMvlInfraccion.Importe;
            txtComentario.Text= m_entMvlInfraccion.Comentario;
            cdcAnulada.Text= m_entMvlInfraccion.Anulada;

            // Habilitamos el frame
            txtPatente.NormalDisable= false;
            txtPatente.Enabled= false;
            txtFecha.NormalDisable= false;
            txtFecha.Enabled= m_entMvlInfraccion.EsNueva;
            cmbCodmotivo.NormalDisable= false;
            cmbCodmotivo.Enabled= m_entMvlInfraccion.EsNueva;
            txtLugar.NormalDisable= false;
            txtLugar.Enabled= !m_entMvlInfraccion.EstaBorrada;
            cmbPagada.NormalDisable= false;
            cmbPagada.Enabled= !m_entMvlInfraccion.EstaBorrada;
            txtImporte.NormalDisable= false;
            txtImporte.Enabled= !m_entMvlInfraccion.EstaBorrada;
            txtComentario.NormalDisable= false;
            txtComentario.Enabled= !m_entMvlInfraccion.EstaBorrada;
            cdcAnulada.NormalDisable= false;
            cdcAnulada.Enabled= !m_entMvlInfraccion.EstaBorrada;
            cmdCancelar.Enabled= true;
            cmdGrabar.Enabled= !m_entMvlInfraccion.EstaBorrada;
            gbDeshabilitar.Enabled= ((!m_entMvlInfraccion.EsNueva) &&(!m_entMvlInfraccion.EstaBorrada));
            gbHabilitar.Enabled= !gbDeshabilitar.Enabled;

            // Dehabilitamos la grilla y los controles operativos
            cmdNuevo.Enabled= false;
            cmdModificar.Enabled= false;
            gbCompactar.Enabled= false;
            btnExit.Enabled= true;
            cmdPrint.Enabled= false;
            cmdExcel.Enabled= false;
            grdDatos.Enabled= false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
