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
using XAML_Prueba.Models;
using XAML_Prueba.ViewModels;

namespace XAML_Prueba.Views
{
    /// <summary>
    /// Lógica de interacción para ListaUsuariosView.xaml
    /// </summary>
    public partial class ListaUsuariosView : Page
    {
        public ListaUsuariosView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var usersViewModel = this.Resources["users"] as UsersViewModel;
            
            if(usersViewModel!.SelectedUser == null)
            {
                MessageBox.Show("Se necesita seleccionar un usuario para editar", "Message");
                return;
            }
            
            ModificarView modificarView = new ModificarView(usersViewModel);
            modificarView.Show();
        }

        private void Navigation(object sender, RoutedEventArgs e)
        {
            BienvenidaView bienvenidaView = new BienvenidaView();

            if (NavigationService != null)
            {
                NavigationService.Navigate(bienvenidaView);
            }
        }
    }
}
