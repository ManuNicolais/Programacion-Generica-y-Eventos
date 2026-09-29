namespace RegistroDeGastos
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Servicio = new System.Windows.Forms.TextBox();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            this.comboBox_Monedas = new System.Windows.Forms.ComboBox();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_conversion = new System.Windows.Forms.Label();
            this.button_Conversion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion de Gasto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio de Gasto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccion de Moneda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Agregar a Lista";
            // 
            // textBox_Servicio
            // 
            this.textBox_Servicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Servicio.Location = new System.Drawing.Point(288, 24);
            this.textBox_Servicio.Name = "textBox_Servicio";
            this.textBox_Servicio.Size = new System.Drawing.Size(130, 32);
            this.textBox_Servicio.TabIndex = 4;
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Precio.Location = new System.Drawing.Point(288, 73);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.Size = new System.Drawing.Size(130, 32);
            this.textBox_Precio.TabIndex = 5;
            // 
            // comboBox_Monedas
            // 
            this.comboBox_Monedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Monedas.FormattingEnabled = true;
            this.comboBox_Monedas.Items.AddRange(new object[] {
            "Peso",
            "Dolar",
            "Euro",
            "Real",
            "Yen"});
            this.comboBox_Monedas.Location = new System.Drawing.Point(288, 123);
            this.comboBox_Monedas.Name = "comboBox_Monedas";
            this.comboBox_Monedas.Size = new System.Drawing.Size(130, 33);
            this.comboBox_Monedas.TabIndex = 6;
            // 
            // button_Agregar
            // 
            this.button_Agregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Agregar.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Agregar.Location = new System.Drawing.Point(288, 174);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(130, 33);
            this.button_Agregar.TabIndex = 7;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = false;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Conversion de Moneda";
            // 
            // label_conversion
            // 
            this.label_conversion.AutoSize = true;
            this.label_conversion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_conversion.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_conversion.Location = new System.Drawing.Point(87, 274);
            this.label_conversion.Name = "label_conversion";
            this.label_conversion.Size = new System.Drawing.Size(35, 31);
            this.label_conversion.TabIndex = 10;
            this.label_conversion.Text = "...";
            this.label_conversion.Visible = false;
            // 
            // button_Conversion
            // 
            this.button_Conversion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Conversion.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Conversion.Location = new System.Drawing.Point(165, 312);
            this.button_Conversion.Name = "button_Conversion";
            this.button_Conversion.Size = new System.Drawing.Size(130, 33);
            this.button_Conversion.TabIndex = 14;
            this.button_Conversion.Text = "Convertir";
            this.button_Conversion.UseVisualStyleBackColor = false;
            this.button_Conversion.Click += new System.EventHandler(this.button_Conversion_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleDescription = "";
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(439, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(330, 280);
            this.dataGridView1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Conversion);
            this.Controls.Add(this.label_conversion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Agregar);
            this.Controls.Add(this.comboBox_Monedas);
            this.Controls.Add(this.textBox_Precio);
            this.Controls.Add(this.textBox_Servicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registro de Gastos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Servicio;
        private System.Windows.Forms.TextBox textBox_Precio;
        private System.Windows.Forms.ComboBox comboBox_Monedas;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_conversion;
        private System.Windows.Forms.Button button_Conversion;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

