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
    public partial class MovilCombustible : Form
    {
        #region Miembros
        Bel.LEEstaciones m_LEEstEstaciones = null;
        private StatMsg m_smResult = null;

        #endregion
        #region Constructor
        public MovilCombustible()
        {
            
            InitializeComponent();
            m_smResult = new StatMsg("MovilCombustible");
            CargarEstaciones();
            CargarCombo();
            
            
        }

        private void CargarCombo()
        {
            cdcEstacion.FillFromStrLEntidad(m_LEEstEstaciones, "ets_rcd_cod", "ets_des_des", "deleted");
        }
        #endregion

        #region Otros Metodos

        private void CargarEstaciones()
        {
            m_smResult.UilReset("TraerInfoBase");
            m_LEEstEstaciones = Bll.Tablas.EstUpFull(true, ref m_smResult);
            MsgRuts.AnalizeError(this, m_smResult);
        }
        #endregion

        #region Eventos Click
        private void gbAceptar_Click(object sender, EventArgs e)
        {
            if (!ControlesValidos()) MsgRuts.ShowMsg(this,"Ingrese los datos correctamente");
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private bool ControlesValidos()
        {
            return neImporte.IsValid & neLitros.IsValid & cdcEstacion.IsValid;
        }

        private void gbCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
        #endregion


        #region Propiedades
        public int Importe
        {
            get { return neImporte.Numero; }
        }


        public int Litros
        {
            get { return neLitros.Numero; }
        }


        public String Estacion
        {
            get { return cdcEstacion.SelectedStrCode; }
            set {}
        }
        #endregion

    }
}
