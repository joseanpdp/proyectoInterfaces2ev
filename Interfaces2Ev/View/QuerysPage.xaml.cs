using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Interfaces2Ev.View
{
     
    public partial class QuerysPage : Page
    {
        MySqlConnection conexion = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=root;database=northwind");
        public QuerysPage()
        {
            InitializeComponent();
        }

        private void createProduct(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string query = "INSERT INTO Products (ProductName, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock) " +
                           "VALUES (@ProductName, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock)";
            try
            {
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
                        command.Parameters.AddWithValue("@ProductName", productName.Text.ToString());
                        command.Parameters.AddWithValue("@CategoryID", categoryId);
                        command.Parameters.AddWithValue("@QuantityPerUnit", quantityPerUnit.Text.ToString());
                        command.Parameters.AddWithValue("@UnitPrice", double.Parse(price.Text.ToString()));
                        command.Parameters.AddWithValue("@UnitsInStock", int.Parse(stock.Text.ToString()));

                        command.ExecuteNonQuery();

                        MessageBox.Show("Se ha creado exitosamente.");

                }
            } catch (Exception ex)
            {
                MessageBox.Show("No se ha podido crear, por favor vuelvelo a intentar.");
            }
            conexion.Close();
        }

        
    }
}
