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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ScapeRoomVentilacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string Pass { get; set; } = "#dbce18#eb6323";
        private static string Usuario { get; set; } = "@clementjose";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (PassBox.Password == Pass && UsuarioTextBox.Text == Usuario)
            {
                Window1 window = new Window1();
                window.Activate();
                window.Show();
                this.Close();
            }
            if (PassBox.Password != Pass)
            {
                PassErrorTextBlock.Visibility = Visibility.Visible;
            }
            else
            {
                PassErrorTextBlock.Visibility = Visibility.Hidden;
            }
            if (UsuarioTextBox.Text != Usuario)
            {
                UsuarioErrorTextBlock.Visibility = Visibility.Visible;
            }
            else
            {
                UsuarioErrorTextBlock.Visibility = Visibility.Hidden;
            }
        }
    }
}
