using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TNGS.NetApp;
using Rivn.Bel;
using Rivn.Bll;

namespace Rivn.Mv
{
    public partial class ModificarEstado : Form
    {
        private LEEstados m_LEEstados;

        public ModificarEstado(LEEstados p_LEEstados)
        {
            InitializeComponent();
            m_LEEstados = p_LEEstados;
            LlenarCombo();

        }

        private void LlenarCombo()
        {
            cdcEstados.FillFromStrLEntidad(m_LEEstados, "est_rcd_cod", "est_des_des", "deleted");
        }

        private void gbAceptar_Click(object sender, EventArgs e)
        {
            if (!cdcEstados.IsValid) { MsgRuts.ShowMsg(this, "Ingrese los datos correctamente"); return; }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void gbCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }


        public string Estado {
            get {return cdcEstados.SelectedStrCode; }

        }
    }
}
