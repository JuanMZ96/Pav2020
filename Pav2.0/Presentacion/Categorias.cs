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
using System.Collections;
using ClassLibrary1;

namespace Pav2.Presentacion
{
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != null && txt_descripcion.Text != null)
            {
                if (Logica.Categorias.GuardarCategoria(txt_name.Text, txt_descripcion.Text) == false)
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

        private void txt_value_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_value.Text);
            if (txt_name.Text != null && txt_descripcion.Text != null)
            {
                if (Logica.Categorias.ModificarCategoria(id, txt_name.Text, txt_descripcion.Text) == false)
                {
                    MessageBox.Show("No se pudo modificar.");
                }
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios.");
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_value.Text);
            if (txt_name.Text != null && txt_descripcion.Text != null)
            {
                if (Logica.Categorias.EliminarCategoria(id) == false)
                {
                    MessageBox.Show("No se pudo eliminar.");
                }
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            
            
                Categoria var1 = (Categoria)dgv.CurrentRow.DataBoundItem;
                txt_name.Text = var1.nombre;
                txt_descripcion.Text = var1.descripcion;
                txt_value.Text = var1.id_categoria.ToString();
            
        }


        private void CargarGrilla()
        {
            //dgv_categorias.Rows.Clear();

            List<Categoria> T = Logica.Categorias.MostrarDgv();
            dgv_categorias.DataSource = T;
            dgv_categorias.Columns[0].Visible = false;
            dgv_categorias.Columns[3].Visible = false;
            dgv_categorias.Columns[4].Visible = false;
            dgv_categorias.Columns[5].Visible = false;


            txt_name.Text = "";
            txt_descripcion.Text = "";
           

        }

    }
}
