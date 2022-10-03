
namespace PRESENTACION
{
    partial class FormAlta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_agregar_producto = new System.Windows.Forms.Button();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.txtboxDescripcion = new System.Windows.Forms.TextBox();
            this.txtboxMarca = new System.Windows.Forms.TextBox();
            this.txtboxPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_agregar_producto
            // 
            this.Btn_agregar_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_agregar_producto.FlatAppearance.BorderSize = 0;
            this.Btn_agregar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar_producto.ForeColor = System.Drawing.Color.White;
            this.Btn_agregar_producto.Location = new System.Drawing.Point(677, 426);
            this.Btn_agregar_producto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_agregar_producto.Name = "Btn_agregar_producto";
            this.Btn_agregar_producto.Size = new System.Drawing.Size(135, 35);
            this.Btn_agregar_producto.TabIndex = 8;
            this.Btn_agregar_producto.Text = "Agregar producto";
            this.Btn_agregar_producto.UseVisualStyleBackColor = false;
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.BackColor = System.Drawing.Color.Black;
            this.txtboxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxNombre.ForeColor = System.Drawing.Color.White;
            this.txtboxNombre.Location = new System.Drawing.Point(35, 102);
            this.txtboxNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.PlaceholderText = "Nombre";
            this.txtboxNombre.Size = new System.Drawing.Size(357, 17);
            this.txtboxNombre.TabIndex = 2;
            // 
            // txtboxDescripcion
            // 
            this.txtboxDescripcion.BackColor = System.Drawing.Color.Black;
            this.txtboxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtboxDescripcion.Location = new System.Drawing.Point(35, 160);
            this.txtboxDescripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtboxDescripcion.Name = "txtboxDescripcion";
            this.txtboxDescripcion.PlaceholderText = "Descripción";
            this.txtboxDescripcion.Size = new System.Drawing.Size(357, 17);
            this.txtboxDescripcion.TabIndex = 3;
            // 
            // txtboxMarca
            // 
            this.txtboxMarca.BackColor = System.Drawing.Color.Black;
            this.txtboxMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxMarca.ForeColor = System.Drawing.Color.White;
            this.txtboxMarca.Location = new System.Drawing.Point(35, 218);
            this.txtboxMarca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtboxMarca.Name = "txtboxMarca";
            this.txtboxMarca.PlaceholderText = "Marca";
            this.txtboxMarca.Size = new System.Drawing.Size(357, 17);
            this.txtboxMarca.TabIndex = 4;
            // 
            // txtboxPrecio
            // 
            this.txtboxPrecio.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtboxPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxPrecio.ForeColor = System.Drawing.Color.White;
            this.txtboxPrecio.Location = new System.Drawing.Point(35, 275);
            this.txtboxPrecio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtboxPrecio.Name = "txtboxPrecio";
            this.txtboxPrecio.PlaceholderText = "Precio";
            this.txtboxPrecio.Size = new System.Drawing.Size(357, 17);
            this.txtboxPrecio.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carga de productos";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(138, 337);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 339);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cantidad";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(35, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 3);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(35, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 3);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(35, 241);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 3);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(35, 298);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(359, 3);
            this.panel4.TabIndex = 15;
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(836, 485);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxPrecio);
            this.Controls.Add(this.txtboxMarca);
            this.Controls.Add(this.txtboxDescripcion);
            this.Controls.Add(this.txtboxNombre);
            this.Controls.Add(this.Btn_agregar_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormAlta";
            this.Opacity = 0.9D;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_agregar_producto;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.TextBox txtboxDescripcion;
        private System.Windows.Forms.TextBox txtboxMarca;
        private System.Windows.Forms.TextBox txtboxPrecio;
        private System.Windows.Forms.Label label1;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}

