namespace ConvertirTemperatura
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Boton_Calculara = new Button();
            Texto_1 = new Label();
            Texto_2 = new Label();
            Texto_Celsius = new TextBox();
            Texto_Conversion = new Label();
            Titulo = new Label();
            SuspendLayout();
            // 
            // Boton_Calculara
            // 
            Boton_Calculara.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Boton_Calculara.Location = new Point(207, 191);
            Boton_Calculara.Name = "Boton_Calculara";
            Boton_Calculara.Size = new Size(120, 37);
            Boton_Calculara.TabIndex = 0;
            Boton_Calculara.Text = "Calcular";
            Boton_Calculara.UseVisualStyleBackColor = true;
            Boton_Calculara.Click += Boton_Calculara_Click;
            // 
            // Texto_1
            // 
            Texto_1.AutoSize = true;
            Texto_1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Texto_1.Location = new Point(12, 75);
            Texto_1.Name = "Texto_1";
            Texto_1.Size = new Size(521, 31);
            Texto_1.TabIndex = 1;
            Texto_1.Text = "Ingrese la temperatura a calcular en Celsius\r\n";
            // 
            // Texto_2
            // 
            Texto_2.AutoSize = true;
            Texto_2.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Texto_2.Location = new Point(55, 248);
            Texto_2.Name = "Texto_2";
            Texto_2.Size = new Size(426, 28);
            Texto_2.TabIndex = 2;
            Texto_2.Text = "La temperatura en grados Fahrenheit es: ";
            // 
            // Texto_Celsius
            // 
            Texto_Celsius.Location = new Point(207, 135);
            Texto_Celsius.Name = "Texto_Celsius";
            Texto_Celsius.Size = new Size(120, 23);
            Texto_Celsius.TabIndex = 3;
            // 
            // Texto_Conversion
            // 
            Texto_Conversion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Texto_Conversion.AutoSize = true;
            Texto_Conversion.BackColor = Color.IndianRed;
            Texto_Conversion.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Texto_Conversion.Location = new Point(256, 293);
            Texto_Conversion.Name = "Texto_Conversion";
            Texto_Conversion.Size = new Size(30, 26);
            Texto_Conversion.TabIndex = 4;
            Texto_Conversion.Text = "...";
            Texto_Conversion.Visible = false;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.BackColor = Color.IndianRed;
            Titulo.Font = new Font("Times New Roman", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(43, 26);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(444, 23);
            Titulo.TabIndex = 5;
            Titulo.Text = "Conversion de Temperatura de Celsius a Fahrenheit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 341);
            Controls.Add(Titulo);
            Controls.Add(Texto_Conversion);
            Controls.Add(Texto_Celsius);
            Controls.Add(Texto_2);
            Controls.Add(Texto_1);
            Controls.Add(Boton_Calculara);
            Name = "Form1";
            Text = "Conversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Boton_Calculara;
        private Label Texto_1;
        private Label Texto_2;
        private TextBox Texto_Celsius;
        private Label Texto_Conversion;
        private Label Titulo;
    }
}
