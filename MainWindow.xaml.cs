using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;
using DexDesktop.Models;


namespace DexDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = ((App)Application.Current).RegisteredUsers;
        }

        Register registration = new Register();
        AdminWindow admin = new AdminWindow();
        WelcomePopUp welcome = new WelcomePopUp();
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxEmail.Text.Length == 0)
            {
                errormessage.Text = "Va rugam inserati o adresa de email";
                textBoxEmail.Focus();
            }
            else if (!Regex.IsMatch(textBoxEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Inserati o adresa de email valida!";
                textBoxEmail.Select(0, textBoxEmail.Text.Length);
                textBoxEmail.Focus();
            }
            else
            {
                string email = textBoxEmail.Text;
                string password = passwordBox1.Password;

              
                
                if (email != null && password != null)
                { 
                    welcome.TextBlockName.Text = email;
                    errormessage.Text = "Ati fost logat cu succes!";
                }
                else
                {
                    errormessage.Text = "Ne pare rau! Parola/Email incorecte";
                }
            }
        }
        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            registration.Show();
            Close();
        }

        private void buttonAdmin_Click(object sender, RoutedEventArgs e)
        {
            admin.Show();
            Close();
        }
    }
}
