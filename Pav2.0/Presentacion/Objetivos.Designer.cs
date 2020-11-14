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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Objetivos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombreCorto = new System.Windows.Forms.TextBox();
            this.txt_nombreLargo = new System.Windows.Forms.TextBox();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.chk_borrado = new System.Windows.Forms.CheckBox();
            this.chk_todo = new System.Windows.Forms.CheckBox();
            this.lbl_equis = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_guardar = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.PictureBox();
            this.lbl_eliminar = new System.Windows.Forms.Label();
            this.lbl_modificar = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.PictureBox();
            this.lbl_habilitar = new System.Windows.Forms.Label();
            this.btn_Modificar = new System.Windows.Forms.PictureBox();
            this.btn_habilitar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Modificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_habilitar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre corto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre largo:";
            // 
            // txt_nombreCorto
            // 
            this.txt_nombreCorto.Location = new System.Drawing.Point(104, 90);
            this.txt_nombreCorto.MaxLength = 50;
            this.txt_nombreCorto.Name = "txt_nombreCorto";
            this.txt_nombreCorto.Size = new System.Drawing.Size(162, 20);
            this.txt_nombreCorto.TabIndex = 4;
            // 
            // txt_nombreLargo
            // 
            this.txt_nombreLargo.Location = new System.Drawing.Point(104, 133);
            this.txt_nombreLargo.MaxLength = 100;
            this.txt_nombreLargo.Multiline = true;
            this.txt_nombreLargo.Name = "txt_nombreLargo";
            this.txt_nombreLargo.Size = new System.Drawing.Size(162, 74);
            this.txt_nombreLargo.TabIndex = 5;
            // 
            // datagridview
            // 
            this.datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.datagridview.Location = new System.Drawing.Point(34, 42);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.Size = new System.Drawing.Size(576, 424);
            this.datagridview.TabIndex = 6;
            this.datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_objetivos_CellContentClick);
            this.datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_objetivos_CellContentClick);
            this.datagridview.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_objetivos_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "id_objetivo";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "ID ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 208;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "nombre_corto";
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Nombre corto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 96;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "nombre_largo";
            this.Column3.HeaderText = "Nombre largo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.DataPropertyName = "borrado";
            this.Column4.FalseValue = "false";
            this.Column4.HeaderText = "Borrado";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.TrueValue = "true";
            this.Column4.Width = 50;
            // 
            // txt_value
            // 
            this.txt_value.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_value.Location = new System.Drawing.Point(577, 528);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(29, 20);
            this.txt_value.TabIndex = 8;
            this.txt_value.Visible = false;
            // 
            // chk_estado
            // 
            this.chk_estado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(512, 532);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(59, 17);
            this.chk_estado.TabIndex = 9;
            this.chk_estado.Text = "Estado";
            this.chk_estado.UseVisualStyleBackColor = true;
            this.chk_estado.CheckedChanged += new System.EventHandler(this.chk_estado_CheckedChanged);
            // 
            // chk_borrado
            // 
            this.chk_borrado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chk_borrado.AutoSize = true;
            this.chk_borrado.Location = new System.Drawing.Point(512, 505);
            this.chk_borrado.Name = "chk_borrado";
            this.chk_borrado.Size = new System.Drawing.Size(80, 17);
            this.chk_borrado.TabIndex = 11;
            this.chk_borrado.Text = "Eliminar DB";
            this.chk_borrado.UseVisualStyleBackColor = true;
            // 
            // chk_todo
            // 
            this.chk_todo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_todo.AutoSize = true;
            this.chk_todo.Location = new System.Drawing.Point(512, 482);
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
            this.lbl_equis.Location = new System.Drawing.Point(272, 93);
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
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbl_equis);
            this.splitContainer1.Panel1.Controls.Add(this.txt_nombreCorto);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txt_nombreLargo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chk_borrado);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_guardar);
            this.splitContainer1.Panel2.Controls.Add(this.chk_estado);
            this.splitContainer1.Panel2.Controls.Add(this.btn_guardar);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_eliminar);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_modificar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Eliminar);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_habilitar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Modificar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_habilitar);
            this.splitContainer1.Panel2.Controls.Add(this.chk_todo);
            this.splitContainer1.Panel2.Controls.Add(this.datagridview);
            this.splitContainer1.Panel2.Controls.Add(this.txt_value);
            this.splitContainer1.Size = new System.Drawing.Size(970, 564);
            this.splitContainer1.SplitterDistance = 323;
            this.splitContainer1.TabIndex = 14;
            // 
            // lbl_guardar
            // 
            this.lbl_guardar.AutoSize = true;
            this.lbl_guardar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_guardar.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_guardar.Location = new System.Drawing.Point(31, 523);
            this.lbl_guardar.Name = "lbl_guardar";
            this.lbl_guardar.Size = new System.Drawing.Size(45, 13);
            this.lbl_guardar.TabIndex = 43;
            this.lbl_guardar.Text = "Guardar";
            this.lbl_guardar.Visible = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::Pav2.Properties.Resources.Save;
            this.btn_guardar.Location = new System.Drawing.Point(34, 482);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(38, 38);
            this.btn_guardar.TabIndex = 36;
            this.btn_guardar.TabStop = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            this.btn_guardar.MouseLeave += new System.EventHandler(this.btn_guardar_MouseLeave);
            this.btn_guardar.MouseHover += new System.EventHandler(this.btn_guardar_MouseHover);
            // 
            // lbl_eliminar
            // 
            this.lbl_eliminar.AutoSize = true;
            this.lbl_eliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_eliminar.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_eliminar.Location = new System.Drawing.Point(117, 523);
            this.lbl_eliminar.Name = "lbl_eliminar";
            this.lbl_eliminar.Size = new System.Drawing.Size(43, 13);
            this.lbl_eliminar.TabIndex = 42;
            this.lbl_eliminar.Text = "Eliminar";
            this.lbl_eliminar.Visible = false;
            // 
            // lbl_modificar
            // 
            this.lbl_modificar.AutoSize = true;
            this.lbl_modificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_modificar.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_modificar.Location = new System.Drawing.Point(75, 523);
            this.lbl_modificar.Name = "lbl_modificar";
            this.lbl_modificar.Size = new System.Drawing.Size(50, 13);
            this.lbl_modificar.TabIndex = 41;
            this.lbl_modificar.Text = "Modificar";
            this.lbl_modificar.Visible = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Image = global::Pav2.Properties.Resources.Delete;
            this.btn_Eliminar.Location = new System.Drawing.Point(120, 482);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(36, 38);
            this.btn_Eliminar.TabIndex = 37;
            this.btn_Eliminar.TabStop = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            this.btn_Eliminar.MouseLeave += new System.EventHandler(this.btn_Eliminar_MouseLeave);
            this.btn_Eliminar.MouseHover += new System.EventHandler(this.btn_Eliminar_MouseHover);
            // 
            // lbl_habilitar
            // 
            this.lbl_habilitar.AutoSize = true;
            this.lbl_habilitar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_habilitar.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_habilitar.Location = new System.Drawing.Point(162, 523);
            this.lbl_habilitar.Name = "lbl_habilitar";
            this.lbl_habilitar.Size = new System.Drawing.Size(45, 13);
            this.lbl_habilitar.TabIndex = 40;
            this.lbl_habilitar.Text = "Habilitar";
            this.lbl_habilitar.Visible = false;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Image = global::Pav2.Properties.Resources.Edit1;
            this.btn_Modificar.Location = new System.Drawing.Point(78, 482);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(36, 38);
            this.btn_Modificar.TabIndex = 38;
            this.btn_Modificar.TabStop = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            this.btn_Modificar.MouseLeave += new System.EventHandler(this.btn_Modificar_MouseLeave);
            this.btn_Modificar.MouseHover += new System.EventHandler(this.btn_Modificar_MouseHover);
            // 
            // btn_habilitar
            // 
            this.btn_habilitar.Image = global::Pav2.Properties.Resources.Add;
            this.btn_habilitar.Location = new System.Drawing.Point(166, 482);
            this.btn_habilitar.Name = "btn_habilitar";
            this.btn_habilitar.Size = new System.Drawing.Size(37, 38);
            this.btn_habilitar.TabIndex = 39;
            this.btn_habilitar.TabStop = false;
            this.btn_habilitar.MouseLeave += new System.EventHandler(this.btn_habilitar_MouseLeave);
            this.btn_habilitar.MouseHover += new System.EventHandler(this.btn_habilitar_MouseHover);
            // 
            // Objetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 588);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Objetivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Objetivos";
            this.Load += new System.EventHandler(this.Objetivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Modificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_habilitar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombreCorto;
        private System.Windows.Forms.TextBox txt_nombreLargo;
        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.CheckBox chk_estado;
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_guardar;
        private System.Windows.Forms.PictureBox btn_guardar;
        private System.Windows.Forms.Label lbl_eliminar;
        private System.Windows.Forms.Label lbl_modificar;
        private System.Windows.Forms.PictureBox btn_Eliminar;
        private System.Windows.Forms.Label lbl_habilitar;
        private System.Windows.Forms.PictureBox btn_Modificar;
        private System.Windows.Forms.PictureBox btn_habilitar;
    }
}