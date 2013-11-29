using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TNGS.NetRoutines;
namespace ControlesCustom
{
    public partial class ItemDockeable : UserControl
    {
        
        public ItemDockeable()
        {
            InitializeComponent();
            pbEstadoMalo.Visible = false;

        }

        public enum Estados { Verde, Rojo }
        public void CambiarFoto(Estados estado)
        {
            if (estado == Estados.Verde)
            {
                pbEstadoBueno.Visible = true;
                pbEstadoMalo.Visible = false;
            }
            else
            {
                pbEstadoBueno.Visible = false;
                pbEstadoMalo.Visible = true;
            }
        }

        public Estados CambiarEstado{
            set{CambiarFoto(value);}
        }

        public int itemNumero {
            get { return Convert.ToInt32(Numero.Text);} 
            set {Numero.Text = value.ToString()} 
        }

        public DateTime itemFecha {
            get { return Convert.ToDateTime(Fecha.Text); }
            set { Fecha.Text = value.ToString(); } 
        }

        



    }
}
