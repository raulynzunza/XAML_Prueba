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

namespace XAML_Prueba.Views
{
    /// <summary>
    /// Lógica de interacción para OpcionesView.xaml
    /// </summary>
    public partial class OpcionesView : Page
    {
        public OpcionesView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListaUsuariosView opcionesView = new ListaUsuariosView();

            if (NavigationService != null)
            {
                NavigationService.Navigate(opcionesView);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RegistroView registroView = new RegistroView();

            if (NavigationService != null)
            {
                NavigationService.Navigate(registroView);
            }
        }
    }
}
