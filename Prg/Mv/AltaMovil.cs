﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mrln.Bll;
using TNGS;
using TNGS.NetApp;
using TNGS.NetRoutines;
using TNGS.NetControls;
using WeifenLuo.WinFormsUI.Docking;


namespace Mrln.Mv
{
    public partial class AltaMovil : Form
    {

        //miembros
        private StatMsg m_smResult;
        private bool m_EstadoAlta;
        private Bel.EMovil m_entMovil;
        public delegate void ChangedMovilEventHandler(object sender, EventArgs e);
        public event ChangedMovilEventHandler m_evChangedMovil;

        //constructor principal
        public AltaMovil()
        {
            InitializeComponent();
           
            m_smResult = new StatMsg();

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
            teNroPloteado.Enabled = false;
            btnExit.Enabled = true;
            tgrpDatosBasicos.Enabled = p_bImgHabilitado;

        }

        //constructor para mostrar
        public AltaMovil(Bel.EMovil p_entMovil): this(p_entMovil, false)
        {
            tgrpEquipamiento.Enabled = false;
            gbGrabar.Enabled = false;
            gbLimpiarTodo.Enabled = false;
            btnDestildarTodoEqi.Enabled = false;
            btnTildaTodos.Enabled = false;
        }


        #region Metodos privados de la UIL


        protected virtual void OnChangedMovil(EventArgs e)
        {
            if (m_evChangedMovil != null)
                m_evChangedMovil(this, e);
        }


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
            clEquipamientos.FillFromStrLEntidad(Tablas.EqiUpFull(true, m_smResult), "eqi_cod_cod", "eqi_des_des", "deleted");

            MsgRuts.AnalizeError(this, m_smResult);
        }

        // pone en blanco todos los campos de DatosBasicos Movil
        private void limpiarTodosLosCamposDatosBasicos()
        {
            tePatente.Clear();
            teNroMotor.Clear();
            teNroPloteado.Clear();
            teNroChasis.Clear();
            teDescripcionMovil.Clear();
            teAnotaciones.Clear();
            neAnioFabric.Clear();
            neKilometros.Clear();
            cdcModelo.SelectedIndex = -1;
            cdcMovilPropio.SelectedIndex = -1;
            cdcTipoMovil.SelectedIndex = -1;
        }

        // Llenac la combo modelos con los modelos que hay en la tabla modelos.
        private void llenarComboModelos()
        {
            //llenamos la combo
            cdcModelo.FillFromStrLEntidad(Bll.Tablas.ModUpFull(true, m_smResult), "mds_rcd_cod", "mds_des_des", "deleted");
            if(MsgRuts.AnalizeError(this, m_smResult)) return;

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

        private void llenarComboTipoMovil()
        {
            ListaEntidades tiposMoviles = EnCll.Moviles.GetListaTipoMoviles;

            if (tiposMoviles == null)
            {
                tiposMoviles = Bll.Moviles.fGetTiposMovilesCEDI(m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;
            }

            if (tiposMoviles == null || tiposMoviles.Count == 0)
                cdcTipoMovil.AddStrCD("   1", "ESTANDAR");
            else
                cdcTipoMovil.FillFromStrLEntidad(tiposMoviles, "codigo", "descripcion", "deleted");
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
                   || (!teNroPloteado.IsValid)
                   || (!tePatente.IsValid)
                   || (!cdcModelo.IsValid)
                   || (cdcModelo.SelectedStrCode == "")
                   || (!cdcMovilPropio.IsValid)
                   || (cdcMovilPropio.SelectedStrCode == "")
                   || (cdcTipoMovil.SelectedStrCode == "")
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

            bool tieneEseMovilEquipamiento = false;

            // instanciamos un array donde van a guardarse los codigos de los equipamientos seleccionados
            string[] arraySoporte = new string[p_clEqui.Items.Count];
            int l_iContador = 0;
            foreach (CodDesItems item in p_clEqui.Items)
            {
                // Si la lista enteidades es null, es porque no existe ninguna en la lista entidad con ese StrCode. 
                if (l_lentMovEquipamiento == null)
                    arraySoporte[l_iContador] = "";
                else
                {
                    tieneEseMovilEquipamiento = l_lentMovEquipamiento.Any(mvlEquip => mvlEquip.Codequip == item.StrCode);

                    if (tieneEseMovilEquipamiento)
                        arraySoporte[l_iContador] = item.StrCode;
                    else
                        arraySoporte[l_iContador] = "";
                }

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
            p_entMovil.Nroploteado = teNroPloteado.Text;
            p_entMovil.Modelo = cdcModelo.SelectedStrCode; 
            p_entMovil.Aniofabric = neAnioFabric.Numero;
            p_entMovil.Propio = cdcMovilPropio.SelectedStrCode;
            p_entMovil.Tipodemovil = cdcTipoMovil.SelectedStrCode;
    
        }

        // llena una entidad Movil Estado pasada por parametro, con los datos del formulario
        private Bel.EMovilEstado GenerarEstadoDefault()
        {
            //creamos una nueva ListaEntidad nueva. 
            Bel.EMovilEstado l_leMvlEstado = Bel.EMovilEstado.NewEmpty();

            
            //instanciamos el parametro que viene de afuera del sistemas ESTADO DEFAULT
            EParametro l_ptroEstadoDefault = App.ParaGet("estadoDef", false, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult))
            {
                l_leMvlEstado.Patente = "";
                return l_leMvlEstado;
            } 
            l_leMvlEstado.Patente = tePatente.Text;
            l_leMvlEstado.Fecha = DateTime.Now;
            l_leMvlEstado.Codestado = Bel.EMovilEstado.FrmtCodestado(l_ptroEstadoDefault.VStr);
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
                Bll.Moviles.Save(m_entMovil, m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;
                MsgRuts.ShowMsg(this, "El nuevo Movil ha sido agregado satisfactoriamente");
            }
            else
            {
                // si es estado de Update se llama al metodo que elimina todos los equipamientos, carga los nuevos y graba la entidad.
                Bll.Moviles.CambiarEquipamientoYGrabarMovil(m_entMovil, ObtenerLEntidadSeleccionadosCheckedList(), m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;
                MsgRuts.ShowMsg(this, "El Movil ha sido modificado satisfactoriamente");
            }

            OnChangedMovil(EventArgs.Empty);
            this.Close();
        }
        
        private void AltaMovil_Load(object sender, EventArgs e)
        {
            //llenamos los controles del formulario con la informacion sacada de las tablas.
            llenarCheckListEquipamiento();
            llenarComboModelos();
            llenarComboMovilPropio();
            llenarComboTipoMovil();


            //seteamos todos los datos de la entidad existente en los campos
            teAnotaciones.Text = m_entMovil.Anot;
            teDescripcionMovil.Text = m_entMovil.Des;
            teNroChasis.Text = m_entMovil.Nrochasis;
            teNroMotor.Text = m_entMovil.Nromotor;
            teNroPloteado.Text = m_entMovil.Nroploteado;
            tePatente.Text = m_entMovil.Patente;
            cdcModelo.SelectedStrCode = m_entMovil.Modelo;
            cdcMovilPropio.SelectedStrCode = m_entMovil.Propio;
            cdcTipoMovil.SelectedStrCode = m_entMovil.Tipodemovil;
            neAnioFabric.Numero = m_entMovil.Aniofabric;

            //llenamos la CDCheckedList
            CheckearEquipamientosMovil(clEquipamientos, m_entMovil);

        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
