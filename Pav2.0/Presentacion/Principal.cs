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
            AltaUsuarios ventana2 = new AltaUsuarios();
            ventana2.ShowDialog();
        }

        private void Principal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((btn_Perfiles.Focused)||(btn_categorias.Focused)||(btn_usuarios.Focused)) 
            {
                if (e.KeyChar == Convert.ToChar(Keys.Escape))
                {
                    Environment.Exit(0);
                }
            }
            
        }
    }
}
