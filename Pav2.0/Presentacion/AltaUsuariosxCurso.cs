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
using ClassLibrary1;

namespace Pav2.Presentacion
{
    public partial class AltaUsuariosxCurso : Form
    {
        public AltaUsuariosxCurso()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int idCurso = (int)cmb_Curso.SelectedValue;
            int idUsuario = (int)cmb_Usuario.SelectedValue;
            
            if (txt_Puntuacion.Text != "" && txt_Observaciones.Text != "")
            {
                int puntuacion = Int32.Parse(txt_Puntuacion.Text);
                string observaciones = txt_Observaciones.Text;
                ReturnValue valido = UsuariosxCurso.GuardarUsuariosxCurso(idCurso, idUsuario, puntuacion, observaciones, dtp_FechaInicio.Value ,dtp_FechaFin.Value);
                if (valido.isSuccess) { MessageBox.Show("Se creo correctamente"); }
                else { MessageBox.Show(valido.ErrorMessage, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Complete el campo correspondiente"); }
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

        private void AltaUsuariosxCurso_Load(object sender, EventArgs e)
        {
            CargarComboUsuarios();
            CargarComboCursos();
        }
    }


}
