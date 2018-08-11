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
    public partial class OrdenesFinalizadas : ReporteBase
    {
        // Miembros
        CDCombo cdcMoviles = new CDCombo();
        DateEdit deFechaInicio = new DateEdit();
        DateEdit deFechaFin = new DateEdit();

        // Constructor
        public OrdenesFinalizadas() : base("OrdenesFinalizadas")
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
            this.panelBuilder.AddControlWithLabel("Moviles", cdcMoviles)
                             .AddControlWithLabel("Fecha Inicio", deFechaInicio)
                             .AddControlWithLabel("Fecha Fin", deFechaFin);

        }

        override public ListaEntidades realizarBusqueda(ref string p_strNombreEmpresa, ref string p_strNombreReporte,
                                                        ref string p_strDetalleReporte, ref int p_intCorteDeControl)
        {
            // Cargamos los valores de referencia para el llenado del report.
            p_strNombreReporte = "Ordenes de Trabajo Finalizadas";


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

            ListaEntidades l_leOrdenesFinalizadas = Bll.OrdenesTrabajo.ZFinalizadas(deFechaInicio.Fecha, deFechaFin.Fecha,
                                                                                    l_strPatenteIni, l_strPatenteFin, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return null;

            l_leOrdenesFinalizadas.ChangeCaption("movil", "V1MóvilCN1");
            l_leOrdenesFinalizadas.ChangeCaption("fapertura", "V1F. AperturaFN1");
            l_leOrdenesFinalizadas.ChangeCaption("fcierre", "V1F. CierreFN1");
            l_leOrdenesFinalizadas.ChangeCaption("taller", "V1TallerCN1");
            l_leOrdenesFinalizadas.ChangeCaption("total", "V1Total2S1");

            return l_leOrdenesFinalizadas;
        }
    }
}
