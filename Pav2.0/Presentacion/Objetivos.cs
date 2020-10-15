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
    public partial class Objetivos : Form
    {
        public Objetivos()
        {
            InitializeComponent();
        }


        private void Objetivos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
            //lbl_estado.Visible = false;
            chk_estado.Visible = false;
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_nombreCorto.Text != null && txt_nombreLargo.Text != null)
            {
                if (Logica.Objetivos.GuardarObjetivo(txt_nombreCorto.Text, txt_nombreLargo.Text) == false)
                {
                    MessageBox.Show("No se pudo guardar.");
                }
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios.");
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

            if (txt_nombreCorto.Text != "" && txt_nombreLargo.Text != "")
            {
                int id = Int32.Parse(txt_value.Text);
                if (Logica.Objetivos.ModificarObjetivo(id, txt_nombreCorto.Text, txt_nombreLargo.Text, chk_estado.Checked) == false)
                {
                    MessageBox.Show("No se pudo modificar.");
                }
                CargarGrilla();
                //limpiarcampos();
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios.");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (txt_nombreCorto.Text != "" && txt_nombreLargo.Text != "")
            {
                int id = Int32.Parse(txt_value.Text);
                if (Logica.Objetivos.EliminarObjetivo(id, chk_borrado.Checked) == false)
                {
                    MessageBox.Show("No se pudo eliminar.");
                }
                CargarGrilla();
                //limpiarcampos();
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios.");
            }
        }

        private void CargarGrilla()
        {
            //dgv_categorias.Rows.Clear();

            List<Objetivo> T = Logica.Objetivos.MostrarDataObjetivos(chk_todo.Checked);
            dgv_objetivos.DataSource = T;
            dgv_objetivos.Columns[0].Visible = false; //Oculta la columna id_objetivo
            //dgv_objetivos.Columns[3].Visible = false;
            dgv_objetivos.Columns[4].Visible = false;
            if (chk_todo.Checked)
            {
                dgv_objetivos.Columns[3].Visible = true;

            }

            txt_nombreCorto.Text = "";
            txt_nombreLargo.Text = "";


        }

        private void dgv_objetivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;


            Objetivo var1 = (Objetivo)dgv.CurrentRow.DataBoundItem;
            txt_nombreCorto.Text = var1.nombre_corto;
            txt_nombreLargo.Text = var1.nombre_largo;
            txt_value.Text = var1.id_objetivo.ToString();
            chk_estado.Checked = (bool)var1.borrado;
            btn_guardar.Enabled = false;
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;

        }

        private void chk_estado_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrilla();
            //lbl_estado.Visible = chk_todo.Checked;
            chk_estado.Visible = chk_todo.Checked;
        }

        private void chk_todo_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrilla();
            //lbl_estado.Visible = chk_todo.Checked;
            chk_estado.Visible = chk_todo.Checked;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
