using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
using Mysqlx.Cursor;
using System.Diagnostics;

namespace Interfaces2Ev.BBDD
{
    internal class BBDD
    {
        public static MySqlConnection conexion =
            new MySqlConnection("datasource=localhost;port=3306;username=root;password=root;database=northwind");

        public static Boolean login(String username, String password)
        {

            Boolean flag = false;
            conexion.Open();
            try
            {
                string consultaUser = "SELECT * FROM users WHERE username = '" + username + "' and password = '" + password + "'";

                MySqlCommand cmd = new MySqlCommand(consultaUser, conexion);
                MySqlDataReader lector = cmd.ExecuteReader();

                if (lector.Read())
                {
                    flag = true;
                } else
                {
                    MessageBox.Show("Inicio de sesión fallida, el usuario o la contraseña es incorrecto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión a la base de datos.");
            }
            conexion.Close();
            return flag;
        }
    }
}
