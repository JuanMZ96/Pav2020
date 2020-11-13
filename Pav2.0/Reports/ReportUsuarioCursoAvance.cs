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
using static Pav2.Logica.CustomClass;

namespace Pav2.Reports
{
    public partial class ReportUsuarioCursoAvance : Form
    {
        BugTrackerFinalEntities Contex = new BugTrackerFinalEntities();
        public ReportUsuarioCursoAvance()
        {
            InitializeComponent();
        }

        private void ReportUsuarioCursoAvance_Load(object sender, EventArgs e)
        {

            CargarGrillaUsuario(txt_FiltroUsuario.Text);
            CargarGrillaCurso(txt_FiltroCurso.Text);

            
            
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

        private void txt_FiltroUsuario_TextChanged(object sender, EventArgs e)
        {
            CargarGrillaUsuario(txt_FiltroUsuario.Text);
        }

        private void txt_FiltroCurso_TextChanged(object sender, EventArgs e)
        {
            CargarGrillaCurso(txt_FiltroCurso.Text);
        }

        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_tipo.SelectedItem)
            {
                case "Usuario":
                    gp_cursos.Enabled = false;
                    gp_fechas.Enabled = false;
                    dgv_curso.Visible = false;
                    dgv_usuarios.Visible = true;
                    gp_usuarios.Enabled = true;
                    btn_generar.Enabled = false;
                    break;
                case "Curso":
                    gp_fechas.Enabled = false;
                    gp_usuarios.Enabled = false;
                    dgv_curso.Visible = true;
                    dgv_usuarios.Visible = false;
                    gp_cursos.Enabled = true;
                    btn_generar.Enabled = false;
                    break;
                case "Fecha":
                    gp_usuarios.Enabled = false;
                    gp_cursos.Enabled = false;
                    gp_fechas.Enabled = true;
                    dgv_curso.Visible = false;
                    dgv_usuarios.Visible = false;
                    btn_generar.Enabled = false;
                    btn_generar.Enabled = false;
                    break;
                case "Todo":
                    gp_cursos.Enabled = false;
                    gp_fechas.Enabled = false;
                    gp_usuarios.Enabled = false;
                    dgv_curso.Visible = false;
                    dgv_usuarios.Visible = false;
                    btn_generar.Enabled = true;
                    break;
            }
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        public void GenerarReporte()
        {
            int param = 0;
            if (txt_param.Text != String.Empty)
            { param = Int32.Parse(txt_param.Text); }
            //Listado
            //Terminados
            //Incompletos
            switch (cmb_tipoGrafico.SelectedItem) 
            {
                case "Listado":
                    List<UsuarioxCursoAvanceCustom> list = Listado(param, (string)cmb_tipo.SelectedItem, dtp_inicio.Value, dtp_fin.Value);
                    usuarioxCursoAvanceCustomBindingSource.DataSource = list;
                    reportViewer1.Clear();
                    this.reportViewer1.RefreshReport();
                    break;

                case "Terminados":
                    List<UsuarioxCursoAvanceCustom> complet = Terminados(param, (string)cmb_tipo.SelectedItem, dtp_inicio.Value, dtp_fin.Value);
                    usuarioxCursoAvanceCustomBindingSource.DataSource = complet;
                    reportViewer1.Clear();
                    this.reportViewer1.RefreshReport();
                    break;
                case "Incompletos":
                    List<UsuarioxCursoAvanceCustom> incomplete = Incompletos(param, (string)cmb_tipo.SelectedItem, dtp_inicio.Value, dtp_fin.Value);
                    usuarioxCursoAvanceCustomBindingSource.DataSource = incomplete;
                    reportViewer1.Clear();
                    this.reportViewer1.RefreshReport();
                    break;
            }
        }

