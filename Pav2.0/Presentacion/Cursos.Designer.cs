namespace Pav2.Presentacion
{
    partial class Cursos
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
            this.dgv_cursos = new System.Windows.Forms.DataGridView();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_fechaVigencia = new System.Windows.Forms.Label();
            this.dtp_datatime = new System.Windows.Forms.DateTimePicker();
            this.chk_todo = new System.Windows.Forms.CheckBox();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.chk_borrado = new System.Windows.Forms.CheckBox();
            this.lbl_categorias = new System.Windows.Forms.Label();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.lbl_eliminar = new System.Windows.Forms.Label();
            this.lbl_modificar = new System.Windows.Forms.Label();
            this.lbl_habilitar = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_guardar = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.PictureBox();
            this.btn_borrar = new System.Windows.Forms.PictureBox();
            this.btn_modificar = new System.Windows.Forms.PictureBox();
            this.btn_habilitar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_borrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_modificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_habilitar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cursos
            // 
            this.dgv_cursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_cursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cursos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cursos.Location = new System.Drawing.Point(41, 40);
            this.dgv_cursos.Name = "dgv_cursos";
            this.dgv_cursos.ReadOnly = true;
            this.dgv_cursos.Size = new System.Drawing.Size(562, 394);
            this.dgv_cursos.TabIndex = 6;
            this.dgv_cursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cursos_CellContentClick);
            this.dgv_cursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cursos_CellContentClick);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(45, 70);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 9;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_name.Location = new System.Drawing.Point(116, 67);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(162, 20);
            this.txt_name.TabIndex = 8;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(45, 108);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(66, 13);
            this.lbl_descripcion.TabIndex = 11;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_descripcion.Location = new System.Drawing.Point(116, 105);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(162, 74);
            this.txt_descripcion.TabIndex = 10;
            // 
            // lbl_fechaVigencia
            // 
            this.lbl_fechaVigencia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_fechaVigencia.AutoSize = true;
            this.lbl_fechaVigencia.Location = new System.Drawing.Point(45, 238);
            this.lbl_fechaVigencia.Name = "lbl_fechaVigencia";
            this.lbl_fechaVigencia.Size = new System.Drawing.Size(84, 13);
            this.lbl_fechaVigencia.TabIndex = 15;
            this.lbl_fechaVigencia.Text = "Fecha Vigencia:";
            // 
            // dtp_datatime
            // 
            this.dtp_datatime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtp_datatime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datatime.Location = new System.Drawing.Point(135, 238);
            this.dtp_datatime.Name = "dtp_datatime";
            this.dtp_datatime.Size = new System.Drawing.Size(143, 20);
            this.dtp_datatime.TabIndex = 16;
            // 
            // chk_todo
            // 
            this.chk_todo.AutoSize = true;
            this.chk_todo.Location = new System.Drawing.Point(505, 450);
            this.chk_todo.Name = "chk_todo";
            this.chk_todo.Size = new System.Drawing.Size(98, 17);
            this.chk_todo.TabIndex = 17;
            this.chk_todo.Text = "Incluir borrados";
            this.chk_todo.UseVisualStyleBackColor = true;
            this.chk_todo.CheckedChanged += new System.EventHandler(this.chk_todo_CheckedChanged);
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(507, 512);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(58, 20);
            this.txt_value.TabIndex = 18;
            this.txt_value.Visible = false;
            // 
            // chk_borrado
            // 
            this.chk_borrado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chk_borrado.AutoSize = true;
            this.chk_borrado.Location = new System.Drawing.Point(505, 488);
            this.chk_borrado.Name = "chk_borrado";
            this.chk_borrado.Size = new System.Drawing.Size(77, 17);
            this.chk_borrado.TabIndex = 19;
            this.chk_borrado.Text = "EliminarDB";
            this.chk_borrado.UseVisualStyleBackColor = true;
            this.chk_borrado.Visible = false;
            // 
            // lbl_categorias
            // 
            this.lbl_categorias.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_categorias.AutoSize = true;
            this.lbl_categorias.Location = new System.Drawing.Point(45, 203);
            this.lbl_categorias.Name = "lbl_categorias";
            this.lbl_categorias.Size = new System.Drawing.Size(57, 13);
            this.lbl_categorias.TabIndex = 20;
            this.lbl_categorias.Text = "Categoría:";
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(116, 200);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(162, 21);
            this.cmb_categoria.TabIndex = 21;
            // 
            // lbl_eliminar
            // 
            this.lbl_eliminar.AutoSize = true;
            this.lbl_eliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_eliminar.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_eliminar.Location = new System.Drawing.Point(124, 491);
            this.lbl_eliminar.Name = "lbl_eliminar";
            this.lbl_eliminar.Size = new System.Drawing.Size(43, 13);
            this.lbl_eliminar.TabIndex = 34;
            this.lbl_eliminar.Text = "Eliminar";
            this.lbl_eliminar.Visible = false;
            // 
            // lbl_modificar
            // 
            this.lbl_modificar.AutoSize = true;
            this.lbl_modificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_modificar.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_modificar.Location = new System.Drawing.Point(82, 491);
            this.lbl_modificar.Name = "lbl_modificar";
            this.lbl_modificar.Size = new System.Drawing.Size(50, 13);
            this.lbl_modificar.TabIndex = 33;
            this.lbl_modificar.Text = "Modificar";
            this.lbl_modificar.Visible = false;
            // 
            // lbl_habilitar
            // 
            this.lbl_habilitar.AutoSize = true;
            this.lbl_habilitar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_habilitar.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_habilitar.Location = new System.Drawing.Point(169, 491);
            this.lbl_habilitar.Name = "lbl_habilitar";
            this.lbl_habilitar.Size = new System.Drawing.Size(45, 13);
            this.lbl_habilitar.TabIndex = 32;
            this.lbl_habilitar.Text = "Habilitar";
            this.lbl_habilitar.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txt_name);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_nombre);
            this.splitContainer1.Panel1.Controls.Add(this.txt_descripcion);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_descripcion);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_fechaVigencia);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_datatime);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_categorias);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_categoria);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbl_guardar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_guardar);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_cursos);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_eliminar);
            this.splitContainer1.Panel2.Controls.Add(this.chk_todo);
            this.splitContainer1.Panel2.Controls.Add(this.txt_value);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_modificar);
            this.splitContainer1.Panel2.Controls.Add(this.chk_borrado);
            this.splitContainer1.Panel2.Controls.Add(this.btn_borrar);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_habilitar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_modificar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_habilitar);
            this.splitContainer1.Size = new System.Drawing.Size(970, 564);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.TabIndex = 35;
            // 
            // lbl_guardar
            // 
            this.lbl_guardar.AutoSize = true;
            this.lbl_guardar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_guardar.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_guardar.Location = new System.Drawing.Point(38, 491);
            this.lbl_guardar.Name = "lbl_guardar";
            this.lbl_guardar.Size = new System.Drawing.Size(45, 13);
            this.lbl_guardar.TabIndex = 35;
            this.lbl_guardar.Text = "Guardar";
            this.lbl_guardar.Visible = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::Pav2.Properties.Resources.Save;
            this.btn_guardar.Location = new System.Drawing.Point(41, 450);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(38, 38);
            this.btn_guardar.TabIndex = 25;
            this.btn_guardar.TabStop = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click_1);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Image = global::Pav2.Properties.Resources.Delete;
            this.btn_borrar.Location = new System.Drawing.Point(127, 450);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(36, 38);
            this.btn_borrar.TabIndex = 29;
            this.btn_borrar.TabStop = false;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click_1);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Image = global::Pav2.Properties.Resources.Edit1;
            this.btn_modificar.Location = new System.Drawing.Point(85, 450);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(36, 38);
            this.btn_modificar.TabIndex = 30;
            this.btn_modificar.TabStop = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click_1);
            // 
            // btn_habilitar
            // 
            this.btn_habilitar.Image = global::Pav2.Properties.Resources.Add;
            this.btn_habilitar.Location = new System.Drawing.Point(173, 450);
            this.btn_habilitar.Name = "btn_habilitar";
            this.btn_habilitar.Size = new System.Drawing.Size(37, 38);
            this.btn_habilitar.TabIndex = 31;
            this.btn_habilitar.TabStop = false;
            this.btn_habilitar.Click += new System.EventHandler(this.btn_habilitar_Click);
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 588);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Cursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cursos)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_borrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_modificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_habilitar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cursos;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_fechaVigencia;
        private System.Windows.Forms.DateTimePicker dtp_datatime;
        private System.Windows.Forms.CheckBox chk_todo;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.CheckBox chk_borrado;
        private System.Windows.Forms.Label lbl_categorias;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.Label lbl_eliminar;
        private System.Windows.Forms.Label lbl_modificar;
        private System.Windows.Forms.Label lbl_habilitar;
        private System.Windows.Forms.PictureBox btn_habilitar;
        private System.Windows.Forms.PictureBox btn_modificar;
        private System.Windows.Forms.PictureBox btn_borrar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox btn_guardar;
        private System.Windows.Forms.Label lbl_guardar;
    }
}