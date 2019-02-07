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
    public partial class AccidentesPorMovil : ReporteBase
    {
        // Miembros
        CDCombo cdcMoviles = new CDCombo();
        DateEdit deFechaInicio = new DateEdit();
        DateEdit deFechaFin = new DateEdit();

        // Constructor
        public AccidentesPorMovil() : base("AccidentesPorMovil")
        {
            InitializeComponent();
        }
        
        public override void buildPanel()
        {
            Bel.LEMoviles moviles = Bll.Moviles.UpFull(true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            cdcMoviles.FillFromStrLEntidad(moviles, Bel.EMovil.PatenteCmp, Bel.EMovil.DesCmp, "deleted");
            cdcMoviles.AddStrCD("", "--TODOS--", 0);

            // Añadimos controles necesarios.
            this.panelBuilder.AddControlWithLabel("Moviles", cdcMoviles)
                             .AddControlWithLabel("Fecha Inicio", deFechaInicio)
                             .AddControlWithLabel("Fecha Fin", deFechaFin);

        }


        override public ListaEntidades realizarBusqueda(ref string p_strNombreEmpresa, ref string p_strPrograma, ref string p_strNombreReporte,
                                                        ref string p_strDetalleReporte, ref int p_intCorteDeControl)
        {
            // Cargamos los valores de referencia para el llenado del report.
            p_strNombreReporte = "Accidentes Por Móvil";
            p_strNombreEmpresa = Shr.ROParam.Empresa.VStr;
            p_strPrograma = "Reportes";

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

            ListaEntidades l_leCostos = Bll.Moviles.MvacZAccidentesPorMovil(deFechaInicio.Fecha, deFechaFin.Fecha, l_strPatenteIni, l_strPatenteFin, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return null;

            l_leCostos.ChangeCaption("detalle", "V1DetalleCN1");

            return l_leCostos;
        }

    }
}
