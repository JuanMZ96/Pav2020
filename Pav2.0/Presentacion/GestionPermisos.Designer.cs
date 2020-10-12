namespace Pav2.Presentacion
{
    partial class GestionPermisos
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
            this.cmb_perfiles = new System.Windows.Forms.ComboBox();
            this.dgv_formularios = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.chk_todo = new System.Windows.Forms.CheckBox();
            this.id_formulario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_formularios)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_perfiles
            // 
            this.cmb_perfiles.FormattingEnabled = true;
            this.cmb_perfiles.Location = new System.Drawing.Point(30, 34);
            this.cmb_perfiles.Name = "cmb_perfiles";
            this.cmb_perfiles.Size = new System.Drawing.Size(121, 21);
            this.cmb_perfiles.TabIndex = 1;
            // 
            // dgv_formularios
            // 
            this.dgv_formularios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_formularios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_formularios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_formulario,
            this.nombre,
            this.cheked});
            this.dgv_formularios.Location = new System.Drawing.Point(30, 61);
            this.dgv_formularios.Name = "dgv_formularios";
            this.dgv_formularios.Size = new System.Drawing.Size(261, 242);
            this.dgv_formularios.TabIndex = 2;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(307, 61);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(307, 90);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 4;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(307, 119);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 5;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // chk_todo
            // 
            this.chk_todo.AutoSize = true;
            this.chk_todo.Location = new System.Drawing.Point(307, 190);
            this.chk_todo.Name = "chk_todo";
            this.chk_todo.Size = new System.Drawing.Size(80, 17);
            this.chk_todo.TabIndex = 6;
            this.chk_todo.Text = "checkBox1";
            this.chk_todo.UseVisualStyleBackColor = true;
            // 
            // id_formulario
            // 
            this.id_formulario.DataPropertyName = "id_formulario";
            this.id_formulario.HeaderText = "Id";
            this.id_formulario.Name = "id_formulario";
            this.id_formulario.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // cheked
            // 
            this.cheked.HeaderText = "Habilitado";
            this.cheked.Name = "cheked";
            // 
            // GestionPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 316);
            this.Controls.Add(this.chk_todo);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dgv_formularios);
            this.Controls.Add(this.cmb_perfiles);
            this.Name = "GestionPermisos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GestionPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_formularios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_perfiles;
        private System.Windows.Forms.DataGridView dgv_formularios;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.CheckBox chk_todo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_formulario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cheked;
    }
}