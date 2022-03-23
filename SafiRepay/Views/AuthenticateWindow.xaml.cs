﻿using SafiRepay.Views;
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

namespace SafiRepay
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class AuthenticateWindow : Window
    {
        public AuthenticateWindow()
        {
            InitializeComponent();
        }

        private void Btn_Signin_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Clic sur le bouton");

            ShellWindow mainWindow = new ShellWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
