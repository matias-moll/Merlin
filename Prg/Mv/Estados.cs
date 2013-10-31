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
        private Bel.EMovilCombus m_entMovilCombus = null;
        private Bel.EMovilKms m_entMovilKm = null;
        private Bel.EMovilEquip m_entMovilEq = null;
        private Bel.EMovilEstado m_entMovilEst = null;
        private Bel.LEMovilesEstado m_lemeEstados = null;
        private StatMsg m_smResult = null;
        private ACLInfo m_aclInfo = null;
        private string m_strSort = "";
        #endregion

        #region Constructores

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

        #endregion


        #region Relleno De Datos

        /// <summary>
        /// Llena la Combo De Estados Utilizando la ListaEntidad estados ya cargada con todos los estados
        /// </summary>
        private void LlenarComboEstados()
        {
            m_smResult.UilReset("LlenarComboEstados");
            //TODO: Aca hay que poner el metodo en las tablas generales de estados
            //m_lemeEstados = Bll.Tablas.(true,ref m_smResult);

            cmbEstado.FillFromStrLEntidad(m_lemeEstados, "est_cod_cod", "st_des_des", "deleted");

            MsgRuts.AnalizeError(this, m_smResult);
        }


        /// <summary>
        /// Llena la tree con todos los moviles activos
        /// </summary>
        private void LlenarTreeMoviles()
        {
            m_smResult.UilReset("LlenarTreeMoviles");
            ListaEntidades estaSeriaLaListaDeMoviles = new ListaEntidades(new DataTable());
            //TODO: llamar metodo para llenar tree
            // Bll.Moviles.
            MsgRuts.AnalizeError(this, m_smResult);

        }


        /// <summary>
        /// Llena la grid de los Estados con el historial de los estados que tuvo un movil
        /// </summary>
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



        /// <summary>
        /// Se llenan los datos importantes del movil
        /// </summary>
        private void LlenarDatos()
        {
            tePatente.Text = m_entMovil.Patente;
            teModelo.Text = GetModelo(m_entMovil.Modelo);
            cmbEstado.SelectedStrCode = m_entMovil.Estado;
        }



        /// <summary>
        /// Se llena la grid con el historial de carga de combustible
        /// </summary>
        private void LlenarGridCombustible()
        {
            m_smResult.UilReset("LlenarGridCombustible");
            // TODO: Usar metodo bll que traiga 5 primeros
            // LEMovilesKms l_LEMovKm = Bll.Moviles.MvkmGet5MovilesCombustibles(l_cdiMovil.StrCode, true, ref m_smResult);
            LEMovilesCombus l_LEMovComb = Bll.Moviles.MvcoFGet(m_entMovil.Patente, true, ref m_smResult);
            fgCombustibles.FillFromLEntidad(l_LEMovComb);
            MsgRuts.AnalizeError(this, m_smResult);
        }


        /// <summary>
        /// Se llena la grid de kilometros con el historial del kilometraje
        /// </summary>
        private void LlenarGridKm()
        {
            m_smResult.UilReset("LlenarGridKms");
            // TODO: Usar metodo bll que traiga 5 primeros
            // LEMovilesKms l_LEMovKm = Bll.Moviles.MvkmGet5MovilesKm(l_cdiMovil.StrCode, true, ref m_smResult);
            LEMovilesKms l_LEMovKm = Bll.Moviles.MvkmFGet(m_entMovil.Patente, true, ref m_smResult);
            fgCombustibles.FillFromLEntidad(l_LEMovKm);
            MsgRuts.AnalizeError(this, m_smResult);
        }



        /// <summary>
        /// Se llena el equipamiento del movil seleccionado
        /// </summary>
        private void LlenarGridEquipamiento()
        {
            m_smResult.UilReset("LlenarGridEquipamiento");
            fgCombustibles.FillFromLEntidad(m_entMovil.MovilesEquip);
            MsgRuts.AnalizeError(this, m_smResult);
        }


        /// <summary>
        /// Se limpian los campos
        /// </summary>
        private void LimpiarCampos()
        {
            teModelo.Clear();
            tePatente.Clear();
            cmbEstado.SelectedIndex = 0;
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Se realiza el llenado de datos y el seteo del miembro Entidad Movil Luego de elegir un Movil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ftrMoviles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            m_entMovil = Bll.Moviles.Get(ftrMoviles.SelectedNodeAsCDI.StrCode, true, ref m_smResult);
            LlenarGridEquipamiento();
            LlenarGridKm();
            LlenarGridCombustible();
            LlenarDatos();
            LlenarGridEstados();
        }


        #region Clicks


        /// <summary>
        /// Borrado de un Movil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        //TODO: Preguntar acerca del borrado
        private void gbBorrarMovil_Click(object sender, EventArgs e)
        {
            if (!BorradoSeguro()) return;

        }


        /// <summary>
        /// Borrar un Equipamiento de un determinado movil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gbBorrarEq_Click(object sender, EventArgs e)
        {
            if (!BorradoSeguro()) return;
            //TODO: Preguntar a Mati:
            // Bll.Moviles.MveqRemove(m_entMovil.Patente,fgEquipamiento.Select,)

        }


        /// <summary>
        /// Ingresar un nuevo kilometraje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Metodo que permite modificar El Estado de un movil seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gbModificarEstado_Click(object sender, EventArgs e)
        {
            m_smResult.UilReset("ModificarEstado");

            EMovilEstado l_EMEstMovilEstado;
            //creamos la entidad y la llenamos con sus datos y la guardamos
            l_EMEstMovilEstado = Bel.EMovilEstado.NewEmpty();
            l_EMEstMovilEstado.Codestado = cmbEstado.SelectedStrCode;
            l_EMEstMovilEstado.Fecha = DateTime.Now;
            l_EMEstMovilEstado.Patente = m_entMovil.Patente;
            l_EMEstMovilEstado.Km = m_entMovil.Kms;
            Bll.Moviles.MvesSave(l_EMEstMovilEstado, ref m_smResult);

            //Guardamos tmb la entidad movil con su nuevo estado cambiado
            m_entMovil.Estado = cmbEstado.SelectedStrCode;
            Bll.Moviles.Save(m_entMovil, ref m_smResult);




            MsgRuts.AnalizeError(this, m_smResult);
        }
        #endregion
        #endregion


        #region Otros Metodos

        /// <summary>
        /// dispara ventana que avisa al usuario que los datos ingresados no son correctos
        /// </summary>
        private void DatosInvalidos()
        {
            MessageBox.Show("Alguno de los datos no han sido ingresados correctamente", "Datos Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        /// <summary>
        /// Pregunta al usuario si esta seguro que quiere borrar
        /// </summary>
        /// <returns></returns>
        private bool BorradoSeguro()
        {
            DialogResult l_drResult = MessageBox.Show("¿Está seguro que desea borrar?", "Borrado", MessageBoxButtons.YesNo);
            if (l_drResult == System.Windows.Forms.DialogResult.Yes)
                return true;
            else return false;
        }


        /// <summary>
        /// Metodo que devuelve la descripcion del modelo al pasarle su codigo
        /// </summary>
        /// <param name="p_strCodModelo">Codigo de Modelo</param>
        /// <returns>Devuelve la descripción del modelo</returns>
        private string GetModelo(string p_strCodModelo)
        {
            m_smResult.UilReset("GetModelo");
            return Bll.Tablas.ModGet(p_strCodModelo, true, ref m_smResult).Des;
            MsgRuts.AnalizeError(this, m_smResult);
        }


        #endregion
    }
}
