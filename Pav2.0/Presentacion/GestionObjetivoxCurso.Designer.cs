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
            this.dgv_ObjetivosxCurso = new System.Windows.Forms.DataGridView();
            this.cmb_cursos = new System.Windows.Forms.ComboBox();
            this.cmb_objetivos = new System.Windows.Forms.ComboBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.chk_borrado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ObjetivosxCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ObjetivosxCurso
            // 
            this.dgv_ObjetivosxCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ObjetivosxCurso.Location = new System.Drawing.Point(12, 51);
            this.dgv_ObjetivosxCurso.Name = "dgv_ObjetivosxCurso";
            this.dgv_ObjetivosxCurso.Size = new System.Drawing.Size(458, 387);
            this.dgv_ObjetivosxCurso.TabIndex = 0;
            // 
            // cmb_cursos
            // 
            this.cmb_cursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cursos.FormattingEnabled = true;
            this.cmb_cursos.Items.AddRange(new object[] {
            "-"});
            this.cmb_cursos.Location = new System.Drawing.Point(100, 10);
            this.cmb_cursos.Name = "cmb_cursos";
            this.cmb_cursos.Size = new System.Drawing.Size(121, 21);
            this.cmb_cursos.TabIndex = 1;
            this.cmb_cursos.SelectedValueChanged += new System.EventHandler(this.cmb_cursos_ValueMemberChanged);
            this.cmb_cursos.Click += new System.EventHandler(this.cmb_cursos_Click);
            // 
            // cmb_objetivos
            // 
            this.cmb_objetivos.FormattingEnabled = true;
            this.cmb_objetivos.Items.AddRange(new object[] {
            "-"});
            this.cmb_objetivos.Location = new System.Drawing.Point(349, 10);
            this.cmb_objetivos.Name = "cmb_objetivos";
            this.cmb_objetivos.Size = new System.Drawing.Size(121, 21);
            this.cmb_objetivos.TabIndex = 2;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(504, 9);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(504, 50);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // chk_borrado
            // 
            this.chk_borrado.AutoSize = true;
            this.chk_borrado.Location = new System.Drawing.Point(480, 79);
            this.chk_borrado.Name = "chk_borrado";
            this.chk_borrado.Size = new System.Drawing.Size(99, 17);
            this.chk_borrado.TabIndex = 5;
            this.chk_borrado.Text = "Incluir Borrados";
            this.chk_borrado.UseVisualStyleBackColor = true;
            // 
            // GestionObjetivoxCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.chk_borrado);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.cmb_objetivos);
            this.Controls.Add(this.cmb_cursos);
            this.Controls.Add(this.dgv_ObjetivosxCurso);
            this.Name = "GestionObjetivoxCurso";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GestionObjetivoxCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ObjetivosxCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ObjetivosxCurso;
        private System.Windows.Forms.ComboBox cmb_cursos;
        private System.Windows.Forms.ComboBox cmb_objetivos;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.CheckBox chk_borrado;
    }
}