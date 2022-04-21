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
            String message = Login.Connect(tbx_email.Text, pbx_pwd.Password);
            if (message == "Success")
            {
                // Call the ShellWindow view and close without verifying the credentials : TODO
                ShellWindow mainWindow = new ShellWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                // Set the mesage for the user
                tbx_message.Text = message;
            }

        }
    }
}
