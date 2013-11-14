using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rivn.Bll;
using TNGS;
using TNGS.NetApp;
using TNGS.NetRoutines;
using TNGS.NetControls;
using WeifenLuo.WinFormsUI.Docking;
using TNGS.NetAppBll;


namespace Rivn.Mv
{
    public partial class AltaMovil : DockContent
    {

        #region Constructor y variables miembro

        //miembros
        private StatMsg m_stResult;
        private bool m_EstadoAlta;
        private Bel.EMovil m_entMovil;

        //constructor principal
        public AltaMovil()
        {
            InitializeComponent();
           
            m_stResult = new StatMsg("AltaMovil");

            //creamos la nueva entidad VACIA
            m_entMovil = Bel.EMovil.NewEmpty();
            

            
            m_EstadoAlta = true;

        }

        //constructor para modificacion
        public AltaMovil(Bel.EMovil p_entMovil, bool p_bImgHabilitado) : this()
        {
            if(p_bImgHabilitado)
                //cambiamos titulo del formulario
                this.Text = "Modificar Movil Patente: " + p_entMovil.Patente;
            else
                //cambiamos titulo del formulario
                this.Text = "Modificar Equipamiento Movil Patente: " + p_entMovil.Patente;

            //nos guardamos la entidad a Updatear en la variable miembro Movil
            m_entMovil = p_entMovil;
            m_EstadoAlta = false;

            //disbleamos los controles que no tienen que estar activos
            neKilometros.Enabled = false;
            gbLimpiarTodo.Enabled = false;
            tePatente.Enabled = false;
            teNroChasis.Enabled = false;
            teNroMotor.Enabled = false;
            gbCancel.Enabled = false;
            igDatosBasicosMovil.Enabled = p_bImgHabilitado;

        }

        #endregion

        #region Metodos privados de la UIL

        // chequea o Unchekea todos los items de una CheckBoxList, false para uncheaquear, true para chequear.
        private void setearTodosLosItemsCheckedList(CDCheckedList p_clCheckedListBox, bool p_unBool)
        {
            for (int index = 0; index < p_clCheckedListBox.Items.Count; index++)
            {
                p_clCheckedListBox.SetItemChecked(index, p_unBool);
            }
        }

        // llena un CheckListBox con los equipamientos de la tabla Equipamientos.
        private void llenarCheckListEquipamiento()
        {
            m_stResult.UilReset("llenarCheckListEquipamiento");
            clEquipamientos.FillFromStrLEntidad(Tablas.EqiUpFull(true, ref m_stResult), "eqi_cod_cod", "eqi_des_des", "deleted");

            MsgRuts.AnalizeError(this, m_stResult);
        }

        // pone en blanco todos los campos de DatosBasicos Movil
        private void limpiarTodosLosCamposDatosBasicos()
        {
            tePatente.Clear();
            teNroMotor.Clear();
            teNroChasis.Clear();
            teDescripcionMovil.Clear();
            teAnotaciones.Clear();
            neAnioFabric.Clear();
            neKilometros.Clear();
            cdcModelo.SelectedIndex = -1;
            cdcMovilPropio.SelectedIndex = -1;
        }

        // Llenac la combo modelos con los modelos que hay en la tabla modelos.
        private void llenarComboModelos()
        {
            //reseteamos el statmsg
            m_stResult.UilReset("llenarComboModelos");  
            //llenamos la combo
            cdcModelo.FillFromStrLEntidad(Bll.Tablas.ModUpFull(true, ref m_stResult), "mds_rcd_cod", "mds_des_des", "deleted");
            //chequeamos errores
            if(MsgRuts.AnalizeError(this, m_stResult)) return;
            //seteamos en el valor vacio a la combo para que se vea fancy
            cdcModelo.SelectedIndex = -1;
        }

        // llena comboMovil con SI NO Vacio
        private void llenarComboMovilPropio()
        {
            //llenamos con los valores si Y no
            cdcMovilPropio.AddStrCD("N", "NO", 0);
            cdcMovilPropio.AddStrCD("S", "SI", 0);
        }

