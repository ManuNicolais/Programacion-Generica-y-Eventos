using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tarea9Estudiantes
{
    public partial class Form1 : Form
    {
        private Grupo grupo;

        public Form1()
        {
            InitializeComponent();
            grupo = new Grupo(); // Inicializar el grupo de estudiantes
        }

        // Evento para agregar un estudiante
        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                int edad = int.Parse(txtEdad.Text);

                // Obtener las tres notas
                float nota1 = float.Parse(txtNota1.Text);
                float nota2 = float.Parse(txtNota2.Text);
                float nota3 = float.Parse(txtNota3.Text);

                // Crear una instancia de Estudiante con las tres notas
                Estudiante estudiante = new Estudiante(nombre, edad, new float[] { nota1, nota2, nota3 });
                grupo.AgregarEstudiante(estudiante);

                MessageBox.Show($"Estudiante {nombre} agregado correctamente.");
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

        // Evento para calcular el promedio de notas del grupo
        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            if (grupo.NumEstudiantes > 0)
            {
                float promedio = grupo.CalcularPromedio();
                MessageBox.Show($"El promedio de notas del grupo es: {promedio}");
            }
            else
            {
                MessageBox.Show("No hay estudiantes en el grupo.");
            }
        }
    }

    // Clase Estudiante
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public float[] Notas { get; set; }

        // Constructor que recibe las tres notas
        public Estudiante(string nombre, int edad, float[] notas)
        {
            Nombre = nombre;
            Edad = edad;
            Notas = notas;
        }

        // Método para calcular el promedio de las tres notas
        public float CalcularPromedio()
        {
            float suma = 0;
            foreach (float nota in Notas)
            {
                suma += nota;
            }
            return suma / Notas.Length;
        }
    }

    // Clase Grupo
    public class Grupo
    {
        private List<Estudiante> estudiantes;

        public Grupo()
        {
            estudiantes = new List<Estudiante>();
        }

        public int NumEstudiantes
        {
            get { return estudiantes.Count; }
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            estudiantes.Add(estudiante);
        }

        // Calcular el promedio de todos los estudiantes en el grupo
        public float CalcularPromedio()
        {
            float suma = 0;
            foreach (Estudiante estudiante in estudiantes)
            {
                suma += estudiante.CalcularPromedio();
            }
            return suma / estudiantes.Count;
        }
    }
}
