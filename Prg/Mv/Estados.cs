using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rivn.Bll;
using Rivn.Bel;
using TNGS;
using TNGS.NetApp;
using TNGS.NetRoutines;
using TNGS.NetControls;
using WeifenLuo.WinFormsUI.Docking;


namespace Rivn.Mv
{
    public partial class Estados : DockContent
    {
        #region Miembros de la Clase
        private Bel.EMovil m_entMovil = null;
        private Bel.EMovilCombus  m_entMovilCombus = null;
        private Bel.EMovilKms m_entMovilKm = null;
        private Bel.EMovilEquip m_entMovilEq = null;
        private Bel.EMovilEstado m_entMovilEst = null;
        private Bel.LEMovilesEstado m_lemeEstados = null;
        private StatMsg m_smResult = null;
        private ACLInfo m_aclInfo = null;
        private string m_strSort = "";
        #endregion

        public Estados()
        {
            InitializeComponent();
            // Obtenemos los permisos ACL
            m_aclInfo = App.ACLInfo;

            // Aplicamos los nieves de seguridad
            App.ApplySecurity(this);

            // Iniciamos los objetos de la clase
            m_smResult = new StatMsg("Moviles");

            // Dockeamos el formulario
            ((MainFrame)App.GetMainWindow()).AddContent(this);

            LlenarTreeMoviles();
            LlenarComboEstados();



        }

        private void LlenarComboEstados()
        {
            m_smResult.UilReset("LlenarComboEstados");
            //TODO: Aca hay que poner el metodo en las tablas generales de estados
            //m_lemeEstados = Bll.Tablas.(true,ref m_smResult);

            cmbEstado.FillFromStrLEntidad(m_lemeEstados, "est_cod_cod", "st_des_des", "deleted");
             
            MsgRuts.AnalizeError(this, m_smResult);
        }

        private void LlenarTreeMoviles()
        {
            m_smResult.UilReset("LlenarTreeMoviles");
            ListaEntidades estaSeriaLaListaDeMoviles = new ListaEntidades(new DataTable());
            //TODO: llamar metodo para llenar tree
           // Bll.Moviles.
            MsgRuts.AnalizeError(this, m_smResult);

        }

        private void Estados_Load(object sender, EventArgs e)
        {

        }

        private void ftrMoviles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            m_entMovil = Bll.Moviles.Get(ftrMoviles.SelectedNodeAsCDI.StrCode, true, ref m_smResult);
            LlenarGridEquipamiento();
            LlenarGridKm();
            LlenarGridCombustible();
            LlenarDatos();
            LlenarGridEstados();
        }

        private void LlenarGridEstados()
        {
            //TODO: Preguntar a mati acerca del get
            m_smResult.UilReset("LlenarGridEstados");
            // TODO: Usar metodo bll que traiga 5 primeros
            // LEMovilesKms l_LEMovKm = Bll.Moviles.MvkmGet5MovilesCombustibles(l_cdiMovil.StrCode, true, ref m_smResult);
            LEMovilesEstado l_LEMovComb = Bll.Moviles.MvesFGet(m_entMovil.Patente, true, ref m_smResult);
            fgCombustibles.FillFromLEntidad(l_LEMovComb);
            MsgRuts.AnalizeError(this, m_smResult);   
        }

        private void LlenarDatos()
        {
            tePatente.Text = m_entMovil.Patente;
            teModelo.Text = GetModelo(m_entMovil.Modelo);
            cmbEstado.SelectedStrCode = m_entMovil.Estado;
        }

        private string GetModelo(string p_strCodModelo)
        {
            m_smResult.UilReset("GetModelo");
            return Bll.Tablas.ModGet(p_strCodModelo, true, ref m_smResult).Des;
            MsgRuts.AnalizeError(this, m_smResult);
        }

