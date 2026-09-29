namespace Tarea9Persona
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Button btnCrearPersona;
        private System.Windows.Forms.Button btnCrearEmpleado;

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
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.btnCrearPersona = new System.Windows.Forms.Button();
            this.btnCrearEmpleado = new System.Windows.Forms.Button();
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

            // txtGenero
            this.txtGenero.Location = new System.Drawing.Point(12, 64);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 2;
            this.txtGenero.PlaceholderText = "Genero";

            // txtSalario
            this.txtSalario.Location = new System.Drawing.Point(12, 90);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 3;
            this.txtSalario.PlaceholderText = "Salario";

            // txtCargo
            this.txtCargo.Location = new System.Drawing.Point(12, 116);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 4;
            this.txtCargo.PlaceholderText = "Cargo";

            // btnCrearPersona
            this.btnCrearPersona.Location = new System.Drawing.Point(12, 142);
            this.btnCrearPersona.Name = "btnCrearPersona";
            this.btnCrearPersona.Size = new System.Drawing.Size(100, 23);
            this.btnCrearPersona.TabIndex = 5;
            this.btnCrearPersona.Text = "Crear Persona";
            this.btnCrearPersona.UseVisualStyleBackColor = true;

            // btnCrearEmpleado
            this.btnCrearEmpleado.Location = new System.Drawing.Point(12, 171);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(100, 23);
            this.btnCrearEmpleado.TabIndex = 6;
            this.btnCrearEmpleado.Text = "Crear Empleado";
            this.btnCrearEmpleado.UseVisualStyleBackColor = true;

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCrearEmpleado);
            this.Controls.Add(this.btnCrearPersona);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Migración a WinForms";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
