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
            
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Logica.Objetivos.GuardarObjetivo(txt_nombreCorto.Text, txt_nombreLargo.Text) == false)
                {
                    MessageBox.Show("Los campos no pueden estar vacios o el objetivo ya existe.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { MessageBox.Show("Se creó correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                CargarGrilla();
            }
            catch (Exception x){ MessageBox.Show("Error: "+ x); }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombreCorto.Text != "" && txt_nombreLargo.Text != "")
                {
                    int id = Int32.Parse(txt_value.Text);
                    if (Logica.Objetivos.ModificarObjetivo(id, txt_nombreCorto.Text, txt_nombreLargo.Text) == false)
                    {
                        MessageBox.Show("No se pudo modificar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else { MessageBox.Show("Se modificó correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                    CargarGrilla();
                    limpiarcampos();
                }
                else
                {
                    MessageBox.Show("Los campos no pueden estar vacios.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception x) { MessageBox.Show("Error: " + x); }
            
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombreCorto.Text != "" && txt_nombreLargo.Text != "")
                {
                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar? ", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        int id = Int32.Parse(txt_value.Text);
                        if (Logica.Objetivos.EliminarObjetivo(id, chk_borrado.Checked) == false)
                        {
                            MessageBox.Show("No se pudo eliminar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else { MessageBox.Show("Se eliminó correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                    }

                    CargarGrilla();
                    limpiarcampos();
                }
                else
                {
                    MessageBox.Show("Los campos no pueden estar vacios.");
                }
            }
            catch (Exception x) { MessageBox.Show("Error: " + x); }
            
        }

        private void CargarGrilla()
        {
            try
            {
                List<Objetivo> T = Logica.Objetivos.MostrarDataObjetivos(chk_todo.Checked);
                datagridview.DataSource = T;
                datagridview.Columns[0].Visible = false; //Oculta la columna id_objetivo
                datagridview.Columns[3].Visible = false;
                datagridview.Columns[4].Visible = false;
                if (chk_todo.Checked)
                {
                    datagridview.Columns[3].Visible = true;
                }
            }
            catch (Exception x) { MessageBox.Show("Error: " + x); }
            
            txt_nombreCorto.Text = "";
            txt_nombreLargo.Text = "";
        }

        private void dgv_objetivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv == null)
                    return;

                Objetivo var1 = (Objetivo)dgv.CurrentRow.DataBoundItem;
                txt_nombreCorto.Text = var1.nombre_corto;
                txt_nombreLargo.Text = var1.nombre_largo;
                txt_value.Text = var1.id_objetivo.ToString();
                btn_guardar.Enabled = false;
                btn_Eliminar.Enabled = true;
                btn_Modificar.Enabled = true;
                if (var1.borrado == true) { btn_habilitar.Visible = true; btn_Modificar.Enabled = false; }
                else { btn_habilitar.Visible = false; btn_Modificar.Enabled = true; }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: "+ x);
            }
        }

        //private void chk_estado_CheckedChanged(object sender, EventArgs e)
        //{
        //    //CargarGrilla();
            
        //}

        private void chk_todo_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrilla();
            
        }


        private void limpiarcampos()
        {
            txt_nombreCorto.Clear();
            txt_nombreLargo.Clear();
            txt_value.Clear();
            //chk_estado.Checked = false;
            btn_habilitar.Visible = false;
        }


        private void lbl_equis_Click(object sender, EventArgs e)
        {
            btn_guardar.Enabled = true;
            btn_Modificar.Enabled = false;
            btn_Eliminar.Enabled = false;
            limpiarcampos();

        }

        private void btn_guardar_MouseHover(object sender, EventArgs e)
        {
            lbl_guardar.Visible = true;
        }

        private void btn_guardar_MouseLeave(object sender, EventArgs e)
        {
            lbl_guardar.Visible = false;
        }

        private void btn_Modificar_MouseHover(object sender, EventArgs e)
        {
            lbl_modificar.Visible = true;
        }

        private void btn_Modificar_MouseLeave(object sender, EventArgs e)
        {
            lbl_modificar.Visible = false;
        }

        private void btn_Eliminar_MouseHover(object sender, EventArgs e)
        {
            lbl_eliminar.Visible = true;
        }

        private void btn_Eliminar_MouseLeave(object sender, EventArgs e)
        {
            lbl_eliminar.Visible = false;
        }

        private void btn_habilitar_MouseHover(object sender, EventArgs e)
        {
            lbl_habilitar.Visible = true;
        }

        private void btn_habilitar_MouseLeave(object sender, EventArgs e)
        {
            lbl_habilitar.Visible = false;
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombreCorto.Text != "" && txt_nombreLargo.Text != "")
                {
                    int id = Int32.Parse(txt_value.Text);
                    bool borrado = false;
                    if (Logica.Objetivos.habilitarObjetivo(id, borrado).isSuccess == false)
                    {
                        MessageBox.Show("No se pudo habilitar.");
                    }
                    else { MessageBox.Show("Objetivo habilitada."); }
                    limpiarcampos();
                    CargarGrilla();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x);
            }
        }
    } 
}



