namespace Pav2.Presentacion
{
    partial class Objetivos
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombreCorto = new System.Windows.Forms.TextBox();
            this.txt_nombreLargo = new System.Windows.Forms.TextBox();
            this.dgv_objetivos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCorto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.chk_borrado = new System.Windows.Forms.CheckBox();
            this.chk_todo = new System.Windows.Forms.CheckBox();
            this.lbl_equis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_objetivos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(253, 286);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 0;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(140, 178);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre corto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre largo:";
            // 
            // txt_nombreCorto
            // 
            this.txt_nombreCorto.Location = new System.Drawing.Point(130, 51);
            this.txt_nombreCorto.Name = "txt_nombreCorto";
            this.txt_nombreCorto.Size = new System.Drawing.Size(100, 20);
            this.txt_nombreCorto.TabIndex = 4;
            // 
            // txt_nombreLargo
            // 
            this.txt_nombreLargo.Location = new System.Drawing.Point(130, 114);
            this.txt_nombreLargo.Name = "txt_nombreLargo";
            this.txt_nombreLargo.Size = new System.Drawing.Size(100, 20);
            this.txt_nombreLargo.TabIndex = 5;
            // 
            // dgv_objetivos
            // 
            this.dgv_objetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_objetivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.NomCorto,
            this.Column2,
            this.Column3});
            this.dgv_objetivos.Location = new System.Drawing.Point(332, 51);
            this.dgv_objetivos.Name = "dgv_objetivos";
            this.dgv_objetivos.ReadOnly = true;
            this.dgv_objetivos.Size = new System.Drawing.Size(443, 150);
            this.dgv_objetivos.TabIndex = 6;
            this.dgv_objetivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_objetivos_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_objetivo";
            this.Column1.HeaderText = "ID ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // NomCorto
            // 
            this.NomCorto.DataPropertyName = "nombre_corto";
            this.NomCorto.HeaderText = "Nombre corto";
            this.NomCorto.Name = "NomCorto";
            this.NomCorto.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nombre_largo";
            this.Column2.HeaderText = "Nombre largo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "borrado";
            this.Column3.FalseValue = "false";
            this.Column3.HeaderText = "Borrado";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.TrueValue = "true";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(140, 229);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 7;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(332, 223);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(100, 20);
            this.txt_value.TabIndex = 8;
            this.txt_value.Visible = false;
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(485, 229);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(15, 14);
            this.chk_estado.TabIndex = 9;
            this.chk_estado.UseVisualStyleBackColor = true;
            this.chk_estado.CheckedChanged += new System.EventHandler(this.chk_estado_CheckedChanged);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(140, 286);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 10;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // chk_borrado
            // 
            this.chk_borrado.AutoSize = true;
            this.chk_borrado.Location = new System.Drawing.Point(562, 229);
            this.chk_borrado.Name = "chk_borrado";
            this.chk_borrado.Size = new System.Drawing.Size(80, 17);
            this.chk_borrado.TabIndex = 11;
            this.chk_borrado.Text = "Eliminar DB";
            this.chk_borrado.UseVisualStyleBackColor = true;
            // 
            // chk_todo
            // 
            this.chk_todo.AutoSize = true;
            this.chk_todo.Location = new System.Drawing.Point(677, 229);
            this.chk_todo.Name = "chk_todo";
            this.chk_todo.Size = new System.Drawing.Size(98, 17);
            this.chk_todo.TabIndex = 12;
            this.chk_todo.Text = "Incluir borrados";
            this.chk_todo.UseVisualStyleBackColor = true;
            this.chk_todo.CheckedChanged += new System.EventHandler(this.chk_todo_CheckedChanged);
            // 
            // lbl_equis
            // 
            this.lbl_equis.AutoSize = true;
            this.lbl_equis.Location = new System.Drawing.Point(253, 117);
            this.lbl_equis.Name = "lbl_equis";
            this.lbl_equis.Size = new System.Drawing.Size(14, 13);
            this.lbl_equis.TabIndex = 13;
            this.lbl_equis.Text = "X";
            this.lbl_equis.Click += new System.EventHandler(this.lbl_equis_Click);
            // 
            // Objetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_equis);
            this.Controls.Add(this.chk_todo);
            this.Controls.Add(this.chk_borrado);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.chk_estado);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.dgv_objetivos);
            this.Controls.Add(this.txt_nombreLargo);
            this.Controls.Add(this.txt_nombreCorto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Name = "Objetivos";
            this.Text = "Objetivos";
            this.Load += new System.EventHandler(this.Objetivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_objetivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombreCorto;
        private System.Windows.Forms.TextBox txt_nombreLargo;
        private System.Windows.Forms.DataGridView dgv_objetivos;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.CheckBox chk_estado;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.CheckBox chk_borrado;
        private System.Windows.Forms.CheckBox chk_todo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCorto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.Label lbl_equis;
    }
}