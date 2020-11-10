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
                int usuario = (int)cmb_Usuario.SelectedValue;
                List<CustomClass.UsuarioxCursoCustom> T = UsuariosxCurso.MostrarGrillaCustom(chk_IncluirBorrados.Checked,usuario);
                dgv_UsuarioCurso.DataSource = T;
                foreach (DataGridViewColumn columns in dgv_UsuarioCurso.Columns)
                {
                    if ((columns.Index < 2) && (columns.Index < 4))
                    {
                        columns.Visible = false;
                    }
                }
            }
            catch { }
        }
        private void GestionUsuarioxCurso_Load(object sender, EventArgs e)
        {
            CargarComboUsuarios();
            CargarComboCursos();
            CargarGrilla();
        }

        private void cmb_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void chk_IncluirBorrados_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int idCurso = (int)cmb_Curso.SelectedValue;
            int idUsuario = (int)cmb_Usuario.SelectedValue;
            ReturnValue valido = Logica.UsuariosxCurso.EliminarUsuariosxCurso(idCurso, idUsuario, chk_BorrarDB.Checked);
            if (valido.isSuccess) { MessageBox.Show("Se borro correctamente."); CargarGrilla(); }
            else { MessageBox.Show(valido.ErrorMessage); }
        }

        private void dgv_UsuarioCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;
            UsuarioxCursoCustom var = (UsuarioxCursoCustom)dgv.CurrentRow.DataBoundItem;
            cmb_Curso.SelectedValue = var.id_curso;
            txt_puntuacion.Text = var.puntuacion.ToString();
            txt_observaciones.Text = var.observaciones;
            dtp_FechaInicio.Value = var.fecha_inicio;
            dtp_FechaFin.Value = var.fecha_fin;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            int idCurso = (int)cmb_Curso.SelectedValue;
            int idUsuario = (int)cmb_Usuario.SelectedValue;
            int puntuacion = Int32.Parse(txt_puntuacion.Text);
            ReturnValue valido = Logica.UsuariosxCurso.ModificarUsuariosxCurso(idCurso, idUsuario, puntuacion, txt_observaciones.Text, dtp_FechaInicio.Value, dtp_FechaFin.Value);
            if (valido.isSuccess) { MessageBox.Show("Se modifico correctamente"); CargarGrilla(); }
            else { MessageBox.Show(valido.ErrorMessage); }

        }
    }
}
