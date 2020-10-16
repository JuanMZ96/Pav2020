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
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.lbl_perfil = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
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
            this.btn_Perfiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Principal_KeyPress);
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
            this.btn_categorias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Principal_KeyPress);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.Location = new System.Drawing.Point(12, 70);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(75, 23);
            this.btn_usuarios.TabIndex = 2;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.button1_Click);
            this.btn_usuarios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Principal_KeyPress);
            // 
            // lbl_perfil
            // 
            this.lbl_perfil.AutoSize = true;
            this.lbl_perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perfil.Location = new System.Drawing.Point(7, 391);
            this.lbl_perfil.Name = "lbl_perfil";
            this.lbl_perfil.Size = new System.Drawing.Size(65, 25);
            this.lbl_perfil.TabIndex = 4;
            this.lbl_perfil.Text = "Label";
            this.lbl_perfil.Visible = false;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(7, 416);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(65, 25);
            this.lbl_usuario.TabIndex = 5;
            this.lbl_usuario.Text = "Label";
            this.lbl_usuario.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_perfil);
            this.Controls.Add(this.btn_usuarios);
            this.Controls.Add(this.btn_categorias);
            this.Controls.Add(this.btn_Perfiles);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Principal_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Perfiles;
        private System.Windows.Forms.Button btn_categorias;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Label lbl_perfil;
        private System.Windows.Forms.Label lbl_usuario;
    }
}