        private void LlenarGridCombustible()
        {
            m_smResult.UilReset("LlenarGridCombustible");
            // TODO: Usar metodo bll que traiga 5 primeros
            // LEMovilesKms l_LEMovKm = Bll.Moviles.MvkmGet5MovilesCombustibles(l_cdiMovil.StrCode, true, ref m_smResult);
            LEMovilesCombus l_LEMovComb = Bll.Moviles.MvcoFGet(m_entMovil.Patente, true, ref m_smResult);
           fgCombustibles.FillFromLEntidad(l_LEMovComb);
           MsgRuts.AnalizeError(this, m_smResult);
        }

        private void LlenarGridKm()
        {
            m_smResult.UilReset("LlenarGridKms");
            // TODO: Usar metodo bll que traiga 5 primeros
            // LEMovilesKms l_LEMovKm = Bll.Moviles.MvkmGet5MovilesKm(l_cdiMovil.StrCode, true, ref m_smResult);
            LEMovilesKms l_LEMovKm = Bll.Moviles.MvkmFGet(m_entMovil.Patente, true, ref m_smResult);
            fgCombustibles.FillFromLEntidad(l_LEMovKm);
            MsgRuts.AnalizeError(this, m_smResult);
        }

        private void LlenarGridEquipamiento()
        {
            m_smResult.UilReset("LlenarGridEquipamiento");
            fgCombustibles.FillFromLEntidad(m_entMovil.MovilesEquip);
            MsgRuts.AnalizeError(this, m_smResult);
        }

        private void LimpiarCampos()
        {
            teModelo.Clear();
            tePatente.Clear();
            cmbEstado.SelectedIndex = 0;
        }

        private void gbBorrarMovil_Click(object sender, EventArgs e)
        {
            if (!BorradoSeguro()) return;

        }

        private bool BorradoSeguro()
        {
           DialogResult l_drResult =  MessageBox.Show("¿Está seguro que desea borrar?", "Borrado", MessageBoxButtons.YesNo);
           if (l_drResult == System.Windows.Forms.DialogResult.Yes)
               return true;
           else return false;
        }

        private void gbBorrarEq_Click(object sender, EventArgs e)
        {
            if (!BorradoSeguro()) return;
            //TODO: Preguntar a Mati:
           // Bll.Moviles.MveqRemove(m_entMovil.Patente,fgEquipamiento.Select,)

        }

        private void gbNuevoKM_Click(object sender, EventArgs e)
        {
            EMovilKms l_EMKmMovilKm = Bel.EMovilKms.NewEmpty();
            if (!neKilometros.IsValid)
                DatosInvalidos();
            l_EMKmMovilKm.Fecha = DateTime.Now;
            l_EMKmMovilKm.Km = neKilometros.Numero;
            l_EMKmMovilKm.Patente = tePatente.Text;
            Bll.Moviles.MvkmSave(l_EMKmMovilKm, ref m_smResult);
            m_entMovil.MovilesKms.AddEntity(l_EMKmMovilKm);

            


        }

        private void DatosInvalidos()
        {
            MessageBox.Show("Alguno de los datos no han sido ingresados correctamente", "Datos Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        private void gbModificarEstado_Click(object sender, EventArgs e)
        {
            m_smResult.UilReset("ModificarEstado");

            EMovilEstado l_EMEstMovilEstado;
            l_EMEstMovilEstado = Bel.EMovilEstado.NewEmpty();
            l_EMEstMovilEstado.Codestado = cmbEstado.SelectedStrCode;
            l_EMEstMovilEstado.Fecha = DateTime.Now;
            l_EMEstMovilEstado.Patente = m_entMovil.Patente;
            l_EMEstMovilEstado.Km = m_entMovil.Kms;
            Bll.Moviles.MvesSave(l_EMEstMovilEstado, ref m_smResult);

            m_entMovil.Estado = cmbEstado.SelectedStrCode;
            Bll.Moviles.Save(m_entMovil, ref m_smResult);



            
            MsgRuts.AnalizeError(this, m_smResult);
        }
    }
}
