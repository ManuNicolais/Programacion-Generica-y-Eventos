namespace ConvertirTemperatura
{
    public partial class Form1 : Form
    {
        //variables
        float Temperatura_Celsius;
        float Temperatura_Fahrenheit;

        public Form1()
        {
            InitializeComponent();
        }
         
        private void Boton_Calculara_Click(object sender, EventArgs e)
        {
            try
            {
                Temperatura_Celsius = float.Parse(Texto_Celsius.Text);
                Temperatura_Fahrenheit = (Temperatura_Celsius * 9 / 5) + 32;

                Texto_Conversion.Text = Temperatura_Fahrenheit.ToString() + " °F";
                Texto_Conversion.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
