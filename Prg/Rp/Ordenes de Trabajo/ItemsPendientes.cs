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
    public partial class ItemsPendientes : ReporteBase
    {
        // Miembros
        CDCombo cdcMoviles = new CDCombo();

        // Constructor
        public ItemsPendientes() : base("ItemsPendientes")
        {
            InitializeComponent();
        }
        
        public override void buildPanel()
        {
            Bel.LEMoviles moviles = Bll.Moviles.UpFull(true, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            cdcMoviles.FillFromStrLEntidad(moviles, Bel.EMovil.PatenteCmp, Bel.EMovil.DesCmp, "deleted");
            cdcMoviles.AddStrCD("", "--TODOS--", 0);

            // Añadimos controles necesarios.
            this.panelBuilder.AddControlWithLabel("Moviles", cdcMoviles);

        }

        override public ListaEntidades realizarBusqueda(ref string p_strNombreEmpresa, ref string p_strNombreReporte,
                                                        ref string p_strDetalleReporte, ref int p_intCorteDeControl)
        {
            // Cargamos los valores de referencia para el llenado del report.
            p_strNombreReporte = "Items de Ordenes de Trabajo Pendientes";


            // Declaramos y definimos las 2 variables para los limites de la busqueda
            string l_strPatenteIni = "", l_strPatenteFin = "";

            // Logica de los limites de busqueda 
            if (cdcMoviles.SelectedStrCode.Trim() == "")
            {
                l_strPatenteIni = "       0";
                l_strPatenteFin = "zzzzzzzz";
            }
            else
                l_strPatenteIni = l_strPatenteFin = cdcMoviles.SelectedStrCode;

            ListaEntidades l_leItemsPendientes = Bll.OrdenesTrabajo.OtitZPendientes(l_strPatenteIni, l_strPatenteFin, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return null;

            return l_leItemsPendientes;
        }

    }
}
