namespace Pav2.Presentacion
{
    partial class Login
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_nameid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(84, -11);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 11;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(74, 251);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(232, 23);
            this.btnIngresar.TabIndex = 17;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txt_pwd
            // 
            this.txt_pwd.ForeColor = System.Drawing.Color.DimGray;
            this.txt_pwd.Location = new System.Drawing.Point(74, 204);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(232, 20);
            this.txt_pwd.TabIndex = 16;
            this.txt_pwd.Text = "Contraseña";
            this.txt_pwd.Enter += new System.EventHandler(this.txt_pwd_Enter);
            this.txt_pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pwd_KeyPress);
            this.txt_pwd.Leave += new System.EventHandler(this.txt_pwd_Leave);
            // 
            // txt_nameid
            // 
            this.txt_nameid.ForeColor = System.Drawing.Color.DimGray;
            this.txt_nameid.Location = new System.Drawing.Point(74, 165);
            this.txt_nameid.Name = "txt_nameid";
            this.txt_nameid.Size = new System.Drawing.Size(232, 20);
            this.txt_nameid.TabIndex = 15;
            this.txt_nameid.Text = "Usuario";
            this.txt_nameid.Enter += new System.EventHandler(this.txt_nameid_Enter);
            this.txt_nameid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pwd_KeyPress);
            this.txt_nameid.Leave += new System.EventHandler(this.txt_nameid_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "LOGIN";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(112, 330);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Ha olvidado su contraseña?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pav2.Properties.Resources.iconfinder_jee_74_2180663__1_;
            this.pictureBox1.Location = new System.Drawing.Point(158, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 60);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 2);
            this.label2.TabIndex = 19;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(382, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_nameid);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(398, 422);
            this.MinimumSize = new System.Drawing.Size(398, 422);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_nameid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}