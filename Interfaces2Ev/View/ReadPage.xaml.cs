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
    /// Lógica de interacción para CRUD.xaml
    /// </summary>
    public partial class ReadPage : Page
    {
        static MySqlConnection conexion =
           new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=root;database=northwind");

        public ReadPage()
        {
            InitializeComponent();
            showProducts();
        }

        private void showProducts()
        {
            string query = "SELECT p.ProductID AS ProductID, p.ProductName AS ProductName, " +
                                  "c.CategoryName AS CategoryName, p.QuantityPerUnit AS QuantityPerUnit, " +
                                  "p.UnitPrice AS UnitPrice, p.UnitsInStock AS UnitsInStock " +
                             "FROM Products p " +
                             "INNER JOIN Categories c ON p.CategoryID = c.CategoryID " +
                             "ORDER BY p.ProductID ASC;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);

            using (adapter)
            {
                conexion.Open();
                DataTable table = new DataTable();
                adapter.Fill(table);
                productsDatagrid.ItemsSource = table.DefaultView;
                conexion.Close();
            }
        }

        private void updateProduct(object sender, RoutedEventArgs e)
        {
            conexion.Open();

            try
            {
                string query = "UPDATE Products SET ProductName = @NewProductName, CategoryID = @CategoryID, QuantityPerUnit = @QuantityPerUnit, " +
                        "UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock " +
                        "WHERE ProductID = @ProductID;";

                using (MySqlCommand command = new MySqlCommand(query, conexion))
                {
                    ComboBoxItem selectedItem = (ComboBoxItem)categories.SelectedItem;
                    int categoryId = 0;
                    if (selectedItem != null)
                    {
                        string contenido = selectedItem.Content.ToString();
                        switch (contenido)
                        {
                            case "Beverages":
                                categoryId = 1;
                                break;
                            case "Condiments":
                                categoryId = 2;
                                break;
                            case "Confections":
                                categoryId = 3;
                                break;
                            case "Dairy Products":
                                categoryId = 4;
                                break;
                            case "Grains/Cereals":
                                categoryId = 5;
                                break;
                            case "Meat/Poultry":
                                categoryId = 6;
                                break;
                            case "Produce":
                                categoryId = 7;
                                break;
                            case "Seafood":
                                categoryId = 8;
                                break;
                            default:
                                categoryId = 0;
                                break;
                        }
                    }
                    command.Parameters.AddWithValue("@ProductID", int.Parse(productId.Text.ToString()));
                    command.Parameters.AddWithValue("@NewProductName", newProductName.Text.ToString());
                    command.Parameters.AddWithValue("@CategoryID", categoryId);
                    command.Parameters.AddWithValue("@QuantityPerUnit", quantityPerUnit.Text.ToString());
                    command.Parameters.AddWithValue("@UnitPrice", double.Parse(price.Text.ToString()));
                    command.Parameters.AddWithValue("@UnitsInStock", int.Parse(stock.Text.ToString()));

                    command.ExecuteNonQuery();

                    MessageBox.Show("Se ha actualizado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido cambiar los valores especificados, por favor vuelvelo a intentar. " + ex.Message);
            }
            conexion.Close();
            showProducts();
        }

        private void deleteProduct(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string query = "DELETE FROM OrderDetails WHERE ProductID = @ProductID;DELETE FROM Products WHERE ProductID = @ProductID;";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@ProductID", long.Parse(productId.Text.ToString()));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Se ha eliminado.");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido borrar, por favor vuelvelo a intentar. " + ex.Message);
            }
            conexion.Close();
            showProducts();
        }
    }
}
