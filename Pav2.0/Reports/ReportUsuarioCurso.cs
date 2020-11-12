using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.EntitySql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Pav2.Logica.CustomClass;

namespace Pav2.Reports
{
    public partial class ReportUsuarioCurso : Form
    {
        int seleccionados = 0;
        List<int> listaUsuario = new List<int>();

        public ReportUsuarioCurso()
        {
            InitializeComponent();
            lbl_seleccionar.Text = "Seleccionados: " + seleccionados;

        }
        
        private void ReportUsuarioCurso_Load(object sender, EventArgs e)
        {
            
            CargarGrillaUsuario(txt_FiltroUsuario.Text);
            CargarGrillaCurso(txt_FiltroCurso.Text);
            //usuarioxCursoCustomBindingSource.DataSource Acá tengo que poner la función segun lo que pida buscar
            
        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
     

        public static List<UsuarioxCursoCustom> cargarReport(int param, string tipo, DateTime inicio, DateTime fin)
        {
            BugTrackerFinalEntities Contex = new BugTrackerFinalEntities();
            ////Usuario
            //Curso
            //Fecha
            //Todo
            var report = from usuarioCurso in Contex.UsuariosCursos
                         join usuario in Contex.Usuarios
                         on usuarioCurso.id_usuario equals usuario.id_usuario
                         join cursos in Contex.Cursos
                         on usuarioCurso.id_curso equals cursos.id_curso
                         where usuarioCurso.borrado == false
                         select new UsuarioxCursoCustom()
                         {
                             nombre = cursos.nombre,
                             puntuacion = (int)usuarioCurso.puntuacion,
                             fecha_inicio = (DateTime)usuarioCurso.fecha_inicio,
                             fecha_fin = (DateTime)usuarioCurso.fecha_fin,
                             usuario = usuario.usuario1,
                         };
            if (tipo == "Usuario")
            {

                report = from usuarioCurso in Contex.UsuariosCursos
                         join usuario in Contex.Usuarios
                         on usuarioCurso.id_usuario equals usuario.id_usuario
                         join cursos in Contex.Cursos
                         on usuarioCurso.id_curso equals cursos.id_curso
                         where usuarioCurso.borrado == false &&
                                usuarioCurso.id_usuario == param
                         select new UsuarioxCursoCustom()
                         {
                             nombre = cursos.nombre,
                             puntuacion = (int)usuarioCurso.puntuacion,
                             fecha_inicio = (DateTime)usuarioCurso.fecha_inicio,
                             fecha_fin = (DateTime)usuarioCurso.fecha_fin,
                             usuario = usuario.usuario1,
                         };
               
            }
            else if (tipo == "Curso")
            {
                report = from usuarioCurso in Contex.UsuariosCursos
                         join usuario in Contex.Usuarios
                         on usuarioCurso.id_usuario equals usuario.id_usuario
                         join cursos in Contex.Cursos
                         on usuarioCurso.id_curso equals cursos.id_curso
                         where usuarioCurso.borrado == false &&
                                usuarioCurso.id_curso == param
                         select new UsuarioxCursoCustom()
                         {
                             nombre = cursos.nombre,
                             puntuacion = (int)usuarioCurso.puntuacion,
                             fecha_inicio = (DateTime)usuarioCurso.fecha_inicio,
                             fecha_fin = (DateTime)usuarioCurso.fecha_fin,
                             usuario = usuario.usuario1,
                         };
            }
            else if (tipo == "Fecha") {

                report = from usuarioCurso in Contex.UsuariosCursos
                         join usuario in Contex.Usuarios
                         on usuarioCurso.id_usuario equals usuario.id_usuario
                         join cursos in Contex.Cursos
                         on usuarioCurso.id_curso equals cursos.id_curso
                         where usuarioCurso.borrado == false &&
                               usuarioCurso.fecha_inicio > inicio &&
                               usuarioCurso.fecha_fin < fin
                         select new UsuarioxCursoCustom()
                         {
                             nombre = cursos.nombre,
                             puntuacion = (int)usuarioCurso.puntuacion,
                             fecha_inicio = (DateTime)usuarioCurso.fecha_inicio,
                             fecha_fin = (DateTime)usuarioCurso.fecha_fin,
                             usuario = usuario.usuario1,

                         };
            }

            return report.ToList();

        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        public void CargarGrillaUsuario(string filtro)
        {
            try
            {
                List<Usuario> usuario = Logica.Usuarios.MostrarDataUsuarios(false);
                dgv_usuarios.DataSource = usuario;
                foreach (DataGridViewColumn columns in dgv_usuarios.Columns)
                {
                    if (columns.Index != 2)
                    {
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

        public void CargarGrillaCurso(string filtro)
        {
            try
            {
                List<Curso> curso = Logica.Cursos.MostrarDataCurso(false);
                dgv_curso.DataSource = curso;
                foreach (DataGridViewColumn columns in dgv_curso.Columns)
                {
                    if (columns.Index != 1)
                    {
                        columns.Visible = false;
                    }
                }
                if (filtro != string.Empty)
                {
                    List<Curso> cursos = Logica.Cursos.FiltrarDataCurso(filtro);
                    dgv_curso.DataSource = cursos;
                }
            }
            catch { }
        }

        private void dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                DataGridView dgv = sender as DataGridView;
                if (dgv == null) return;
                Usuario var1 = (Usuario)dgv.CurrentRow.DataBoundItem;
                txt_param.Text = var1.id_usuario.ToString();
                btn_report.Enabled = true;
        }
        private void dgv_curso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;
            Curso var1 = (Curso)dgv.CurrentRow.DataBoundItem;
            txt_param.Text = var1.id_curso.ToString();
            btn_report.Enabled = true;
        }
        private void txt_FiltroUsuario_TextChanged(object sender, EventArgs e)
        {
            CargarGrillaUsuario(txt_FiltroUsuario.Text);
        }

        private void txt_FiltroCurso_TextChanged(object sender, EventArgs e)
        {
            CargarGrillaCurso(txt_FiltroCurso.Text);
        }

        public void GenerarReporte()
        {
            int param = 0;
            if (txt_param.Text != String.Empty)
            {  param = Int32.Parse(txt_param.Text); }
            List<UsuarioxCursoCustom> result = cargarReport(param, (string)cmb_tipo.SelectedItem, dtp_inicio.Value, dtp_fin.Value);

            usuarioxCursoCustomBindingSource.DataSource = result;
            reportViewer1.Clear();
            this.reportViewer1.RefreshReport();

        }

        private void cmb_tipo_SelectedValueChanged(object sender, EventArgs e)
        {
            ////Usuario
            //Curso
            //Fecha
            //Todo
            switch (cmb_tipo.SelectedItem)
            {
                case "Usuario":
                    gp_curos.Enabled = false;
                    gp_fechas.Enabled = false;
                    dgv_curso.Visible = false;
                    dgv_usuarios.Visible = true;
                    gp_usuarios.Enabled = true;
                    btn_report.Enabled = false;
                    break;
                case "Curso":
                    gp_fechas.Enabled = false;
                    gp_usuarios.Enabled = false;
                    dgv_curso.Visible = true;
                    dgv_usuarios.Visible = false;
                    gp_curos.Enabled = true;
                    btn_report.Enabled = false;
                    break;
                case "Fecha":
                    gp_usuarios.Enabled = false;
                    gp_curos.Enabled = false;
                    gp_fechas.Enabled = true;
                    dgv_curso.Visible = false;
                    dgv_usuarios.Visible = false;
                    btn_report.Enabled = false;
                    btn_report.Enabled = false;
                    break;
                case "Todo":
                    gp_curos.Enabled = false;
                    gp_fechas.Enabled = false;
                    gp_usuarios.Enabled = false;
                    dgv_curso.Visible = false;
                    dgv_usuarios.Visible = false;
                    btn_report.Enabled = true;
                    break;
            }
        }
    }
}
