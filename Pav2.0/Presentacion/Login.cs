using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pav2.Logica;


namespace Pav2.Presentacion
{
    public partial class Login : Form
    {   
       
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txt_nameid.Text != String.Empty && txt_pwd.Text != String.Empty)
            {
                if (Logica.Usuarios.ValidarCredenciales(txt_nameid.Text, txt_pwd.Text))
                {
                    Principal ventanaprin = new Principal();
                    this.Hide();
                    ventanaprin.ShowDialog();
                    this.Show();


                }


            }
            else
            {
                MessageBox.Show("Complete los campos");
            }

        }
    }
    
}
