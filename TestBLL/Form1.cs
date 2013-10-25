using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TNGS.NetRoutines;
using Rivn.Bll;


namespace TestBLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Rivn.Bel.ECategoria l_ECCat = Rivn.Bel.ECategoria.NewEmpty();
           l_ECCat.Cod = "123";
           l_ECCat.Des = "Categoría fachera";
           StatMsg l_stC = new StatMsg("hola");
           Rivn.Bll.Tablas.CatSave(l_ECCat, ref l_stC);
           if (l_stC.NOk)
               MessageBox.Show(l_stC.Msg);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StatMsg l_smStatMsg = new StatMsg("Prueba");
            string[] l_saArray = new string[10];
            for (int i = 0; i <= 9; i++)
            {
               l_saArray[i] = "Este es el item " + i.ToString();
            }
            Rivn.Bll.Tablas.fAddArray(l_saArray, ref l_smStatMsg);           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
