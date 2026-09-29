using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LienzoApp
{
    public partial class MainWindow : Window
    {
        private bool dibujando = false;
        private Polyline lineaActual;
        private Brush colorActual = Brushes.Black;
        private double grosorActual = 2;
        private bool controlesVisibles = true; // Estado para controlar la visibilidad de los controles

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Lienzo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                dibujando = true;

                lineaActual = new Polyline
                {
                    Stroke = colorActual,
                    StrokeThickness = grosorActual
                };

                lineaActual.Points.Add(e.GetPosition(Lienzo));
                Lienzo.Children.Add(lineaActual);
            }
        }

        private void Lienzo_MouseMove(object sender, MouseEventArgs e)
        {
            if (dibujando)
            {
                lineaActual.Points.Add(e.GetPosition(Lienzo));
            }
        }

        private void Lienzo_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released)
            {
                dibujando = false;
            }
        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var comboBox = sender as System.Windows.Controls.ComboBox;
            var selectedItem = comboBox.SelectedItem as System.Windows.Controls.ComboBoxItem;
            var color = selectedItem.Tag.ToString();
            colorActual = (Brush)new BrushConverter().ConvertFromString(color);
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            grosorActual = e.NewValue;
        }

        private void ButtonBorrador_Click(object sender, RoutedEventArgs e)
        {
            // Cambia el pincel a color blanco para usar como "borrador"
            colorActual = Brushes.White;
        }

        private void ButtonLimpiar_Click(object sender, RoutedEventArgs e)
        {
            // Usamos Linq para obtener todos los elementos que son de tipo Polyline (los dibujos)
            var dibujos = Lienzo.Children.OfType<Polyline>().ToList();

            // Eliminamos los dibujos, pero mantenemos los controles
            foreach (var dibujo in dibujos)
            {
                Lienzo.Children.Remove(dibujo);
            }
        }

        // Método para mostrar/ocultar los controles
        private void ToggleControles_Click(object sender, RoutedEventArgs e)
        {
            if (controlesVisibles)
            {
                ControlesPanel.Visibility = Visibility.Collapsed;
                ToggleControlesButton.Content = "Mostrar Controles";
            }
            else
            {
                ControlesPanel.Visibility = Visibility.Visible;
                ToggleControlesButton.Content = "Esconder Controles";
            }
            controlesVisibles = !controlesVisibles; // Alternar el estado
        }
    }
}