        // chequea que todos los campos tengan datos validos.
        private bool ValidarControles()
        {
            // si alguno de los campos basico es invalido, mostramos un error.
            if (
                   (!teAnotaciones.IsValid)
                   || (!teDescripcionMovil.IsValid)
                   || (!teNroChasis.IsValid)
                   || (!teNroMotor.IsValid)
                   || (!tePatente.IsValid)
                   || (!cdcModelo.IsValid)
                   || (cdcModelo.SelectedStrCode == "")
                   || (!cdcMovilPropio.IsValid)
                   || (cdcMovilPropio.SelectedStrCode == "")
                   || (!neAnioFabric.IsValid)
                   || (!neKilometros.IsValid)
               )
            {
                MsgRuts.ShowMsg(this, "Algun campo basico es invalido");
                return false;
            }
            else
            {
                // un movil tiene que tener almenos un equipamiento, por eso chequeamos que no este vacia la seleccion.
                if (clEquipamientos.CheckedStrCodes == null)
                {
                    MsgRuts.ShowMsg(this, "No hay ningun equipamiento seleccionado para este movil");
                    return false;
                }
                return true;
            }


        }

        // cheakea true los equipamientos que tiene un movil en una checked List
        private void CheckearEquipamientosMovil(CDCheckedList p_clEqui, Bel.EMovil p_eMovil)
        {
            // recuperamos la LE de equipamientos del movil
            Bel.LEMovilesEquip l_lentMovEquipamiento = p_eMovil.MovilesEquip;
            // creamos una nueva variable para llenarla con las entidadesde la lista entidad
            Bel.EMovilEquip l_entMovilEquip;

            // instanciamos un array donde van a guardarse los codigos de los equipamientos seleccionados
            string[] arraySoporte = new string[p_clEqui.Items.Count];
            int l_iContador = 0;
            foreach (CodDesItems item in p_clEqui.Items)
            {
                l_entMovilEquip = l_lentMovEquipamiento[p_eMovil.Patente, item.StrCode];

                // si la entidad es null, es porque no existe ninguna en la lista entidad con ese StrCode. 
                // si no es null, la chequeamos.
                if (null != l_entMovilEquip)
                    arraySoporte[l_iContador] = item.StrCode;
                else
                    arraySoporte[l_iContador] = "";

                l_iContador = l_iContador + 1;
            }


            //chequeamos desde el array creado
            p_clEqui.CheckedStrCodes = arraySoporte;
        }

        // llena una Entidad Movil pasada por parametro, con los datos del formulario
        private void CargarDatosBasicosEnEntidadMovil(Bel.EMovil p_entMovil)
        {
            //llenamos la entidad
            p_entMovil.Patente = tePatente.Text;
            p_entMovil.Des = teDescripcionMovil.Text;
            p_entMovil.Nrochasis = teNroChasis.Text;
            p_entMovil.Nromotor = teNroMotor.Text;
            p_entMovil.Modelo = cdcModelo.SelectedStrCode; 
            p_entMovil.Aniofabric = neAnioFabric.Numero;
            p_entMovil.Propio = cdcMovilPropio.SelectedStrCode;
    
        }

        // llena una entidad Movil Estado pasada por parametro, con los datos del formulario
        private Bel.EMovilEstado GenerarEstadoDefault()
        {
            //creamos una nueva ListaEntidad nueva. 
            Bel.EMovilEstado l_leMvlEstado = Bel.EMovilEstado.NewEmpty();

            //reseteamos el StatMsg
            m_stResult.UilReset("GenerarEstadoDefault");
            
            //instanciamos el parametro que viene de afuera del sistemas ESTADO DEFAULT

            //TNGS.NetAppBll.EParametro l_ptroEstadoDefault = AppRuts.ParaGet("DefaultStateMovil", false, ref m_stResult);
            //if (MsgRuts.AnalizeError(this, m_stResult))
            //{ 
            //    l_leMvlEstado.Patente = "";
            //    return l_leMvlEstado;
            //} 

            l_leMvlEstado.Patente = tePatente.Text;
            l_leMvlEstado.Fecha = DateTime.Now;
            l_leMvlEstado.Codestado = "1";// l_ptroEstadoDefault.VStr;
            l_leMvlEstado.Km = neKilometros.Numero;

            return l_leMvlEstado;
        }

        // obtiene los campos equipamientos chequeados.
        private Bel.LEMovilesEquip ObtenerLEntidadSeleccionadosCheckedList()
        {
            Bel.LEMovilesEquip l_leMovilEqts = Bel.LEMovilesEquip.NewEmpty();
            Bel.EMovilEquip l_entMovilEq = Bel.EMovilEquip.NewEmpty();

            l_entMovilEq.Patente = tePatente.Text;
            //l_entMovilEq.Esfijo = "S";
            // Recorremos el Array de Strings de los Cod Seleccionados y llenamos el codigo en las entidades y luego cargandolas en la LE.
            foreach (string item in clEquipamientos.CheckedStrCodes)
            {
                l_entMovilEq.Codequip = item;
                l_leMovilEqts.AddEntity(l_entMovilEq);
                
            }
            return l_leMovilEqts;
        }

