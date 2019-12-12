using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace ScapeRoomVentilacion
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            WindowState = WindowState.Maximized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VentilacionTextblock.Text = "Escotillas: Cerradas";
            (sender as ToggleButton).IsEnabled = false;
            MessageBox.Show("Se han cerrado las ventilaciones del edificio", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