        public static List<UsuarioxCursoAvanceCustom> Listado(int param, string tipo, DateTime inicio, DateTime fin)
        {
            BugTrackerFinalEntities Contex = new BugTrackerFinalEntities();
            ////Usuario
            //Curso
            //Fecha
            //Todo
            var report = from usuarioCursoAvance in Contex.UsuariosCursoAvances
                         join usuario in Contex.Usuarios
                         on usuarioCursoAvance.id_usuario equals usuario.id_usuario
                         join cursos in Contex.Cursos
                         on usuarioCursoAvance.id_curso equals cursos.id_curso
                         where usuarioCursoAvance.borrado == false
                         select new UsuarioxCursoAvanceCustom()
                         {
                             Curso = cursos.nombre,
                             porcentaje = (int)usuarioCursoAvance.porc_avance,
                             fecha_inicio = (DateTime)usuarioCursoAvance.inicio,
                             fecha_fin = (DateTime)usuarioCursoAvance.fin,
                             Usuario = usuario.usuario1,
                         };
            if (tipo == "Usuario")
            {
                report = from usuarioCursoAvance in Contex.UsuariosCursoAvances
                         join usuario in Contex.Usuarios
                         on usuarioCursoAvance.id_usuario equals usuario.id_usuario
                         join cursos in Contex.Cursos
                         on usuarioCursoAvance.id_curso equals cursos.id_curso
                         where usuarioCursoAvance.borrado == false &&
                                usuarioCursoAvance.id_usuario == param
                         select new UsuarioxCursoAvanceCustom()
                         {
                             Curso = cursos.nombre,
                             porcentaje = (int)usuarioCursoAvance.porc_avance,
                             fecha_inicio = (DateTime)usuarioCursoAvance.inicio,
                             fecha_fin = (DateTime)usuarioCursoAvance.fin,
                             Usuario = usuario.usuario1,
                         };
            }
            else if (tipo == "Curso")
            {
                report = from usuarioCursoAvance in Contex.UsuariosCursoAvances
                         join usuario in Contex.Usuarios
                         on usuarioCursoAvance.id_usuario equals usuario.id_usuario
                         join cursos in Contex.Cursos
                         on usuarioCursoAvance.id_curso equals cursos.id_curso
                         where usuarioCursoAvance.borrado == false &&
                                usuarioCursoAvance.id_curso == param
                         select new UsuarioxCursoAvanceCustom()
                         {
                             Curso = cursos.nombre,
                             porcentaje = (int)usuarioCursoAvance.porc_avance,
                             fecha_inicio = (DateTime)usuarioCursoAvance.inicio,
                             fecha_fin = (DateTime)usuarioCursoAvance.fin,
                             Usuario = usuario.usuario1,
                         };
            }
            else if (tipo == "Fecha")
            {
                report = from usuarioCursoAvance in Contex.UsuariosCursoAvances
                         join usuario in Contex.Usuarios
                         on usuarioCursoAvance.id_usuario equals usuario.id_usuario
                         join cursos in Contex.Cursos
                         on usuarioCursoAvance.id_curso equals cursos.id_curso
                         where usuarioCursoAvance.borrado == false &&
                                usuarioCursoAvance.inicio > inicio &&
                               usuarioCursoAvance.fin < fin
                         select new UsuarioxCursoAvanceCustom()
                         {
                             Curso = cursos.nombre,
                             porcentaje = (int)usuarioCursoAvance.porc_avance,
                             fecha_inicio = (DateTime)usuarioCursoAvance.inicio,
                             fecha_fin = (DateTime)usuarioCursoAvance.fin,
                             Usuario = usuario.usuario1,
                         };
            }
            return report.ToList();
        }

