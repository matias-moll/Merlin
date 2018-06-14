using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace ControlesCustom
{
    public partial class itemBarra : UserControl
    {

        #region Variables Miembro y Constructores
        // fecha inicial que muestra el control (Cumpleanios de Juanchi :D)
        DateTime inicialDate = new DateTime(1993, 1, 29);
        // enumerado de tipos de estado
        public enum Estados { Verde, Rojo }

         public itemBarra(){
           
            InitializeComponent();
            // Empieza siendo visible el estado VERDE
            pbRojo.Visible = false;
            // le asignamos la fecha inicial al lbl
            lblFecha.Text = inicialDate.Day.ToString() + "/" + inicialDate.Month.ToString() + "/" + inicialDate.Year.ToString();
        }

        public itemBarra(int nro, string titulo, DateTime fecha, string descripcion): this()
        {
            this.Numero = nro;
            this.Titulo = titulo;
            this.Fecha = fecha;
            this.Descripcion = descripcion;
        }

        #endregion

        #region Propiedades del Control
        
        // propiedad par cambiar el estado
        [Browsable(true)]
        public Estados CambiarEstado{
            set{CambiarFoto(value);}
            get
            {
                if (pbRojo.Visible)
                    return Estados.Rojo;
                else
                    return Estados.Verde;
            }
        }

        // cambia o devuelve el numero de item
        public int Numero {
            get { return Convert.ToInt32(lblNumero.Text);}
            set { lblNumero.Text = value.ToString(); } 
        }

        [Browsable(true)]
        // cambia o devuelve la fecha
        public DateTime Fecha {
            get {  return TNGS.NetRoutines.DateTimeRuts.MakeDate(lblFecha.Text).Date; }
            set { lblFecha.Text = value.Day.ToString() +"/" +value.Month.ToString() + "/" +value.Year.ToString(); }
        }

        // cambia o devuelve el titulo
        public string Titulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }


        // cambia o devuelve el titulo
        public string Descripcion
        {
            get { return fllDescripcion.Text; }
            set { fllDescripcion.Text = value; }
        }
        #endregion

        #region Metodos Privados del control

        //cambia la foto del circulo de estado 
        private void CambiarFoto(Estados estado)
        {

            if (estado == Estados.Verde)
            {
                pbVerde.Visible = true;
                pbRojo.Visible = false;
            }
            else
            {
                pbVerde.Visible = false;
                pbRojo.Visible = true;
            }
        }
        #endregion

        #region Eventos del Control


        #endregion

    }
}
