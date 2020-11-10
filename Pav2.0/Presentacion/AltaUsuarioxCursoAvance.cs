using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using static Pav2.Logica.CustomClass;
using Pav2.Logica;

namespace Pav2.Presentacion
{
    public partial class AltaUsuarioxCursoAvance : Form
    {
        
        public AltaUsuarioxCursoAvance()
        {
            InitializeComponent();
            CargarGrillaUsuario(txtFiltro.Text);
        }

        public void CargarGrillaUsuario(string filtro)
        {

            try {
                List<Usuario> usuario = Logica.Usuarios.MostrarDataUsuarios(false);
                dgv_usuarios.DataSource = usuario;
                foreach (DataGridViewColumn columns in dgv_usuarios.Columns){
                    if (columns.Index != 2){
                        columns.Visible = false;
                    }
                }
                if (filtro != string.Empty)
                {
                    List<Usuario> usuarios = Logica.Usuarios.FiltrarDataUsuario(filtro);
                    dgv_usuarios.DataSource = usuarios;
                }
            }
            catch { }
        }
        public void CargarGrillaCurso(int idusuario)
        {
            List<UsuarioxCursoCustom> curso = Logica.UsuariosxCurso.MostrarGrillaCustom(false, idusuario);
            dgv_cursos.DataSource = curso;
            foreach (DataGridViewColumn columns in dgv_cursos.Columns)
            {
                if (columns.Index < 2 || columns.Index > 6)
                {
                    columns.Visible = false;
                }

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarGrillaUsuario(txtFiltro.Text);

        }

        private void dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;
            Usuario var1 = (Usuario)dgv.CurrentRow.DataBoundItem;
            CargarGrillaCurso(var1.id_usuario);

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int idusuario = Int32.Parse(txt_usuario.Text);
            int idcurso = Int32.Parse(txtFiltro.Text);
            DateTime fechaInicio = DateTime.Now;
            DateTime fechaFin = dtp_fin.Value;
            int porcentaje = Int32.Parse(txt_porcentaje.Text);
            ReturnValue valido = Logica.UsuarioxCursoAvance.GuardarUsuarioxCursoAvance(idusuario, idcurso, fechaInicio, fechaFin, porcentaje);
            if (valido.isSuccess) { MessageBox.Show("Se guardo correctamente"); }
            else { MessageBox.Show(valido.ErrorMessage); }
        }

        private void dgv_cursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;
            UsuarioxCursoCustom var1 = (UsuarioxCursoCustom)dgv.CurrentRow.DataBoundItem;
            txt_usuario.Text = var1.id_usuario.ToString();
            txt_curso.Text = var1.id_curso.ToString();
            dtp_fin.Value = var1.fecha_fin;
        }
    }
}
