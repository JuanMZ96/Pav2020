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
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.usuario1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_cursos = new System.Windows.Forms.DataGridView();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_porcentaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_curso = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cursos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(6, 35);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(142, 20);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario1});
            this.dgv_usuarios.Location = new System.Drawing.Point(6, 61);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.Size = new System.Drawing.Size(148, 201);
            this.dgv_usuarios.TabIndex = 3;
            this.dgv_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellClick);
            // 
            // usuario1
            // 
            this.usuario1.DataPropertyName = "Usuario1";
            this.usuario1.HeaderText = "Nombre";
            this.usuario1.Name = "usuario1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar Usuarios:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgv_cursos
            // 
            this.dgv_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cursos.Location = new System.Drawing.Point(160, 64);
            this.dgv_cursos.Name = "dgv_cursos";
            this.dgv_cursos.Size = new System.Drawing.Size(233, 201);
            this.dgv_cursos.TabIndex = 5;
            this.dgv_cursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cursos_CellClick);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(713, 61);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_porcentaje
            // 
            this.txt_porcentaje.Location = new System.Drawing.Point(476, 61);
            this.txt_porcentaje.Name = "txt_porcentaje";
            this.txt_porcentaje.Size = new System.Drawing.Size(100, 20);
            this.txt_porcentaje.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Porcentaje";
            // 
            // txt_curso
            // 
            this.txt_curso.Enabled = false;
            this.txt_curso.Location = new System.Drawing.Point(160, 184);
            this.txt_curso.Name = "txt_curso";
            this.txt_curso.Size = new System.Drawing.Size(64, 20);
            this.txt_curso.TabIndex = 12;
            this.txt_curso.Visible = false;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Enabled = false;
            this.txt_usuario.Location = new System.Drawing.Point(160, 158);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(64, 20);
            this.txt_usuario.TabIndex = 14;
            this.txt_usuario.Visible = false;
            // 
            // dtp_fin
            // 
            this.dtp_fin.Enabled = false;
            this.dtp_fin.Location = new System.Drawing.Point(230, 158);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(77, 20);
            this.dtp_fin.TabIndex = 15;
            this.dtp_fin.Visible = false;
            // 
            // AltaUsuarioxCursoAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_cursos);
            this.Controls.Add(this.dtp_fin);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_curso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_porcentaje);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.txtFiltro);
            this.Name = "AltaUsuarioxCursoAvance";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario1;
        private System.Windows.Forms.DataGridView dgv_cursos;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_porcentaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_curso;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.DateTimePicker dtp_fin;
    }
}