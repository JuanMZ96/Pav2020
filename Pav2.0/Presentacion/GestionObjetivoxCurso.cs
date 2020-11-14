using ClassLibrary1;
using Pav2.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Pav2.Logica.CustomClass;

namespace Pav2.Presentacion
{
    public partial class GestionObjetivoxCurso : Form
    {
        public GestionObjetivoxCurso()
        {
            InitializeComponent();
        }
        private void CargarComboObjetivos()
        {
            System.Collections.IList T = Logica.Objetivos.MostrarCombo();
            cmb_objetivos.DataSource = T;
            cmb_objetivos.ValueMember = "id_objetivo";
            cmb_objetivos.DisplayMember = "nombre_corto";
        }
        private void CargarComboCursos()
        {
            System.Collections.IList T = Logica.Cursos.MostrarCombo();
            cmb_cursos.DataSource = T;
            cmb_cursos.ValueMember = "id";
            cmb_cursos.DisplayMember = "name";
        }

        private void CargarGrilla()
        {
            try
            {
                int curso = (int)cmb_cursos.SelectedValue;
                List<ObjetivoxCursoCustom> T = ObjetivosxCurso.MostrarGrilla(chk_IncluirBorrados.Checked,curso);
                dgv_ObjetivosxCurso.DataSource = T;
                foreach (DataGridViewColumn columns in dgv_ObjetivosxCurso.Columns)
                {
                    if (columns.Index < 2) //&& (columns.Index < 4))
                    {
                        columns.Visible = false;
                    }
                }
                dgv_ObjetivosxCurso.Columns[6].Visible = false;
                if (chk_IncluirBorrados.Checked) { dgv_ObjetivosxCurso.Columns[5].Visible = true; }
                else { dgv_ObjetivosxCurso.Columns[5].Visible = false; }
            }
            catch { }


        }
        private void GestionObjetivoxCurso_Load(object sender, EventArgs e)
        {
            CargarComboObjetivos();

        }

        private void cmb_cursos_ValueMemberChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void cmb_cursos_Click(object sender, EventArgs e)
        {
            if(cmb_cursos.SelectedValue == null) { CargarComboCursos(); chk_IncluirBorrados.Enabled = true;}
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCurso = (int)cmb_cursos.SelectedValue;
                int idobjetivo = (int)cmb_objetivos.SelectedValue;
                int puntaje = Int32.Parse(txt_puntaje.Text);
                ReturnValue valido = Logica.ObjetivosxCurso.ModificarObjetivosxCurso(idCurso, idobjetivo, puntaje);
                if (valido.isSuccess) { MessageBox.Show("Se modifico correctamente"); CargarGrilla(); }
                else { MessageBox.Show(valido.ErrorMessage); }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x);
            }
        }

        private void dgv_ObjetivosxCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv == null) return;
                ObjetivoxCursoCustom var1 = (ObjetivoxCursoCustom)dgv.CurrentRow.DataBoundItem;
                cmb_objetivos.SelectedValue = var1.id_objetivo;
                txt_puntaje.Text = var1.puntos.ToString();
                //chk_estado.Checked = (bool)var1.borrado;
                if (var1.borrado == true) { btn_habilitar.Visible = true; btn_modificar.Enabled = false; }
                else { btn_habilitar.Visible = false; btn_modificar.Enabled = true; }
            }
            catch (Exception x) { MessageBox.Show("Error: " + x); }
        }

        private void chk_borrado_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCurso = (int)cmb_cursos.SelectedValue;
                int idobjetivo = (int)cmb_objetivos.SelectedValue;
                ReturnValue valido = Logica.ObjetivosxCurso.EliminarObjetivosxCurso(idCurso, idobjetivo, chk_borrado.Checked);
                if (valido.isSuccess) { MessageBox.Show("Se borro correctamente"); CargarGrilla(); }
                else { MessageBox.Show(valido.ErrorMessage); }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x);
            }
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCurso = (int)cmb_cursos.SelectedValue;
                int idObjetivo = (int)cmb_objetivos.SelectedValue;
                bool borrado = false;
                ReturnValue valido = Logica.ObjetivosxCurso.HabilitarObjetivoxCurso(idObjetivo,idCurso, borrado);
                if (valido.isSuccess) { MessageBox.Show("Objetivo habilitado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information); CargarGrilla(); }
                else { MessageBox.Show(valido.ErrorMessage); }
                //limpiarCampos();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x);
            }
        }

        private void btn_modificar_MouseHover(object sender, EventArgs e)
        {
            lbl_modificar.Visible = true;
        }

        private void btn_modificar_MouseLeave(object sender, EventArgs e)
        {
            lbl_modificar.Visible = false;
        }

        private void btn_eliminar_MouseHover(object sender, EventArgs e)
        {
            lbl_eliminar.Visible = true;
        }

        private void btn_eliminar_MouseLeave(object sender, EventArgs e)
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
    }
}