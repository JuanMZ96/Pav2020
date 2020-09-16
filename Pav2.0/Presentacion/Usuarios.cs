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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int id = (int)cmb_perfiles.SelectedValue;
            Logica.Usuarios.CrearUsuarios(id,txt_nombre.Text, txt_pw.Text,txt_mail.Text);
        }

        private void CargarCombo()
        {

            System.Collections.IList T = Logica.Usuarios.MostrarCombo();
            cmb_perfiles.DataSource = T;
            cmb_perfiles.ValueMember = "id";
            cmb_perfiles.DisplayMember = "Nombre";

        }
    }
        
}
