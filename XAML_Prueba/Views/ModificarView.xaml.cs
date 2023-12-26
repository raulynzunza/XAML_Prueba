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
using XAML_Prueba.DB;
using XAML_Prueba.Helpers;
using XAML_Prueba.Models;
using XAML_Prueba.ViewModels;

namespace XAML_Prueba.Views
{
    /// <summary>
    /// Lógica de interacción para ModificarView.xaml
    /// </summary>
    public partial class ModificarView : Window
    {
        
         UsersViewModel usersViewModel = new UsersViewModel();
        private Validations validationInstance;

        public ModificarView(UsersViewModel lstViewModel)
        {
            InitializeComponent();
           
            usersViewModel = lstViewModel;

            name.Text = lstViewModel.SelectedUser.Nombre.ToString();
            apellido_p.Text = lstViewModel.SelectedUser.Apellido_P.ToString();
            apellido_m.Text = lstViewModel.SelectedUser.Apellido_M.ToString();
            edad.Text = lstViewModel.SelectedUser.Edad.ToString();
            email.Text = lstViewModel.SelectedUser.Email.ToString();
            admin.IsChecked = lstViewModel.SelectedUser.Admin;

            validationInstance = new Validations();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var db = new Db();

            var users = db.EditUser(new Users()
            {
                Id = usersViewModel.SelectedUser.Id,
                Nombre = name.Text.ToString(),
                Apellido_P = apellido_p.Text.ToString(),
                Apellido_M = apellido_m.Text.ToString(),
                Edad = Int32.Parse(edad.Text.ToString()),
                Email = email.Text.ToString(),
                Admin = (bool)admin.IsChecked!
            });

            usersViewModel.Users = users;

            MessageBox.Show("Se modificó el usuario", "Mensaje");
            this.Close();
        }

        private void TextBox_PreviewTextInputNumbers(object sender, TextCompositionEventArgs e)
        {
            validationInstance.TextBox_PreviewTextInputNumbers(sender, e);
        }

        private void TextBox_PreviewTextInputString(object sender, TextCompositionEventArgs e)
        {
            validationInstance.TextBox_PreviewTextInputString(sender, e);
        }
    }
}
