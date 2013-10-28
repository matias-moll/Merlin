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


namespace Rivn.Mv
{
    public partial class AltaMovil : DockContent
    {
        #region Constructor y variables miembro

        //miembros
        private StatMsg m_stResult;

        //constructor
        public AltaMovil()
        {
            InitializeComponent();
            ((MainFrame)App.GetMainWindow()).AddContent(this);
            m_stResult = new StatMsg("AltaMovil");
            llenarCheckListEquipamiento();
            llenarComboModelos();
            llenarComboMovilPropio();

        }

        public AltaMovil(Bel.EMovil p_entMovil) : this()
        {
            //seteamos todos los datos de la entidad existente en los campos
            teAnotaciones.Text = p_entMovil.Anot;
            teDescripcionMovil.Text = p_entMovil.Des;
            teNroChasis.Text = p_entMovil.Nrochasis;
            teNroMotor.Text = p_entMovil.Nromotor;
            tePatente.Text = p_entMovil.Patente;
            cdcModelo.SelectedStrCode = p_entMovil.Modelo;
            cdcMovilPropio.SelectedStrCode = p_entMovil.Propio;
            neAnioFabric.Numero = p_entMovil.Aniofabric;

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
            cdcModelo.AddStrCD("","VACIO", 0);

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
        
        //genera una nueva entidad Movil, con los datos del formulario
        private Bel.EMovil generarNuevaEntidadMovil()
        {
            Bel.EMovil l_entMovil = Bel.EMovil.NewEmpty();
            l_entMovil.Patente = tePatente.Text;
            l_entMovil.Des = teDescripcionMovil.Text;
            l_entMovil.Nrochasis = teNroChasis.Text;
            l_entMovil.Nromotor = teNroMotor.Text;
            l_entMovil.Modelo = cdcModelo.SelectedStrCode; 
            l_entMovil.Aniofabric = neAnioFabric.Numero;
            l_entMovil.Propio = cdcMovilPropio.SelectedStrCode;

            //VerEsto NO TIENE QUE IR   
            l_entMovil.Kms = 1;
            l_entMovil.Estado = "ROTO";

            //retornamos la EMovil Creado
            return l_entMovil;
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
            setearTodosLosItemsCheckedList(clEquipamientos, false);
            limpiarTodosLosCamposDatosBasicos();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
           //nos fijamos que todos los campos sean validos.
            if (CamposDatosBasicosSonValidos())
            {
                MsgRuts.ShowMsg(this, "Algun campo es invalido");
                return;
            }

            //generamos la entidad Movil
            Bel.EMovil l_entMovil = generarNuevaEntidadMovil();

            m_stResult.UilReset("btnGrabar_Click");

            //grabamos la entidad
            Bll.Moviles.Save(l_entMovil, ref m_stResult);

            if (MsgRuts.AnalizeError(this, m_stResult)) return ;

            //le hacemos notar que el registro se grabo
            MsgRuts.ShowMsg(this, "El Movil se guardo satisfactoriamente");

        }


    

    }
}
