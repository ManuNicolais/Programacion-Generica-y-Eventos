using System;
using System.Windows.Forms;

namespace CuentaBancariaApp
{
    public partial class Form1 : Form
    {
        // Instancias de cuentas
        private CuentaCorriente cuentaCorriente;
        private CuentaAhorro cuentaAhorro;

        public Form1()
        {
            InitializeComponent();

            // Inicializamos las cuentas con datos de ejemplo
            cuentaCorriente = new CuentaCorriente(1000, "CC12345"); // Saldo inicial de 1000
            cuentaAhorro = new CuentaAhorro(2000, "CA67890"); // Saldo inicial de 2000

            // Actualizamos la UI con los datos iniciales
            UpdateUI();
        }

        // Método que actualiza los valores de las etiquetas con el saldo y número de cuenta
        private void UpdateUI()
        {
            lblSaldoCorriente.Text = $"Saldo Corriente: {cuentaCorriente.Saldo.ToString("C2")}";
            lblNumeroCorriente.Text = $"Número Corriente: {cuentaCorriente.NumeroCuenta}";

            lblSaldoAhorro.Text = $"Saldo Ahorro: {cuentaAhorro.Saldo.ToString("C2")}";
            lblNumeroAhorro.Text = $"Número Ahorro: {cuentaAhorro.NumeroCuenta}";
        }

        // Evento al hacer clic en el botón "Cobrar Comisión"
        private void btnCobrarComision_Click(object sender, EventArgs e)
        {
            try
            {
                int comision = 10; // Comision fija de ejemplo
                cuentaCorriente.CobrarComisiones(comision);
                MessageBox.Show($"Se ha cobrado una comisión de {comision} en la Cuenta Corriente.", "Comisión Cobrada");
                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cobrar la comisión: {ex.Message}", "Error");
            }
        }

        // Evento al hacer clic en el botón "Calcular Intereses"
        private void btnCalcularIntereses_Click(object sender, EventArgs e)
        {
            try
            {
                int interes = 5; // Interés del 5%
                cuentaAhorro.CalcularIntereses(interes);
                MessageBox.Show($"Se ha calculado un interés del {interes}% en la Cuenta de Ahorro.", "Intereses Calculados");
                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular los intereses: {ex.Message}", "Error");
            }
        }
    }

    // Clase CuentaBancaria
    public class CuentaBancaria
    {
        public float Saldo { get; set; }
        public string NumeroCuenta { get; set; }

        public CuentaBancaria(float saldo, string numeroCuenta)
        {
            Saldo = saldo;
            NumeroCuenta = numeroCuenta;
        }

        public CuentaBancaria() : this(0, "") { }
    }

    // Clase CuentaCorriente
    public class CuentaCorriente : CuentaBancaria
    {
        public CuentaCorriente(float saldo, string numeroCuenta) : base(saldo, numeroCuenta) { }

        public CuentaCorriente() : base() { }

        public void CobrarComisiones(int comision)
        {
            if (Saldo < comision)
                throw new InvalidOperationException("El saldo es insuficiente para cobrar la comisión.");

            Saldo -= comision;
        }
    }

    // Clase CuentaAhorro
    public class CuentaAhorro : CuentaBancaria
    {
        public CuentaAhorro(float saldo, string numeroCuenta) : base(saldo, numeroCuenta) { }

        public void CalcularIntereses(int interes)
        {
            if (interes < 0)
                throw new ArgumentException("El interés no puede ser negativo.");

            Saldo -= Saldo * interes / 100;
        }
    }
}
