namespace Pav2.Presentacion
{
    partial class Categorias
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.dgv_categorias = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.chk_todo = new System.Windows.Forms.CheckBox();
            this.chk_borrado = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_guardar = new System.Windows.Forms.Label();
            this.lbl_eliminar = new System.Windows.Forms.Label();
            this.lbl_modificar = new System.Windows.Forms.Label();
            this.lbl_habilitar = new System.Windows.Forms.Label();
            this.lbl_x = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.PictureBox();
            this.btn_borrar = new System.Windows.Forms.PictureBox();
            this.btn_modificar = new System.Windows.Forms.PictureBox();
            this.btn_Habilitar = new System.Windows.Forms.PictureBox();
            this.btn_HabilitarGris = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_borrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_modificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Habilitar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_HabilitarGris)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(108, 79);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(162, 20);
            this.txt_name.TabIndex = 3;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(108, 115);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(162, 74);
            this.txt_descripcion.TabIndex = 4;
            // 
            // dgv_categorias
            // 
            this.dgv_categorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_categorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_categorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_categorias.Location = new System.Drawing.Point(34, 57);
            this.dgv_categorias.Name = "dgv_categorias";
            this.dgv_categorias.ReadOnly = true;
            this.dgv_categorias.Size = new System.Drawing.Size(574, 409);
            this.dgv_categorias.TabIndex = 5;
            this.dgv_categorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_categorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_categorias.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "nombre";
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 69;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "descripcion";
            this.Column2.HeaderText = "Descripción ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "borrado";
            this.Column3.HeaderText = "Borrado";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 69;
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(510, 539);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(40, 20);
            this.txt_value.TabIndex = 6;
            this.txt_value.Visible = false;
            this.txt_value.TextChanged += new System.EventHandler(this.txt_value_TextChanged);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(36, 82);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 7;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(36, 118);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(66, 13);
            this.lbl_descripcion.TabIndex = 8;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // chk_todo
            // 
            this.chk_todo.AutoSize = true;
            this.chk_todo.Location = new System.Drawing.Point(510, 483);
            this.chk_todo.Name = "chk_todo";
            this.chk_todo.Size = new System.Drawing.Size(98, 17);
            this.chk_todo.TabIndex = 11;
            this.chk_todo.Text = "Incluir borrados";
            this.chk_todo.UseVisualStyleBackColor = true;
            this.chk_todo.CheckedChanged += new System.EventHandler(this.chk_estado_CheckedChanged);
            // 
            // chk_borrado
            // 
            this.chk_borrado.AutoSize = true;
            this.chk_borrado.Location = new System.Drawing.Point(510, 507);
            this.chk_borrado.Name = "chk_borrado";
            this.chk_borrado.Size = new System.Drawing.Size(77, 17);
            this.chk_borrado.TabIndex = 14;
            this.chk_borrado.Text = "EliminarDB";
            this.chk_borrado.UseVisualStyleBackColor = true;
            this.chk_borrado.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbl_x);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_nombre);
            this.splitContainer1.Panel1.Controls.Add(this.txt_name);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_descripcion);
            this.splitContainer1.Panel1.Controls.Add(this.txt_descripcion);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chk_borrado);
            this.splitContainer1.Panel2.Controls.Add(this.txt_value);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_guardar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_guardar);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_eliminar);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_modificar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_borrar);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_habilitar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_modificar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Habilitar);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_categorias);
            this.splitContainer1.Panel2.Controls.Add(this.chk_todo);
            this.splitContainer1.Panel2.Controls.Add(this.btn_HabilitarGris);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(970, 564);
            this.splitContainer1.SplitterDistance = 323;
            this.splitContainer1.TabIndex = 16;
            // 
            // lbl_guardar
            // 
            this.lbl_guardar.AutoSize = true;
            this.lbl_guardar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_guardar.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_guardar.Location = new System.Drawing.Point(31, 524);
            this.lbl_guardar.Name = "lbl_guardar";
            this.lbl_guardar.Size = new System.Drawing.Size(45, 13);
            this.lbl_guardar.TabIndex = 43;
            this.lbl_guardar.Text = "Guardar";
            this.lbl_guardar.Visible = false;
            // 
            // lbl_eliminar
            // 
            this.lbl_eliminar.AutoSize = true;
            this.lbl_eliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_eliminar.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_eliminar.Location = new System.Drawing.Point(117, 524);
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
            this.lbl_modificar.Location = new System.Drawing.Point(75, 524);
            this.lbl_modificar.Name = "lbl_modificar";
            this.lbl_modificar.Size = new System.Drawing.Size(50, 13);
            this.lbl_modificar.TabIndex = 41;
            this.lbl_modificar.Text = "Modificar";
            this.lbl_modificar.Visible = false;
            // 
            // lbl_habilitar
            // 
            this.lbl_habilitar.AutoSize = true;
            this.lbl_habilitar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_habilitar.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_habilitar.Location = new System.Drawing.Point(162, 524);
            this.lbl_habilitar.Name = "lbl_habilitar";
            this.lbl_habilitar.Size = new System.Drawing.Size(45, 13);
            this.lbl_habilitar.TabIndex = 40;
            this.lbl_habilitar.Text = "Habilitar";
            this.lbl_habilitar.Visible = false;
            // 
            // lbl_x
            // 
            this.lbl_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x.Image = global::Pav2.Properties.Resources.Clear;
            this.lbl_x.Location = new System.Drawing.Point(276, 79);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(26, 20);
            this.lbl_x.TabIndex = 10;
            this.lbl_x.Click += new System.EventHandler(this.lbl_x_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::Pav2.Properties.Resources.Save;
            this.btn_guardar.Location = new System.Drawing.Point(34, 483);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(38, 38);
            this.btn_guardar.TabIndex = 36;
            this.btn_guardar.TabStop = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            this.btn_guardar.MouseLeave += new System.EventHandler(this.btn_guardar_MouseLeave);
            this.btn_guardar.MouseHover += new System.EventHandler(this.btn_guardar_MouseHover);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Image = global::Pav2.Properties.Resources.Delete;
            this.btn_borrar.Location = new System.Drawing.Point(120, 483);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(36, 38);
            this.btn_borrar.TabIndex = 37;
            this.btn_borrar.TabStop = false;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            this.btn_borrar.MouseLeave += new System.EventHandler(this.btn_borrar_MouseLeave);
            this.btn_borrar.MouseHover += new System.EventHandler(this.btn_borrar_MouseHover);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Image = global::Pav2.Properties.Resources.Edit1;
            this.btn_modificar.Location = new System.Drawing.Point(78, 483);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(36, 38);
            this.btn_modificar.TabIndex = 38;
            this.btn_modificar.TabStop = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            this.btn_modificar.MouseLeave += new System.EventHandler(this.btn_modificar_MouseLeave);
            this.btn_modificar.MouseHover += new System.EventHandler(this.btn_modificar_MouseHover);
            // 
            // btn_Habilitar
            // 
            this.btn_Habilitar.Image = global::Pav2.Properties.Resources.Add;
            this.btn_Habilitar.Location = new System.Drawing.Point(166, 483);
            this.btn_Habilitar.Name = "btn_Habilitar";
            this.btn_Habilitar.Size = new System.Drawing.Size(37, 38);
            this.btn_Habilitar.TabIndex = 39;
            this.btn_Habilitar.TabStop = false;
            this.btn_Habilitar.Click += new System.EventHandler(this.btn_Habilitar_Click);
            this.btn_Habilitar.MouseLeave += new System.EventHandler(this.btn_Habilitar_MouseLeave);
            this.btn_Habilitar.MouseHover += new System.EventHandler(this.btn_Habilitar_MouseHover);
            // 
            // btn_HabilitarGris
            // 
            this.btn_HabilitarGris.Image = global::Pav2.Properties.Resources.Add_grey;
            this.btn_HabilitarGris.Location = new System.Drawing.Point(166, 483);
            this.btn_HabilitarGris.Name = "btn_HabilitarGris";
            this.btn_HabilitarGris.Size = new System.Drawing.Size(35, 38);
            this.btn_HabilitarGris.TabIndex = 44;
            this.btn_HabilitarGris.TabStop = false;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 588);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Categorías";
            this.Load += new System.EventHandler(this.Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorias)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_borrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_modificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Habilitar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_HabilitarGris)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.DataGridView dgv_categorias;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.CheckBox chk_todo;
        private System.Windows.Forms.CheckBox chk_borrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_guardar;
        private System.Windows.Forms.PictureBox btn_guardar;
        private System.Windows.Forms.Label lbl_eliminar;
        private System.Windows.Forms.Label lbl_modificar;
        private System.Windows.Forms.PictureBox btn_borrar;
        private System.Windows.Forms.Label lbl_habilitar;
        private System.Windows.Forms.PictureBox btn_modificar;
        private System.Windows.Forms.PictureBox btn_Habilitar;
        private System.Windows.Forms.PictureBox btn_HabilitarGris;
    }
}