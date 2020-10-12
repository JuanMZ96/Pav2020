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
    public partial class Objetivos : Form
    {
        public Objetivos()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_nombreCorto.Text != null && txt_nombreLargo.Text != null)
            {
                if (Logica.Objetivos.GuardarObjetivo(txt_nombreCorto.Text, txt_nombreLargo.Text) == false)
                {
                    MessageBox.Show("No se pudo guardar.");
                }
                //CargarGrilla();
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios.");
            }
        }
    }
}
