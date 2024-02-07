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

namespace Interfaces2Ev.View
{
    /// <summary>
    /// Lógica de interacción para NavigationView.xaml
    /// </summary>
    public partial class NavigationView : Window
    {
        public NavigationView()
        {
            InitializeComponent();
        }

        private void OnNavigationItemSelected(object sender, RoutedEventArgs e)
        {
            ListBoxItem selectedNavItem = (ListBoxItem)navigationListBox.SelectedItem;

            switch (selectedNavItem.Name.ToString())
            {
                case "CRUD":
                    mainFrame.Navigate(new QuerysPage());
                    break;
                case "Product_Table":
                    mainFrame.Navigate(new ReadPage());
                    break;
                case "By_Categories":
                    mainFrame.Navigate(new ByCategoriesPage());
                    break;
                case "Sold_products":
                    mainFrame.Navigate(new SoldPage());
                    break;
                case "Without_stock":
                    mainFrame.Navigate(new StockPage());
                    break;
                case "Expensive_products":
                    mainFrame.Navigate(new ExpensivePage());
                    break;
                case "Exit":
                    LoginWindow loginWindow = new LoginWindow();
                    loginWindow.Show();
                    this.Close();
                    break;
            }
        }
    }
}
