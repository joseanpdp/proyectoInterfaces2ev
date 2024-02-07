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
using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using System.Data;

namespace Interfaces2Ev.View
{
    /// <summary>
    /// Lógica de interacción para ExpensivePage.xaml
    /// </summary>
    public partial class ExpensivePage : Page
    {
        static MySqlConnection conexion =
           new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=root;database=northwind");

        public ExpensivePage()
        {
            InitializeComponent();
            showProducts();
        }

        private void showProducts()
        {
            string query = "SELECT ProductName, UnitPrice FROM Products ORDER BY UnitPrice DESC LIMIT 5;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);

            using (adapter)
            {
                conexion.Open();
                DataTable table = new DataTable();
                adapter.Fill(table);
                expensive.ItemsSource = table.DefaultView;
                conexion.Close();
            }
        }
    }
}
