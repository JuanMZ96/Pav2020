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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.dgv_categorias = new System.Windows.Forms.DataGridView();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(302, 129);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(396, 129);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 1;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(486, 129);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar.TabIndex = 2;
            this.btn_borrar.Text = "Eliminar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(371, 35);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 3;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(371, 82);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(100, 20);
            this.txt_descripcion.TabIndex = 4;
            // 
            // dgv_categorias
            // 
            this.dgv_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categorias.Location = new System.Drawing.Point(12, 12);
            this.dgv_categorias.Name = "dgv_categorias";
            this.dgv_categorias.Size = new System.Drawing.Size(240, 150);
            this.dgv_categorias.TabIndex = 5;
            this.dgv_categorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(486, 185);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(100, 20);
            this.txt_value.TabIndex = 6;
            this.txt_value.Visible = false;
            this.txt_value.TextChanged += new System.EventHandler(this.txt_value_TextChanged);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(299, 40);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 7;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(299, 85);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(66, 13);
            this.lbl_descripcion.TabIndex = 8;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 209);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.dgv_categorias);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Name = "Categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorías";
            this.Load += new System.EventHandler(this.Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.DataGridView dgv_categorias;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_descripcion;
    }
}