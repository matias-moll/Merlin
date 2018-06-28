using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mrln.Bll;
using TNGS;
using TNGS.NetApp;
using TNGS.NetRoutines;
using TNGS.NetControls;
using WeifenLuo.WinFormsUI.Docking;


namespace Mrln.Mv
{
    public partial class Alertas : DockContent
    {

        //miembros
        private StatMsg m_stResult;

        //constructor principal
        public Alertas()
        {
            InitializeComponent();
           
            m_stResult = new StatMsg();
        }

        #region Metodos privados de la UIL
        

        #endregion

        #region Eventos de los controles

        #endregion

    }
}
