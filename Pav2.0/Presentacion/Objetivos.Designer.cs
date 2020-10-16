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
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.chk_borrado = new System.Windows.Forms.CheckBox();
            this.chk_todo = new System.Windows.Forms.CheckBox();
            this.lbl_equis = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(212, 315);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 0;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(103, 207);
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
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre corto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre largo:";
            // 
            // txt_nombreCorto
            // 
            this.txt_nombreCorto.Location = new System.Drawing.Point(103, 48);
            this.txt_nombreCorto.Name = "txt_nombreCorto";
            this.txt_nombreCorto.Size = new System.Drawing.Size(100, 20);
            this.txt_nombreCorto.TabIndex = 4;
            // 
            // txt_nombreLargo
            // 
            this.txt_nombreLargo.Location = new System.Drawing.Point(103, 94);
            this.txt_nombreLargo.Multiline = true;
            this.txt_nombreLargo.Name = "txt_nombreLargo";
            this.txt_nombreLargo.Size = new System.Drawing.Size(180, 92);
            this.txt_nombreLargo.TabIndex = 5;
            // 
            // datagridview
            // 
            this.datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.datagridview.Location = new System.Drawing.Point(312, 48);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.Size = new System.Drawing.Size(463, 274);
            this.datagridview.TabIndex = 6;
            this.datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_objetivos_CellContentClick);
            this.datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_objetivos_CellContentClick);
            this.datagridview.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_objetivos_CellContentClick);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(103, 258);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 7;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // txt_value
            // 
            this.txt_value.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_value.Location = new System.Drawing.Point(332, 402);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(100, 20);
            this.txt_value.TabIndex = 8;
            // 
            // chk_estado
            // 
            this.chk_estado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(475, 408);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(59, 17);
            this.chk_estado.TabIndex = 9;
            this.chk_estado.Text = "Estado";
            this.chk_estado.UseVisualStyleBackColor = true;
            this.chk_estado.CheckedChanged += new System.EventHandler(this.chk_estado_CheckedChanged);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(103, 315);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 10;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // chk_borrado
            // 
            this.chk_borrado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chk_borrado.AutoSize = true;
            this.chk_borrado.Location = new System.Drawing.Point(562, 408);
            this.chk_borrado.Name = "chk_borrado";
            this.chk_borrado.Size = new System.Drawing.Size(80, 17);
            this.chk_borrado.TabIndex = 11;
            this.chk_borrado.Text = "Eliminar DB";
            this.chk_borrado.UseVisualStyleBackColor = true;
            // 
            // chk_todo
            // 
            this.chk_todo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chk_todo.AutoSize = true;
            this.chk_todo.Location = new System.Drawing.Point(677, 408);
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
            this.lbl_equis.Location = new System.Drawing.Point(224, 51);
            this.lbl_equis.Name = "lbl_equis";
            this.lbl_equis.Size = new System.Drawing.Size(14, 13);
            this.lbl_equis.TabIndex = 13;
            this.lbl_equis.Text = "X";
            this.lbl_equis.Click += new System.EventHandler(this.lbl_equis_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_objetivo";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_corto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre corto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre_largo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre largo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "borrado";
            this.dataGridViewCheckBoxColumn1.FalseValue = "false";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Borrado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.TrueValue = "true";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_objetivo";
            this.Column1.HeaderText = "ID ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nombre_corto";
            this.Column2.HeaderText = "Nombre corto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "nombre_largo";
            this.Column3.HeaderText = "Nombre largo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 95;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "borrado";
            this.Column4.FalseValue = "false";
            this.Column4.HeaderText = "Borrado";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.TrueValue = "true";
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
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.txt_nombreLargo);
            this.Controls.Add(this.txt_nombreCorto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Name = "Objetivos";
            this.Text = "Objetivos";
            this.Load += new System.EventHandler(this.Objetivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
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
        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.CheckBox chk_estado;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.CheckBox chk_borrado;
        private System.Windows.Forms.CheckBox chk_todo;
        private System.Windows.Forms.Label lbl_equis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
    }
}