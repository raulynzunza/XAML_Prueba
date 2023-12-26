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
using XAML_Prueba.Helpers;

namespace XAML_Prueba.Views
{
    /// <summary>
    /// Lógica de interacción para RegistroView.xaml
    /// </summary>
    public partial class RegistroView : Page
    {
        private Validations validationInstance;
        public RegistroView()
        {
            InitializeComponent();
            validationInstance = new Validations();
        }

        private void TextBox_PreviewTextInputNumbers(object sender, TextCompositionEventArgs e)
        {
            validationInstance.TextBox_PreviewTextInputNumbers(sender, e);
        }        

        private void TextBox_PreviewTextInputString(object sender, TextCompositionEventArgs e)
        {
            validationInstance.TextBox_PreviewTextInputString(sender, e);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BienvenidaView bienvenidaView = new BienvenidaView();

            if (NavigationService != null)
            {
                NavigationService.Navigate(bienvenidaView);
            }            
        }
    }
}
