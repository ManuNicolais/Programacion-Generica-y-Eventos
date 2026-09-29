using System;
using System.Data;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private string ultimoResultado = ""; // Var para almacenar el último resultado

        public Form1()
        {
            InitializeComponent();
            Lab_Datos.Text = "";
            TB_Resultado.Text = "";
        }
        
        private void Num_0_Click(object sender, EventArgs e)
        {
            AgregarNumero("0");
        }

        private void Num_1_Click(object sender, EventArgs e)
        {
            AgregarNumero("1");
        }

        private void Num_2_Click(object sender, EventArgs e)
        {
            AgregarNumero("2");
        }

        private void Num_3_Click(object sender, EventArgs e)
        {
            AgregarNumero("3");
        }

        private void Num_4_Click(object sender, EventArgs e)
        {
            AgregarNumero("4");
        }

        private void Num_5_Click(object sender, EventArgs e)
        {
            AgregarNumero("5");
        }

        private void Num_6_Click(object sender, EventArgs e)
        {
            AgregarNumero("6");
        }

        private void Num_7_Click(object sender, EventArgs e)
        {
            AgregarNumero("7");
        }

        private void Num_8_Click(object sender, EventArgs e)
        {
            AgregarNumero("8");
        }

        private void Num_9_Click(object sender, EventArgs e)
        {
            AgregarNumero("9");
        }

        private void Bot_Suma_Click(object sender, EventArgs e)
        {
            AgregarOperacion("+");
        }

        private void Bot_Resta_Click(object sender, EventArgs e)
        {
            AgregarOperacion("-");
        }

        private void Bot_Dividir_Click(object sender, EventArgs e)
        {
            AgregarOperacion("÷");
        }

        private void Bot_Multiplicar_Click(object sender, EventArgs e)
        {
            AgregarOperacion("×");
        }

        private void Bot_AC_Click(object sender, EventArgs e)
        {
            Lab_Datos.Text = "";
            TB_Resultado.Text = "";
            // No limpiamos el último resultado para que esté disponible para 'Ans'
        }

        private void Bot_Igual_Click(object sender, EventArgs e)
        {
            try
            {
                string expresion = Lab_Datos.Text.Replace("÷", "/").Replace("×", "*").Replace(",", ".");                // Reemplazamos "÷" por "/" y "×" por "*", y también reemplazamos "," por "."
                DataTable dt = new DataTable(); 
                var resultado = dt.Compute(expresion, ""); 
                TB_Resultado.Text = resultado.ToString(); 
                ultimoResultado = resultado.ToString(); //guardo el resultado para el Ans
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la expresión. Revisa los paréntesis o la operación.");
            }
        }

        private void Bot_Punto_Click(object sender, EventArgs e)
        {
            // Agregamos un punto en lugar de una coma
            Lab_Datos.Text += ".";
        }

        private void Bot_Del_Click(object sender, EventArgs e)
        {
            if (Lab_Datos.Text.Length > 0)
            {
                Lab_Datos.Text = Lab_Datos.Text.Substring(0, Lab_Datos.Text.Length - 1);
            }
        }

        private void AgregarNumero(string numero)
        {
            Lab_Datos.Text += numero;
        }

        private void AgregarOperacion(string operacion)
        {
            Lab_Datos.Text += $" {operacion} ";
        }

        private void Bot_Parentesis1_Click(object sender, EventArgs e)
        {
            Lab_Datos.Text += "(";
        }

        private void Bot_Parentesis2_Click(object sender, EventArgs e)
        {
            Lab_Datos.Text += ")";
        }

        private void Bot_Guardado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ultimoResultado))
            {
                AgregarNumero(ultimoResultado);
            }
        }
    }
}
