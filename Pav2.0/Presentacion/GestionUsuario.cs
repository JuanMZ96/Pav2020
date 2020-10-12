using ClassLibrary1;
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
    public partial class GestionUsuario : Form
    {
        public GestionUsuario()
        {
            InitializeComponent();
        }

        private void GestionUsuario_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarCombo();
        }


        private void CargarGrilla()
        {

            List<Logica.CustomClass.UsuarioCustom> T = Logica.Usuarios.MostarDatosUsuarioCustom(chk_todo.Checked);
            dgv_usuarios.DataSource = T;
            
            foreach (DataGridViewColumn columns in dgv_usuarios.Columns)
            {
                if ((columns.Index < 2) && (columns.Index < 4))
                {
                    columns.Visible = false;
                }
            }
        }
            private void dgv_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                   DataGridView dgv = sender as DataGridView;
                   if (dgv == null)
                   return;
                  Logica.CustomClass.UsuarioCustom var1 = (Logica.CustomClass.UsuarioCustom)dgv.CurrentRow.DataBoundItem;
                  cmb_perfiles.SelectedValue = var1.id_perfil;
                  txt_name.Text = var1.usuario;
                  txt_password.Text = var1.passw;
                  txt_value.Text = var1.id_usuario.ToString();
                  txt_mail.Text = var1.mail;
                  chk_estado.Checked = (bool)var1.borrado;
            


            }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
                int id = Int32.Parse(txt_value.Text);
                if (!Logica.Usuarios.EliminarUsuario(id, chk_borrado.Checked))
                {
                    MessageBox.Show("No se pudo eliminar.");
                }
                CargarGrilla();
              //limpiarcampos();
        }

        private void chk_estado_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btn_modifcar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_value.Text);
            if (!Logica.Usuarios.ModificarUsuario((int)cmb_perfiles.SelectedValue ,id , chk_estado.Checked, txt_name.Text, txt_password.Text, txt_mail.Text))
            {
                MessageBox.Show("No se pudo eliminar.");
            }
            CargarGrilla();
        }
        private void CargarCombo()
        {

            System.Collections.IList T = Logica.Perfiles.MostrarCombo();
            cmb_perfiles.DataSource = T;
            cmb_perfiles.ValueMember = "Id_perfil";
            cmb_perfiles.DisplayMember = "Nombre";

        }

    }


}
