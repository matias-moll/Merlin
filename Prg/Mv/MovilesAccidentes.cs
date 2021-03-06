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
    // © 1996-2018 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    /// <summary>
    /// Formulario para Mantenimiento de la Tabla:MvlAccidentes
    /// </summary>
    public partial class MovilesAccidentes : Form
    {
        #region Miembros de la Clase
            private Bel.EMovilAccidente m_entMvlAccidente= null;
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

        }

        //--------------------------------------------------------------
        // Eventos del formulario y los controles
        //--------------------------------------------------------------

        /// <summary>
        /// Carga del Formulario
        /// </summary>
        private void MovilesAccidentes_Load(object sender, System.EventArgs e)
        {
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
            grdDatos.ExportToExcel(false, false, "", "MovilesAccidentes", m_smResult);
        }

        /// <summary>
        /// Imprime la grilla
        /// </summary>
        private void gbPrint_Click(object sender, System.EventArgs e)
        {
            grdDatos.Print(Shr.ROParam.Empresa.VStr, App.Programa.Nombre,
                           "Lista de MovilesAccidentes", "");
        }

        /// <summary>
        /// Genera un Nuevo registro en la tabla
        /// </summary>
        private void gbNuevo_Click(object sender, System.EventArgs e)
        {
            // Creamos una nueva entidad, pasamos a modo de edicion y
            // damos foco al primer campo
            m_entMvlAccidente= Bel.EMovilAccidente.NewEmpty();
            m_entMvlAccidente.Fecha = DateTime.Now;
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
            m_entMvlAccidente= Bll.Moviles.MvacGet((string) grdDatos.GetMatrixValueObj(l_iRow, 1),
                                                   (DateTime) grdDatos.GetMatrixValueObj(l_iRow, 2),
                                                   false, m_smResult);
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
                                      /*App.Usuario.Usuario +*/ "MovilesAccidentesPurge") == DialogResult.No) return;

            // Purgamos la tabla
            App.ShowMsg("Compactando la tabla...");
            Bll.Moviles.MvacPurge(m_smResult);
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
            Bll.Moviles.MvacEnabled(m_entMvlAccidente.EstaBorrada,
                                    m_entMvlAccidente.Patente,
                                    m_entMvlAccidente.Fecha,
                                    m_entMvlAccidente.FxdVersion,
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
            m_entMvlAccidente.Patente= txtPatente.Text;
            m_entMvlAccidente.Fecha= txtFecha.FechaHora;
            m_entMvlAccidente.Localidad= txtLocalidad.Text;
            m_entMvlAccidente.Direccion= txtDireccion.Text;
            m_entMvlAccidente.Motivo= txtMotivo.Text;
            m_entMvlAccidente.Detalle= txtDetalle.Text;
            m_entMvlAccidente.Dotacion= txtDotacion.Text;

            // Tratamos de grabar la entidad
            Bll.Moviles.MvacSave(m_entMvlAccidente, m_smResult);
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
            Bel.LEMovilesAccidentes l_lentMovilesAccidentes= Bll.Moviles.MvacFGet(m_strPatenteMovilElegido, false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Asignamos a la grilla
            grdDatos.Focus();
            grdDatos.FillFromLEntidad(l_lentMovilesAccidentes, "deleted");
            grdDatos.ColWitdhs= App.GetStrURegistry(false, "GridFormat", "MovilesAccidentesGrdWidths", "");
            grdDatos.GridOrder= App.GetStrURegistry(false, "GridFormat", "MovilesAccidentesGrdSort", "");
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
            gbDeshabilitar.Enabled= false;
            gbHabilitar.Enabled= false;

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
            gbDeshabilitar.Enabled= ((!m_entMvlAccidente.EsNueva) &&(!m_entMvlAccidente.EstaBorrada));
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
