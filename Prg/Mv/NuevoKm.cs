using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TNGS.NetApp;

namespace Rivn.Mv
{
    public partial class NuevoKm : Form
    {
        public NuevoKm()
        {
            InitializeComponent();
        }

        private void gbAceptar_Click(object sender, EventArgs e)
        {
            if (!neKms.IsValid) { MsgRuts.ShowMsg(this, "Ingrese los datos correctamente"); return; };
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void gbCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        public int Kilometros
        {
            get { return neKms.Numero; }
        }
    }
}
