namespace Pav2.Presentacion
{
    partial class AltaUsuarioxCursoAvance
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
            this.txt_Filtro = new System.Windows.Forms.TextBox();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.usuario1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_buscarUsuario = new System.Windows.Forms.Label();
            this.dgv_cursos = new System.Windows.Forms.DataGridView();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_porcentaje = new System.Windows.Forms.Label();
            this.txt_curso = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.txt_porcentaje = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cargarProgresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProgresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_avanceCurso = new System.Windows.Forms.DataGridView();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_cursos = new System.Windows.Forms.ComboBox();
            this.lbl_seleccionarCurso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cursos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_avanceCurso)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.Location = new System.Drawing.Point(10, 38);
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(142, 20);
            this.txt_Filtro.TabIndex = 1;
            this.txt_Filtro.Visible = false;
            this.txt_Filtro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario1});
            this.dgv_usuarios.Location = new System.Drawing.Point(12, 63);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.Size = new System.Drawing.Size(148, 201);
            this.dgv_usuarios.TabIndex = 3;
            this.dgv_usuarios.Visible = false;
            this.dgv_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellClick);
           
            // 
            // usuario1
            // 
            this.usuario1.DataPropertyName = "Usuario1";
            this.usuario1.HeaderText = "Nombre";
            this.usuario1.Name = "usuario1";
            this.usuario1.ReadOnly = true;
            // 
            // lbl_buscarUsuario
            // 
            this.lbl_buscarUsuario.AutoSize = true;
            this.lbl_buscarUsuario.Location = new System.Drawing.Point(16, 22);
            this.lbl_buscarUsuario.Name = "lbl_buscarUsuario";
            this.lbl_buscarUsuario.Size = new System.Drawing.Size(87, 13);
            this.lbl_buscarUsuario.TabIndex = 4;
            this.lbl_buscarUsuario.Text = "Buscar Usuarios:";
            this.lbl_buscarUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_buscarUsuario.Visible = false;
            // 
            // dgv_cursos
            // 
            this.dgv_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cursos.Location = new System.Drawing.Point(166, 63);
            this.dgv_cursos.Name = "dgv_cursos";
            this.dgv_cursos.ReadOnly = true;
            this.dgv_cursos.Size = new System.Drawing.Size(324, 201);
            this.dgv_cursos.TabIndex = 5;
            this.dgv_cursos.Visible = false;
            this.dgv_cursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cursos_CellClick);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(415, 33);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Visible = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_porcentaje
            // 
            this.lbl_porcentaje.AutoSize = true;
            this.lbl_porcentaje.Location = new System.Drawing.Point(293, 36);
            this.lbl_porcentaje.Name = "lbl_porcentaje";
            this.lbl_porcentaje.Size = new System.Drawing.Size(58, 13);
            this.lbl_porcentaje.TabIndex = 8;
            this.lbl_porcentaje.Text = "Porcentaje";
            this.lbl_porcentaje.Visible = false;
            // 
            // txt_curso
            // 
            this.txt_curso.Enabled = false;
            this.txt_curso.Location = new System.Drawing.Point(19, 241);
            this.txt_curso.Name = "txt_curso";
            this.txt_curso.Size = new System.Drawing.Size(64, 20);
            this.txt_curso.TabIndex = 12;
            this.txt_curso.Visible = false;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Enabled = false;
            this.txt_usuario.Location = new System.Drawing.Point(19, 215);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(64, 20);
            this.txt_usuario.TabIndex = 14;
            this.txt_usuario.Visible = false;
            // 
            // dtp_fin
            // 
            this.dtp_fin.Enabled = false;
            this.dtp_fin.Location = new System.Drawing.Point(89, 215);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(68, 20);
            this.dtp_fin.TabIndex = 15;
            this.dtp_fin.Visible = false;
            // 
            // txt_porcentaje
            // 
            this.txt_porcentaje.Location = new System.Drawing.Point(357, 33);
            this.txt_porcentaje.Mask = "999";
            this.txt_porcentaje.Name = "txt_porcentaje";
            this.txt_porcentaje.Size = new System.Drawing.Size(24, 20);
            this.txt_porcentaje.TabIndex = 16;
            this.txt_porcentaje.ValidatingType = typeof(int);
            this.txt_porcentaje.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarProgresoToolStripMenuItem,
            this.modificarProgresoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cargarProgresoToolStripMenuItem
            // 
            this.cargarProgresoToolStripMenuItem.Name = "cargarProgresoToolStripMenuItem";
            this.cargarProgresoToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.cargarProgresoToolStripMenuItem.Text = "Cargar Progreso";
            this.cargarProgresoToolStripMenuItem.Click += new System.EventHandler(this.cargarProgresoToolStripMenuItem_Click);
            // 
            // modificarProgresoToolStripMenuItem
            // 
            this.modificarProgresoToolStripMenuItem.Name = "modificarProgresoToolStripMenuItem";
            this.modificarProgresoToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.modificarProgresoToolStripMenuItem.Text = "Modificar Progreso";
            this.modificarProgresoToolStripMenuItem.Click += new System.EventHandler(this.modificarProgresoToolStripMenuItem_Click_1);
            // 
            // dgv_avanceCurso
            // 
            this.dgv_avanceCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_avanceCurso.Location = new System.Drawing.Point(166, 63);
            this.dgv_avanceCurso.Name = "dgv_avanceCurso";
            this.dgv_avanceCurso.ReadOnly = true;
            this.dgv_avanceCurso.Size = new System.Drawing.Size(324, 201);
            this.dgv_avanceCurso.TabIndex = 18;
            this.dgv_avanceCurso.Visible = false;
            this.dgv_avanceCurso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_avanceCurso_CellContentClick);
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Enabled = false;
            this.dtp_inicio.Location = new System.Drawing.Point(89, 241);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(68, 20);
            this.dtp_inicio.TabIndex = 19;
            this.dtp_inicio.Visible = false;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(415, 33);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 20;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Visible = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_usuarios);
            this.groupBox1.Controls.Add(this.cmb_cursos);
            this.groupBox1.Controls.Add(this.lbl_seleccionarCurso);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Controls.Add(this.txt_curso);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Controls.Add(this.dtp_fin);
            this.groupBox1.Controls.Add(this.txt_porcentaje);
            this.groupBox1.Controls.Add(this.dtp_inicio);
            this.groupBox1.Controls.Add(this.lbl_buscarUsuario);
            this.groupBox1.Controls.Add(this.dgv_cursos);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.dgv_avanceCurso);
            this.groupBox1.Controls.Add(this.lbl_porcentaje);
            this.groupBox1.Controls.Add(this.txt_Filtro);
            this.groupBox1.Location = new System.Drawing.Point(9, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 297);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // cmb_cursos
            // 
            this.cmb_cursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cursos.FormattingEnabled = true;
            this.cmb_cursos.Location = new System.Drawing.Point(166, 36);
            this.cmb_cursos.Name = "cmb_cursos";
            this.cmb_cursos.Size = new System.Drawing.Size(121, 21);
            this.cmb_cursos.TabIndex = 22;
            this.cmb_cursos.Visible = false;
            this.cmb_cursos.SelectedIndexChanged += new System.EventHandler(this.cmb_cursos_SelectedIndexChanged);
            // 
            // lbl_seleccionarCurso
            // 
            this.lbl_seleccionarCurso.AutoSize = true;
            this.lbl_seleccionarCurso.Location = new System.Drawing.Point(163, 22);
            this.lbl_seleccionarCurso.Name = "lbl_seleccionarCurso";
            this.lbl_seleccionarCurso.Size = new System.Drawing.Size(93, 13);
            this.lbl_seleccionarCurso.TabIndex = 21;
            this.lbl_seleccionarCurso.Text = "Seleccionar Curso";
            this.lbl_seleccionarCurso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_seleccionarCurso.Visible = false;
            // 
            // AltaUsuarioxCursoAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 392);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AltaUsuarioxCursoAvance";
            this.Text = "Progreso de Curso";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cursos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_avanceCurso)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Filtro;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Label lbl_buscarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario1;
        private System.Windows.Forms.DataGridView dgv_cursos;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_porcentaje;
        private System.Windows.Forms.TextBox txt_curso;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.DateTimePicker dtp_fin;
        private System.Windows.Forms.MaskedTextBox txt_porcentaje;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cargarProgresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProgresoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_avanceCurso;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_cursos;
        private System.Windows.Forms.Label lbl_seleccionarCurso;
    }
}