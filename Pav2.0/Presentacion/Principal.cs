using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav2.Presentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btn_Perfiles_Click(object sender, EventArgs e)
        {
           
            GestionPerfiles ventana1 = new GestionPerfiles();
            ventana1.ShowDialog();

        }

        private void btn_categorias_Click(object sender, EventArgs e)
        {
            Categorias ventana2 = new Categorias();
                ventana2.ShowDialog();

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
            Login ventana1 = new Login();            
            ventana1.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios ventana2 = new Usuarios();
            ventana2.ShowDialog();
        }
    }
}
