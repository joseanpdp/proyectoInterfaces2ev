using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Interfaces2Ev.BBDD;

namespace Interfaces2Ev.View;

/// <summary>
/// Interaction logic for LoginWindow.xaml
/// </summary>
public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
    }

    private void Enter(object sender, RoutedEventArgs e)
    {
        login();
    }

    private void login()
    {
        String user = txtUser.Text.ToString();
        String password = txtPassword.Password.ToString();

        if (BBDD.BBDD.login(user, password))
        {
            Debug.WriteLine("exito--------------------------------------------");

            NavigationView NVPage = new NavigationView();
            NVPage.Show();
            this.Close();
        }
    }
}