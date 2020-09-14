namespace Pav2.Presentacion
{
    partial class GestionPerfiles
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
            this.btn_AltaPerfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AltaPerfil
            // 
            this.btn_AltaPerfil.Location = new System.Drawing.Point(677, 374);
            this.btn_AltaPerfil.Name = "btn_AltaPerfil";
            this.btn_AltaPerfil.Size = new System.Drawing.Size(75, 23);
            this.btn_AltaPerfil.TabIndex = 0;
            this.btn_AltaPerfil.Text = "Nuevo Perfil";
            this.btn_AltaPerfil.UseVisualStyleBackColor = true;
            // 
            // GestionPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AltaPerfil);
            this.Name = "GestionPerfiles";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AltaPerfil;
    }
}