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
using System.Windows.Shapes;

namespace Kursovay
{
    public partial class AuthrizationWindow : Window
    {
        gr683_zkaEntities db = new gr683_zkaEntities();
        public AuthrizationWindow()
        {
            InitializeComponent();
        }

        private void AuthorizationClick(object sender, RoutedEventArgs e)
        {
            Auth(login.Text, password.Password);
        }

        public bool Auth(string log, string pass)
        {
            if (string.IsNullOrEmpty(log) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Введите логин и пароль!");
                return false;
            }

            using (var db = new gr683_zkaEntities())
            {
                var usertype1 = db.Users.AsNoTracking().FirstOrDefault(u => u.Login == log && u.Password == pass);
                if(usertype1 == null)
                {
                    MessageBox.Show("Ошибка! Пользователь не найден.");
                    return false;
                }

                if (usertype1.Post == "User" || usertype1.Post == "Admin")
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                    return true;
                }

                return false;
            }
        }
    }
}
