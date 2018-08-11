using System;
using System.Windows.Forms;
using TNGS.NetApp;
using TNGS.NetControls;
using TNGS.NetRoutines;
using WeifenLuo.WinFormsUI.Docking;
using TNGS.NetAppSupport;
using Mrln.Bel;

namespace Mrln.Rp
{
    public partial class EstadoMoviles : ReporteBase
    {
        // Miembros
        CDCombo cdcEstados = new CDCombo();

        // Constructor
        public EstadoMoviles() : base("EstadoMoviles")
        {
            InitializeComponent();
        }
        
        public override void buildPanel()
        {
            Bel.LEEstados estados = Bll.Tablas.EdsUpFull(true, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cdcEstados.FillFromStrLEntidad(estados, Bel.EEstado.DesCmp, Bel.EEstado.DesCmp, "deleted");
            cdcEstados.AddStrCD("", "--TODOS--", 0);

            // Añadimos controles necesarios.
            this.panelBuilder.AddControlWithLabel("Estados", cdcEstados);

        }

        override public ListaEntidades realizarBusqueda(ref string p_strNombreEmpresa, ref string p_strNombreReporte,
                                                        ref string p_strDetalleReporte, ref int p_intCorteDeControl)
        {
            // Cargamos los valores de referencia para el llenado del report.
            p_strNombreReporte = "Estado Moviles";


            // Declaramos y definimos las 2 variables para los limites de la busqueda
            string l_strEstadoIni = "", l_strEstadoFin = "";

            // Logica de los limites de busqueda 
            if (cdcEstados.SelectedStrCode.Trim() == "")
            {
                // Enrealidad son des, pero calculo que con este deberia funcionar el between.
                l_strEstadoIni = "       0";
                l_strEstadoFin = "zzzzzzzz";
            }
            else
                l_strEstadoIni = l_strEstadoFin = cdcEstados.SelectedStrCode;

            ListaEntidades l_leMoviles = Bll.Moviles.ZMovilesPorEstado(l_strEstadoIni, l_strEstadoFin, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return null;

            return l_leMoviles;
        }

    }
}
