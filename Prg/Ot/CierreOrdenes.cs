using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TNGS;
using TNGS.NetControls;
using TNGS.NetRoutines;
using TNGS.NetApp;
using WeifenLuo.WinFormsUI.Docking;
using Mrln.Bel;

namespace Mrln.Ot
{
    public partial class CierreOrdenes:Form
    {
        // Variables Miembro
        private StatMsg m_smResult = new StatMsg();
        private EOrdenTrabajo m_eOrdenACerrar = null;

        // Constructor Edit
        public CierreOrdenes(int p_iNumeroOrdenTrabajo)
        {
            InitializeComponent();

            m_eOrdenACerrar = Bll.OrdenesTrabajo.Get(p_iNumeroOrdenTrabajo, true, m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
        }

        private void CierreOrdenes_Load(object sender, EventArgs e)
        {
            teMovilPatente.Text = m_eOrdenACerrar.Patente;
            teTaller.Text = m_eOrdenACerrar.Ot_taller;
            neOrdenTrabajo.Numero = m_eOrdenACerrar.Nro;
            CargarItems();
        }

        #region Eventos de los Controles

        private void gbCheckAll_Click(object sender, EventArgs e)
        {
            CambiarCheckEnTodasLasFilas(true);
        }

        private void gbUncheckAll_Click(object sender, EventArgs e)
        {
            CambiarCheckEnTodasLasFilas(false);
        }

        private void fgItems_CurrentCellChanged(object sender, EventArgs e)
        {
            EOTItem itemSeleccionado = m_eOrdenACerrar.OTItems[fgItems.CurrentRowIndex];
            teComentarioCierre.Text = itemSeleccionado.Comentariocierre;
            deImporteCierre.Decimal = itemSeleccionado.Importecierre;
            tgrpItem.Enabled = true;
            deImporteCierre.Enabled = true;
            teComentarioCierre.Enabled = true;
            gbAceptarItem.Enabled = true;
        }

        private void gbAceptarItem_Click(object sender, EventArgs e)
        {
            // Actualizamos ambos campos en la entidad seleccionado y recargamos la UI.
            m_eOrdenACerrar.OTItems.InternalData[fgItems.CurrentRowIndex][EOTItem.ComentariocierreCmp] = teComentarioCierre.Text;
            m_eOrdenACerrar.OTItems.InternalData[fgItems.CurrentRowIndex][EOTItem.ImportecierreCmp] = deImporteCierre.Decimal;
            CargarItems();

            teComentarioCierre.Text = "";
            deImporteCierre.Decimal = 0;
            tgrpItem.Enabled = false;
        }

        private void gbPendiente_Click(object sender, EventArgs e)
        {
            CambiarEstadoEnItemsChequeados(EOTItem.Estados.Pendiente);
        }

        private void gbCancelado_Click(object sender, EventArgs e)
        {
            CambiarEstadoEnItemsChequeados(EOTItem.Estados.Cancelado);
        }

        private void gbRealizado_Click(object sender, EventArgs e)
        {
            CambiarEstadoEnItemsChequeados(EOTItem.Estados.Realizado);
        }

        private void gbCerrarOrden_Click(object sender, EventArgs e)
        {
            if (m_eOrdenACerrar.OTItems.Any(item => !item.tieneEstadoCargado))
            {
                MsgRuts.ShowMsg(this, "No se puede cerrar una orden de trabajo con items que no tengan un estado cargado.");
                return;
            }

            Bll.Moviles.fCerrarOrden(m_eOrdenACerrar, m_smResult);

            MsgRuts.ShowMsg(this, "La orden de trabajo fue cerrada exitosamente");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gbCancel_Click(object sender, EventArgs e)
        {
            // mostramos un mensaje si esta seguro de cerrar
            if (MsgRuts.ShowMsg(this,
                "Si cierra la pantalla perdera todo lo hecho en ella",
                MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region Metodos Privados

        private void CargarItems()
        {
            m_eOrdenACerrar.OTItems.ChangeCaption(EOTItem.NroagrupadorCmp, "");
            m_eOrdenACerrar.OTItems.ChangeCaption(EOTItem.NroitemCmp, "");
            m_eOrdenACerrar.OTItems.ChangeCaption(EOTItem.CodcategoriaCmp, "");
            m_eOrdenACerrar.OTItems.ChangeCaption(EOTItem.ComentarioCmp, "");
            m_eOrdenACerrar.OTItems.ChangeCaption("deleted", "");
            fgItems.FillFromLEntidad(m_eOrdenACerrar.OTItems);
        }

        private void CambiarEstadoEnItemsChequeados(EOTItem.Estados estado)
        {
            LEOTItems itemsSinModificar = m_eOrdenACerrar.OTItems;

            bool hayUnItemChequeado = false;

            // Recorremos todas las entidades para ver cuales estan chequeadas y les cambiamos su estado.
            for (int index = 0; index < fgItems.Count; index++)
            {
                if (fgItems.GetCheckState(index))
                {
                    m_eOrdenACerrar.OTItems.InternalData[index][EOTItem.EstadoCmp] = estado.ToString();

                    hayUnItemChequeado = true;
                }
            }

            if (!hayUnItemChequeado)
            {
                MsgRuts.ShowMsg(this, "No hay ningun item seleccionado para modificar su estado");
                return;
            }

            // Actualizamos la UI
            CargarItems();

        }

        private void CambiarCheckEnTodasLasFilas(bool nuevoValor)
        {
            for (int index = 0; index < fgItems.Count; index++)
            {
                fgItems.CheckRow(index, nuevoValor);
            }
        }

        #endregion
    }
}