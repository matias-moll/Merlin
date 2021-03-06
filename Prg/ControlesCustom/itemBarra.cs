﻿using System;
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
        public event EventHandler FuiSeleccionado;

        #region Variables Miembro y Constructores
        // fecha inicial que muestra el control (Cumpleanios de Juanchi :D)
        DateTime inicialDate = new DateTime(1993, 1, 29);

        bool estoySeleccionado = false;

        // enumerado de tipos de estado
        public enum Estados { Verde, Rojo, Amarillo}

         public itemBarra(){
           
            InitializeComponent();

            // le asignamos la fecha inicial al lbl
            lblFecha.Text = inicialDate.Day.ToString() + "/" + inicialDate.Month.ToString() + "/" + inicialDate.Year.ToString();
        }

        public itemBarra(int nro, string titulo, DateTime fecha, string taller, string estadoOrden) : this()
        {
            this.Numero = nro;
            this.Titulo = titulo;
            this.Fecha = fecha;
            this.EstadoOrden = estadoOrden;



            this.Taller = taller;
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
                else if (pbVerde.Visible)
                    return Estados.Verde;
                else
                    return Estados.Amarillo;
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
        public string Taller
        {
            get { return fllDescripcion.Text; }
            set
            {
                // Si esta en realizacion es amarillo, sino miramos si tiene taller o no.
                if (EstadoOrden == "EnProgreso")
                    this.CambiarFoto(Estados.Amarillo);
                else if (value.Trim() == "")
                    this.CambiarFoto(Estados.Rojo);
                else
                    this.CambiarFoto(Estados.Verde);

                fllDescripcion.Text = value;
            }
        }

        public string EstadoOrden { get; private set; }
        #endregion

        #region Metodos Privados del control

        //cambia la foto del circulo de estado 
        private void CambiarFoto(Estados estado)
        {

            if (estado == Estados.Verde)
            {
                pbVerde.Visible = true;
                pbRojo.Visible = false;
                pbAmarillo.Visible = false;
            }
            else if (estado == Estados.Rojo)
            {
                pbVerde.Visible = false;
                pbRojo.Visible = true;
                pbAmarillo.Visible = false;
            }
            else
            {
                pbVerde.Visible = false;
                pbRojo.Visible = false;
                pbAmarillo.Visible = true;
            }
        }
        #endregion


        public bool Seleccionado
        {
            get { return estoySeleccionado; }
            set
            {
                if (value)
                    this.BorderStyle = BorderStyle.FixedSingle;
                else
                    this.BorderStyle = BorderStyle.None;

                estoySeleccionado = value;
            }
        }

        public bool EsEditable
        {
            // Si se muestra cualquier boton que no sea el verde es porque la orden no esta lista para ser cerrada.
            get { return !pbVerde.Visible; }
        }

        private void itemBarra_Click(object sender, EventArgs e)
        {
            this.Seleccionado = true;

            // Manera compacta de chequear que alguien este colgado del evento y llamarlo.
            FuiSeleccionado?.Invoke(this, null);
        }
    }
}