        public static List<UsuarioxCursoAvanceCustom> Terminados(int param, string tipo, DateTime inicio, DateTime fin)
        {
            BugTrackerFinalEntities Contex = new BugTrackerFinalEntities();
            ////Usuario
            //Curso
            //Fecha
            //Todo
            var report = from usuarioCursoAvance in Contex.UsuariosCursoAvances
                         join usuario in Contex.Usuarios
                         on usuarioCursoAvance.id_usuario equals usuario.id_usuario
                         join cursos in Contex.Cursos
                         on usuarioCursoAvance.id_curso equals cursos.id_curso
                         where usuarioCursoAvance.borrado == false &&
                          usuarioCursoAvance.porc_avance == 100
                         select new UsuarioxCursoAvanceCustom()
                         {
                             Curso = cursos.nombre,
                             porcentaje = (int)usuarioCursoAvance.porc_avance,
                             fecha_inicio = (DateTime)usuarioCursoAvance.inicio,
                             fecha_fin = (DateTime)usuarioCursoAvance.fin,
                             Usuario = usuario.usuario1,
                         };
            if (tipo == "Usuario")
            {
                report = from usuarioCursoAvance in Contex.UsuariosCursoAvances
                         join usuario in Contex.Usuarios
                         on usuarioCursoAvance.id_usuario equals usuario.id_usuario
                         join cursos in Contex.Cursos
                         on usuarioCursoAvance.id_curso equals cursos.id_curso
                         where usuarioCursoAvance.borrado == false &&
                                usuarioCursoAvance.id_usuario == param &&
                                usuarioCursoAvance.porc_avance == 100
                         select new UsuarioxCursoAvanceCustom()
                         {
                             Curso = cursos.nombre,
                             porcentaje = (int)usuarioCursoAvance.porc_avance,
                             fecha_inicio = (DateTime)usuarioCursoAvance.inicio,
                             fecha_fin = (DateTime)usuarioCursoAvance.fin,
                             Usuario = usuario.usuario1,
                         };
            }
            else if (tipo == "Curso")
            {
                report = from usuarioCursoAvance in Contex.UsuariosCursoAvances
                         join usuario in Contex.Usuarios
                         on usuarioCursoAvance.id_usuario equals usuario.id_usuario
                         join cursos in Contex.Cursos
                         on usuarioCursoAvance.id_curso equals cursos.id_curso
                         where usuarioCursoAvance.borrado == false &&
                                usuarioCursoAvance.id_curso == param &&
                                usuarioCursoAvance.porc_avance == 100
                         select new UsuarioxCursoAvanceCustom()
                         {
                             Curso = cursos.nombre,
                             porcentaje = (int)usuarioCursoAvance.porc_avance,
                             fecha_inicio = (DateTime)usuarioCursoAvance.inicio,
                             fecha_fin = (DateTime)usuarioCursoAvance.fin,
                             Usuario = usuario.usuario1,
                         };
            }
            else if (tipo == "Fecha")
            {
                report = from usuarioCursoAvance in Contex.UsuariosCursoAvances
                         join usuario in Contex.Usuarios
                         on usuarioCursoAvance.id_usuario equals usuario.id_usuario
                         join cursos in Contex.Cursos
                         on usuarioCursoAvance.id_curso equals cursos.id_curso
                         where usuarioCursoAvance.borrado == false &&
                                usuarioCursoAvance.porc_avance == 100 &&
                                usuarioCursoAvance.inicio > inicio &&
                               usuarioCursoAvance.fin < fin
                         select new UsuarioxCursoAvanceCustom()
                         {
                             Curso = cursos.nombre,
                             porcentaje = (int)usuarioCursoAvance.porc_avance,
                             fecha_inicio = (DateTime)usuarioCursoAvance.inicio,
                             fecha_fin = (DateTime)usuarioCursoAvance.fin,
                             Usuario = usuario.usuario1,
                         };
            }
            return report.ToList();
        }

