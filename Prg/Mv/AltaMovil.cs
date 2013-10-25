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

        private void llenarComboModelos()
        {
            m_stResult.UilReset("llenarComboModelos");
            cmbModelo.FillFromStrLEntidad(Bll.Tablas.ModUpFull(true, ref m_stResult), "mds_rcd_cod", "mds_des_des", "deleted");

            MsgRuts.AnalizeError(this, m_stResult);
        }
        
        //genera una nueva entidad Movil, con los datos del formulario
        private Bel.EMovil generarNuevaEntidadMovil()
        {
            Bel.EMovil l_entMovil = Bel.EMovil.NewEmpty();
            l_entMovil.Patente = tePatente.Text;
            l_entMovil.Des = teDescripcionMovil.Text;
            l_entMovil.Nrochasis = teNroChasis.Text;
            l_entMovil.Nromotor = teNroMotor.Text;
            l_entMovil.Modelo = cmbModelo.SelectedStrCode; 
            l_entMovil.Aniofabric = neAnioFabric.Numero;
            //de aca en adelante hay que cambiarlos, estan HARDCODED
                l_entMovil.Kms = 1;
                l_entMovil.Estado = "ROTO";
                l_entMovil.Propio = "S";
                //l_entMovil.MovilesCombus = Bel.LEMovilesCombus.NewEmpty();
                //l_entMovil.MovilesEstado = Bel.LEMovilesEstado.NewEmpty();
                //l_entMovil.MovilesKms = Bel.LEMovilesKms.NewEmpty();
                //l_entMovil.MovilesEquip = Bel.LEMovilesEquip.NewEmpty();

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
