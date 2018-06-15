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

            LEOrdenesTrabajo ordenesPendientes = Bll.OrdenesTrabajo.getPendientes(ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            CargarOrdenes(ordenesPendientes);
        }

        private void CargarOrdenes(LEOrdenesTrabajo ordenesACargar)
        {
            xpPanelOrdenes.Controls.Clear();

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
            return new itemBarra(orden.Nro, orden.Patente, orden.Fecapertura, orden.Ot_taller);
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
            m_LEMoviles = Bll.Moviles.UpFull(true, ref m_smResult);
            cdcMoviles.FillFromStrLEntidad(m_LEMoviles, "mov_ecd_patente", "mov_des_des", "deleted");
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

        }

        private void gbFiltrar_Click(object sender, EventArgs e)
        {
            if (!gbFiltrar.Checked)
            {
                LEOrdenesTrabajo ordenesPorMovil = Bll.OrdenesTrabajo.ObtenerOTsPorPatente(cdcMoviles.SelectedStrCode, ref m_smResult);
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
                LEOrdenesTrabajo ordenesPendientes = Bll.OrdenesTrabajo.getPendientes(ref m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;
                CargarOrdenes(ordenesPendientes);
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

            if(!m_ibItemSeleccionado.EsEditable)
            {
                MsgRuts.ShowMsg(this, "Una orden completa y con taller no puede ser editada");
                return;
            }

            AltaOrdenes l_frmAltaOrdenes = new AltaOrdenes(m_ibItemSeleccionado.Numero);
            l_frmAltaOrdenes.ShowDialog(this);

            m_ibItemSeleccionado.Taller = l_frmAltaOrdenes.OrdenModificada.Ot_taller;
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

        private void gbVerItems_Click(object sender, EventArgs e)
        {
            if (noHayItemSeleccionado())
                return;

            LEOTItems itemsOrdenSeleccionada = OrdenesTrabajo.OtitFGet(m_ibItemSeleccionado.Numero, true, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            itemsOrdenSeleccionada.ChangeCaption(EOTItem.NroagrupadorCmp, "");
            itemsOrdenSeleccionada.ChangeCaption(EOTItem.NroitemCmp, "");
            itemsOrdenSeleccionada.ChangeCaption("deleted", "");

            fgGrillaItemsOT.FillFromLEntidad(itemsOrdenSeleccionada);
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

        private void gbCancelar_Click(object sender, EventArgs e)
        {
            if (noHayItemSeleccionado())
                return;

            // Pasamos la orden seleccionada a estado cancelada y la grabamos.
            EOrdenTrabajo ordenSeleccionada = OrdenesTrabajo.Get(m_ibItemSeleccionado.Numero, true, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            ordenSeleccionada.Cancelada();

            OrdenesTrabajo.Save(ordenSeleccionada, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            MsgRuts.ShowMsg(this, String.Format("La orden de trabajo numero {0} fue cancelada.", m_ibItemSeleccionado.Numero));

            // Actualizamos la lista de ordenes.
            LEOrdenesTrabajo ordenesPendientes = Bll.OrdenesTrabajo.getPendientes(ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            CargarOrdenes(ordenesPendientes);
        }
    }
}
