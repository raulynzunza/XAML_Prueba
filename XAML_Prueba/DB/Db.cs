using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAML_Prueba.Models;
using System.Data.SqlClient;
using XAML_Prueba.Helpers;

namespace XAML_Prueba.DB
{
    internal class Db
    {                
        private readonly string _connection;

        public string Connection => _connection;

        public Db()
        {
            _connection = ConfigurationManager.GetConnectionString();
        }

        internal ObservableCollection<Users> GetUsers()
        {
            ObservableCollection<Users> users = new ObservableCollection<Users>();
            string query = "SELECT id, nombre, apellido_p, apellido_m, edad, email, admin FROM Users;";

            using (SqlConnection cn = new SqlConnection(Connection))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new Users()
                    {
                        Id = (int)reader["id"],
                        Nombre = (string)reader["nombre"],
                        Apellido_P = (string)reader["apellido_p"],
                        Apellido_M = (string)reader["apellido_m"],
                        Edad = (int)reader["edad"],
                        Email = (string)reader["email"],
                        Admin = (bool)reader["admin"],                        
                    });
                }

                cn.Close();
                reader.Close();
            }

            return users;
        }

        internal void AddUsers(Users user)
        {
            string query = "INSERT INTO Users(nombre, apellido_p, apellido_m, edad, email, admin) VALUES(@nombre, @apellido_p, @apellido_m, @edad, @email, @admin);";

            using (SqlConnection cn = new SqlConnection(Connection))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@nombre", user.Nombre);
                cmd.Parameters.AddWithValue("@apellido_p", user.Apellido_P);
                cmd.Parameters.AddWithValue("@apellido_m", user.Apellido_M);
                cmd.Parameters.AddWithValue("@edad", user.Edad);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@admin", user.Admin);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        internal void DeleteUser(Users user)
        {
            string query = "DELETE FROM Users WHERE id=@id;";

            using (SqlConnection cn = new SqlConnection(Connection))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        internal ObservableCollection<Users> EditUser(Users user)
        {
            ObservableCollection<Users> users = new ObservableCollection<Users>();

            string query = "UPDATE Users SET nombre=@nombre, apellido_p=@apellido_p, apellido_m=@apellido_m, edad=@edad, email=@email, admin=@admin WHERE id=@id;";            

            using (SqlConnection cn = new SqlConnection(Connection))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.Parameters.AddWithValue("@nombre", user.Nombre);
                cmd.Parameters.AddWithValue("@apellido_p", user.Apellido_P);
                cmd.Parameters.AddWithValue("@apellido_m", user.Apellido_M);
                cmd.Parameters.AddWithValue("@edad", user.Edad);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@admin", user.Admin);
                cmd.ExecuteNonQuery();                
                cn.Close();
            }

            return GetUsers();
        }

    }
}
