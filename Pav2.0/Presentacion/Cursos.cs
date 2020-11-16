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
using static Pav2.Logica.CustomClass;

namespace Pav2.Presentacion
{
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }

        

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                ReturnValue valido = Logica.Cursos.GuardarCursos(txt_name.Text, txt_descripcion.Text, (int)cmb_categoria.SelectedValue, dtp_datatime.Value);
                if (valido.isSuccess) { MessageBox.Show("Se creó correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); CargarGrilla(); }
                else { MessageBox.Show(valido.ErrorMessage, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: "+ x);
            }
            
        }

        private void btn_modificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txt_value.Text);
                ReturnValue valido = Logica.Cursos.ModificarCursos(id, txt_name.Text, txt_descripcion.Text, (int)cmb_categoria.SelectedValue, dtp_datatime.Value);
                if (valido.isSuccess) { MessageBox.Show("Se modificó correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); CargarGrilla(); }
                else { MessageBox.Show(valido.ErrorMessage, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x);
            }
        }

        private void btn_borrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar? ", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int id = Int32.Parse(txt_value.Text);
                    ReturnValue valido = Logica.Cursos.EliminarCursos(id, chk_borrado.Checked);
                    if (valido.isSuccess) { MessageBox.Show("Se eliminó correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); CargarGrilla(); }
                    else { MessageBox.Show(valido.ErrorMessage, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                    
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x);
            }
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarGrilla();

        }

        private void CargarCombo()
        {
            System.Collections.IList t = Logica.Categorias.CargarCombo();
            cmb_categoria.DataSource = t;
            cmb_categoria.ValueMember = "id_categoria";
            cmb_categoria.DisplayMember = "nombre";

        }
        private void CargarGrilla()
        {
            List<CustomClass.CursosCustomdgv> T = Logica.Cursos.CargarGrillaCustom(chk_todo.Checked);
            dgv_cursos.DataSource = T;
            foreach (DataGridViewColumn columns in dgv_cursos.Columns)
            {
                if ((columns.Index < 2))
                {
                    columns.Visible = false;
                }
                if (chk_todo.Checked) {dgv_cursos.Columns[6].Visible = true;}
                else { dgv_cursos.Columns[6].Visible = false; }
                btn_habilitar.Visible = false;
                btn_habilitar.Enabled = true;
            }



        }
        private void dgv_cursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv == null)
                    return;
                CursosCustomdgv var1 = (CursosCustomdgv)dgv.CurrentRow.DataBoundItem;
                txt_value.Text = var1.id_curso.ToString();
                txt_name.Text = var1.nombre;
                txt_descripcion.Text = var1.descripcion;
                dtp_datatime.Value = var1.fecha;
                cmb_categoria.SelectedValue = var1.id_categoria;
                if (var1.borrado == true) { btn_habilitar.Visible = true; 
                                            btn_modificar.Enabled = false;
                                            btn_habilitar.Enabled = true;}
                else { btn_habilitar.Visible = false; 
                        btn_modificar.Enabled = true;
                        btn_habilitar.Enabled = true; }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x);
            }
            


        }
        private void chk_todo_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            try
            {
             
                 int id = Int32.Parse(txt_value.Text);
                 bool borrado = false;
                 if (Logica.Cursos.HabilitarCursos(id, borrado).isSuccess == false)
                 {
                     MessageBox.Show("No se pudo habilitar.");
                 }
                 else { MessageBox.Show("Curso habilitado."); }
                 limpiarcampos();
                 CargarGrilla();
                
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x);
            }
        }
        private void limpiarcampos()
        {
            txt_descripcion.Clear();
            txt_name.Clear();
            txt_value.Clear();
            
        }
    }

}
