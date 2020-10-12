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

namespace Pav2.Presentacion
{
    public partial class GestionPermisos : Form
    {
        public GestionPermisos()
        {
            InitializeComponent();
            CargarGrilla();
            CargarComboPerfiles();
        }

        private void GestionPermisos_Load(object sender, EventArgs e)
        {

        }

        private void CargarComboPerfiles()
        {
            System.Collections.IList T = Logica.Perfiles.MostrarCombo();
            cmb_perfiles.DataSource = T;
            cmb_perfiles.ValueMember = "id_perfil";
            cmb_perfiles.DisplayMember = "nombre";


        }
        private void CargarGrilla()
        {
            List<Formulario> T = Logica.Formularios.CargarGrilla(chk_todo.Checked);
            dgv_formularios.DataSource = T;
            foreach (DataGridViewColumn columns in dgv_formularios.Columns)
            {
                if (columns.Index > 2)
                {
                    columns.Visible = false;
                }
            }
           

        }
    }
}
