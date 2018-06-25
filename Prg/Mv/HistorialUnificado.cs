using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mrln.Bll;
using Mrln.Bel;
using TNGS;
using TNGS.NetApp;
using TNGS.NetRoutines;
using TNGS.NetControls;
using WeifenLuo.WinFormsUI.Docking;

namespace Mrln.Mv
{
    public partial class HistorialUnificado : Form
    {

        private StatMsg m_smResult = null;

        #region Constructor
        public HistorialUnificado(string p_strPatente)
        {
            InitializeComponent();
            m_smResult = new StatMsg();

            ListaEntidades historial = Bll.Moviles.GetHistorialFull(p_strPatente, ref m_smResult);

            Bel.LERowsHistorial historialTIpado = new Bel.LERowsHistorial(historial.InternalData.Table);
            mrHistorialUnificado.LoadData(historialTIpado,"Historial Unificado", "", "Moviles", "Historial Unificado", "Historial Unificado", "", ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            lblPatenteValue.Text = p_strPatente;
        }

        #endregion

        private void gbAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
