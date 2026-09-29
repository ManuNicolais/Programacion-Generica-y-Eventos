using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tarea_10___Act_5___Imagenes
{
    public partial class Form1 : Form
    {
        private int zoomLevel = 100; // Iniciar el nivel de zoom en 100% (tamaño original)
        private int brilloLevel = 0; // Nivel inicial de brillo
        private Image originalImage;  // Guardar la imagen original

        public Form1()
        {
            InitializeComponent();
            // Ajustar el PictureBox para que la imagen se ajuste a su tamaño
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Configurar valores iniciales para los trackbars
            trackBar_Zoom.Minimum = 10;  // Por ejemplo, 10% como valor mínimo
            trackBar_Zoom.Maximum = 200; // Por ejemplo, 200% como valor máximo
            trackBar_Zoom.Value = zoomLevel; // Establecer el valor inicial de zoom

            trackBar_Brillo.Minimum = -100; // Rango de brillo: -100 (oscurecer) a +100 (aclarar)
            trackBar_Brillo.Maximum = 100;
            trackBar_Brillo.Value = brilloLevel; // Establecer el valor inicial de brillo
        }

        private void trackBar_Zoom_Scroll(object sender, EventArgs e)
        {
            zoomLevel = trackBar_Zoom.Value; // Actualizar el nivel de zoom según el valor del trackbar
            ApplyImageAdjustments(); // Aplicar zoom y brillo
        }

        private void trackBar_Brillo_Scroll(object sender, EventArgs e)
        {
            brilloLevel = trackBar_Brillo.Value; // Actualizar el nivel de brillo
            ApplyImageAdjustments(); // Aplicar zoom y brillo
        }

        // Función para ajustar el brillo de una imagen
        private Bitmap AdjustBrightness(Bitmap image, int brightness)
        {
            Bitmap tempBitmap = new Bitmap(image.Width, image.Height);

            // Factor de brillo (se convierte el valor a un rango entre -1.0 y 1.0)
            float brightnessFactor = brightness / 100f;

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    // Obtener el color original del píxel
                    Color originalColor = image.GetPixel(x, y);

                    // Ajustar los canales RGB según el factor de brillo
                    int r = (int)(originalColor.R + (255 * brightnessFactor));
                    int g = (int)(originalColor.G + (255 * brightnessFactor));
                    int b = (int)(originalColor.B + (255 * brightnessFactor));

                    // Limitar los valores entre 0 y 255
                    r = Math.Max(0, Math.Min(r, 255));
                    g = Math.Max(0, Math.Min(g, 255));
                    b = Math.Max(0, Math.Min(b, 255));

                    // Asignar el nuevo color ajustado
                    Color newColor = Color.FromArgb(r, g, b);
                    tempBitmap.SetPixel(x, y, newColor);
                }
            }

            return tempBitmap;
        }

        // Función para aplicar zoom y brillo
        private void ApplyImageAdjustments()
        {
            if (originalImage == null)
            {
                return; // Si no hay imagen cargada, no hacer nada
            }

            // Aplicar el nivel de zoom a la imagen
            float zoomFactor = zoomLevel / 100f; // Convertir el nivel de zoom a un factor (1 = tamaño original)
            int newWidth = (int)(originalImage.Width * zoomFactor);
            int newHeight = (int)(originalImage.Height * zoomFactor);

            if (newWidth > 0 && newHeight > 0)
            {
                // Crear una nueva imagen redimensionada con el nivel de zoom
                Bitmap zoomedImage = new Bitmap(originalImage, newWidth, newHeight);

                // Aplicar el brillo a la imagen redimensionada
                Bitmap brightenedImage = AdjustBrightness(zoomedImage, brilloLevel);

                // Mostrar la imagen ajustada en el PictureBox
                pictureBox1.Image = brightenedImage;

                // Ajustar la imagen al tamaño del PictureBox
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(open.FileName);  // Cargamos la imagen original
                pictureBox1.Image = new Bitmap(originalImage); // Mostrar imagen en el PictureBox
                ApplyImageAdjustments(); // Aplicar ajustes iniciales
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("No hay imagen cargada para aplicar los ajustes.");
                return;
            }

            ApplyImageAdjustments(); // Aplicar zoom y brillo
        }

        private void Btn_Guardarr_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No hay imagen para guardar.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.bmp;)|*.jpg; *.jpeg; *.bmp;";
            saveFileDialog.DefaultExt = "jpg";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image.Save(saveFileDialog.FileName); // Guardar la imagen con los cambios
                    MessageBox.Show("Imagen guardada correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la imagen: " + ex.Message);
                }
            }
        }
    }
}
