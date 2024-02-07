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
    /// Lógica de interacción para StockPage.xaml
    /// </summary>
    public partial class StockPage : Page
    {
        static MySqlConnection conexion =
            new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=root;database=northwind");

        public StockPage()
        {
            InitializeComponent();
            showProductsWithoutStock();
        }

        private void showProductsWithoutStock()
        {
            string query = "SELECT p.ProductName AS ProductName, c.CategoryName AS CategoryName, p.QuantityPerUnit AS QuantityPerUnit, p.UnitPrice AS UnitPrice, p.UnitsInStock AS UnitsInStock " +
                             "FROM Products p " +
                             "INNER JOIN Categories c ON p.CategoryID = c.CategoryID " +
                             "WHERE UnitsInStock = 0;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);

            using (adapter)
            {
                conexion.Open();
                DataTable table = new DataTable();
                adapter.Fill(table);
                withoutStock.ItemsSource = table.DefaultView;
                conexion.Close();
            }
        }
    }
}
