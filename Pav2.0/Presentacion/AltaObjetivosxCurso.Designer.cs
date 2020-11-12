namespace Pav2.Presentacion
{
    partial class AltaObjetivosxCurso
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
            this.cmb_cursos = new System.Windows.Forms.ComboBox();
            this.cmb_objetivos = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_gestion = new System.Windows.Forms.Button();
            this.txt_puntaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_cursos
            // 
            this.cmb_cursos.FormattingEnabled = true;
            this.cmb_cursos.Location = new System.Drawing.Point(143, 29);
            this.cmb_cursos.Name = "cmb_cursos";
            this.cmb_cursos.Size = new System.Drawing.Size(121, 21);
            this.cmb_cursos.TabIndex = 0;
            this.cmb_cursos.SelectedIndexChanged += new System.EventHandler(this.cmb_cursos_SelectedIndexChanged);
            // 
            // cmb_objetivos
            // 
            this.cmb_objetivos.FormattingEnabled = true;
            this.cmb_objetivos.Location = new System.Drawing.Point(143, 55);
            this.cmb_objetivos.Name = "cmb_objetivos";
            this.cmb_objetivos.Size = new System.Drawing.Size(121, 21);
            this.cmb_objetivos.TabIndex = 1;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(284, 29);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_gestion
            // 
            this.btn_gestion.Location = new System.Drawing.Point(284, 80);
            this.btn_gestion.Name = "btn_gestion";
            this.btn_gestion.Size = new System.Drawing.Size(75, 23);
            this.btn_gestion.TabIndex = 3;
            this.btn_gestion.Text = "Gestion";
            this.btn_gestion.UseVisualStyleBackColor = true;
            this.btn_gestion.Click += new System.EventHandler(this.btn_gestion_Click);
            // 
            // txt_puntaje
            // 
            this.txt_puntaje.Location = new System.Drawing.Point(143, 83);
            this.txt_puntaje.Name = "txt_puntaje";
            this.txt_puntaje.Size = new System.Drawing.Size(121, 20);
            this.txt_puntaje.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cursos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Objetivos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Puntaje";
            // 
            // AltaObjetivosxCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 130);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_puntaje);
            this.Controls.Add(this.btn_gestion);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.cmb_objetivos);
            this.Controls.Add(this.cmb_cursos);
            this.Name = "AltaObjetivosxCurso";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ObjetivosxCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_cursos;
        private System.Windows.Forms.ComboBox cmb_objetivos;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_gestion;
        private System.Windows.Forms.TextBox txt_puntaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}