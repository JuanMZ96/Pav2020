namespace Pav2.Reports
{
    partial class ReportUsuarioCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.usuarioxCursoCustomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.btn_report = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gp_usuarios = new System.Windows.Forms.GroupBox();
            this.lbl_seleccionar = new System.Windows.Forms.Label();
            this.txt_FiltroUsuario = new System.Windows.Forms.TextBox();
            this.txt_param = new System.Windows.Forms.TextBox();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.gp_cursos = new System.Windows.Forms.GroupBox();
            this.dgv_curso = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FiltroCurso = new System.Windows.Forms.TextBox();
            this.lbl_curso = new System.Windows.Forms.Label();
            this.gp_fechas = new System.Windows.Forms.GroupBox();
            this.lbl_fin = new System.Windows.Forms.Label();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioxCursoCustomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.gp_usuarios.SuspendLayout();
            this.gp_cursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_curso)).BeginInit();
            this.gp_fechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuarioxCursoCustomBindingSource
            // 
            this.usuarioxCursoCustomBindingSource.DataSource = typeof(Pav2.Logica.CustomClass.UsuarioxCursoCustom);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.usuarioxCursoCustomBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pav2.Reports.UsuarioCurso.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(571, 35);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(653, 540);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generar por";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "Usuario",
            "Curso",
            "Fecha",
            "Todo"});
            this.cmb_tipo.Location = new System.Drawing.Point(90, 19);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipo.TabIndex = 3;
            this.cmb_tipo.SelectedValueChanged += new System.EventHandler(this.cmb_tipo_SelectedValueChanged);
            // 
            // btn_report
            // 
            this.btn_report.Enabled = false;
            this.btn_report.Location = new System.Drawing.Point(241, 15);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(96, 28);
            this.btn_report.TabIndex = 4;
            this.btn_report.Text = "Reporte Listado";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(9, 16);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(40, 13);
            this.lbl_Usuario.TabIndex = 6;
            this.lbl_Usuario.Text = "Buscar";
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.dgv_usuarios.Location = new System.Drawing.Point(6, 67);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.RowHeadersVisible = false;
            this.dgv_usuarios.Size = new System.Drawing.Size(146, 150);
            this.dgv_usuarios.TabIndex = 7;
            this.dgv_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "usuario1";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // gp_usuarios
            // 
            this.gp_usuarios.Controls.Add(this.dgv_usuarios);
            this.gp_usuarios.Controls.Add(this.lbl_seleccionar);
            this.gp_usuarios.Controls.Add(this.txt_FiltroUsuario);
            this.gp_usuarios.Controls.Add(this.lbl_Usuario);
            this.gp_usuarios.Controls.Add(this.txt_param);
            this.gp_usuarios.Location = new System.Drawing.Point(12, 59);
            this.gp_usuarios.Name = "gp_usuarios";
            this.gp_usuarios.Size = new System.Drawing.Size(167, 227);
            this.gp_usuarios.TabIndex = 8;
            this.gp_usuarios.TabStop = false;
            this.gp_usuarios.Text = "Usuarios";
            // 
            // lbl_seleccionar
            // 
            this.lbl_seleccionar.AutoSize = true;
            this.lbl_seleccionar.Location = new System.Drawing.Point(9, 232);
            this.lbl_seleccionar.Name = "lbl_seleccionar";
            this.lbl_seleccionar.Size = new System.Drawing.Size(24, 13);
            this.lbl_seleccionar.TabIndex = 10;
            this.lbl_seleccionar.Text = "text";
            this.lbl_seleccionar.Visible = false;
            // 
            // txt_FiltroUsuario
            // 
            this.txt_FiltroUsuario.Location = new System.Drawing.Point(6, 41);
            this.txt_FiltroUsuario.Name = "txt_FiltroUsuario";
            this.txt_FiltroUsuario.Size = new System.Drawing.Size(100, 20);
            this.txt_FiltroUsuario.TabIndex = 9;
            this.txt_FiltroUsuario.TextChanged += new System.EventHandler(this.txt_FiltroUsuario_TextChanged);
            // 
            // txt_param
            // 
            this.txt_param.Location = new System.Drawing.Point(6, 41);
            this.txt_param.Name = "txt_param";
            this.txt_param.Size = new System.Drawing.Size(43, 20);
            this.txt_param.TabIndex = 11;
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Location = new System.Drawing.Point(41, 54);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(159, 20);
            this.dtp_inicio.TabIndex = 9;
            // 
            // dtp_fin
            // 
            this.dtp_fin.Location = new System.Drawing.Point(41, 93);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(159, 20);
            this.dtp_fin.TabIndex = 10;
            // 
            // gp_cursos
            // 
            this.gp_cursos.Controls.Add(this.dgv_curso);
            this.gp_cursos.Controls.Add(this.label2);
            this.gp_cursos.Controls.Add(this.txt_FiltroCurso);
            this.gp_cursos.Controls.Add(this.lbl_curso);
            this.gp_cursos.Location = new System.Drawing.Point(185, 59);
            this.gp_cursos.Name = "gp_cursos";
            this.gp_cursos.Size = new System.Drawing.Size(165, 227);
            this.gp_cursos.TabIndex = 12;
            this.gp_cursos.TabStop = false;
            this.gp_cursos.Text = "Cursos";
            // 
            // dgv_curso
            // 
            this.dgv_curso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_curso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgv_curso.Location = new System.Drawing.Point(6, 67);
            this.dgv_curso.Name = "dgv_curso";
            this.dgv_curso.ReadOnly = true;
            this.dgv_curso.RowHeadersVisible = false;
            this.dgv_curso.Size = new System.Drawing.Size(146, 150);
            this.dgv_curso.TabIndex = 7;
            this.dgv_curso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_curso_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "text";
            this.label2.Visible = false;
            // 
            // txt_FiltroCurso
            // 
            this.txt_FiltroCurso.Location = new System.Drawing.Point(6, 41);
            this.txt_FiltroCurso.Name = "txt_FiltroCurso";
            this.txt_FiltroCurso.Size = new System.Drawing.Size(100, 20);
            this.txt_FiltroCurso.TabIndex = 9;
            this.txt_FiltroCurso.TextChanged += new System.EventHandler(this.txt_FiltroCurso_TextChanged);
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Location = new System.Drawing.Point(9, 16);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(40, 13);
            this.lbl_curso.TabIndex = 6;
            this.lbl_curso.Text = "Buscar";
            // 
            // gp_fechas
            // 
            this.gp_fechas.Controls.Add(this.lbl_fin);
            this.gp_fechas.Controls.Add(this.lbl_inicio);
            this.gp_fechas.Controls.Add(this.lbl_fecha);
            this.gp_fechas.Controls.Add(this.dtp_inicio);
            this.gp_fechas.Controls.Add(this.dtp_fin);
            this.gp_fechas.Location = new System.Drawing.Point(356, 59);
            this.gp_fechas.Name = "gp_fechas";
            this.gp_fechas.Size = new System.Drawing.Size(209, 217);
            this.gp_fechas.TabIndex = 13;
            this.gp_fechas.TabStop = false;
            this.gp_fechas.Text = "Fechas";
            // 
            // lbl_fin
            // 
            this.lbl_fin.AutoSize = true;
            this.lbl_fin.Location = new System.Drawing.Point(6, 99);
            this.lbl_fin.Name = "lbl_fin";
            this.lbl_fin.Size = new System.Drawing.Size(21, 13);
            this.lbl_fin.TabIndex = 14;
            this.lbl_fin.Text = "Fin";
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.Location = new System.Drawing.Point(6, 60);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(32, 13);
            this.lbl_inicio.TabIndex = 13;
            this.lbl_inicio.Text = "Inicio";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(6, 26);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(63, 13);
            this.lbl_fecha.TabIndex = 12;
            this.lbl_fecha.Text = "Seleccionar";
            // 
            // ReportUsuarioCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 625);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.gp_cursos);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gp_usuarios);
            this.Controls.Add(this.gp_fechas);
            this.Name = "ReportUsuarioCurso";
            this.Text = "ReportUsuarioCurso";
            this.Load += new System.EventHandler(this.ReportUsuarioCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioxCursoCustomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.gp_usuarios.ResumeLayout(false);
            this.gp_usuarios.PerformLayout();
            this.gp_cursos.ResumeLayout(false);
            this.gp_cursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_curso)).EndInit();
            this.gp_fechas.ResumeLayout(false);
            this.gp_fechas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource usuarioxCursoCustomBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.GroupBox gp_usuarios;
        private System.Windows.Forms.TextBox txt_FiltroUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Label lbl_seleccionar;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.DateTimePicker dtp_fin;
        private System.Windows.Forms.TextBox txt_param;
        private System.Windows.Forms.GroupBox gp_cursos;
        private System.Windows.Forms.DataGridView dgv_curso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FiltroCurso;
        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox gp_fechas;
        private System.Windows.Forms.Label lbl_fin;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.Label lbl_fecha;
    }
}