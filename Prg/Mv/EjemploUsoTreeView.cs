using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TNGS.NetRoutines;

namespace Rivn.Mv
{
    public partial class EjemploUsoTreeView : Form
    {
        public EjemploUsoTreeView()
        {
            InitializeComponent();
        }

        private void EjemploUsoTreeView_Load(object sender, EventArgs e)
        {
            // La lista entidades de moviles la tenes que recuperar un SP especial que tenes que armar, para poder tirarsela
            // a un tree. No podes usar el upFull comun.
            /*
             * Aca te dejo una idea de como deberia ser el codigo para el SP que tenes que armar. Fijate bien los nombres
             * de los campos y t0do eso, dsps vemos bien el tema de las imagenes y les explico para que sirve y como se usa.
             * 
             * select mvl_cod_cod as Codigo, 
	                  mvl_des_des as Descripcion, 
	                  2 as Nivel, 
	                  2 as Orden, 
	                  1 as Imagen, 
	                  2 as Niveles 
                 from TNGS_Rivn..Moviles
             */ 
            // Con ese SP hecho llenas esta listaEntidad a partir de un metodo en la Bll que llame al metodo
            // que te expone ese SP y dsps llame al metodo fagregarRoot que es un metodo que te deje en la Bll de moviles.
            ListaEntidades estaSeriaLaListaDeMoviles = new ListaEntidades(new DataTable());
            // Con la LE ya armada, simplemente se llena el tree como con las grillas.
            ftrEjemplo.FillFromIntLEntidad(estaSeriaLaListaDeMoviles, "Codigo", "Descripcion", 2, "Nivel", "Imagen", "Imagen");
            ftrEjemplo.ExpandAll();



            // Con esto se limpia el tree si llegaras a necesitarlo
            ftrEjemplo.Nodes.Clear();
        }

        private void ftrEjemplo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Este evento se dispara cada vez que cambia la seleccion de un item del tree.
            // Esto te devuelve el nodo elegido como CodDesItem, ahi tenes el codigo para recuperar el movil y cargar los datos de al lado.
            CodDesItems bleh = ftrEjemplo.SelectedNodeAsCDI;
        }
    }
}
