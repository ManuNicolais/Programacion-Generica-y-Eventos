using System;
using System.Windows.Forms;

namespace Tarea9Persona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Asignar eventos a los botones
            btnCrearPersona.Click += EventDispatcher;
            btnCrearEmpleado.Click += EventDispatcher;
        }

        // Dispatcher centralizado para manejar eventos de botón
        private void EventDispatcher(object sender, EventArgs e)
        {
            try
            {
                if (sender == btnCrearPersona)
                {
                    CrearPersona();
                }
                else if (sender == btnCrearEmpleado)
                {
                    CrearEmpleado();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error en el formato de entrada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para crear una Persona
        private void CrearPersona()
        {
            string nombre = txtNombre.Text;

            // Asegurarse de que la edad sea un número válido
            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                throw new FormatException("La edad debe ser un número entero.");
            }

            string genero = txtGenero.Text;

            // Crear una instancia de Persona
            Persona persona = new Persona(nombre, edad, genero);

            MessageBox.Show($"Persona creada:\nNombre: {persona.Nombre}\nEdad: {persona.Edad}\nGénero: {persona.Genero}");
        }

        // Método para crear un Empleado
        private void CrearEmpleado()
        {
            string nombre = txtNombre.Text;

            // Asegurarse de que la edad sea un número válido
            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                throw new FormatException("La edad debe ser un número entero.");
            }

            string genero = txtGenero.Text;

            // Asegurarse de que el salario sea un número válido
            if (!float.TryParse(txtSalario.Text, out float salario))
            {
                throw new FormatException("El salario debe ser un número.");
            }

            string cargo = txtCargo.Text;

            // Crear una instancia de Empleado
            Empleado empleado = new Empleado(nombre, edad, genero, salario, cargo);

            MessageBox.Show($"Empleado creado:\nNombre: {empleado.Nombre}\nEdad: {empleado.Edad}\nGénero: {empleado.Genero}\nSalario: {empleado.Salario}\nCargo: {empleado.Cargo}");
        }
    }

    // Definición de la clase Persona
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }

        public Persona(string nombre, int edad, string genero)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
        }
    }

    // Definición de la clase Empleado que hereda de Persona
    public class Empleado : Persona
    {
        public float Salario { get; set; }
        public string Cargo { get; set; }

        public Empleado(string nombre, int edad, string genero, float salario, string cargo)
            : base(nombre, edad, genero)
        {
            Salario = salario;
            Cargo = cargo;
        }
    }
}
