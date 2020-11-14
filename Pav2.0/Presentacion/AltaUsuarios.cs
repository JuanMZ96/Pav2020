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
    public partial class AltaUsuarios : Form
    {
        public AltaUsuarios()
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


        private void CargarCombo()
        {

            System.Collections.IList T = Logica.Perfiles.MostrarCombo();
            cmb_perfiles.DataSource = T;
            cmb_perfiles.ValueMember = "id_perfil";
            cmb_perfiles.DisplayMember = "nombre";

        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            int id = (int)cmb_perfiles.SelectedValue;
            ReturnValue validador = Usuarios.CrearUsuarios(id, txt_nombre.Text.Replace(" ",""), txt_pw.Text, txt_mail.Text);
            if (validador.isSuccess) MessageBox.Show(validador.ErrorMessage);
            else { MessageBox.Show(validador.ErrorMessage); }
        }
    }
        
}
