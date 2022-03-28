using SafiRepay.Views;
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
using RestSharp;
using SafiRepay.Models;
using MahApps.Metro.Controls;

namespace SafiRepay
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class AuthenticateWindow : MetroWindow
    {
        public AuthenticateWindow()
        {
            InitializeComponent();
# if DEBUG
            tbx_email.Text = "visiteur01@safi.com";
            pbx_pwd.Password = "pwsio";
# endif
        }

        private void Btn_Signin_Click(object sender, RoutedEventArgs e)
        {
            // Create an associative array with the email and the password
            Dictionary<String, String> userCredentials = new Dictionary<string, string>();
            userCredentials.Add("email", tbx_email.Text);
            userCredentials.Add("password", pbx_pwd.Password);

            // Call /login route to the API
            IRestResponse response = Api.Post("login", userCredentials);

            // Print the response content into the console
            Console.WriteLine(response.Content);

            ShellWindow mainWindow = new ShellWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