        public static List<UsuarioxCursoAvanceCustom> Incompletos(int param, string tipo, DateTime inicio, DateTime fin)
        {
            BugTrackerFinalEntities Contex = new BugTrackerFinalEntities();
            ////Usuario
            //Curso
            //Fecha
            //Todo
            var report = from usuarioCursoAvance in Contex.UsuariosCursoAvances
                         join usuario in Contex.Usuarios
                         on usuarioCursoAvance.id_usuario equals usuario.id_usuario
                         join cursos in Contex.Cursos
                         on usuarioCursoAvance.id_curso equals cursos.id_curso
                         where usuarioCursoAvance.borrado == false &&
                          usuarioCursoAvance.porc_avance != 100
                         select new UsuarioxCursoAvanceCustom()
                         {
                             Curso = cursos.nombre,
                             porcentaje = (int)usuarioCursoAvance.porc_avance,
                             fecha_inicio = (DateTime)usuarioCursoAvance.inicio,
                             fecha_fin = (DateTime)usuarioCursoAvance.fin,
                             Usuario = usuario.usuario1,
                         };
            if (tipo == "Usuario")
            {
                report = from usuarioCursoAvance in Contex.UsuariosCursoAvances
                         join usuario in Contex.Usuarios
                         on usuarioCursoAvance.id_usuario equals usuario.id_usuario
                         join cursos in Contex.Cursos
                         on usuarioCursoAvance.id_curso equals cursos.id_curso
                         where usuarioCursoAvance.borrado == false &&
                                usuarioCursoAvance.id_usuario == param &&
                                usuarioCursoAvance.porc_avance != 100
                         select new UsuarioxCursoAvanceCustom()
                         {
                             Curso = cursos.nombre,
                             porcentaje = (int)usuarioCursoAvance.porc_avance,
                             fecha_inicio = (DateTime)usuarioCursoAvance.inicio,
                             fecha_fin = (DateTime)usuarioCursoAvance.fin,
                             Usuario = usuario.usuario1,
                         };
            }
            else if (tipo == "Curso")
            {
                report = from usuarioCursoAvance in Contex.UsuariosCursoAvances
                         join usuario in Contex.Usuarios
                         on usuarioCursoAvance.id_usuario equals usuario.id_usuario
                         join cursos in Contex.Cursos
                         on usuarioCursoAvance.id_curso equals cursos.id_curso
                         where usuarioCursoAvance.borrado == false &&
                                usuarioCursoAvance.id_curso == param &&
                                usuarioCursoAvance.porc_avance != 100
                         select new UsuarioxCursoAvanceCustom()
                         {
                             Curso = cursos.nombre,
                             porcentaje = (int)usuarioCursoAvance.porc_avance,
                             fecha_inicio = (DateTime)usuarioCursoAvance.inicio,
                             fecha_fin = (DateTime)usuarioCursoAvance.fin,
                             Usuario = usuario.usuario1,
                         };
            }
            else if (tipo == "Fecha")
            {
                report = from usuarioCursoAvance in Contex.UsuariosCursoAvances
                         join usuario in Contex.Usuarios
                         on usuarioCursoAvance.id_usuario equals usuario.id_usuario
                         join cursos in Contex.Cursos
                         on usuarioCursoAvance.id_curso equals cursos.id_curso
                         where usuarioCursoAvance.borrado == false &&
                                usuarioCursoAvance.porc_avance != 100 &&
                                usuarioCursoAvance.inicio > inicio &&
                               usuarioCursoAvance.fin < fin
                         select new UsuarioxCursoAvanceCustom()
                         {
                             Curso = cursos.nombre,
                             porcentaje = (int)usuarioCursoAvance.porc_avance,
                             fecha_inicio = (DateTime)usuarioCursoAvance.inicio,
                             fecha_fin = (DateTime)usuarioCursoAvance.fin,
                             Usuario = usuario.usuario1,
                         };
            }
            return report.ToList();
        }
        private void dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;
            Usuario var1 = (Usuario)dgv.CurrentRow.DataBoundItem;
            txt_param.Text = var1.id_usuario.ToString();
            btn_generar.Enabled = true;
        }

        private void dgv_curso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;
            Curso var1 = (Curso)dgv.CurrentRow.DataBoundItem;
            txt_param.Text = var1.id_curso.ToString();
            btn_generar.Enabled = true;
        }

      
    }
    
}
