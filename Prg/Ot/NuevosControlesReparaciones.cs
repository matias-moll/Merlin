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

namespace Rivn.Ot
{
    public partial class NuevosControlesReparaciones:DockContent
    {

        #region Miembros y Contructores
        // Variables Miembro

        private StatMsg m_smResult = new StatMsg("NuevosControlesReparaciones");
        private Bel.LEOTItems m_leOTItems;
        private Bel.LEReparaciones m_leReparaciones;
        private int m_intNumeroAgrupador;

        // Constructor Inicial
        public NuevosControlesReparaciones()
        {
            InitializeComponent();
            ((MainFrame)App.GetMainWindow()).AddContent(this);
            // Reseteamos el StatMsg
            m_smResult.UilReset("NuevosControlesReparaciones");
            
            // Seteamos como nueva la lista entidad OTItems
            m_leOTItems = Bel.LEOTItems.NewEmpty();
            // Nos traemos todas las reparaciones de la grilla a memoria
            m_leReparaciones = Bll.Tablas.RepUpFull(true, ref m_smResult) ;

            //seteamos el numero de agrupador como 1
            m_intNumeroAgrupador= 1;
        }
        
        #endregion

        #region Metodos Privados

        // LLena la combo de patente con todas las de la base .
        private void LLenarComboPatentesMoviles(CDCombo p_cdcCombo)
        {
            // reseteamos el statmsg
            m_smResult.UilReset("LLenarComboPatentesMoviles");
            // llenamos la combo con los moviles
            p_cdcCombo.FillFromStrLEntidad(Bll.Moviles.UpFull(true, ref m_smResult), "mov_ecd_patente", "mov_ecd_patente", "deleted");
            // chequeamos que haya salido todo bien
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            //seteamos en el null para que se vea fancy
            p_cdcCombo.SelectedIndex = -1;
        }

        // Nos retorna la reparacion de Codigo pasado por parametro
        private Bel.EReparacion obtenerReparacion(string p_sCodigoSelecionado)
        {
            return m_leReparaciones[p_sCodigoSelecionado];
        }

        // LLena una Entidad OrdenTrabajoITEM y nos la devuelve para poder aniadirla a nuestra lista entidad.
        private Bel.EOTItem LLenarOTItem(Bel.EReparacion p_eReparacion, int p_nroAgrupador, int p_nroItem,string p_sDescControl )
        {
            Bel.EOTItem l_entOTitem = Bel.EOTItem.NewEmpty();

            l_entOTitem.Nroot = 1;
            l_entOTitem.Nroagrupador = p_nroAgrupador;
            l_entOTitem.Nroitem = p_nroItem;
            l_entOTitem.Descategoria = p_eReparacion.Codcat;
            l_entOTitem.Desoperacion = p_eReparacion.Des;
            l_entOTitem.Destarea = p_eReparacion.Des;
            l_entOTitem.Comentario = teComentario.Text;
            l_entOTitem.Importe = deImporte.Decimal;

            return l_entOTitem;
        }

        #endregion

        #region Eventos de los Controles

        private void rbControles_CheckedChanged(object sender, EventArgs e)
        {
            //si no esta seleccionado volvemos.
            if (!rbControles.Checked)
                return;
            // nos aseguramos de que haya un movil seleccionado
            if (cdcPatente.SelectedIndex == -1)
            {
                MsgRuts.ShowMsg(this, "No hay ningun Movil seleccionado");
                return;
            }
            //cambiamos el nombre del ImgGroup
            igControlReparacion.GroupTitle = "Controles";
            // reseteamos al statmsg
            m_smResult.UilReset("rbControles_CheckedChanged");
            //llenamos la lista con los controles de la tabla
            cdlControlesReparaciones.FillFromStrLEntidad(Bll.Controles.UpFull(true, ref m_smResult), "ctl_cod_cod", "ctl_des_des", "deleted");
            // chequeamos que haya salido todo bien
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
        }

        private void rbReparaciones_CheckedChanged(object sender, EventArgs e)
           {
                // si no esta chequeado hacemos un return
               if (!rbReparaciones.Checked)
                   return;
                // nos aseguramos de que haya un movil seleccionado
                if (cdcPatente.SelectedIndex == -1)
                {
                    MsgRuts.ShowMsg(this, "No hay ningun Movil seleccionado");
                    return;
                }
                //cambiamos el nombre del ImgGroup
                igControlReparacion.GroupTitle = "Reparaciones";    
                // reseteamos al statmsg
                m_smResult.UilReset("rbControles_CheckedChanged");
                //llenamos la lista con los controles de la tabla
                cdlControlesReparaciones.FillFromStrLEntidad(Bll.Tablas.RepUpFull(true, ref m_smResult), "rep_cd6_cod", "rep_xde_des", "deleted");
                // chequeamos que haya salido todo bien
                if (MsgRuts.AnalizeError(this, m_smResult)) return;
            }
        
        private void NuevosControlesReparaciones_Load(object sender, EventArgs e)
        {
            // LLenamos Las patentes que hay en la tabla.
            LLenarComboPatentesMoviles(cdcPatente);
        }

        private void gbCancel_Click(object sender, EventArgs e)
        {
            // mostramos un mensaje si esta seguro de cerrar
            if (MsgRuts.ShowMsg(this, 
                "Si cierra la pantalla perdera todo lo hecho en ella", 
                MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            // si el dialog es OK cerramos.
            this.Close();
        }

        private void gbAgregar_Click(object sender, EventArgs e)
        {
            m_smResult.UilReset("gbAgregar_Click");

            if (rbControles.Checked)
            {
                Bel.LEControlesRepa l_leCodRep = Bll.Controles.CrepFGet(cdlControlesReparaciones.SelectedStrCode, true, ref m_smResult);
                //declaramos un contador para que numero en el agrupador
                int l_iContador = 1;
                //por cada una de las reparaciones del control, grabamos una entidad
                foreach (Bel.EControlRepa controRepa in l_leCodRep)
                {
                    Bel.EReparacion l_eRepaSelec = obtenerReparacion(cdlControlesReparaciones.SelectedStrCode);
                   
                    //llenamos la OTitem y lo agregamos a la lista entidad
                    m_leOTItems.AddEntity(LLenarOTItem(l_eRepaSelec, m_intNumeroAgrupador, l_iContador,)); //aca va la descripcion del control));
                    
                    //aumentamos el contador de items
                   l_iContador += 1;
                    
                }

                // LLenamos la grilla con lista entidad
                fgControlRepaSeleccionados.FillFromLEntidad(m_leOTItems); 
                //aumentamos en uno al Agrupador
                m_intNumeroAgrupador += 1;

                //desabilitamos el control seleccionado para que no lo pueda volver a usar
                // NoSe si hacerlo.
            }
            if (rbReparaciones.Checked)
            {
                Bel.EReparacion l_eRepaSelec = obtenerReparacion(cdlControlesReparaciones.SelectedStrCode);
                // en una reparacion siempre la descripcion de control es la misma que la descripcion de reparacion
                // en una reparacion el numero de item siempre es 1, (porque es unica)
                m_leOTItems.AddEntity(LLenarOTItem(l_eRepaSelec, m_intNumeroAgrupador, 1, l_eRepaSelec.Des));
                // LLenamos la grilla con lista entidad
                fgControlRepaSeleccionados.FillFromLEntidad(m_leOTItems);
                //aumentamos en uno al Agrupador
                m_intNumeroAgrupador += 1;
            }
        }

        private void gbAccept_Click(object sender, EventArgs e)
        {

        }

        #endregion

       





    }
}
