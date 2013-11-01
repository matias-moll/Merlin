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
        private Bel.LEMoviles m_LEMoviles = null;
        private Bel.EMovil m_entMovil = null;
        private Bel.LEEstados m_LEEdsEstados = null;
        //Los de abajo podrian no estar hay que ver
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

            TraerInfoBase();
            TraerInfoEstados();
            LlenarTreeMoviles();
            LlenarComboEstados();



        }

        private void TraerInfoBase()
        {
            m_smResult.UilReset("TraerInfoBase");
            m_LEMoviles = Bll.Moviles.UpFull(true, ref m_smResult);
            MsgRuts.AnalizeError(this, m_smResult);
        }

        private void TraerInfoEstados()
        {
            m_smResult.UilReset("TraerInfoEstados");
            m_LEEdsEstados = Bll.Tablas.EdsUpFull(true, ref m_smResult);
            MsgRuts.AnalizeError(this, m_smResult);

        }

        #endregion


        #region Relleno De Datos

        /// <summary>
        /// Llena la Combo De Estados Utilizando la ListaEntidad estados ya cargada con todos los estados
        /// </summary>
        private void LlenarComboEstados()
        {
            m_smResult.UilReset("LlenarComboEstados");

            cmbEstado.FillFromStrLEntidad(m_LEEdsEstados, "est_cod_cod", "st_des_des", "deleted");

            MsgRuts.AnalizeError(this, m_smResult);
        }


        /// <summary>
        /// Llena la tree con todos los moviles activos
        /// </summary>
        private void LlenarTreeMoviles()
        {
            m_smResult.UilReset("LlenarTreeMoviles");
            ListaEntidades l_LEMovilesTree = new ListaEntidades(new DataTable());
            Bll.Moviles.fArmarTree(l_LEMovilesTree, true, ref m_smResult);
            ftrMoviles.FillFromStrLEntidad(l_LEMovilesTree, "est_rcd_cod", "est_des_des", 2, "Nivel", "Imagen", "Imagen");
            MsgRuts.AnalizeError(this, m_smResult);

        }


        /// <summary>
        /// Llena la grid de los Estados con el historial de los estados que tuvo un movil
        /// </summary>
        private void LlenarGridEstados()
        {
            m_smResult.UilReset("LlenarGridEstados");
            LEMovilesEstado l_larala = LEMovilesEstado.NewEmpty();
            m_entMovil.MovilesEstado.Sort("desc mve_fyh_fecha");
            fgCombustibles.FillFromLEntidad(Dame5PrimerosEstados(m_entMovil.MovilesEstado));
            MsgRuts.AnalizeError(this, m_smResult);
        }



        /// <summary>
        /// Se llenan los datos importantes del movil
        /// </summary>
        private void LlenarDatos()
        {
            tePatente.Text = m_entMovil.Patente;
            teModelo.Text = GetModelo(m_entMovil.Modelo);

            //TODO: Cambiar para sacar del historico de estados
            //cmbEstado.SelectedStrCode =
        }



        /// <summary>
        /// Se llena la grid con el historial de carga de combustible
        /// </summary>
        private void LlenarGridCombustible()
        {
            m_smResult.UilReset("LlenarGridCombustible");
            m_entMovil.MovilesCombus.Sort("desc mco_fyh_fecha");
            fgCombustibles.FillFromLEntidad(Dame5PrimerosCombustibles(m_entMovil.MovilesCombus));
            MsgRuts.AnalizeError(this, m_smResult);
        }


        /// <summary>
        /// Se llena la grid de kilometros con el historial del kilometraje
        /// </summary>
        private void LlenarGridKm()
        {
            m_smResult.UilReset("LlenarGridKms");
            m_entMovil.MovilesKms.Sort("desc mkm_fyh_fecha");
            fgCombustibles.FillFromLEntidad(Dame5PrimerosKms(m_entMovil.MovilesKms));
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

            m_entMovil = m_LEMoviles[ftrMoviles.SelectedNodeAsCDI.StrCode];
            LlenarGridEquipamiento();
            LlenarGridKm();
            LlenarGridCombustible();
            LlenarDatos();
            LlenarGridEstados();
        }


        #region Clicks

        private void gbModificarMovil_Click(object sender, EventArgs e)
        {

        }


        private void gbModificarEq_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Borrado de un Movil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        //TODO: Preguntar acerca del borrado
        private void gbBorrarMovil_Click(object sender, EventArgs e)
        {
            m_smResult.UilReset("BorrarMovil");
            if (!BorradoSeguro()) return;
            Bll.Moviles.Remove(m_entMovil.Patente,m_entMovil.FxdVersion, ref m_smResult);
            m_entMovil = null;
            LimpiarCampos();
            TraerInfoBase();
            LlenarTreeMoviles();
            MsgRuts.AnalizeError(this, m_smResult);
        }


        /// <summary>
        /// Borrar un Equipamiento de un determinado movil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gbBorrarEq_Click(object sender, EventArgs e)
        {
            m_smResult.UilReset("BorrarEquipamientoMovil");
            if (!BorradoSeguro()) return;
            object l_objCodigo = fgEquipamiento.GetMatrixValueObj(fgEquipamiento.CurrentRowIndex,0);
            if ((l_objCodigo == DBNull.Value) || (l_objCodigo == null))
                    return;
            Bll.Moviles.MveqRemove(m_entMovil.Patente, (string)l_objCodigo, m_entMovil.FxdVersion, ref m_smResult);
            MsgRuts.AnalizeError(this, m_smResult);


        }


        private void gbNuevoMovil_Click(object sender, EventArgs e)
        {
        }


        private void gbAgregarCombustible_Click(object sender, EventArgs e)
        {
            m_smResult.UilReset("AgregarCargaCombustible");
            MovilCombustible l_frmMovilCombustible = new MovilCombustible();
            l_frmMovilCombustible.ShowDialog();
            if (l_frmMovilCombustible.DialogResult == System.Windows.Forms.DialogResult.Abort)
            {
                return;
            }
            EMovilCombus l_EMComMovilCombustible = EMovilCombus.NewEmpty();
            l_EMComMovilCombustible.Codestacion = l_frmMovilCombustible.Estacion;
            l_EMComMovilCombustible.Fecha = DateTime.Now;
            l_EMComMovilCombustible.Litros = l_frmMovilCombustible.Litros;
            l_EMComMovilCombustible.Patente = m_entMovil.Patente;
            l_EMComMovilCombustible.Importe = l_frmMovilCombustible.Importe;
            Bll.Moviles.MvcoSave(l_EMComMovilCombustible, ref m_smResult);
            TraerInfoBase();
            LlenarGridCombustible();
            MsgRuts.AnalizeError(this, m_smResult);


        }
        /// <summary>
        /// Ingresar un nuevo kilometraje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void gbNuevoKM_Click(object sender, EventArgs e)
        {
            m_smResult.UilReset("ClickNuevoKm");
            EMovilKms l_EMKmMovilKm = Bel.EMovilKms.NewEmpty();
            if (!neKilometros.IsValid)
                DatosInvalidos();
            l_EMKmMovilKm.Fecha = DateTime.Now;
            l_EMKmMovilKm.Km = neKilometros.Numero;
            l_EMKmMovilKm.Patente = tePatente.Text;
            Bll.Moviles.MvkmSave(l_EMKmMovilKm, ref m_smResult);
            TraerInfoBase();
            LlenarGridKm();
            MsgRuts.AnalizeError(this,m_smResult);



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
            m_entMovil.MovilesKms.Sort("desc mkm_nro_km");
            l_EMEstMovilEstado.Km = m_entMovil.MovilesKms[0].Km;

            Bll.Moviles.MvesSave(l_EMEstMovilEstado, ref m_smResult);

            //Guardamos tmb la entidad movil con su nuevo estado cambiado
            Bll.Moviles.Save(m_entMovil, ref m_smResult);




            MsgRuts.AnalizeError(this, m_smResult);
        }
        #endregion
        #endregion


        #region Otros Metodos
        /// <summary>
        /// Devuelve 5 primeros estados de un movil
        /// </summary>
        /// <param name="p_LEMEEstadosDeMovil">Lista Entidad tipada MOviles Estado</param>
        /// <returns></returns>
        private LEMovilesEstado Dame5PrimerosEstados(LEMovilesEstado p_LEMEEstadosDeMovil)
        {
           LEMovilesEstado l_LEMEPrimerosCincoMovilesEstados = LEMovilesEstado.NewEmpty();
            for (long i = 0; i <= 4; i++)
            {
                l_LEMEPrimerosCincoMovilesEstados.AddEntity(p_LEMEEstadosDeMovil[i]);
            }
            return l_LEMEPrimerosCincoMovilesEstados;
        }

        /// <summary>
        /// Devuelve 5 primeras cargas de combustible de un movil
        /// </summary>
        /// <param name="p_LEMEEstadosDeMovil">Lista entidad tipada</param>
        /// <returns></returns>
        private LEMovilesCombus Dame5PrimerosCombustibles(LEMovilesCombus p_LEMECombusDeMovil)
        {
            LEMovilesCombus l_LEMEPrimerosCincoMovilesCombustibles = LEMovilesCombus.NewEmpty();
            for (long i = 0; i <= 4; i++)
            {
                l_LEMEPrimerosCincoMovilesCombustibles.AddEntity(p_LEMECombusDeMovil[i]);
            }
            return l_LEMEPrimerosCincoMovilesCombustibles;
        }


        /// <summary>
        /// Devuelve lista entidad con los primeros 5 registros de kms
        /// </summary>
        /// <param name="p_LEMEEstadosDeMovil">Lista entidad tipada de estados</param>
        /// <returns></returns>
        private LEMovilesKms Dame5PrimerosKms(LEMovilesKms p_LEMEKmsDeMovil)
        {
            LEMovilesKms l_LEMEPrimerosCincoMovilesKms = LEMovilesKms.NewEmpty();
            for (long i = 0; i <= 4; i++)
            {
                l_LEMEPrimerosCincoMovilesKms.AddEntity(p_LEMEKmsDeMovil[i]);
            }
            return l_LEMEPrimerosCincoMovilesKms;
        }







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
