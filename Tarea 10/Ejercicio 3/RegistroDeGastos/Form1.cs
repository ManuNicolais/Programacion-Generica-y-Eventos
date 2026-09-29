using System;
using System.Windows.Forms;
using System.Drawing;

namespace RegistroDeGastos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IniciarGrid();
        }

        private void IniciarGrid()
        {
            // Configuramos las columnas del DataGridView
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Servicio";
            dataGridView1.Columns[1].Name = "Precio";
            dataGridView1.Columns[2].Name = "Moneda";

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkBlue;
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.Rows.Add("Agua", 5000, "Peso");
            dataGridView1.Rows.Add("Luz", 15000, "Dolar");
        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            try
            {//Verificaciones
                if (!string.IsNullOrWhiteSpace(textBox_Servicio.Text) &&
                    !string.IsNullOrWhiteSpace(textBox_Precio.Text) &&
                    comboBox_Monedas.SelectedIndex != -1)
                {
                    float precio = float.Parse(textBox_Precio.Text);
                    string moneda = comboBox_Monedas.SelectedItem.ToString();

                    dataGridView1.Rows.Add(textBox_Servicio.Text, precio, moneda);

                    textBox_Servicio.Clear();
                    textBox_Precio.Clear();
                    comboBox_Monedas.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Por favor, completa todos los campos (servicio, precio y moneda).",
                                    "Campos Vacíos",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un precio válido.",
                                "Error de Formato",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private float ConvertirAPesos(float precio, string moneda)
        {
            switch (moneda)
            {
                case "Peso":
                    return precio;
                case "Dolar":
                    return precio * 1200;
                case "Euro":
                    return precio * 1300;
                case "Real":
                    return precio * 230;
                case "Yen":
                    return precio * 8;
                default:
                    return 0;
            }
        }

        private void button_Conversion_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0 || dataGridView1.Rows[0].Cells[1].Value == null)
            {
                MessageBox.Show("No hay datos en el grid para convertir.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            float totalEnPesos = 0;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells[1].Value != null && fila.Cells[2].Value != null)
                {
                    try
                    {
                        float precio = float.Parse(fila.Cells[1].Value.ToString());
                        string moneda = fila.Cells[2].Value.ToString();
                        totalEnPesos += ConvertirAPesos(precio, moneda);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Uno de los precios no es válido.",
                                        "Error de Formato",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }

            label_conversion.Visible = true;
            label_conversion.Text = totalEnPesos.ToString("N2") + " Pesos";
        }
    }
}
