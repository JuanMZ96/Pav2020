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
    public partial class GestionUsuarioxCurso : Form
    {
        public GestionUsuarioxCurso()
        {
            InitializeComponent();
        }
        private void CargarComboTipoBusqueda()
        {
            cmb_TipoBusqueda.Items.Add("Usuario");
            cmb_TipoBusqueda.Items.Add("Curso");
        }
        private void CargarComboUsuarios()
        {
            System.Collections.IList T = Usuarios.MostrarDataUsuarios(false);
            cmb_Usuario.DataSource = T;
            cmb_Usuario.ValueMember = "id_usuario";
            cmb_Usuario.DisplayMember = "usuario1";
        }
        private void CargarComboCursos()
        {
            System.Collections.IList T = Logica.Cursos.MostrarCombo();
            cmb_Curso.DataSource = T;
            cmb_Curso.ValueMember = "id";
            cmb_Curso.DisplayMember = "name";
        }
        private void CargarGrilla()
        {
            try
            {
                int param = 0;
                if (cmb_TipoBusqueda.Text == "Usuario" ) { param = (int)cmb_Usuario.SelectedValue; }
                else if (cmb_TipoBusqueda.Text == "Curso") { param = (int)cmb_Curso.SelectedValue; }
                string tipo = cmb_TipoBusqueda.Text;
                List<CustomClass.UsuarioxCursoCustom> T = UsuariosxCurso.MostrarGrilla(chk_IncluirBorrados.Checked, param, tipo);
                dgv_UsuarioCurso.DataSource = T;
                foreach (DataGridViewColumn columns in dgv_UsuarioCurso.Columns)
                {
                    if ((columns.Index < 2) && (columns.Index < 4))
                    {
                        columns.Visible = false;
                    }
                }
                if (chk_IncluirBorrados.Checked){dgv_UsuarioCurso.Columns[8].Visible = true;}
                else { dgv_UsuarioCurso.Columns[8].Visible = false;}
                btn_habilitar.Visible = false;
                //-------------
                btn_Eliminar.Enabled = false;
                btn_Modificar.Enabled = false;
                
            }
            catch (Exception x){ MessageBox.Show("Error: " + x); }
        }
        private void GestionUsuarioxCurso_Load(object sender, EventArgs e)
        {
            CargarComboUsuarios();
            CargarComboCursos();
            CargarComboTipoBusqueda();
            cmb_Usuario.Enabled = false;
            cmb_Curso.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
        }

        private void cmb_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_TipoBusqueda.Text == "Usuario") { CargarGrilla(); }
            limpiarCampos();
        }

        private void chk_IncluirBorrados_CheckedChanged(object sender, EventArgs e)
        {
            if (cmb_TipoBusqueda.Text == "Usuario") { CargarGrilla(); }
            else if (cmb_TipoBusqueda.Text == "Curso") { CargarGrilla(); }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCurso = (int)cmb_Curso.SelectedValue;
                int idUsuario = (int)cmb_Usuario.SelectedValue;
                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar ? ", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    ReturnValue valido = Logica.UsuariosxCurso.EliminarUsuariosxCurso(idCurso, idUsuario, chk_BorrarDB.Checked);
                    if (valido.isSuccess) { MessageBox.Show("Se eliminó correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information); CargarGrilla(); }
                    else { MessageBox.Show(valido.ErrorMessage); }
                }
                limpiarCampos();
            }
            catch (Exception x) { MessageBox.Show("Error: " + x);}
            
        }

        private void dgv_UsuarioCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv == null) return;
                UsuarioxCursoCustom var = (UsuarioxCursoCustom)dgv.CurrentRow.DataBoundItem;
                cmb_Curso.SelectedValue = var.id_curso;
                cmb_Usuario.SelectedValue = var.id_usuario;
                txt_puntuacion.Text = var.puntuacion.ToString();
                txt_observaciones.Text = var.observaciones;
                dtp_FechaInicio.Value = var.fecha_inicio;
                dtp_FechaFin.Value = var.fecha_fin;
                if (var.borrado == true) { btn_habilitar.Visible = true; btn_Modificar.Enabled = false; }
                else { btn_habilitar.Visible = false; btn_Modificar.Enabled = true; }  //Hacer visible "habilitar" deshabilita el modificar
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x);
            }
            //-------------
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCurso = (int)cmb_Curso.SelectedValue;
                int idUsuario = (int)cmb_Usuario.SelectedValue;
                int puntuacion = Int32.Parse(txt_puntuacion.Text);
                ReturnValue valido = Logica.UsuariosxCurso.ModificarUsuariosxCurso(idCurso, idUsuario, puntuacion, txt_observaciones.Text, dtp_FechaInicio.Value, dtp_FechaFin.Value);
                if (valido.isSuccess) { MessageBox.Show("Se modifico correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information); CargarGrilla(); }
                else { MessageBox.Show(valido.ErrorMessage); }
                limpiarCampos();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x);
            }
            
        }
        private void limpiarCampos()
        {
            txt_puntuacion.Text = "";
            txt_observaciones.Text = "";
            btn_habilitar.Visible = false;
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCurso = (int)cmb_Curso.SelectedValue;
                int idUsuario = (int)cmb_Usuario.SelectedValue;
                bool borrado = false;
                ReturnValue valido = Logica.UsuariosxCurso.HabilitarUsuarioCurso(idCurso, idUsuario, borrado);
                if (valido.isSuccess) { MessageBox.Show("Curso habilitado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information); CargarGrilla(); }
                else { MessageBox.Show(valido.ErrorMessage); }
                limpiarCampos();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x);
            }
            
        }
        private void cmb_TipoBusqueda_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_TipoBusqueda.Text == "Usuario")
            {
                cmb_Usuario.Enabled = true;
                cmb_Curso.Enabled = false;
                CargarComboCursos();
                CargarComboUsuarios();
            }
            else if(cmb_TipoBusqueda.Text == "Curso")
            {
                cmb_Usuario.Enabled = false;
                cmb_Curso.Enabled = true;
                CargarComboCursos();
                CargarComboUsuarios();
            }
        }
        private void cmb_Curso_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_TipoBusqueda.Text == "Curso") { CargarGrilla(); }
            limpiarCampos();
        }
    }
}
