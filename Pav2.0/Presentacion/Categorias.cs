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
            btn_borrar.Enabled = false;
            btn_modificar.Enabled = false;
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text != null && txt_descripcion.Text != null)
                {
                    if (Logica.Categorias.GuardarCategoria(txt_name.Text, txt_descripcion.Text) == false)
                    {
                        MessageBox.Show("No se pudo guardar.");
                    }
                    else { MessageBox.Show("Se creó correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Los campos no pueden estar vacios.");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: "+ x);
            }
        }

        private void txt_value_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text != "" && txt_descripcion.Text != "")
                {
                    int id = Int32.Parse(txt_value.Text);
                    if (Logica.Categorias.ModificarCategoria(id, txt_name.Text, txt_descripcion.Text) == false)
                    {
                        MessageBox.Show("No se pudo modificar.");
                    }
                    else { MessageBox.Show("Se modificó correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    CargarGrilla();
                    limpiarcampos();
                }
                else
                {
                    MessageBox.Show("Los campos no pueden estar vacios.");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x);
            }
            
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txt_name.Text != "" && txt_descripcion.Text != "")
                {
                    DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar ? ", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        int id = Int32.Parse(txt_value.Text);
                        if (Logica.Categorias.EliminarCategoria(id, chk_borrado.Checked) == false)
                        {
                            MessageBox.Show("No se pudo eliminar.");
                        }
                        else { MessageBox.Show("Se eliminó correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                    
                    CargarGrilla();
                    limpiarcampos();
                }
                else
                {
                    MessageBox.Show("Los campos no pueden estar vacios.","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv == null)
                    return;

                Categoria var1 = (Categoria)dgv.CurrentRow.DataBoundItem;
                txt_name.Text = var1.nombre;
                txt_descripcion.Text = var1.descripcion;
                txt_value.Text = var1.id_categoria.ToString();
                //chk_estado.Checked = (bool)var1.borrado;
                btn_guardar.Enabled = false;
                btn_borrar.Enabled = true;
                btn_modificar.Enabled = true;
                if (var1.borrado == true) { btn_Habilitar.Visible = true; btn_modificar.Enabled = false; }
                else { btn_Habilitar.Visible = false; btn_modificar.Enabled = true; }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: "+ x);
            }
        }


        private void CargarGrilla()
        {
            //dgv_categorias.Rows.Clear();
            try
            {
                List<Categoria> T = Logica.Categorias.MostrarDataCategorias(chk_todo.Checked);
                dgv_categorias.DataSource = T;
                dgv_categorias.Columns[0].Visible = false;
                dgv_categorias.Columns[3].Visible = false;
                dgv_categorias.Columns[4].Visible = false;
                //dgv_categorias.Columns[5].Visible = false;
                if (chk_todo.Checked)
                {
                    dgv_categorias.Columns[3].Visible = true;
                }
                btn_Habilitar.Visible = false;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: "+ x);
            }
            txt_name.Text = "";
            txt_descripcion.Text = "";
        }

        private void lbl_x_Click(object sender, EventArgs e)
        {
            btn_guardar.Enabled = true;
            btn_modificar.Enabled = false;
            btn_borrar.Enabled = false;
            limpiarcampos();

        }

        private void chk_estado_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrilla();
            
        }
        private void limpiarcampos()
        {
            txt_descripcion.Clear();
            txt_name.Clear();
            txt_value.Clear();
            btn_Habilitar.Visible = false;
        }

        private void btn_Habilitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text != "" && txt_descripcion.Text != "")
                {
                    int id = Int32.Parse(txt_value.Text);
                    bool borrado = false;
                    if (Logica.Categorias.HabilitarCategoria(id, borrado).isSuccess == false)
                    {
                        MessageBox.Show("No se pudo habilitar.");
                    }
                    else { MessageBox.Show("Categoria habilitada."); }
                    limpiarcampos();
                    CargarGrilla();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x);
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_guardar_MouseHover(object sender, EventArgs e)
        {
            lbl_guardar.Visible = true;
        }

        private void btn_guardar_MouseLeave(object sender, EventArgs e)
        {
            lbl_guardar.Visible = false;
        }

        private void btn_modificar_MouseHover(object sender, EventArgs e)
        {
            lbl_modificar.Visible = true;
        }

        private void btn_modificar_MouseLeave(object sender, EventArgs e)
        {
            lbl_modificar.Visible = false;
        }

        private void btn_borrar_MouseHover(object sender, EventArgs e)
        {
            lbl_eliminar.Visible = true;
        }

        private void btn_borrar_MouseLeave(object sender, EventArgs e)
        {
            lbl_eliminar.Visible = false;
        }

        private void btn_Habilitar_MouseHover(object sender, EventArgs e)
        {
            lbl_habilitar.Visible = true;
        }

        private void btn_Habilitar_MouseLeave(object sender, EventArgs e)
        {
            lbl_habilitar.Visible = false;
        }
    }   

}

            