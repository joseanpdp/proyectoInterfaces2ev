using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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

namespace Interfaces2Ev.View
{
    /// <summary>
    /// Lógica de interacción para ByCategoriesPage.xaml
    /// </summary>
    public partial class ByCategoriesPage : Page
    {
        static MySqlConnection conexion =
            new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=root;database=northwind");

        public ByCategoriesPage()
        {
            InitializeComponent();
            showProductsWithCategories();
        }

        private void showProductsWithCategories()
        {
            string query = "SELECT p.ProductName AS ProductName, c.CategoryName AS CategoryName, p.QuantityPerUnit AS QuantityPerUnit, p.UnitPrice AS UnitPrice, p.UnitsInStock AS UnitsInStock " +
                             "FROM Products p " +
                             "INNER JOIN Categories c ON p.CategoryID = c.CategoryID;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
            
            using (adapter)
            {
                conexion.Open();
                DataTable table = new DataTable();
                adapter.Fill(table);
                productsWithCategoriesDatagrid.ItemsSource = table.DefaultView;
                conexion.Close();
            }
        }

        private void searchByCategory(object sender, RoutedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)categories.SelectedItem;

            if (selectedItem != null && !selectedItem.Content.ToString().Equals("*"))
            {
                string contenido = selectedItem.Content.ToString();
                string query = "SELECT p.ProductName AS ProductName, c.CategoryName AS CategoryName, p.QuantityPerUnit AS QuantityPerUnit, p.UnitPrice AS UnitPrice, p.UnitsInStock AS UnitsInStock " +
                        "FROM Products p " +
                        "INNER JOIN Categories c ON p.CategoryID = c.CategoryID " +
                        "WHERE CategoryName = @CategoryName";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                adapter.SelectCommand.Parameters.AddWithValue("@CategoryName", contenido);

                using (adapter)
                {
                    conexion.Open();
                    DataTable table = new DataTable();
                    table.Columns.Clear();
                    adapter.Fill(table);
                    productsWithCategoriesDatagrid.ItemsSource = table.DefaultView;
                    conexion.Close();
                }
            }
            else 
            {
                showProductsWithCategories();
            }
        }
    }
}
