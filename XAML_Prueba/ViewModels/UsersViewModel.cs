using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using XAML_Prueba.Commands;
using XAML_Prueba.DB;
using XAML_Prueba.Models;

namespace XAML_Prueba.ViewModels
{
    public class UsersViewModel : ViewModelBase
    {
        private readonly Db db;
        private ObservableCollection<Users> _users;
        private Users _user;
        private Users _selectedUser;

        public UsersViewModel()
        {
            db = new Db();
            _user = new Users();
            _users = db.GetUsers();
        }

        public Users User
        {
            get => _user;
            set
            {
                if(_user != value)
                {
                    _user = value;
                    OnPropertyChanged(nameof(User));
                }
            }
        }

        public ObservableCollection<Users> Users
        {
            get => _users;
            set
            {
                if(_users != value)
                {
                    _users = value;
                    OnPropertyChanged(nameof(Users));
                }
            }
        }

        public Users SelectedUser
        {
            get => _selectedUser;
            set
            {
                _selectedUser = value;
                OnPropertyChanged(nameof(SelectedUser)); // Asegúrate de notificar cambios
            }
        }

        public ICommand GetCommand
        {
            get
            {
                return new RelayCommand(GetExecute, GetCanExecute);
            }
        }

        public ICommand AddCommand
        {
            get
            {
                return new RelayCommand(AddExecute, AddCanExecute);
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                return new RelayCommand(DeleteExecute, DeleteCanExecute);
            }
        }

        public ICommand EditCommand
        {
            get
            {
                return new RelayCommand(EditExecute, EditCanExecute);
            }
        }

        private void AddExecute(Object user)
        {
            if (User.Nombre == null || User.Apellido_P == null || User.Apellido_M == null || User.Email == null || User.Edad.ToString().Length == 0)
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error");
                return;
            }
            db.AddUsers(User);
            Users = db.GetUsers();
            MessageBox.Show("Se agrego el usuario correctamente.","Message");
        }

        private bool AddCanExecute(Object user)
        {
            return true;
        }

        private void DeleteExecute(Object user)
        {
           

            if (SelectedUser != null)
            {
                var flag = MessageBox.Show("¿Desea eliminar el usuario?", "Confirmación", MessageBoxButton.OKCancel);
                if (flag == MessageBoxResult.OK)
                {
                    db.DeleteUser(SelectedUser);
                    Users.Remove(SelectedUser);
                }
            }else
            {
                MessageBox.Show("Debe seleccionar un usuario.");
            }            

        }

        private bool DeleteCanExecute(Object user)
        {
            return true;
        }

        private void EditExecute(Object user)
        {
            if (SelectedUser != null)
            {
                var users = db.EditUser(SelectedUser);
                Users.Remove(SelectedUser);           
                this.Users = users;
            }
        }

        private bool EditCanExecute(Object user)
        {
            return true;
        }

        private void GetExecute(Object user)
        {
            if (SelectedUser != null)
            {                
                _users = db.GetUsers();
            }
        }

        private bool GetCanExecute(Object user)
        {
            return true;
        }

    }
}
