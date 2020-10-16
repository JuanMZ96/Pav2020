using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                List<Logica.CustomClass.ObjetivoxCursoCustom> T = Logica.ObjetivosxCurso.MostrarGrilla(chk_borrado.Checked, curso);
                dgv_ObjetivosxCurso.DataSource = T;
                foreach (DataGridViewColumn columns in dgv_ObjetivosxCurso.Columns)
                {
                    if ((columns.Index < 2) && (columns.Index < 4))
                    {
                        columns.Visible = false;
                    }
                }
            }
            catch { }
            

        }
        private void GestionObjetivoxCurso_Load(object sender, EventArgs e)
        {

            
        }

        private void cmb_cursos_ValueMemberChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void cmb_cursos_Click(object sender, EventArgs e)
        {
            CargarComboCursos();
        }
    }
}
