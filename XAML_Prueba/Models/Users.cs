using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAML_Prueba.Models
{
    public class Users
    {
        private int _id;
        private string _nombre;
        private string _apellido_p;
        private string _apellido_m;
        private int _edad;
        private string _email;
        private bool _admin;

        public int Id { get => _id; set { _id = value; } }
        public string Nombre { get => _nombre;  set { _nombre = value; } }
        public string Apellido_P { get => _apellido_p; set { _apellido_p = value; } }
        public string Apellido_M { get => _apellido_m; set { _apellido_m = value; } }
        public int Edad { get => _edad; set { _edad = value; } }
        public string Email { get => _email; set { _email = value; } }
        public bool Admin { get => _admin; set { _admin = value; } }
    }
}
