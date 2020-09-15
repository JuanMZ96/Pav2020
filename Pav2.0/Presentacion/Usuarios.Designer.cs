namespace Pav2.Presentacion
{
    partial class Usuarios
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cmb_perfiles = new System.Windows.Forms.ComboBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_pw = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_perfiles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(91, 13);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(91, 39);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(100, 20);
            this.txt_pw.TabIndex = 1;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(268, 27);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cmb_perfiles
            // 
            this.cmb_perfiles.FormattingEnabled = true;
            this.cmb_perfiles.Location = new System.Drawing.Point(91, 92);
            this.cmb_perfiles.Name = "cmb_perfiles";
            this.cmb_perfiles.Size = new System.Drawing.Size(137, 21);
            this.cmb_perfiles.TabIndex = 3;
            this.cmb_perfiles.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(91, 66);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(100, 20);
            this.txt_mail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // lbl_pw
            // 
            this.lbl_pw.AutoSize = true;
            this.lbl_pw.Location = new System.Drawing.Point(16, 42);
            this.lbl_pw.Name = "lbl_pw";
            this.lbl_pw.Size = new System.Drawing.Size(61, 13);
            this.lbl_pw.TabIndex = 6;
            this.lbl_pw.Text = "Contraseña";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(16, 69);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(26, 13);
            this.lbl_mail.TabIndex = 7;
            this.lbl_mail.Text = "Mail";
            // 
            // lbl_perfiles
            // 
            this.lbl_perfiles.AutoSize = true;
            this.lbl_perfiles.Location = new System.Drawing.Point(16, 95);
            this.lbl_perfiles.Name = "lbl_perfiles";
            this.lbl_perfiles.Size = new System.Drawing.Size(41, 13);
            this.lbl_perfiles.TabIndex = 8;
            this.lbl_perfiles.Text = "Perfiles";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 124);
            this.Controls.Add(this.lbl_perfiles);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.lbl_pw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.cmb_perfiles);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cmb_perfiles;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_pw;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_perfiles;
    }
}