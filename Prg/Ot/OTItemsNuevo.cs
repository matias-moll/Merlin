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
using Rivn.Bel;

namespace Rivn.Ot
{
    public partial class OTItemsNuevo:DockContent
    {

        // Variables Miembro

        private StatMsg m_smResult = new StatMsg();
        private Bel.LEOTItems m_leOTItems;
        private Bel.LEReparaciones m_leReparaciones;
        private int m_intNumeroAgrupador;
        private bool m_estadoMofidicar;
        private Bel.EOrdenTrabajo m_eOrdenAModificar;

        // Constructor Inicial
        public OTItemsNuevo()
        {
            InitializeComponent();
            ((MainFrame)App.GetMainWindow()).AddContent(this);

            estadoInicial();
        }

        // Constructor Inicial
        public OTItemsNuevo(int p_iNumeroOrdenTrabajo)
        {
            InitializeComponent();
            ((MainFrame)App.GetMainWindow()).AddContent(this);

            // Estado Mofidicar es Verdadero
            m_estadoMofidicar = true;

            // desabilitamos los controles necesarios para que el usuario no pueda interactuar con ellos 
            tgrpControlesYRep.Enabled = false;
            pnlOpciones.Enabled = false;
            gbAgregar.Enabled = false;
            cdcPatente.Enabled = false;

            // Seteamos la el numero de orden trabajo en el TV
            neOrdenTrabajo.Numero = p_iNumeroOrdenTrabajo;

            // Traemos la orden con su lista de items asociada
            m_eOrdenAModificar = Bll.OrdenesTrabajo.Get(p_iNumeroOrdenTrabajo, true, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Asignamos los items actuales que tiene la orden a nuestra lista 
            m_leOTItems = m_eOrdenAModificar.OTItems;
            // Configuramos los captions de la lista entidad OTItems
            ConfigurarCaptionsLEOitems(m_leOTItems);
            // LLenamos la Grilla con el metodo especial
            FillFromLEOTItemsConAnchoDeColumna(fgControlRepaSeleccionados, m_leOTItems);

            // Configuramos los captions de la lista entidad OTItems
            ConfigurarCaptionsLEOitems(m_leOTItems);

            // LLenamos Las patentes que hay en la tabla y Seteamos la patente seleccionada del movil a la asociada en la OT 
            cdcPatente.AddStrCD("patente",m_eOrdenAModificar.Patente,1);
            cdcPatente.SelectedStrCode = "patente";

            // por ultimo obtenemos el numero maximo de agrupador y le sumamos uno.
            m_intNumeroAgrupador = 1;
            foreach (Bel.EOTItem item in m_eOrdenAModificar.OTItems)
            {
                if (m_intNumeroAgrupador < item.Nroagrupador)
                    m_intNumeroAgrupador = item.Nroagrupador;
            }
            m_intNumeroAgrupador += 1; 
        }


        #region Metodos Privados

        // LLena la combo de patente con todas las de la base .
        private void LLenarComboPatentesMoviles()
        {
            // llenamos la combo con los moviles
            cdcPatente.FillFromStrLEntidad(Bll.Moviles.UpFull(true, ref m_smResult), EMovil.PatenteCmp, EMovil.PatenteCmp, "deleted");
            // chequeamos que haya salido todo bien
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            //seteamos en el null para que se vea fancy
            cdcPatente.SelectedIndex = -1;
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

            l_entOTitem.Nroot = neOrdenTrabajo.Numero;
            l_entOTitem.Nroagrupador = p_nroAgrupador;
            l_entOTitem.Nroitem = p_nroItem;
            l_entOTitem.Descategoria = p_eReparacion.Codcat;
            l_entOTitem.Desoperacion = p_sDescControl;
            l_entOTitem.Destarea = p_eReparacion.Des;
            l_entOTitem.Comentario = teComentario.Text;
            l_entOTitem.Importe = deImporte.Decimal;

            return l_entOTitem;
        }

        // Configura los captions de la ListaOTItems, para ver bien la grilla que muestra los items.
        private void ConfigurarCaptionsLEOitems(Bel.LEOTItems p_leOTItems)
        {
            p_leOTItems.ChangeCaption("oti_nro_nroot", "V1OrdenNN2");
            p_leOTItems.ChangeCaption("oti_nro_nroagrupador", "V1AgrupadorNN2");
            p_leOTItems.ChangeCaption("oti_nro_nroitem", "V1ItemNN2");
            p_leOTItems.ChangeCaption("oti_des_desoperacion", "V1ControlCN2");
            p_leOTItems.ChangeCaption("oti_des_destarea", "V1ReparacionCN2");
            p_leOTItems.ChangeCaption("oti_des_descategoria", "V1CategoriaCN2");
            p_leOTItems.ChangeCaption("oti_imp_importe", "V1Importe2N2");
            p_leOTItems.ChangeCaption("oti_ede_comentario","");
            p_leOTItems.ChangeCaption("instante","");
            p_leOTItems.ChangeCaption("deleted","");
            p_leOTItems.ChangeCaption("usuario","");
            p_leOTItems.ChangeCaption("version","");
        }

        // Crea la nueva entidad OrdenTrabajo que tendra asociados a todos los items
        private Bel.EOrdenTrabajo CrearOrdenDeTrabajo(Bel.LEOTItems p_leOTItems)
        {
            Bel.EOrdenTrabajo l_eOrdenNueva = Bel.EOrdenTrabajo.NewEmpty();
            l_eOrdenNueva.Nro = neOrdenTrabajo.Numero;
            l_eOrdenNueva.Patente = cdcPatente.Text;
            l_eOrdenNueva.Fecapertura = DateTime.Today;
            // en la fecha cierre ponemos nuestra fecha null para que indique no esta abierta
            l_eOrdenNueva.Feccierre = new DateTime(1900, 1, 1);
            // Le asignamos el operador que realizo la orden
            l_eOrdenNueva.Operador = App.Usuario.Usuario;

            // Le asignamos los items que nos vienen por parametro
            l_eOrdenNueva.OTItems = p_leOTItems;

            return l_eOrdenNueva;
        }

        // Habilita o Desabilita los botones quitar
        private void HabilitarBotonesQuitar(bool p_bool)
        {
            gbQuitarTodos.Enabled = p_bool;
            gbQuitarUltimo.Enabled = p_bool;
            gbQuitarSeleccionado.Enabled = p_bool;
        }

        // LLena una grilla con la ListaEntidad y Pone Tamanos de columnas para ajustar a pantalla
        private void FillFromLEOTItemsConAnchoDeColumna(FullGrid p_fullGrid, Bel.LEOTItems p_leOTItems)
        {
            p_fullGrid.FillFromLEntidad(p_leOTItems);
            p_fullGrid.ColWitdhs = "64;80;80;280;280;80;110;";
        }

        private void estadoInicial()
        {
            // Estado Modificar es FALSO
            m_estadoMofidicar = false;

            // desabilitamos los IG y los Botones Quitar para que no puedan usarlos si no selecciona nada
            tgrpOpciones.Enabled = false;
            tgrpControlesYRep.Enabled = false;
            HabilitarBotonesQuitar(false);

            
            // LLenamos Las patentes que hay en la tabla.
            LLenarComboPatentesMoviles();

            // seteamos el numero de OT
            neOrdenTrabajo.Numero = App.TaloGet("TaloOT", ref m_smResult).Valor;

            // Seteamos como nueva la lista entidad OTItems
            m_leOTItems = Bel.LEOTItems.NewEmpty();
            ConfigurarCaptionsLEOitems(m_leOTItems);

            // Nos traemos todas las reparaciones de la grilla a memoria 
            m_leReparaciones = Bll.Tablas.RepUpFull(true, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            //seteamos el numero de agrupador como 1
            m_intNumeroAgrupador = 1;
        }

        private void reiniciarForm()
        {
            limpiarControles();
            estadoInicial();
        }

        private void limpiarControles()
        {
            cdcPatente.Clear();
            fgControlRepaSeleccionados.Clear();
            limpiarPanelControlesYReparaciones();

        }

        private void limpiarPanelControlesYReparaciones()
        {
            teComentario.Text = "";
            deImporte.Decimal = 0;
            lstControlesReparaciones.Clear();
            rbReparaciones.Checked = false;
            rbControles.Checked = false;
        }

        #endregion

        #region Eventos de los Controles

        // llenamos la lista con los controles si se puede.
        private void rbControles_CheckedChanged(object sender, EventArgs e)
        {
            //si no esta seleccionado volvemos.
            if (!rbControles.Checked)
                return;
            // nos aseguramos de que haya un movil seleccionado
            if (cdcPatente.SelectedIndex == -1)
            {
                rbControles.Checked = false;
                MsgRuts.ShowMsg(this, "No hay ningun Movil seleccionado");
                return;
            }
            //cambiamos el nombre del ImgGroup y activamos las opciones
            tgrpControlesYRep.Title = "Controles";
            tgrpOpciones.Enabled = true;
            //llenamos la lista con los controles de la tabla
            lstControlesReparaciones.FillFromStrLEntidad(Bll.Controles.UpFull(true, ref m_smResult), "ctl_cod_cod", "ctl_des_des", "deleted");
            // chequeamos que haya salido todo bien
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            limpiarDatosAsociados();
        }

        // llenamos la lista con las reparacion si se puede
        private void rbReparaciones_CheckedChanged(object sender, EventArgs e)
        {
            // si no esta chequeado hacemos un return
            if (!rbReparaciones.Checked)
                return;
            // nos aseguramos de que haya un movil seleccionado
            if (cdcPatente.SelectedIndex == -1)
            {
                rbReparaciones.Checked = false;
                MsgRuts.ShowMsg(this, "No hay ningun Movil seleccionado");
                return;
            }

            //cambiamos el nombre del ImgGroup y activamos las opciones
            tgrpControlesYRep.Title = "Reparaciones";
            tgrpOpciones.Enabled = true;
            //llenamos la lista con los controles de la tabla
            lstControlesReparaciones.FillFromStrLEntidad(Bll.Tablas.RepUpFull(true, ref m_smResult), "rep_cd6_cod", "rep_xde_des", "deleted");
            // chequeamos que haya salido todo bien
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            limpiarDatosAsociados();
        }

        private void limpiarDatosAsociados()
        {
            teComentario.Text = "";
            deImporte.Decimal = 0;
        }

        // Cierra el formulario
        private void gbCancel_Click(object sender, EventArgs e)
        {
            if (m_leOTItems.Count != 0)
            {
                // mostramos un mensaje si esta seguro de cerrar
                if (MsgRuts.ShowMsg(this,
                    "Si cierra la pantalla perdera todo lo hecho en ella",
                    MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
                // si el dialog es OK cerramos.
            }
            this.Close();
        }

        // Agrega un control o una reparacion a nuestra listaEntidad de items
        private void gbAgregar_Click(object sender, EventArgs e)
        {
            if (rbControles.Checked)
            {
                // Obtenemos todas las reparaciones de el control seleccionado y el Control selecionado
                Bel.LEControlesRepa l_leControlReparaciones = Bll.Controles.CrepFGet(lstControlesReparaciones.SelectedStrCode, true, ref m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;

                Bel.EControl l_entControlSeleccionado = Bll.Controles.Get(lstControlesReparaciones.SelectedStrCode, true , ref m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;
                
                // Declaramos un contador para que numero en el agrupador
                int l_iContador = 1;
                
                // Por cada una de las reparaciones del control, llenamos una entidad
                foreach (Bel.EControlRepa controlRepa in l_leControlReparaciones)
                {
                    Bel.EReparacion l_eRepaSelec = obtenerReparacion(controlRepa.Codrep);
                    // LLenamos la OTitem y lo agregamos a la lista entidad
                    m_leOTItems.AddEntity(LLenarOTItem(l_eRepaSelec, m_intNumeroAgrupador, l_iContador,l_entControlSeleccionado.Des));
                    // Aumentamos el contador de items
                    l_iContador += 1;
                    
                }
                // Si la lista no esta vacia habilitamos los Botones Quitar
                if (m_leOTItems.Count != 0)
                    HabilitarBotonesQuitar(true);

                // LLenamos la grilla con lista entidad
                FillFromLEOTItemsConAnchoDeColumna(fgControlRepaSeleccionados, m_leOTItems); 
                //aumentamos en uno al Agrupador
                m_intNumeroAgrupador += 1;

                //desabilitamos el control seleccionado para que no lo pueda volver a usar
                // No Se si hacerlo. 
            }
            if (rbReparaciones.Checked)
            {
                Bel.EReparacion l_eRepaSelec = obtenerReparacion(lstControlesReparaciones.SelectedStrCode);
                // en una reparacion siempre la descripcion de control es la misma que la descripcion de reparacion
                // en una reparacion el numero de item siempre es 1, (porque es unica)
                m_leOTItems.AddEntity(LLenarOTItem(l_eRepaSelec, m_intNumeroAgrupador, 1, l_eRepaSelec.Des));

                // Si la lista no esta vacia habilitamos los Botones Quitar
                if (m_leOTItems.Count != 0)
                    HabilitarBotonesQuitar(true);

                // LLenamos la grilla con lista entidad
                FillFromLEOTItemsConAnchoDeColumna(fgControlRepaSeleccionados, m_leOTItems);
                //aumentamos en uno al Agrupador
                m_intNumeroAgrupador += 1;
            }

            limpiarPanelControlesYReparaciones();
        }



        // Graba la ListaEntidad de Items en la Base
        private void gbAccept_Click(object sender, EventArgs e)
        {
            // si la lista esta vacia no grabamos
            if(m_leOTItems.Count == 0)
            {
                MsgRuts.ShowMsg(this, "No se puede grabar en la base por que no hay nada en la lista para grabar");
                return;
            }
            // Procedemos al grabado
            if(!m_estadoMofidicar){
                // Graba OrdenNueva con sus items
                Bel.EOrdenTrabajo l_ordenAGrabar = CrearOrdenDeTrabajo(m_leOTItems);
                Bll.OrdenesTrabajo.Save(l_ordenAGrabar,ref m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;
                MsgRuts.ShowMsg(this, "La nueva orden fue agregada exitosamente");
            }
            else{
            // Graba Orden a Actualizar
                // primero asigna los nuevos items a la orden de trabajo
                m_eOrdenAModificar.OTItems = m_leOTItems;
                Bll.OrdenesTrabajo.Save(m_eOrdenAModificar,ref m_smResult);
                if (MsgRuts.AnalizeError(this, m_smResult)) return;
                MsgRuts.ShowMsg(this, "La orden fue modificada exitosamente");            
            }

            // Despueste grabado se cierra el formulario para poder seguir con el programa principal
            reiniciarForm();
        }

        // Borra el ultimo item agregado a la lista
        private void gbQuitarUltimo_Click(object sender, EventArgs e)
        {
            string l_Message = "Si realiza esta accion se borrara el ultimo item de la lista";
            // Si toca cancelar no borra nada
            if (MsgRuts.ShowMsg(this, l_Message, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            // Si le dio OK al dialog. 
            // creamos una lista nueva y encontramos los items que tienen el ultimo numeroAgrupador para borrarlos.
            Bel.LEOTItems l_itemsUltimos = Bel.LEOTItems.NewEmpty();
            
            foreach(Bel.EOTItem item in m_leOTItems){
                //si tiene el ultimo numero agrupador ingresado lo agregamos a los ultimos
                if (item.Nroagrupador == (m_intNumeroAgrupador - 1))
                    l_itemsUltimos.AddEntity(item);
            }

            // los borramos a todos los ultimos
            foreach(Bel.EOTItem item in l_itemsUltimos ){
                m_leOTItems.RemoveEntity(item.Nroot, item.Nroagrupador, item.Nroitem);
            }
             // LLenamos la grilla con lista entidad
                FillFromLEOTItemsConAnchoDeColumna(fgControlRepaSeleccionados, m_leOTItems);

            //restamos uno al contador de agrupadores
            m_intNumeroAgrupador = m_intNumeroAgrupador - 1;

            // Si la lista esta vacia deshabilitamos los Botones Quitar
            if (m_leOTItems.Count == 0)
                HabilitarBotonesQuitar(false);
        }

        // Borra TODOS los items de la lista
        private void gbQuitarTodos_Click(object sender, EventArgs e)
        {
            string l_Message = "Si realiza esta accion borrara todos los items agregados hasta el momento";
            // Si toca cancelar no borra nada
            if (MsgRuts.ShowMsg(this, l_Message, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            // Si le dio OK al dialog. entonces Vaciamos la lista
            m_leOTItems = Bel.LEOTItems.NewEmpty();
            //configuramos los captions
            ConfigurarCaptionsLEOitems(m_leOTItems);
            // LLenamos la grilla con lista entidad
            FillFromLEOTItemsConAnchoDeColumna(fgControlRepaSeleccionados, m_leOTItems);

            neSeleccionado.Numero = 0;
            // Le asignamos 1 al agrupador para que empiece de nuevo.
            m_intNumeroAgrupador = 1;

            // Si la lista esta vacia deshabilitamos los Botones Quitar
            if (m_leOTItems.Count == 0)
                HabilitarBotonesQuitar(false);

        }

        // Borra el item seleccionado de la grilla
        private void gbQuitarSeleccionado_Click(object sender, EventArgs e)
        {
            // chequeamos que algun items este seleccionado
            if (neSeleccionado.Numero == 0)
            {
                MsgRuts.ShowMsg(this, "no hay ningun item seleccionado");
                return;
            }

            string l_Message = "Si realiza esta accion se borrara el/los elementos seleccionado de la lista";
            // Si toca cancelar no borra nada
            if (MsgRuts.ShowMsg(this, l_Message, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            // Si le dio OK al dialog. 
            // creamos una lista nueva y encontramos los items que tienen el ultimo numeroAgrupador para borrarlos.
            Bel.LEOTItems l_itemsABorrar = Bel.LEOTItems.NewEmpty();

            foreach (Bel.EOTItem item in m_leOTItems)
            {
                //si tiene el ultimo numero agrupador ingresado lo agregamos a los ultimos
                if (item.Nroagrupador == (neSeleccionado.Numero))
                    l_itemsABorrar.AddEntity(item);
            }

            // los borramos a todos los ultimos
            foreach (Bel.EOTItem item in l_itemsABorrar)
            {
                m_leOTItems.RemoveEntity(item.Nroot, item.Nroagrupador, item.Nroitem);
            }

           // Bajamos en uno al los agrupadores para que sigan en orden
            // Primero tenemos que crear una lista entidad con los captions donde vamos a poner la lista mofidicada 
            Bel.LEOTItems l_LEOTActualizada = Bel.LEOTItems.NewEmpty();
            ConfigurarCaptionsLEOitems(l_LEOTActualizada);

            // Recorremos la lista y vamos llenando con las modificaciones
            foreach (Bel.EOTItem item in m_leOTItems)
            {
                if (item.Nroagrupador > neSeleccionado.Numero) item.Nroagrupador = item.Nroagrupador - 1;
                l_LEOTActualizada.AddEntity(item);
            }
            // y por ultimo Asignamos la list Nueva a la Miembro
            m_leOTItems = l_LEOTActualizada;

            //establecemos como numero seleccionado a 0, que representa NO SELECCIONADO
            neSeleccionado.Numero = 0;

            // LLenamos la grilla con lista entidad miembro
            FillFromLEOTItemsConAnchoDeColumna(fgControlRepaSeleccionados, m_leOTItems);

            //restamos uno al contador de agrupadores
            m_intNumeroAgrupador = m_intNumeroAgrupador - 1;

            // Si la lista esta vacia deshabilitamos los Botones Quitar
            if (m_leOTItems.Count == 0)
                HabilitarBotonesQuitar(false);
        }
        
        //cambiamos el seleccionado
        private void fgControlRepaSeleccionados_CurrentCellChanged(object sender, EventArgs e)
        {
            // nos fijamos en que fila estamos parados 
            int l_NumeroDeRow = fgControlRepaSeleccionados.CurrentRowIndex;      
            // le asignamos el numero de agrupador a esa fila
            neSeleccionado.Numero = m_leOTItems[l_NumeroDeRow].Nroagrupador;
            return;
        }

        // Habilitamos el IGControlRepa solo cuando hay una patente seleccionada
        private void cdcPatente_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(!m_estadoMofidicar)
            tgrpControlesYRep.Enabled = true;
        }

        #endregion

        private void gbAsignar_Click(object sender, EventArgs e)
        {

        }


    }
}
