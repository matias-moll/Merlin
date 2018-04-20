using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TNGS.NetAppBll;
using Mrln.Bel;
using Mrln.Bll;

namespace Mrln.Mv
{
    public partial class AsigarOT : Form
    {
        private LEEstados m_LEEstados;

        public AsigarOT(LEEstados p_LEEstados)
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
            if (!cdcEstados.IsValid) { AppRuts.App_ShowMsg("Ingrese los datos correctamente"); return; }
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
