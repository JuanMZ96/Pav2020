namespace Pav2.Presentacion
{
    partial class Principal
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
            this.btn_Perfiles = new System.Windows.Forms.Button();
            this.btn_categorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Perfiles
            // 
            this.btn_Perfiles.Location = new System.Drawing.Point(12, 12);
            this.btn_Perfiles.Name = "btn_Perfiles";
            this.btn_Perfiles.Size = new System.Drawing.Size(75, 23);
            this.btn_Perfiles.TabIndex = 0;
            this.btn_Perfiles.Text = "Perfiles";
            this.btn_Perfiles.UseVisualStyleBackColor = true;
            this.btn_Perfiles.Click += new System.EventHandler(this.btn_Perfiles_Click);
            // 
            // btn_categorias
            // 
            this.btn_categorias.Location = new System.Drawing.Point(12, 41);
            this.btn_categorias.Name = "btn_categorias";
            this.btn_categorias.Size = new System.Drawing.Size(75, 23);
            this.btn_categorias.TabIndex = 1;
            this.btn_categorias.Text = "Categorias";
            this.btn_categorias.UseVisualStyleBackColor = true;
            this.btn_categorias.Click += new System.EventHandler(this.btn_categorias_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_categorias);
            this.Controls.Add(this.btn_Perfiles);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Perfiles;
        private System.Windows.Forms.Button btn_categorias;
    }
}