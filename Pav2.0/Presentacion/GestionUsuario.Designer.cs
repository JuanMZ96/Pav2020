namespace Pav2.Presentacion
{
    partial class GestionUsuario
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
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.chk_todo = new System.Windows.Forms.CheckBox();
            this.btn_modifcar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.chk_borrado = new System.Windows.Forms.CheckBox();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.cmb_perfiles = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            this.dgv_usuarios.AllowUserToResizeColumns = false;
            this.dgv_usuarios.AllowUserToResizeRows = false;
            this.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(12, 12);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.Size = new System.Drawing.Size(550, 323);
            this.dgv_usuarios.TabIndex = 0;
            this.dgv_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellContentClick);
            this.dgv_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellContentClick);
            this.dgv_usuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellContentClick);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(643, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(130, 20);
            this.txt_name.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(643, 62);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(130, 20);
            this.txt_password.TabIndex = 2;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(643, 88);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(130, 20);
            this.txt_mail.TabIndex = 3;
            // 
            // chk_todo
            // 
            this.chk_todo.AutoSize = true;
            this.chk_todo.Location = new System.Drawing.Point(12, 342);
            this.chk_todo.Name = "chk_todo";
            this.chk_todo.Size = new System.Drawing.Size(80, 17);
            this.chk_todo.TabIndex = 4;
            this.chk_todo.Text = "checkBox1";
            this.chk_todo.UseVisualStyleBackColor = true;
            this.chk_todo.CheckedChanged += new System.EventHandler(this.chk_estado_CheckedChanged);
            // 
            // btn_modifcar
            // 
            this.btn_modifcar.Location = new System.Drawing.Point(633, 175);
            this.btn_modifcar.Name = "btn_modifcar";
            this.btn_modifcar.Size = new System.Drawing.Size(75, 23);
            this.btn_modifcar.TabIndex = 5;
            this.btn_modifcar.Text = "Modificar";
            this.btn_modifcar.UseVisualStyleBackColor = true;
            this.btn_modifcar.Click += new System.EventHandler(this.btn_modifcar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(723, 175);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.Text = "eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_value
            // 
            this.txt_value.Enabled = false;
            this.txt_value.Location = new System.Drawing.Point(13, 365);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(51, 20);
            this.txt_value.TabIndex = 7;
            // 
            // chk_borrado
            // 
            this.chk_borrado.AutoSize = true;
            this.chk_borrado.Location = new System.Drawing.Point(633, 216);
            this.chk_borrado.Name = "chk_borrado";
            this.chk_borrado.Size = new System.Drawing.Size(69, 17);
            this.chk_borrado.TabIndex = 9;
            this.chk_borrado.Text = "BorrarDB";
            this.chk_borrado.UseVisualStyleBackColor = true;
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(643, 114);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(80, 17);
            this.chk_estado.TabIndex = 10;
            this.chk_estado.Text = "checkBox1";
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // cmb_perfiles
            // 
            this.cmb_perfiles.FormattingEnabled = true;
            this.cmb_perfiles.Location = new System.Drawing.Point(643, 38);
            this.cmb_perfiles.Name = "cmb_perfiles";
            this.cmb_perfiles.Size = new System.Drawing.Size(130, 21);
            this.cmb_perfiles.TabIndex = 11;
            // 
            // GestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.cmb_perfiles);
            this.Controls.Add(this.chk_estado);
            this.Controls.Add(this.chk_borrado);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modifcar);
            this.Controls.Add(this.chk_todo);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.dgv_usuarios);
            this.Name = "GestionUsuario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GestionUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.CheckBox chk_todo;
        private System.Windows.Forms.Button btn_modifcar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.CheckBox chk_borrado;
        private System.Windows.Forms.CheckBox chk_estado;
        private System.Windows.Forms.ComboBox cmb_perfiles;
    }
}