        // llena una entidad Movil KMS pasada por parametro, con los datos del formulario
        private Bel.EMovilKms GenerarEntidadMvlKilometros()
        {
            Bel.EMovilKms l_entMovilKms = Bel.EMovilKms.NewEmpty();
            l_entMovilKms.Patente = tePatente.Text;
            l_entMovilKms.Fecha = DateTime.Now;
            l_entMovilKms.Km = neKilometros.Numero;

            //retornamos la EMovil Creado
            return l_entMovilKms;
        }  

        #endregion

        #region Eventos de los controles
        private void tildarTodo_Click(object sender, EventArgs e)
        {
            setearTodosLosItemsCheckedList(clEquipamientos, true);
        }

        private void btnDestildarTodoEqi_Click(object sender, EventArgs e)
        {
            setearTodosLosItemsCheckedList(clEquipamientos, false);
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            MsgRuts.ShowMsg(this, "Esta seguro que desea limpiar los campos?", MessageBoxButtons.OKCancel);
            setearTodosLosItemsCheckedList(clEquipamientos, false);
            limpiarTodosLosCamposDatosBasicos();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            m_stResult.UilReset("btnGrabar_Click");

            //nos fijamos que todos los campos sean validos.
            if (!ValidarControles())
                return;

            //llenamos la entidad Movil con los datos basicos
            CargarDatosBasicosEnEntidadMovil(m_entMovil);

            //generamos el estado default y nos fijamos que se haya creado con exito, sino lanzamos un error
            Bel.EMovilEstado l_eMvlEstado = GenerarEstadoDefault();
            if(l_eMvlEstado.Patente == "") 
            {
                MsgRuts.ShowMsg(this, "Error al cargar el estado");
                return;
            }

            //procedemos a grabar 
            if(m_EstadoAlta)
            {
                // Agregamos la primer Entidad Kms Del movil, a la Lista Entidad
                m_entMovil.MovilesKms.AddEntity(GenerarEntidadMvlKilometros());
                // Agregamos la Entidad Estado Default a la lista entidad de Moviles Estados
                m_entMovil.MovilesEstado.AddEntity(l_eMvlEstado);
                //si es estado de alta grabamos una entidad nueva.
                m_entMovil.MovilesEquip = ObtenerLEntidadSeleccionadosCheckedList();
                Bll.Moviles.Save(m_entMovil, ref m_stResult);
                if (MsgRuts.AnalizeError(this, m_stResult)) return;
                MsgRuts.ShowMsg(this, "El nuevo Movil ha sido agregado satisfactoriamente");
                this.Close();
            }
            else
            {
                // si es estado de Update se llama al metodo que elimina todos los equipamientos, carga los nuevos y graba la entidad.
                Bll.Moviles.CambiarEquipamientoYGrabarMovil(m_entMovil, ObtenerLEntidadSeleccionadosCheckedList(), ref m_stResult);
                if (MsgRuts.AnalizeError(this, m_stResult)) return;
                MsgRuts.ShowMsg(this, "El Movil ah sido modificado satisfactoriamente");
                this.Close();
            }
        }

        private void gbCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Si cierra esta ventana puede perder datos que no hayan sido grabados",
                "Cuidado",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.Cancel)
                                                                    return;
            this.Close();
        }
        
        private void AltaMovil_Load(object sender, EventArgs e)
        {
            //llenamos los controles del formulario con la informacion sacada de las tablas.
            llenarCheckListEquipamiento();
            llenarComboModelos();
            llenarComboMovilPropio();


            //seteamos todos los datos de la entidad existente en los campos
            teAnotaciones.Text = m_entMovil.Anot;
            teDescripcionMovil.Text = m_entMovil.Des;
            teNroChasis.Text = m_entMovil.Nrochasis;
            teNroMotor.Text = m_entMovil.Nromotor;
            tePatente.Text = m_entMovil.Patente;
            cdcModelo.SelectedStrCode = m_entMovil.Modelo;
            cdcMovilPropio.SelectedStrCode = m_entMovil.Propio;
            neAnioFabric.Numero = m_entMovil.Aniofabric;

            //llenamos la CDCheckedList
            CheckearEquipamientosMovil(clEquipamientos, m_entMovil);

        }

        #endregion

        






    }
}
