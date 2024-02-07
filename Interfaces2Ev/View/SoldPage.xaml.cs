using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
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

namespace Interfaces2Ev.View
{
    /// <summary>
    /// Lógica de interacción para SoldPage.xaml
    /// </summary>
    public partial class SoldPage : Page
    {
        static MySqlConnection conexion =
           new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=root;database=northwind");

        public SoldPage()
        {
            InitializeComponent();
            showProducts();
        }

        private void showProducts()
        {
            string query = "SELECT p.ProductName AS ProductName, SUM(od.Quantity) AS Quantity FROM Products p INNER JOIN OrderDetails od ON p.ProductID = od.ProductID GROUP BY p.ProductID, p.ProductName ORDER BY Quantity DESC LIMIT 5;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);

            using (adapter)
            {
                conexion.Open();
                DataTable table = new DataTable();
                adapter.Fill(table);
                sold.ItemsSource = table.DefaultView;
                conexion.Close();
            }
        }
    }
}
