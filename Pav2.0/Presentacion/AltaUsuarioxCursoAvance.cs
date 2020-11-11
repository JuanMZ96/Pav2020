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
        bool primeraVez = false;
        bool Avance;

        public AltaUsuarioxCursoAvance()
        {
            InitializeComponent();
            CargarGrillaUsuario(txt_Filtro.Text);
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
        public void CargarGrillaCurso(int idusuario)
        {
            string tipo = "Usuario";
            List<UsuarioxCursoCustom> curso = Logica.UsuariosxCurso.MostrarGrilla(false, idusuario, tipo);
            dgv_cursos.DataSource = curso;
            foreach (DataGridViewColumn columns in dgv_cursos.Columns)
            {
                if (columns.Index < 3 || columns.Index > 7)
                {
                    columns.Visible = false;
                }

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarGrillaUsuario(txt_Filtro.Text);

        }

        private void dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;
            Usuario var1 = (Usuario)dgv.CurrentRow.DataBoundItem;
            if (Avance) CargarGrillaCurso(var1.id_usuario);
            else { txt_usuario.Text = var1.id_usuario.ToString(); cargarComboCurso(); }
                
               



        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int idusuario = Int32.Parse(txt_usuario.Text);
            int idcurso = Int32.Parse(txt_curso.Text);
            DateTime fechaInicio =DateTime.Parse(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
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

        public void accionCargarProgreso(bool accion)
        {

            dgv_cursos.Visible = accion;
            btn_guardar.Visible = accion;
            if (!primeraVez)
            {
                lbl_buscarUsuario.Visible = accion;
                dgv_usuarios.Visible = accion;
                txt_Filtro.Visible = accion;
                lbl_porcentaje.Visible = accion;
                txt_porcentaje.Visible = accion;
                groupBox1.Visible = accion;
                primeraVez = true;
            }
        }
        public void accionModificarProgreso(bool accion)
        {
            dgv_avanceCurso.Visible = accion;
            btn_modificar.Visible = accion;
            if (!primeraVez)
            {
                lbl_buscarUsuario.Visible = accion;
                dgv_usuarios.Visible = accion;
                txt_Filtro.Visible = accion;
                lbl_porcentaje.Visible = accion;
                txt_porcentaje.Visible = accion;
                groupBox1.Visible = accion;
                primeraVez = true;
            }
        }

        private void cargarProgresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Cargar";
            limpiar();
            Avance = true;
            accionCargarProgreso(true);
            accionModificarProgreso(false);
        }

        private void modificarProgresoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            groupBox1.Text = "Modificiar";
            limpiar();
            Avance = false;
            accionModificarProgreso(true);
            accionCargarProgreso(false);
            
        }

        public void cargarComboCurso()
        {
            System.Collections.IList T = Logica.Cursos.MostrarCombo();
            cmb_cursos.DataSource = T;
            cmb_cursos.ValueMember = "id";
            cmb_cursos.DisplayMember = "name";
        }
        
        public void cargarGrillaAvance(int idusuario, int idCurso)
        {
            
            List<UsuarioxCursoAvanceCustom> avances = Logica.UsuarioxCursoAvance.MostrarGrilla(idusuario, idCurso);
            dgv_avanceCurso.DataSource = avances;
            foreach (DataGridViewColumn columns in dgv_avanceCurso.Columns)
            {
                if (columns.Index < 3 || columns.Index > 6)
                {
                    columns.Visible = false;
                }
            }
        }
        private void dgv_avanceCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;
            UsuarioxCursoAvanceCustom var1 = (UsuarioxCursoAvanceCustom)dgv.CurrentRow.DataBoundItem;
            txt_usuario.Text = var1.id_usuario.ToString();
            txt_curso.Text = var1.id_curso.ToString();
            dtp_fin.Value = var1.fecha_fin;
            dtp_inicio.Value = var1.fecha_inicio;
            txt_porcentaje.Text = var1.porcentaje.ToString();

        }
        public void limpiar()
        {
            txt_curso.Text = "";
            txt_Filtro.Text = "";
            txt_porcentaje.Text = "";
            txt_usuario.Text = "";

        }
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            int idusuario = Int32.Parse(txt_usuario.Text);
            int idcurso = Int32.Parse(txt_curso.Text);
            DateTime fechaInicio = dtp_inicio.Value;
            DateTime fechaFin = dtp_fin.Value;
            int porcentaje = Int32.Parse(txt_porcentaje.Text);
            ReturnValue valido = UsuarioxCursoAvance.ModificiarUsuarioxCursoAvance(idusuario, idcurso, fechaInicio, fechaFin, porcentaje);
            if (valido.isSuccess) { MessageBox.Show("Se modifico correctamente"); cargarGrillaAvance(idusuario, (int)cmb_cursos.SelectedValue);}
            else { MessageBox.Show(valido.ErrorMessage); }
        }

        private void cmb_cursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                int idusuario = Int32.Parse(txt_usuario.Text);
                cargarGrillaAvance(idusuario, (int)cmb_cursos.SelectedValue);
            }
            catch { }
        }
    }
       
}
