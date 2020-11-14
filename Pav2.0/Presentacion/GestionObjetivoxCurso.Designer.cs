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
            this.chk_IncluirBorrados = new System.Windows.Forms.CheckBox();
            this.txt_puntaje = new System.Windows.Forms.TextBox();
            this.cmb_objetivos = new System.Windows.Forms.ComboBox();
            this.chk_borrado = new System.Windows.Forms.CheckBox();
            this.lbl_cursos = new System.Windows.Forms.Label();
            this.lbl_objetivos = new System.Windows.Forms.Label();
            this.lbl_puntaje = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_eliminar = new System.Windows.Forms.Label();
            this.lbl_modificar = new System.Windows.Forms.Label();
            this.lbl_habilitar = new System.Windows.Forms.Label();
            this.btn_habilitar = new System.Windows.Forms.PictureBox();
            this.btn_modificar = new System.Windows.Forms.PictureBox();
            this.btn_eliminar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ObjetivosxCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_habilitar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_modificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ObjetivosxCurso
            // 
            this.dgv_ObjetivosxCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ObjetivosxCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ObjetivosxCurso.Location = new System.Drawing.Point(46, 57);
            this.dgv_ObjetivosxCurso.Name = "dgv_ObjetivosxCurso";
            this.dgv_ObjetivosxCurso.Size = new System.Drawing.Size(542, 321);
            this.dgv_ObjetivosxCurso.TabIndex = 0;
            this.dgv_ObjetivosxCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ObjetivosxCurso_CellClick);
            // 
            // cmb_cursos
            // 
            this.cmb_cursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cursos.FormattingEnabled = true;
            this.cmb_cursos.Items.AddRange(new object[] {
            "-"});
            this.cmb_cursos.Location = new System.Drawing.Point(111, 117);
            this.cmb_cursos.Name = "cmb_cursos";
            this.cmb_cursos.Size = new System.Drawing.Size(121, 21);
            this.cmb_cursos.TabIndex = 1;
            this.cmb_cursos.SelectedValueChanged += new System.EventHandler(this.cmb_cursos_ValueMemberChanged);
            this.cmb_cursos.Click += new System.EventHandler(this.cmb_cursos_Click);
            // 
            // chk_IncluirBorrados
            // 
            this.chk_IncluirBorrados.AutoSize = true;
            this.chk_IncluirBorrados.Enabled = false;
            this.chk_IncluirBorrados.Location = new System.Drawing.Point(490, 396);
            this.chk_IncluirBorrados.Name = "chk_IncluirBorrados";
            this.chk_IncluirBorrados.Size = new System.Drawing.Size(98, 17);
            this.chk_IncluirBorrados.TabIndex = 5;
            this.chk_IncluirBorrados.Text = "Incluir borrados";
            this.chk_IncluirBorrados.UseVisualStyleBackColor = true;
            this.chk_IncluirBorrados.CheckedChanged += new System.EventHandler(this.chk_borrado_CheckedChanged);
            // 
            // txt_puntaje
            // 
            this.txt_puntaje.Location = new System.Drawing.Point(111, 203);
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
            this.cmb_objetivos.Location = new System.Drawing.Point(111, 159);
            this.cmb_objetivos.Name = "cmb_objetivos";
            this.cmb_objetivos.Size = new System.Drawing.Size(121, 21);
            this.cmb_objetivos.TabIndex = 2;
            // 
            // chk_borrado
            // 
            this.chk_borrado.AutoSize = true;
            this.chk_borrado.Location = new System.Drawing.Point(490, 437);
            this.chk_borrado.Name = "chk_borrado";
            this.chk_borrado.Size = new System.Drawing.Size(69, 17);
            this.chk_borrado.TabIndex = 8;
            this.chk_borrado.Text = "BorrarDB";
            this.chk_borrado.UseVisualStyleBackColor = true;
            this.chk_borrado.Visible = false;
            // 
            // lbl_cursos
            // 
            this.lbl_cursos.AutoSize = true;
            this.lbl_cursos.Location = new System.Drawing.Point(51, 120);
            this.lbl_cursos.Name = "lbl_cursos";
            this.lbl_cursos.Size = new System.Drawing.Size(42, 13);
            this.lbl_cursos.TabIndex = 9;
            this.lbl_cursos.Text = "Cursos:";
            // 
            // lbl_objetivos
            // 
            this.lbl_objetivos.AutoSize = true;
            this.lbl_objetivos.Location = new System.Drawing.Point(51, 162);
            this.lbl_objetivos.Name = "lbl_objetivos";
            this.lbl_objetivos.Size = new System.Drawing.Size(54, 13);
            this.lbl_objetivos.TabIndex = 10;
            this.lbl_objetivos.Text = "Objetivos:";
            // 
            // lbl_puntaje
            // 
            this.lbl_puntaje.AutoSize = true;
            this.lbl_puntaje.Location = new System.Drawing.Point(51, 206);
            this.lbl_puntaje.Name = "lbl_puntaje";
            this.lbl_puntaje.Size = new System.Drawing.Size(46, 13);
            this.lbl_puntaje.TabIndex = 11;
            this.lbl_puntaje.Text = "Puntaje:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbl_puntaje);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_cursos);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_objetivos);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_objetivos);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_cursos);
            this.splitContainer1.Panel1.Controls.Add(this.txt_puntaje);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbl_eliminar);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_modificar);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_habilitar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_habilitar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_modificar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_eliminar);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_ObjetivosxCurso);
            this.splitContainer1.Panel2.Controls.Add(this.chk_IncluirBorrados);
            this.splitContainer1.Panel2.Controls.Add(this.chk_borrado);
            this.splitContainer1.Size = new System.Drawing.Size(970, 564);
            this.splitContainer1.SplitterDistance = 323;
            this.splitContainer1.TabIndex = 13;
            // 
            // lbl_eliminar
            // 
            this.lbl_eliminar.AutoSize = true;
            this.lbl_eliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_eliminar.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_eliminar.Location = new System.Drawing.Point(105, 437);
            this.lbl_eliminar.Name = "lbl_eliminar";
            this.lbl_eliminar.Size = new System.Drawing.Size(43, 13);
            this.lbl_eliminar.TabIndex = 28;
            this.lbl_eliminar.Text = "Eliminar";
            this.lbl_eliminar.Visible = false;
            // 
            // lbl_modificar
            // 
            this.lbl_modificar.AutoSize = true;
            this.lbl_modificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_modificar.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_modificar.Location = new System.Drawing.Point(63, 437);
            this.lbl_modificar.Name = "lbl_modificar";
            this.lbl_modificar.Size = new System.Drawing.Size(50, 13);
            this.lbl_modificar.TabIndex = 27;
            this.lbl_modificar.Text = "Modificar";
            this.lbl_modificar.Visible = false;
            // 
            // lbl_habilitar
            // 
            this.lbl_habilitar.AutoSize = true;
            this.lbl_habilitar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_habilitar.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_habilitar.Location = new System.Drawing.Point(150, 437);
            this.lbl_habilitar.Name = "lbl_habilitar";
            this.lbl_habilitar.Size = new System.Drawing.Size(45, 13);
            this.lbl_habilitar.TabIndex = 26;
            this.lbl_habilitar.Text = "Habilitar";
            this.lbl_habilitar.Visible = false;
            // 
            // btn_habilitar
            // 
            this.btn_habilitar.Image = global::Pav2.Properties.Resources.Add;
            this.btn_habilitar.Location = new System.Drawing.Point(154, 396);
            this.btn_habilitar.Name = "btn_habilitar";
            this.btn_habilitar.Size = new System.Drawing.Size(37, 38);
            this.btn_habilitar.TabIndex = 15;
            this.btn_habilitar.TabStop = false;
            this.btn_habilitar.Click += new System.EventHandler(this.btn_habilitar_Click);
            this.btn_habilitar.MouseLeave += new System.EventHandler(this.btn_habilitar_MouseLeave);
            this.btn_habilitar.MouseHover += new System.EventHandler(this.btn_habilitar_MouseHover);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Image = global::Pav2.Properties.Resources.Edit1;
            this.btn_modificar.Location = new System.Drawing.Point(66, 396);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(36, 38);
            this.btn_modificar.TabIndex = 14;
            this.btn_modificar.TabStop = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            this.btn_modificar.MouseLeave += new System.EventHandler(this.btn_modificar_MouseLeave);
            this.btn_modificar.MouseHover += new System.EventHandler(this.btn_modificar_MouseHover);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Image = global::Pav2.Properties.Resources.Delete;
            this.btn_eliminar.Location = new System.Drawing.Point(108, 396);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(36, 38);
            this.btn_eliminar.TabIndex = 13;
            this.btn_eliminar.TabStop = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            this.btn_eliminar.MouseLeave += new System.EventHandler(this.btn_eliminar_MouseLeave);
            this.btn_eliminar.MouseHover += new System.EventHandler(this.btn_eliminar_MouseHover);
            // 
            // GestionObjetivoxCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 588);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionObjetivoxCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Objetivos por Curso";
            this.Load += new System.EventHandler(this.GestionObjetivoxCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ObjetivosxCurso)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_habilitar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_modificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eliminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ObjetivosxCurso;
        private System.Windows.Forms.ComboBox cmb_cursos;
        private System.Windows.Forms.CheckBox chk_IncluirBorrados;
        private System.Windows.Forms.TextBox txt_puntaje;
        private System.Windows.Forms.ComboBox cmb_objetivos;
        private System.Windows.Forms.CheckBox chk_borrado;
        private System.Windows.Forms.Label lbl_cursos;
        private System.Windows.Forms.Label lbl_objetivos;
        private System.Windows.Forms.Label lbl_puntaje;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox btn_habilitar;
        private System.Windows.Forms.PictureBox btn_modificar;
        private System.Windows.Forms.PictureBox btn_eliminar;
        private System.Windows.Forms.Label lbl_eliminar;
        private System.Windows.Forms.Label lbl_modificar;
        private System.Windows.Forms.Label lbl_habilitar;
    }
}