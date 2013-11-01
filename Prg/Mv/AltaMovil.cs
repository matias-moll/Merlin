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

        //constructor
        public AltaMovil()
        {
            InitializeComponent();
            ((MainFrame)App.GetMainWindow()).AddContent(this);
            m_stResult = new StatMsg("AltaMovil");

            //creamos la nueva entidad VACIA
            m_entMovil = Bel.EMovil.NewEmpty();
            
            //llenamos los controles del formulario con la informacion sacada de las tablas.
            llenarCheckListEquipamiento();
            llenarComboModelos();
            llenarComboMovilPropio();
            
            m_EstadoAlta = true;

        }

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

            //seteamos todos los datos de la entidad existente en los campos
            teAnotaciones.Text = p_entMovil.Anot;
            teDescripcionMovil.Text = p_entMovil.Des;
            teNroChasis.Text = p_entMovil.Nrochasis;
            teNroMotor.Text = p_entMovil.Nromotor;
            tePatente.Text = p_entMovil.Patente;
            cdcModelo.SelectedStrCode = p_entMovil.Modelo;
            cdcMovilPropio.SelectedStrCode = p_entMovil.Propio;
            neAnioFabric.Numero = p_entMovil.Aniofabric;

            //disbleamos los controles que no tienen que estar activos
            neKilometros.Enabled = false;
            tePatente.Enabled = false;
            teNroChasis.Enabled = false;
            teNroMotor.Enabled = false;
            gbCancel.Enabled = false;
            igDatosBasicosMovil.Enabled = p_bImgHabilitado;
            

            //recuperamos la LE de equipamientos del movil
            Bel.LEMovilesEquip l_lentMovEquipamiento = p_entMovil.MovilesEquip;


            Bel.EMovilEquip l_entMovilEquip;
            //checkeamos todos los equipamientos que posee.
            foreach (CodDesItems item in clEquipamientos.Items)
            {
                l_entMovilEquip = l_lentMovEquipamiento[p_entMovil.Patente, item.StrCode];
                //si la entidad es null, es porque no existe ninguna en la lista entidad con ese StrCode. 
                //   si no es null, la chequeamos.
                if( null != l_entMovilEquip) 
                    clEquipamientos.SetCheckedStrCode(item.StrCode, true);
            }
        }

        #endregion


        #region metodos privados de la UIL


        //chequea o Unchekea todos los items de una CheckBoxList, false para uncheaquear, true para chequear.
        private void setearTodosLosItemsCheckedList(CDCheckedList p_clCheckedListBox, bool p_unBool)
        {
            for (int index = 0; index < p_clCheckedListBox.Items.Count; index++)
            {
                p_clCheckedListBox.SetItemChecked(index, p_unBool);
            }
        }

        //pone en blanco todos los campos de DatosBasicos Movil
        private void limpiarTodosLosCamposDatosBasicos()
        {
            tePatente.Clear();
            teNroMotor.Clear();
            teNroChasis.Clear();
            teDescripcionMovil.Clear();
            teAnotaciones.Clear();
        }

        //Llenac la combo modelos con los modelos que hay en la tabla modelos.
        private void llenarComboModelos()
        {
            m_stResult.UilReset("llenarComboModelos");  
            cdcModelo.FillFromStrLEntidad(Bll.Tablas.ModUpFull(true, ref m_stResult), "mds_rcd_cod", "mds_des_des", "deleted");


            MsgRuts.AnalizeError(this, m_stResult);
        }

        //llena comboMovil con SI NO Vacio
        private void llenarComboMovilPropio()
        {
            cdcMovilPropio.AddStrCD("S","SI",0);
            cdcMovilPropio.AddStrCD("N", "NO", 0);
            cdcModelo.AddStrCD("", "VACIO", 0);
        }

        //chequea que todos los campos tengan datos validos.
        private bool CamposDatosBasicosSonValidos()
        {
           if(     
                   (teAnotaciones.IsValid)
                   && (teDescripcionMovil.IsValid)
                   && (teNroChasis.IsValid)
                   && (teNroMotor.IsValid)
                   && (tePatente.IsValid)
                   && (cdcModelo.IsValid)
                   && (cdcModelo.SelectedStrCode != "")
                   && (cdcMovilPropio.IsValid)
                   && (cdcMovilPropio.SelectedStrCode != "")
                   && (neAnioFabric.IsValid)
                   && (neKilometros.IsValid)
               ) return true;

           return false;

        }

        //llena una Entidad Movil pasada por parametro, con los datos del formulario
        private Bel.EMovil CargarFormEnEntidadMovil(Bel.EMovil p_entMovil)
        {
            //llenamos la entidad
            p_entMovil.Patente = tePatente.Text;
            p_entMovil.Des = teDescripcionMovil.Text;
            p_entMovil.Nrochasis = teNroChasis.Text;
            p_entMovil.Nromotor = teNroMotor.Text;
            p_entMovil.Modelo = cdcModelo.SelectedStrCode; 
            p_entMovil.Aniofabric = neAnioFabric.Numero;
            p_entMovil.Propio = cdcMovilPropio.SelectedStrCode;

            //retornamos la EMovil Creado
            return p_entMovil;
        }

        //llena una entidad Movil Estado pasada por parametro, con los datos del formulario
        private Bel.EMovilEstado CargarEntidadMovilEstados(Bel.EMovilEstado p_entMovilEstado)
        {
            m_stResult.UilReset("generarNuevaEntidadMovilEstados");
            
            //instanciamos el parametro que viene de afuera del sistemas ESTADO DEFAULT
            TNGS.NetAppBll.EParametro l_ptroEstadoDefault = AppRuts.ParaGet("DefaultStateMovil", false, ref m_stResult);
            if (MsgRuts.AnalizeError(this, m_stResult)) return p_entMovilEstado;

            p_entMovilEstado.Patente = tePatente.Text;
            p_entMovilEstado.Fecha = DateTime.Now;
            p_entMovilEstado.Codestado = l_ptroEstadoDefault.VStr;
            p_entMovilEstado.Km = neKilometros.Numero;

            //retornamos la EMovil Creado
            return p_entMovilEstado;
        }

        //obtiene los campos equipamientos chequeados.
        private Bel.LEMovilesEquip ObtenerLEntidadSeleccionadosCheckedList()
        {
            Bel.LEMovilesEquip l_leMovilEqts = Bel.LEMovilesEquip.NewEmpty();
            Bel.EMovilEquip l_entMovilEq = Bel.EMovilEquip.NewEmpty();

            l_entMovilEq.Patente = tePatente.Text;
            //Recorremos el Array de Strings de los Cod Seleccionados y llenamos el codigo en las entidades y luego cargandolas en la LE.
            foreach (string item in clEquipamientos.CheckedStrCodes)
            {
                l_entMovilEq.Codequip = item;
                l_leMovilEqts.AddEntity(l_entMovilEq);
            }


            return l_leMovilEqts;
        }

        //llena la ListaEntidad MovilEquip, con los datos del formulario
        private void LlenarLEMovilesEquipamiento(Bel.LEMovilesEquip p_leMovilEq)
        {
            if (m_EstadoAlta)
            {
                m_entMovil.MovilesEquip = ObtenerLEntidadSeleccionadosCheckedList();
            }
            else
            {
                //guardamos los equipamientos que tiene en caso de no poder borrar
                Bel.LEMovilesEquip l_leOriginalAuxiliar = m_entMovil.MovilesEquip;
                foreach(Bel.EMovilEquip item in m_entMovil.MovilesEquip)
                {
                    m_stResult.UilReset("generarNuevaListaEntidadMovilEquipamiento");
                    Bll.Moviles.MveqRemove(item.Patente, item.Codequip, item.FxdVersion, ref m_stResult);
                    if (MsgRuts.AnalizeError(this, m_stResult)) break;
                }
                //si el statMsg no esta bien, se setean los equipamientos que tenia originalmente
                if (m_stResult.NOk)
                {
                    m_entMovil.MovilesEquip = l_leOriginalAuxiliar;
                    return;
                }
                else
                {

                }
            }

            return;
        }

        //llena una entidad Movil KMS pasada por parametro, con los datos del formulario
        private Bel.EMovilKms generarNuevaEntidadMovilKilometros(Bel.EMovilKms p_entMovilKms)
        {
            p_entMovilKms.Patente = tePatente.Text;
            p_entMovilKms.Fecha = DateTime.Now;
            p_entMovilKms.Km = neKilometros.Numero;

            //retornamos la EMovil Creado
            return p_entMovilKms;
        }  
        
        //llena un CheckListBox con los equipamientos de la tabla Equipamientos.
        private void llenarCheckListEquipamiento()
        {
            m_stResult.UilReset("llenarCheckListEquipamiento");
            clEquipamientos.FillFromStrLEntidad(Tablas.EqiUpFull(true, ref m_stResult), "eqi_cod_cod", "eqi_des_des", "deleted");

            MsgRuts.AnalizeError(this, m_stResult);
        }

        #endregion


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
            if (!CamposDatosBasicosSonValidos())
            {
                MsgRuts.ShowMsg(this, "Algun campo es invalido");
                return;
            }

            //generamos la entidad Movil
            Bel.EMovil l_entMovil = generarNuevaEntidadMovil();
            //generamos la entidad MovilKms
            Bel.EMovilKms l_entMovilKms = generarNuevaEntidadMovilKilometros();

            m_stResult.UilReset("btnGrabar_Click");

            //grabamos las entidades
            Bll.Moviles.Save(l_entMovil, ref m_stResult);
            
            //nos fimamos si hay un error
            if (MsgRuts.AnalizeError(this, m_stResult)) {
                return; 
            }


        }


    

    }
}
