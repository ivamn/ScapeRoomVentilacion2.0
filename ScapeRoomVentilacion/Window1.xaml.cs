using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
            
            this.WindowState = System.Windows.WindowState.Maximized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VentilacionTextblock.Text = "Escotillas: Cerradas";
            MessageBox.Show("Se han cerrado las ventilaciones del edicio", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }
    }
}
