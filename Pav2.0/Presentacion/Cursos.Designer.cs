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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.lbl_fechaVigencia = new System.Windows.Forms.Label();
            this.dtp_datatime = new System.Windows.Forms.DateTimePicker();
            this.chk_todo = new System.Windows.Forms.CheckBox();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.chk_borrado = new System.Windows.Forms.CheckBox();
            this.lbl_categorias = new System.Windows.Forms.Label();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cursos
            // 
            this.dgv_cursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_cursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cursos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cursos.Location = new System.Drawing.Point(12, 12);
            this.dgv_cursos.Name = "dgv_cursos";
            this.dgv_cursos.ReadOnly = true;
            this.dgv_cursos.Size = new System.Drawing.Size(559, 324);
            this.dgv_cursos.TabIndex = 6;
            this.dgv_cursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cursos_CellContentClick);
            this.dgv_cursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cursos_CellContentClick);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(688, 47);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 9;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_name.Location = new System.Drawing.Point(741, 44);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(171, 20);
            this.txt_name.TabIndex = 8;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(670, 85);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(66, 13);
            this.lbl_descripcion.TabIndex = 11;
            this.lbl_descripcion.Text = "Descripcion:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_descripcion.Location = new System.Drawing.Point(741, 82);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(171, 20);
            this.txt_descripcion.TabIndex = 10;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_guardar.Location = new System.Drawing.Point(628, 307);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(78, 29);
            this.btn_guardar.TabIndex = 12;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click_1);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_borrar.Location = new System.Drawing.Point(830, 307);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(82, 29);
            this.btn_borrar.TabIndex = 13;
            this.btn_borrar.Text = "Eliminar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click_1);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_modificar.Location = new System.Drawing.Point(727, 307);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(80, 29);
            this.btn_modificar.TabIndex = 14;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click_1);
            // 
            // lbl_fechaVigencia
            // 
            this.lbl_fechaVigencia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_fechaVigencia.AutoSize = true;
            this.lbl_fechaVigencia.Location = new System.Drawing.Point(651, 155);
            this.lbl_fechaVigencia.Name = "lbl_fechaVigencia";
            this.lbl_fechaVigencia.Size = new System.Drawing.Size(84, 13);
            this.lbl_fechaVigencia.TabIndex = 15;
            this.lbl_fechaVigencia.Text = "Fecha Vigencia:";
            // 
            // dtp_datatime
            // 
            this.dtp_datatime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtp_datatime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datatime.Location = new System.Drawing.Point(741, 149);
            this.dtp_datatime.Name = "dtp_datatime";
            this.dtp_datatime.Size = new System.Drawing.Size(171, 20);
            this.dtp_datatime.TabIndex = 16;
            // 
            // chk_todo
            // 
            this.chk_todo.AutoSize = true;
            this.chk_todo.Location = new System.Drawing.Point(12, 361);
            this.chk_todo.Name = "chk_todo";
            this.chk_todo.Size = new System.Drawing.Size(98, 17);
            this.chk_todo.TabIndex = 17;
            this.chk_todo.Text = "Incluir borrados";
            this.chk_todo.UseVisualStyleBackColor = true;
            this.chk_todo.CheckedChanged += new System.EventHandler(this.chk_todo_CheckedChanged);
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(116, 358);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(171, 20);
            this.txt_value.TabIndex = 18;
            this.txt_value.Visible = false;
            // 
            // chk_borrado
            // 
            this.chk_borrado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chk_borrado.AutoSize = true;
            this.chk_borrado.Location = new System.Drawing.Point(691, 217);
            this.chk_borrado.Name = "chk_borrado";
            this.chk_borrado.Size = new System.Drawing.Size(77, 17);
            this.chk_borrado.TabIndex = 19;
            this.chk_borrado.Text = "EliminarDB";
            this.chk_borrado.UseVisualStyleBackColor = true;
            // 
            // lbl_categorias
            // 
            this.lbl_categorias.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_categorias.AutoSize = true;
            this.lbl_categorias.Location = new System.Drawing.Point(680, 120);
            this.lbl_categorias.Name = "lbl_categorias";
            this.lbl_categorias.Size = new System.Drawing.Size(55, 13);
            this.lbl_categorias.TabIndex = 20;
            this.lbl_categorias.Text = "Categoria:";
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(741, 117);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(171, 21);
            this.cmb_categoria.TabIndex = 21;
            // 
            // chk_estado
            // 
            this.chk_estado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(741, 184);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(15, 14);
            this.chk_estado.TabIndex = 22;
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // lbl_estado
            // 
            this.lbl_estado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(688, 185);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(43, 13);
            this.lbl_estado.TabIndex = 23;
            this.lbl_estado.Text = "Estado:";
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.chk_estado);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.lbl_categorias);
            this.Controls.Add(this.chk_borrado);
            this.Controls.Add(this.chk_todo);
            this.Controls.Add(this.dtp_datatime);
            this.Controls.Add(this.lbl_fechaVigencia);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.dgv_cursos);
            this.Controls.Add(this.txt_value);
            this.Name = "Cursos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cursos;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label lbl_fechaVigencia;
        private System.Windows.Forms.DateTimePicker dtp_datatime;
        private System.Windows.Forms.CheckBox chk_todo;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.CheckBox chk_borrado;
        private System.Windows.Forms.Label lbl_categorias;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.CheckBox chk_estado;
        private System.Windows.Forms.Label lbl_estado;
    }
}