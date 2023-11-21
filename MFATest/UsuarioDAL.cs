using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MFATest
{
    class UsuarioDAL
    {
        public static int CrearCuenta(string username, string password, string secretKey)
        {
            int res = 0;
            SqlConnection connection = BDComun.ObtenerConexion();

            SqlCommand command = new SqlCommand("INSERT INTO Users (Username, Password, SecretKey) VALUES (@Username, @Password, @SecretKey)", connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@SecretKey", secretKey);
            res = command.ExecuteNonQuery();

            connection.Close();

            return res;
        }

        public static bool Autenticar(string username, string password)
        {
            bool inicioSesionCorrecto = false;
            SqlConnection connection = BDComun.ObtenerConexion();

            string query = $"SELECT * FROM Users WHERE Username = '{username}' AND Password = '{password}'";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Si se encuentra una fila en la tabla Usuarios con los datos ingresados, el inicio de sesión es correcto
                        User.Username = (string)reader["Username"];
                        User.SecretKey= (string)reader["SecretKey"];
                        inicioSesionCorrecto = true;
                    }
                }
            }

            return inicioSesionCorrecto;
        }



    }
}
