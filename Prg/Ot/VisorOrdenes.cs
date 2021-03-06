using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mrln.Bll;
using Mrln.Bll.ObjetosSoporte;
using Mrln.Bel;
using TNGS;
using TNGS.NetApp;
using TNGS.NetRoutines;
using TNGS.NetControls;
using WeifenLuo.WinFormsUI.Docking;
using ControlesCustom;
using System.Collections;

namespace Mrln.Ot
{
    /// <summary>
    /// Formulario para consulta de datos del oficina
    /// </summary>
    public partial class VisorOrdenes : DockContent
    {
        #region Miembros
        private LEMoviles m_LEMoviles = null;
        private StatMsg m_smResult = null;
        private itemBarra m_ibItemSeleccionado = null;
        #endregion

        // Constuctor
        public VisorOrdenes()
        {
            InitializeComponent();

            // Inicializar variables
            m_smResult = new StatMsg();

            // Dockeamos el formulario
            ((MainFrame)App.GetMainWindow()).AddContent(this);
        }

        private void VisorOrdenes_Load(object sender, EventArgs e)
        {
            LlenarComboMoviles();
            actualizarOrdenesEnPantalla();
        }

        private void actualizarOrdenesEnPantalla()
        {
            LEOrdenesTrabajo ordenesPendientes = Bll.OrdenesTrabajo.getPendientes(m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            CargarOrdenes(ordenesPendientes);
        }

        #region Eventos 

        private void gbFiltrar_Click(object sender, EventArgs e)
        {
            if (!gbFiltrar.Checked)
            {
                if (cdcMoviles.SelectedStrCode == "")
                {
                    MsgRuts.ShowMsg(this, "No se puede filtrar por todas las ordenes. Elija un m�vil antes de clickear filtrar.");
                    return;
                }

                LEOrdenesTrabajo ordenesPorMovil = Bll.OrdenesTrabajo.ObtenerOTsPorPatente(cdcMoviles.SelectedStrCode, m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;

                if (ordenesPorMovil.Count == 0)
                {
                    MsgRuts.ShowMsg(this, "El Movil elegido no tiene ordenes de trabajo asociadas");
                    return;
                }

                CargarOrdenes(ordenesPorMovil);
                gbFiltrar.Checked = true;
                gbFiltrar.Text = "Quitar Filtro";
                cdcMoviles.Enabled = false;
            }
            else
            {
                actualizarOrdenesEnPantalla();

                cdcMoviles.SelectedStrCode = "";
                gbFiltrar.Checked = false;
                gbFiltrar.Text = "Filtrar";
                cdcMoviles.Enabled = true;
            }
        }

        private void gbNuevaOrden_Click(object sender, EventArgs e)
        {
            AltaOrdenes l_frmAltaOrdenes = new AltaOrdenes();
            l_frmAltaOrdenes.ShowDialog(this);

            this.agregarOrdenPendiente(l_frmAltaOrdenes.OrdenCreada);
        }

        private void gbEditarOT_Click(object sender, EventArgs e)
        {
            if (noHayItemSeleccionado())
                return;

            if (!m_ibItemSeleccionado.EsEditable)
            {
                MsgRuts.ShowMsg(this, "Una orden completa y con taller no puede ser editada");
                return;
            }

            AltaOrdenes l_frmAltaOrdenes = new AltaOrdenes(m_ibItemSeleccionado.Numero);
            l_frmAltaOrdenes.ShowDialog(this);

            if (l_frmAltaOrdenes.DialogResult == DialogResult.OK)
                m_ibItemSeleccionado.Taller = l_frmAltaOrdenes.OrdenModificada.Ot_taller;
        }

        private void gbVerItems_Click(object sender, EventArgs e)
        {
            if (noHayItemSeleccionado())
                return;

            LEOTItems itemsOrdenSeleccionada = OrdenesTrabajo.OtitFGet(m_ibItemSeleccionado.Numero, true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            itemsOrdenSeleccionada.ChangeCaption(EOTItem.NroagrupadorCmp, "");
            itemsOrdenSeleccionada.ChangeCaption(EOTItem.NroitemCmp, "");
            itemsOrdenSeleccionada.ChangeCaption("deleted", "");

            fgGrillaItemsOT.FillFromLEntidad(itemsOrdenSeleccionada);
        }

        private void gbCancelar_Click(object sender, EventArgs e)
        {
            if (noHayItemSeleccionado())
                return;

            // Pasamos la orden seleccionada a estado cancelada y la grabamos.
            EOrdenTrabajo ordenSeleccionada = OrdenesTrabajo.Get(m_ibItemSeleccionado.Numero, true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            ordenSeleccionada.Cancelada();

            OrdenesTrabajo.Save(ordenSeleccionada, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            MsgRuts.ShowMsg(this, String.Format("La orden de trabajo numero {0} fue cancelada.", m_ibItemSeleccionado.Numero));

            // Actualizamos la lista de ordenes.
            actualizarOrdenesEnPantalla();
        }

        private void gbCerrarOT_Click(object sender, EventArgs e)
        {
            if (noHayItemSeleccionado())
                return;

            if (m_ibItemSeleccionado.EstadoOrden != "EnProgreso")
            {
                MsgRuts.ShowMsg(this, "Una orden que no est� en progreso no puede ser cerrada.");
                return;
            }

            CierreOrdenes l_frmCierre = new CierreOrdenes(m_ibItemSeleccionado.Numero);
            l_frmCierre.ShowDialog(this);

            if (l_frmCierre.DialogResult == DialogResult.OK)
                actualizarOrdenesEnPantalla();
        }

        private void gbImprimirSeleccionado_Click(object sender, EventArgs e)
        {
            if (noHayItemSeleccionado())
                return;

            EOrdenTrabajo ordenAImprimir = Bll.OrdenesTrabajo.Get(m_ibItemSeleccionado.Numero, true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            imprimirConCrystalReport(ordenAImprimir);
        }
        private void gbImprimirTodos_Click(object sender, EventArgs e)
        {
            LEOrdenesTrabajo ordenesPendientes;

            if (cdcMoviles.SelectedStrCode.Trim() != "")
            {
                ordenesPendientes = Bll.OrdenesTrabajo.ObtenerOTsPorPatente(cdcMoviles.SelectedStrCode, m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;
            }
            else
            {
                ordenesPendientes = Bll.OrdenesTrabajo.getPendientes(m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;
            }

            ordenesPendientes.ToList().ForEach(ordenAImprimir => imprimirConCrystalReport(ordenAImprimir));
        }

        #endregion

        #region Metodos Privados

        private void CargarOrdenes(LEOrdenesTrabajo ordenesACargar)
        {
            xpPanelOrdenes.Controls.Clear();

            if (ordenesACargar.Count == 0)
                return;

            // Separamos el primer caso por cuestion de la location.
            EOrdenTrabajo primeraOrden = ordenesACargar.First();
            itemBarra primerItem = newItemFromOrden(primeraOrden);
            primerItem.FuiSeleccionado += unItem_FueSeleccionado;

            primerItem.Seleccionado = true;
            m_ibItemSeleccionado = primerItem;
            primerItem.Location = new Point(0, 0);
            xpPanelOrdenes.Controls.Add(primerItem);
            ordenesACargar.RemoveEntity(primerItem.Numero);

            // Recorremos el resto de la lista.
            foreach (EOrdenTrabajo orden in ordenesACargar)
            {
                agregarOrdenPendiente(orden);
            }
        }

        private itemBarra newItemFromOrden(EOrdenTrabajo orden)
        {
            return new itemBarra(orden.Nro, orden.Patente, orden.Fecapertura, orden.Ot_taller, orden.Estado.Trim());
        }

        private void agregarOrdenPendiente(EOrdenTrabajo orden)
        {
            itemBarra item = newItemFromOrden(orden);
            item.FuiSeleccionado += unItem_FueSeleccionado;
            Point posicion = new Point();

            // Entran 7 ordenes por cada row lateral.
            if (xpPanelOrdenes.Controls.Count % 7 != 0)
            {
                posicion.X = xpPanelOrdenes.Controls[xpPanelOrdenes.Controls.Count - 1].Location.X + 140;
                posicion.Y = xpPanelOrdenes.Controls[xpPanelOrdenes.Controls.Count - 1].Location.Y;
            }
            else
            {
                posicion.X = 0;
                posicion.Y = xpPanelOrdenes.Controls[xpPanelOrdenes.Controls.Count - 1].Location.Y + 135;
            }

            item.Location = posicion;
            xpPanelOrdenes.Controls.Add(item);
        }

        private void LlenarComboMoviles()
        {
            m_LEMoviles = Bll.Moviles.UpFull(true, m_smResult);
            cdcMoviles.FillFromStrLEntidad(m_LEMoviles, "mov_ecd_patente", "mov_des_des", "deleted");
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            cdcMoviles.AddStrCD("", "--TODOS--");
            cdcMoviles.SelectedStrCode = "";
        }

        private void unItem_FueSeleccionado(object sender, EventArgs e)
        {
            if(m_ibItemSeleccionado != null)
                m_ibItemSeleccionado.Seleccionado = false;

            m_ibItemSeleccionado = (itemBarra)sender;
        }

        private void xpPanelOrdenes_MouseClick(object sender, MouseEventArgs e)
        {
            if (m_ibItemSeleccionado != null)
                m_ibItemSeleccionado.Seleccionado = false;

            m_ibItemSeleccionado = null;
            fgGrillaItemsOT.Clear();
        }

        private bool noHayItemSeleccionado()
        {
            if (m_ibItemSeleccionado == null)
            {
                MsgRuts.ShowMsg(this, "No puede realizar esa accion porque no hay ninguna orden seleccionada.");
                return true;
            }
            else
                return false;
        }

        #endregion

        private void imprimirConCrystalReport(EOrdenTrabajo ordenAImprimir)
        {
            // Creo el reporte
            Bel.CrystalReports.OrdenDeTrabajo reporteOrdenesPendientes = new Bel.CrystalReports.OrdenDeTrabajo();

            // Creo un Arraylist para cargar la entidad
            ArrayList l_arFc = new ArrayList();

            // Cargo la entidad a la lista
            l_arFc.Add(ordenAImprimir);

            // Seteo el arraylist como DataSource del reporte
            reporteOrdenesPendientes.SetDataSource(l_arFc);

            // Seteamos los DataSource de los subreportes
            reporteOrdenesPendientes.Subreports["OTItems"].SetDataSource(ordenAImprimir.OTItems.GetAsArray());

            // Actualizo los datos en el reporte
            reporteOrdenesPendientes.Refresh();

            // Imprimo
            reporteOrdenesPendientes.PrintToPrinter(1, false, 0, 0);
            reporteOrdenesPendientes.Close();
            reporteOrdenesPendientes.Dispose();
        }

        private void gbRealizando_Click(object sender, EventArgs e)
        {
            if (noHayItemSeleccionado())
                return;

            EOrdenTrabajo ordenSeleccionada = Bll.OrdenesTrabajo.Get(m_ibItemSeleccionado.Numero, true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            if(ordenSeleccionada.Codtaller.Trim() == "")
            {
                MsgRuts.ShowMsg(this, "No se puede pasar a orden en progreso sin tener un taller asignado.");
                return;
            }

            Bll.Moviles.fOrdenRealizandose(m_ibItemSeleccionado.Numero, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            actualizarOrdenesEnPantalla();
        }

        private void gbInfo_Click(object sender, EventArgs e)
        {
            // TODO: hacer una ventana con imagenes explicando los estadios de las ordenes.
        }
    }
}
