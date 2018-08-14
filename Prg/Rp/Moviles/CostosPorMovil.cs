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
    public partial class CostosPorMovil : ReporteBase
    {
        // Miembros
        CDCombo cdcMoviles = new CDCombo();
        DateEdit deFechaInicio = new DateEdit();
        DateEdit deFechaFin = new DateEdit();

        // Constructor
        public CostosPorMovil() : base("CostosPorMovil")
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
            p_strNombreReporte = "Costos Por Móvil";

            if (deFechaFin.Fecha == DateTimeRuts.Empty || deFechaInicio.Fecha == DateTimeRuts.Empty)
            {
                MsgRuts.ShowMsg(this, "Debe definir un rango de fechas para la busqueda.");
                return null;
            }

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

            ListaEntidades l_leCostos = Bll.Moviles.ZCostosPorMovil(deFechaInicio.Fecha, deFechaFin.Fecha, l_strPatenteIni, l_strPatenteFin, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return null;

            l_leCostos.ChangeCaption("patente", "V1PatenteCN1");
            l_leCostos.ChangeCaption("movil", "V1MóvilCN1");
            l_leCostos.ChangeCaption("fecha", "V1FechaFN1");
            l_leCostos.ChangeCaption("tipo", "V1TipoCN1");
            l_leCostos.ChangeCaption("descripcion", "V1DescripciónCN1");
            l_leCostos.ChangeCaption("importe", "V1Importe2S1");

            return l_leCostos;
        }

    }
}
