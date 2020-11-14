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
using Pav2.Logica;
using Pav2.Reports;

namespace Pav2.Presentacion
{
    public partial class Principal : Form
    {   
        private CustomClass.UsuarioCustom user { get; set; }
        public Principal()
        {
            InitializeComponent();
        }


        private void Principal_Load(object sender, EventArgs e)
        {
            this.Hide();
            Login ventana1 = new Login(this);
            ventana1.ShowDialog();
            this.Show();

            lbl_perfil.Visible = true;
            lbl_perfil.Text = user.perfil;
            lbl_usuario.Visible = true;
            lbl_usuario.Text = "¡Hola, " + user.usuario + "!";
        }

        private void Principal_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == Convert.ToChar(Keys.Escape))
                {
                    Environment.Exit(0);
                }
        }

        public void guardarUsuario(CustomClass.UsuarioCustom data) {
            this.user = data;
        }

        private void altaDeObjetivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_perfil_Click(object sender, EventArgs e)
        {

        }

        private void categoríasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Categorias ventana2 = new Categorias();
            ventana2.ShowDialog();

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUsuarios ventana2 = new AltaUsuarios();
            ventana2.ShowDialog();

        }

        private void cursosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Cursos ventana2 = new Cursos();
            ventana2.ShowDialog();
        }

        private void objetivosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Objetivos ventana2 = new Objetivos();
            ventana2.ShowDialog();
        }

        private void objetivosPorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaObjetivosxCurso ventana2 = new AltaObjetivosxCurso();
            ventana2.ShowDialog();
        }

        private void usuariosPorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUsuariosxCurso ventana2 = new AltaUsuariosxCurso();
            ventana2.ShowDialog();
        }

        private void avancesPorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUsuarioxCursoAvance ventana2 = new AltaUsuarioxCursoAvance();
            ventana2.ShowDialog();
        }

        private void cursosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReportUsuarioCurso reporte = new ReportUsuarioCurso();
            reporte.ShowDialog();
        }

        private void avancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportUsuarioCursoAvance reporte = new ReportUsuarioCursoAvance();
            reporte.ShowDialog();
        }
    }
}
