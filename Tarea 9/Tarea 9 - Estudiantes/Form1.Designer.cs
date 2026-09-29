namespace Tarea9Estudiantes
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Button btnAgregarEstudiante;
        private System.Windows.Forms.Button btnCalcularPromedio;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.btnCalcularPromedio = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(12, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.PlaceholderText = "Nombre";

            // txtEdad
            this.txtEdad.Location = new System.Drawing.Point(12, 38);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 1;
            this.txtEdad.PlaceholderText = "Edad";

            // txtNota1
            this.txtNota1.Location = new System.Drawing.Point(12, 64);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 2;
            this.txtNota1.PlaceholderText = "Nota 1";

            // txtNota2
            this.txtNota2.Location = new System.Drawing.Point(12, 90);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 3;
            this.txtNota2.PlaceholderText = "Nota 2";

            // txtNota3
            this.txtNota3.Location = new System.Drawing.Point(12, 116);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 4;
            this.txtNota3.PlaceholderText = "Nota 3";

            // btnAgregarEstudiante
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(12, 142);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(130, 23);
            this.btnAgregarEstudiante.TabIndex = 5;
            this.btnAgregarEstudiante.Text = "Agregar Estudiante";
            this.btnAgregarEstudiante.UseVisualStyleBackColor = true;
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.btnAgregarEstudiante_Click);

            // btnCalcularPromedio
            this.btnCalcularPromedio.Location = new System.Drawing.Point(12, 171);
            this.btnCalcularPromedio.Name = "btnCalcularPromedio";
            this.btnCalcularPromedio.Size = new System.Drawing.Size(130, 23);
            this.btnCalcularPromedio.TabIndex = 6;
            this.btnCalcularPromedio.Text = "Calcular Promedio";
            this.btnCalcularPromedio.UseVisualStyleBackColor = true;
            this.btnCalcularPromedio.Click += new System.EventHandler(this.btnCalcularPromedio_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCalcularPromedio);
            this.Controls.Add(this.btnAgregarEstudiante);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Gestión de Estudiantes";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
