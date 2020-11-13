namespace Pav2.Presentacion
{
    partial class GestionObjetivoxCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionObjetivoxCurso));
            this.dgv_ObjetivosxCurso = new System.Windows.Forms.DataGridView();
            this.cmb_cursos = new System.Windows.Forms.ComboBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.chk_IncluirBorrados = new System.Windows.Forms.CheckBox();
            this.txt_puntaje = new System.Windows.Forms.TextBox();
            this.cmb_objetivos = new System.Windows.Forms.ComboBox();
            this.chk_borrado = new System.Windows.Forms.CheckBox();
            this.lbl_cursos = new System.Windows.Forms.Label();
            this.lbl_objetivos = new System.Windows.Forms.Label();
            this.lbl_puntaje = new System.Windows.Forms.Label();
            this.btn_habilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ObjetivosxCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ObjetivosxCurso
            // 
            this.dgv_ObjetivosxCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ObjetivosxCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ObjetivosxCurso.Location = new System.Drawing.Point(12, 78);
            this.dgv_ObjetivosxCurso.Name = "dgv_ObjetivosxCurso";
            this.dgv_ObjetivosxCurso.Size = new System.Drawing.Size(568, 321);
            this.dgv_ObjetivosxCurso.TabIndex = 0;
            this.dgv_ObjetivosxCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ObjetivosxCurso_CellClick);
            // 
            // cmb_cursos
            // 
            this.cmb_cursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cursos.FormattingEnabled = true;
            this.cmb_cursos.Items.AddRange(new object[] {
            "-"});
            this.cmb_cursos.Location = new System.Drawing.Point(15, 34);
            this.cmb_cursos.Name = "cmb_cursos";
            this.cmb_cursos.Size = new System.Drawing.Size(121, 21);
            this.cmb_cursos.TabIndex = 1;
            this.cmb_cursos.SelectedValueChanged += new System.EventHandler(this.cmb_cursos_ValueMemberChanged);
            this.cmb_cursos.Click += new System.EventHandler(this.cmb_cursos_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(438, 8);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(438, 51);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // chk_IncluirBorrados
            // 
            this.chk_IncluirBorrados.AutoSize = true;
            this.chk_IncluirBorrados.Enabled = false;
            this.chk_IncluirBorrados.Location = new System.Drawing.Point(15, 405);
            this.chk_IncluirBorrados.Name = "chk_IncluirBorrados";
            this.chk_IncluirBorrados.Size = new System.Drawing.Size(99, 17);
            this.chk_IncluirBorrados.TabIndex = 5;
            this.chk_IncluirBorrados.Text = "Incluir Borrados";
            this.chk_IncluirBorrados.UseVisualStyleBackColor = true;
            this.chk_IncluirBorrados.CheckedChanged += new System.EventHandler(this.chk_borrado_CheckedChanged);
            // 
            // txt_puntaje
            // 
            this.txt_puntaje.Location = new System.Drawing.Point(310, 34);
            this.txt_puntaje.Name = "txt_puntaje";
            this.txt_puntaje.Size = new System.Drawing.Size(121, 20);
            this.txt_puntaje.TabIndex = 6;
            // 
            // cmb_objetivos
            // 
            this.cmb_objetivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_objetivos.Enabled = false;
            this.cmb_objetivos.FormattingEnabled = true;
            this.cmb_objetivos.Items.AddRange(new object[] {
            "-"});
            this.cmb_objetivos.Location = new System.Drawing.Point(155, 34);
            this.cmb_objetivos.Name = "cmb_objetivos";
            this.cmb_objetivos.Size = new System.Drawing.Size(121, 21);
            this.cmb_objetivos.TabIndex = 2;
            // 
            // chk_borrado
            // 
            this.chk_borrado.AutoSize = true;
            this.chk_borrado.Location = new System.Drawing.Point(519, 57);
            this.chk_borrado.Name = "chk_borrado";
            this.chk_borrado.Size = new System.Drawing.Size(69, 17);
            this.chk_borrado.TabIndex = 8;
            this.chk_borrado.Text = "BorrarDB";
            this.chk_borrado.UseVisualStyleBackColor = true;
            // 
            // lbl_cursos
            // 
            this.lbl_cursos.AutoSize = true;
            this.lbl_cursos.Location = new System.Drawing.Point(12, 18);
            this.lbl_cursos.Name = "lbl_cursos";
            this.lbl_cursos.Size = new System.Drawing.Size(42, 13);
            this.lbl_cursos.TabIndex = 9;
            this.lbl_cursos.Text = "Cursos:";
            // 
            // lbl_objetivos
            // 
            this.lbl_objetivos.AutoSize = true;
            this.lbl_objetivos.Location = new System.Drawing.Point(152, 18);
            this.lbl_objetivos.Name = "lbl_objetivos";
            this.lbl_objetivos.Size = new System.Drawing.Size(54, 13);
            this.lbl_objetivos.TabIndex = 10;
            this.lbl_objetivos.Text = "Objetivos:";
            // 
            // lbl_puntaje
            // 
            this.lbl_puntaje.AutoSize = true;
            this.lbl_puntaje.Location = new System.Drawing.Point(307, 18);
            this.lbl_puntaje.Name = "lbl_puntaje";
            this.lbl_puntaje.Size = new System.Drawing.Size(46, 13);
            this.lbl_puntaje.TabIndex = 11;
            this.lbl_puntaje.Text = "Puntaje:";
            // 
            // btn_habilitar
            // 
            this.btn_habilitar.Location = new System.Drawing.Point(395, 405);
            this.btn_habilitar.Name = "btn_habilitar";
            this.btn_habilitar.Size = new System.Drawing.Size(75, 23);
            this.btn_habilitar.TabIndex = 12;
            this.btn_habilitar.TabStop = false;
            this.btn_habilitar.Text = "Habilitar ";
            this.btn_habilitar.UseVisualStyleBackColor = true;
            this.btn_habilitar.Visible = false;
            this.btn_habilitar.Click += new System.EventHandler(this.btn_habilitar_Click);
            // 
            // GestionObjetivoxCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.btn_habilitar);
            this.Controls.Add(this.lbl_puntaje);
            this.Controls.Add(this.lbl_objetivos);
            this.Controls.Add(this.lbl_cursos);
            this.Controls.Add(this.chk_borrado);
            this.Controls.Add(this.txt_puntaje);
            this.Controls.Add(this.chk_IncluirBorrados);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.cmb_objetivos);
            this.Controls.Add(this.cmb_cursos);
            this.Controls.Add(this.dgv_ObjetivosxCurso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionObjetivoxCurso";
            this.Text = "Gestion de Objetivo por Curso";
            this.Load += new System.EventHandler(this.GestionObjetivoxCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ObjetivosxCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ObjetivosxCurso;
        private System.Windows.Forms.ComboBox cmb_cursos;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.CheckBox chk_IncluirBorrados;
        private System.Windows.Forms.TextBox txt_puntaje;
        private System.Windows.Forms.ComboBox cmb_objetivos;
        private System.Windows.Forms.CheckBox chk_borrado;
        private System.Windows.Forms.Label lbl_cursos;
        private System.Windows.Forms.Label lbl_objetivos;
        private System.Windows.Forms.Label lbl_puntaje;
        private System.Windows.Forms.Button btn_habilitar;
    }
}