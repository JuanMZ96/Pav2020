namespace Pav2.Presentacion
{
    partial class AltaUsuariosxCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaUsuariosxCurso));
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Observaciones = new System.Windows.Forms.Label();
            this.lbl_Puntuación = new System.Windows.Forms.Label();
            this.lbl_Curso = new System.Windows.Forms.Label();
            this.lbl_FechaFin = new System.Windows.Forms.Label();
            this.lbl_FechaInicio = new System.Windows.Forms.Label();
            this.txt_Observaciones = new System.Windows.Forms.TextBox();
            this.txt_Puntuacion = new System.Windows.Forms.TextBox();
            this.dtp_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.cmb_Usuario = new System.Windows.Forms.ComboBox();
            this.cmb_Curso = new System.Windows.Forms.ComboBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Gestionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(43, 56);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(46, 13);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // lbl_Observaciones
            // 
            this.lbl_Observaciones.AutoSize = true;
            this.lbl_Observaciones.Location = new System.Drawing.Point(43, 169);
            this.lbl_Observaciones.Name = "lbl_Observaciones";
            this.lbl_Observaciones.Size = new System.Drawing.Size(81, 13);
            this.lbl_Observaciones.TabIndex = 1;
            this.lbl_Observaciones.Text = "Observaciones:";
            // 
            // lbl_Puntuación
            // 
            this.lbl_Puntuación.AutoSize = true;
            this.lbl_Puntuación.Location = new System.Drawing.Point(43, 132);
            this.lbl_Puntuación.Name = "lbl_Puntuación";
            this.lbl_Puntuación.Size = new System.Drawing.Size(64, 13);
            this.lbl_Puntuación.TabIndex = 2;
            this.lbl_Puntuación.Text = "Puntuación:";
            // 
            // lbl_Curso
            // 
            this.lbl_Curso.AutoSize = true;
            this.lbl_Curso.Location = new System.Drawing.Point(43, 94);
            this.lbl_Curso.Name = "lbl_Curso";
            this.lbl_Curso.Size = new System.Drawing.Size(37, 13);
            this.lbl_Curso.TabIndex = 3;
            this.lbl_Curso.Text = "Curso:";
            // 
            // lbl_FechaFin
            // 
            this.lbl_FechaFin.AutoSize = true;
            this.lbl_FechaFin.Location = new System.Drawing.Point(305, 95);
            this.lbl_FechaFin.Name = "lbl_FechaFin";
            this.lbl_FechaFin.Size = new System.Drawing.Size(69, 13);
            this.lbl_FechaFin.TabIndex = 4;
            this.lbl_FechaFin.Text = "Fecha de fin:";
            // 
            // lbl_FechaInicio
            // 
            this.lbl_FechaInicio.AutoSize = true;
            this.lbl_FechaInicio.Location = new System.Drawing.Point(305, 56);
            this.lbl_FechaInicio.Name = "lbl_FechaInicio";
            this.lbl_FechaInicio.Size = new System.Drawing.Size(82, 13);
            this.lbl_FechaInicio.TabIndex = 5;
            this.lbl_FechaInicio.Text = "Fecha de inicio:";
            // 
            // txt_Observaciones
            // 
            this.txt_Observaciones.Location = new System.Drawing.Point(130, 166);
            this.txt_Observaciones.MaxLength = 150;
            this.txt_Observaciones.Multiline = true;
            this.txt_Observaciones.Name = "txt_Observaciones";
            this.txt_Observaciones.Size = new System.Drawing.Size(139, 74);
            this.txt_Observaciones.TabIndex = 6;
            // 
            // txt_Puntuacion
            // 
            this.txt_Puntuacion.Location = new System.Drawing.Point(116, 129);
            this.txt_Puntuacion.Name = "txt_Puntuacion";
            this.txt_Puntuacion.Size = new System.Drawing.Size(153, 20);
            this.txt_Puntuacion.TabIndex = 7;
            // 
            // dtp_FechaInicio
            // 
            this.dtp_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaInicio.Location = new System.Drawing.Point(393, 53);
            this.dtp_FechaInicio.Name = "dtp_FechaInicio";
            this.dtp_FechaInicio.Size = new System.Drawing.Size(109, 20);
            this.dtp_FechaInicio.TabIndex = 8;
            // 
            // dtp_FechaFin
            // 
            this.dtp_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaFin.Location = new System.Drawing.Point(393, 92);
            this.dtp_FechaFin.Name = "dtp_FechaFin";
            this.dtp_FechaFin.Size = new System.Drawing.Size(109, 20);
            this.dtp_FechaFin.TabIndex = 9;
            // 
            // cmb_Usuario
            // 
            this.cmb_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Usuario.FormattingEnabled = true;
            this.cmb_Usuario.Location = new System.Drawing.Point(95, 53);
            this.cmb_Usuario.Name = "cmb_Usuario";
            this.cmb_Usuario.Size = new System.Drawing.Size(174, 21);
            this.cmb_Usuario.TabIndex = 10;
            // 
            // cmb_Curso
            // 
            this.cmb_Curso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Curso.FormattingEnabled = true;
            this.cmb_Curso.Location = new System.Drawing.Point(95, 91);
            this.cmb_Curso.Name = "cmb_Curso";
            this.cmb_Curso.Size = new System.Drawing.Size(174, 21);
            this.cmb_Curso.TabIndex = 11;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(194, 271);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 12;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Gestionar
            // 
            this.btn_Gestionar.Location = new System.Drawing.Point(299, 271);
            this.btn_Gestionar.Name = "btn_Gestionar";
            this.btn_Gestionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Gestionar.TabIndex = 13;
            this.btn_Gestionar.Text = "Gestionar";
            this.btn_Gestionar.UseVisualStyleBackColor = true;
            this.btn_Gestionar.Click += new System.EventHandler(this.btn_Gestionar_Click);
            // 
            // AltaUsuariosxCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(568, 338);
            this.Controls.Add(this.btn_Gestionar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.cmb_Curso);
            this.Controls.Add(this.cmb_Usuario);
            this.Controls.Add(this.dtp_FechaFin);
            this.Controls.Add(this.dtp_FechaInicio);
            this.Controls.Add(this.txt_Puntuacion);
            this.Controls.Add(this.txt_Observaciones);
            this.Controls.Add(this.lbl_FechaInicio);
            this.Controls.Add(this.lbl_FechaFin);
            this.Controls.Add(this.lbl_Curso);
            this.Controls.Add(this.lbl_Puntuación);
            this.Controls.Add(this.lbl_Observaciones);
            this.Controls.Add(this.lbl_Usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaUsuariosxCurso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Usuario por Curso";
            this.Load += new System.EventHandler(this.AltaUsuariosxCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Observaciones;
        private System.Windows.Forms.Label lbl_Puntuación;
        private System.Windows.Forms.Label lbl_Curso;
        private System.Windows.Forms.Label lbl_FechaFin;
        private System.Windows.Forms.Label lbl_FechaInicio;
        private System.Windows.Forms.TextBox txt_Observaciones;
        private System.Windows.Forms.TextBox txt_Puntuacion;
        private System.Windows.Forms.DateTimePicker dtp_FechaInicio;
        private System.Windows.Forms.DateTimePicker dtp_FechaFin;
        private System.Windows.Forms.ComboBox cmb_Usuario;
        private System.Windows.Forms.ComboBox cmb_Curso;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Gestionar;
    }
}