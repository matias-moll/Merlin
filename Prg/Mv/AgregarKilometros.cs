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

//namespace Rivn.Mv
//{
//    public partial class AgregarKilometros : Form
//    {
//        #region Miembros
//        Bel.LEEstaciones m_LEEstEstaciones = null;
//        private StatMsg m_smResult = null;

//        #endregion
//        #region Constructor
//        public AgregarKilometros()
//        {
            
//            InitializeComponent();
//            m_smResult = new StatMsg("MovilCombustible");         
            
//        }


//        #region Otros Metodos


//        #region Eventos Click
//        private void gbAceptar_Click(object sender, EventArgs e)
//        {
//            if (!ControlesValidos()) MsgRuts.ShowMsg(this,"Ingrese los datos correctamente");
//            this.DialogResult = System.Windows.Forms.DialogResult.OK;
//            this.Close();
//        }

//        private bool ControlesValidos()
//        {
//            return deImporte.IsValid & neLitros.IsValid & cdcEstacion.IsValid;
//        }

//        private void gbCancelar_Click(object sender, EventArgs e)
//        {
//            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
//            this.Close();
//        }
//        #endregion


//        #region Propiedades
//        public Decimal Importe
//        {
//            get { return deImporte.Decimal; }
//        }


//        public int Litros
//        {
//            get { return neLitros.Numero; }
//        }


//        public String Estacion
//        {
//            get { return cdcEstacion.SelectedStrCode; }
//            set {}
//        }
//        #endregion

//        private void lblImporte_Click(object sender, EventArgs e)
//        {

//        }

//    }
//}
