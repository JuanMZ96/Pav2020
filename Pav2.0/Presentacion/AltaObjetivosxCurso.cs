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
using ClassLibrary1;

namespace Pav2.Presentacion
{
    public partial class AltaObjetivosxCurso : Form
    {
        public AltaObjetivosxCurso()
        {
            InitializeComponent();
        }

        private void cmb_cursos_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            cmb_cursos.ValueMember = "id_curso";
            cmb_cursos.DisplayMember = "nombre";
        }

        private void ObjetivosxCurso_Load(object sender, EventArgs e)
        {
            CargarComboObjetivos();
            CargarComboCursos();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int idCurso = (int)cmb_cursos.SelectedValue;
            int idobjetivo = (int)cmb_objetivos.SelectedValue;
            if(txt_puntaje.Text != "") 
            {
                int puntaje = Int32.Parse(txt_puntaje.Text);
                ReturnValue valido = Logica.ObjetivosxCurso.GuardarObjetivosxCurso(idCurso, idobjetivo, puntaje);
                if (valido.isSuccess) { MessageBox.Show("Se creo correctamente"); }
                else { MessageBox.Show(valido.ErrorMessage, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Complete el campo correspondiente"); }
        }
    }   
}
