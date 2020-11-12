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

namespace Pav2.Reports
{
    public partial class ReportUsuarioCurso : Form
    {
        public ReportUsuarioCurso()
        {
            InitializeComponent();
        }
        BugTrackerFinalEntities contex = new BugTrackerFinalEntities();
        private void ReportUsuarioCurso_Load(object sender, EventArgs e)
        {
            List<UsuariosCurso> report = contex.UsuariosCursos.ToList();
            UsuariosCursoBindingSource.DataSource = report;

            reportViewer1.Dock = DockStyle.Fill;
            this.reportViewer1.RefreshReport();
        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
