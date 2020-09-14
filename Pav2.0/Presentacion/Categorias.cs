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

namespace Pav2.Presentacion
{
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            txt_value.Text = "2";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Logica.Categorias.GuardarCategoria(txt_name.Text, txt_descripcion.Text);
        }

        private void txt_value_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_value.Text);
            Logica.Categorias.ModificarCategoria(id, txt_name.Text,txt_descripcion.Text);
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_value.Text);
            Logica.Categorias.EliminarCategoria(id);
        }
    }
}
