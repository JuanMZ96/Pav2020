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
            MostrarUsuarios();
        }


        private void MostrarUsuarios()
        {

            List<Usuario> T = Logica.Usuarios.MostrarDataUsuarios(chk_estado.Checked);
            dgv_usuarios.DataSource = T;

            foreach (DataGridViewColumn columns in dgv_usuarios.Columns)
            {
                if (columns.Index > 5)
                {
                    columns.Visible = false;
                }




                //}
                //foreach (DataGridViewRow row in dgv_usuarios.Rows) 
                //{
                //   Usuario user1 =(Usuario)row.DataBoundItem;

                //    row.Cells[1].Value = user1.Perfile.nombre;


                //}
                //dgv_categorias.Columns[0].Visible = false;
                //dgv_categorias.Columns[3].Visible = false;
                //dgv_categorias.Columns[4].Visible = false;
                //dgv_categorias.Columns[5].Visible = false;


                //txt_name.Text = "";
                //txt_descripcion.Text = "";


            }
        }
            private void dgv_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            Usuario var1 = (Usuario)dgv.CurrentRow.DataBoundItem;
            txt_name.Text = var1.usuario1;
            txt_password.Text = var1.password;
            txt_idUsuario.Text = var1.id_usuario.ToString();
            txt_mail.Text = var1.email;
            txt_estado.Text = var1.borrado.ToString();


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }
    }


}
