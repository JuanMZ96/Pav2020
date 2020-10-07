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
        bool Cerrar = true;
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
                    Cerrar = false;
                    Principal ventanaprin = new Principal();                   
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Complete los campos","Alerta", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( Cerrar == true)
            {
                Environment.Exit(0);
            }
        }

        private void txt_pwd_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnIngresar_Click(sender,e);
            }
            if(e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Login_FormClosing(sender, null);
            }
        }
    }
    
}
