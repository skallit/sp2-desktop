using SafiRepay.Models;
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

namespace SafiRepay.Views
{
    /// <summary>
    /// Logique d'interaction pour UserView.xaml
    /// </summary>
    public partial class UserView : Page
    {
        public UserView()
        {
            InitializeComponent();
        }

        private void Btn_Register(object sender, RoutedEventArgs e)
        {
            String message = User.Register(tbx_firstname.Text, tbx_lastname.Text, tbx_email.Text, pbx_pwd.Password);
            if (message == "Success")
            {
                // Set the mesage for the user
                tbx_message.Text = message;
            }
            else
            {
                // Set the mesage for the user
                tbx_message.Text = message;
            }

        }
    }
}
