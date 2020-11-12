namespace Pav2.Presentacion
{
    partial class GestionUsuarioxCurso
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
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.dtp_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.dgv_UsuarioCurso = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbl_curso = new System.Windows.Forms.Label();
            this.lbl_observaciones = new System.Windows.Forms.Label();
            this.lbl_FechaInicio = new System.Windows.Forms.Label();
            this.lbl_puntuacion = new System.Windows.Forms.Label();
            this.lbl_FechaFin = new System.Windows.Forms.Label();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.txt_puntuacion = new System.Windows.Forms.TextBox();
            this.dtp_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.cmb_Usuario = new System.Windows.Forms.ComboBox();
            this.cmb_Curso = new System.Windows.Forms.ComboBox();
            this.chk_IncluirBorrados = new System.Windows.Forms.CheckBox();
            this.chk_BorrarDB = new System.Windows.Forms.CheckBox();
            this.btn_habilitar = new System.Windows.Forms.Button();
            this.cmb_TipoBusqueda = new System.Windows.Forms.ComboBox();
            this.lbl_tipoBusqueda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsuarioCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(178, 352);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 0;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(3, 64);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(46, 13);
            this.lbl_usuario.TabIndex = 1;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // dtp_FechaFin
            // 
            this.dtp_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaFin.Location = new System.Drawing.Point(36, 322);
            this.dtp_FechaFin.Name = "dtp_FechaFin";
            this.dtp_FechaFin.Size = new System.Drawing.Size(100, 20);
            this.dtp_FechaFin.TabIndex = 3;
            // 
            // dgv_UsuarioCurso
            // 
            this.dgv_UsuarioCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UsuarioCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UsuarioCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgv_UsuarioCurso.Location = new System.Drawing.Point(178, 21);
            this.dgv_UsuarioCurso.Name = "dgv_UsuarioCurso";
            this.dgv_UsuarioCurso.Size = new System.Drawing.Size(562, 309);
            this.dgv_UsuarioCurso.TabIndex = 4;
            this.dgv_UsuarioCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UsuarioCurso_CellContentClick);
            this.dgv_UsuarioCurso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UsuarioCurso_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "usuario";
            this.Column1.HeaderText = "Usuario";
            this.Column1.Name = "Column1";
            this.Column1.Width = 68;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "nombre";
            this.Column2.HeaderText = "Curso";
            this.Column2.Name = "Column2";
            this.Column2.Width = 59;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "puntuacion";
            this.Column3.HeaderText = "Puntuación ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "observaciones";
            this.Column4.HeaderText = "Observaciones";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "fecha_inicio";
            this.Column5.HeaderText = "Fecha inicio";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "fecha_fin";
            this.Column6.HeaderText = "Fecha fin";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column7.DataPropertyName = "borrado";
            this.Column7.HeaderText = "Borrado";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column7.Visible = false;
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Location = new System.Drawing.Point(3, 104);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(37, 13);
            this.lbl_curso.TabIndex = 5;
            this.lbl_curso.Text = "Curso:";
            // 
            // lbl_observaciones
            // 
            this.lbl_observaciones.AutoSize = true;
            this.lbl_observaciones.Location = new System.Drawing.Point(3, 183);
            this.lbl_observaciones.Name = "lbl_observaciones";
            this.lbl_observaciones.Size = new System.Drawing.Size(81, 13);
            this.lbl_observaciones.TabIndex = 6;
            this.lbl_observaciones.Text = "Observaciones:";
            // 
            // lbl_FechaInicio
            // 
            this.lbl_FechaInicio.AutoSize = true;
            this.lbl_FechaInicio.Location = new System.Drawing.Point(3, 252);
            this.lbl_FechaInicio.Name = "lbl_FechaInicio";
            this.lbl_FechaInicio.Size = new System.Drawing.Size(68, 13);
            this.lbl_FechaInicio.TabIndex = 7;
            this.lbl_FechaInicio.Text = "Fecha Inicio:";
            // 
            // lbl_puntuacion
            // 
            this.lbl_puntuacion.AutoSize = true;
            this.lbl_puntuacion.Location = new System.Drawing.Point(3, 144);
            this.lbl_puntuacion.Name = "lbl_puntuacion";
            this.lbl_puntuacion.Size = new System.Drawing.Size(64, 13);
            this.lbl_puntuacion.TabIndex = 8;
            this.lbl_puntuacion.Text = "Puntuación:";
            // 
            // lbl_FechaFin
            // 
            this.lbl_FechaFin.AutoSize = true;
            this.lbl_FechaFin.Location = new System.Drawing.Point(3, 306);
            this.lbl_FechaFin.Name = "lbl_FechaFin";
            this.lbl_FechaFin.Size = new System.Drawing.Size(57, 13);
            this.lbl_FechaFin.TabIndex = 9;
            this.lbl_FechaFin.Text = "Fecha Fin:";
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.Location = new System.Drawing.Point(36, 203);
            this.txt_observaciones.MaxLength = 150;
            this.txt_observaciones.Multiline = true;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(121, 45);
            this.txt_observaciones.TabIndex = 10;
            // 
            // txt_puntuacion
            // 
            this.txt_puntuacion.Location = new System.Drawing.Point(36, 160);
            this.txt_puntuacion.MaxLength = 5;
            this.txt_puntuacion.Name = "txt_puntuacion";
            this.txt_puntuacion.Size = new System.Drawing.Size(121, 20);
            this.txt_puntuacion.TabIndex = 11;
            // 
            // dtp_FechaInicio
            // 
            this.dtp_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaInicio.Location = new System.Drawing.Point(36, 268);
            this.dtp_FechaInicio.Name = "dtp_FechaInicio";
            this.dtp_FechaInicio.Size = new System.Drawing.Size(100, 20);
            this.dtp_FechaInicio.TabIndex = 13;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(281, 352);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 14;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // cmb_Usuario
            // 
            this.cmb_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Usuario.FormattingEnabled = true;
            this.cmb_Usuario.Location = new System.Drawing.Point(36, 80);
            this.cmb_Usuario.Name = "cmb_Usuario";
            this.cmb_Usuario.Size = new System.Drawing.Size(121, 21);
            this.cmb_Usuario.TabIndex = 15;
            this.cmb_Usuario.SelectedValueChanged += new System.EventHandler(this.cmb_Usuario_SelectedIndexChanged);
            // 
            // cmb_Curso
            // 
            this.cmb_Curso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Curso.FormattingEnabled = true;
            this.cmb_Curso.Location = new System.Drawing.Point(36, 120);
            this.cmb_Curso.Name = "cmb_Curso";
            this.cmb_Curso.Size = new System.Drawing.Size(121, 21);
            this.cmb_Curso.TabIndex = 16;
            this.cmb_Curso.SelectedValueChanged += new System.EventHandler(this.cmb_Curso_SelectedValueChanged);
            // 
            // chk_IncluirBorrados
            // 
            this.chk_IncluirBorrados.AutoSize = true;
            this.chk_IncluirBorrados.Location = new System.Drawing.Point(639, 352);
            this.chk_IncluirBorrados.Name = "chk_IncluirBorrados";
            this.chk_IncluirBorrados.Size = new System.Drawing.Size(101, 17);
            this.chk_IncluirBorrados.TabIndex = 17;
            this.chk_IncluirBorrados.Text = "Incluir borrados.";
            this.chk_IncluirBorrados.UseVisualStyleBackColor = true;
            this.chk_IncluirBorrados.CheckedChanged += new System.EventHandler(this.chk_IncluirBorrados_CheckedChanged);
            // 
            // chk_BorrarDB
            // 
            this.chk_BorrarDB.AutoSize = true;
            this.chk_BorrarDB.Location = new System.Drawing.Point(281, 383);
            this.chk_BorrarDB.Name = "chk_BorrarDB";
            this.chk_BorrarDB.Size = new System.Drawing.Size(72, 17);
            this.chk_BorrarDB.TabIndex = 18;
            this.chk_BorrarDB.Text = "Borrar DB";
            this.chk_BorrarDB.UseVisualStyleBackColor = true;
            this.chk_BorrarDB.Visible = false;
            // 
            // btn_habilitar
            // 
            this.btn_habilitar.Location = new System.Drawing.Point(390, 352);
            this.btn_habilitar.Name = "btn_habilitar";
            this.btn_habilitar.Size = new System.Drawing.Size(75, 23);
            this.btn_habilitar.TabIndex = 19;
            this.btn_habilitar.Text = "Habilitar";
            this.btn_habilitar.UseVisualStyleBackColor = true;
            this.btn_habilitar.Visible = false;
            this.btn_habilitar.Click += new System.EventHandler(this.btn_habilitar_Click);
            // 
            // cmb_TipoBusqueda
            // 
            this.cmb_TipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoBusqueda.FormattingEnabled = true;
            this.cmb_TipoBusqueda.Location = new System.Drawing.Point(36, 30);
            this.cmb_TipoBusqueda.Name = "cmb_TipoBusqueda";
            this.cmb_TipoBusqueda.Size = new System.Drawing.Size(121, 21);
            this.cmb_TipoBusqueda.TabIndex = 20;
            this.cmb_TipoBusqueda.SelectedValueChanged += new System.EventHandler(this.cmb_TipoBusqueda_SelectedValueChanged);
            // 
            // lbl_tipoBusqueda
            // 
            this.lbl_tipoBusqueda.AutoSize = true;
            this.lbl_tipoBusqueda.Location = new System.Drawing.Point(3, 9);
            this.lbl_tipoBusqueda.Name = "lbl_tipoBusqueda";
            this.lbl_tipoBusqueda.Size = new System.Drawing.Size(116, 13);
            this.lbl_tipoBusqueda.TabIndex = 21;
            this.lbl_tipoBusqueda.Text = "Realizar busqueda por:";
            // 
            // GestionUsuarioxCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 404);
            this.Controls.Add(this.lbl_tipoBusqueda);
            this.Controls.Add(this.cmb_TipoBusqueda);
            this.Controls.Add(this.btn_habilitar);
            this.Controls.Add(this.chk_BorrarDB);
            this.Controls.Add(this.chk_IncluirBorrados);
            this.Controls.Add(this.cmb_Curso);
            this.Controls.Add(this.cmb_Usuario);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.dtp_FechaInicio);
            this.Controls.Add(this.txt_puntuacion);
            this.Controls.Add(this.txt_observaciones);
            this.Controls.Add(this.lbl_FechaFin);
            this.Controls.Add(this.lbl_puntuacion);
            this.Controls.Add(this.lbl_FechaInicio);
            this.Controls.Add(this.lbl_observaciones);
            this.Controls.Add(this.lbl_curso);
            this.Controls.Add(this.dgv_UsuarioCurso);
            this.Controls.Add(this.dtp_FechaFin);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.btn_Modificar);
            this.Name = "GestionUsuarioxCurso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de usuario por curso";
            this.Load += new System.EventHandler(this.GestionUsuarioxCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsuarioCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.DateTimePicker dtp_FechaFin;
        private System.Windows.Forms.DataGridView dgv_UsuarioCurso;
        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.Label lbl_observaciones;
        private System.Windows.Forms.Label lbl_FechaInicio;
        private System.Windows.Forms.Label lbl_puntuacion;
        private System.Windows.Forms.Label lbl_FechaFin;
        private System.Windows.Forms.TextBox txt_observaciones;
        private System.Windows.Forms.TextBox txt_puntuacion;
        private System.Windows.Forms.DateTimePicker dtp_FechaInicio;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.ComboBox cmb_Usuario;
        private System.Windows.Forms.ComboBox cmb_Curso;
        private System.Windows.Forms.CheckBox chk_IncluirBorrados;
        private System.Windows.Forms.CheckBox chk_BorrarDB;
        private System.Windows.Forms.Button btn_habilitar;
        private System.Windows.Forms.ComboBox cmb_TipoBusqueda;
        private System.Windows.Forms.Label lbl_tipoBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
    }
}