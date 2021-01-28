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
    /// <summary>
    /// Логика взаимодействия для UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Window
    {
        gr683_zkaEntities db = new gr683_zkaEntities();
        public UsersWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UsersDB.ItemsSource = db.Users.ToList();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            FunAdd(txtLoginAdd.Text, txtPasswordAdd.Text, txtPostAdd.Text, txtLastAdd.Text, txtFirstAdd.Text, txtMiddleAdd.Text);
        }

        public int FunAdd(string login, string password, string post, string last, string first, string middle)
        {
            try
            {
                Users users = new Users();
                users.Login = login;
                users.Password = password;
                users.Post = post;
                users.LastName = last;
                users.FirstName = first;
                users.MiddleName = middle;

                db.Users.Add(users);
                db.SaveChanges();
                UsersDB.ItemsSource = db.Users.ToList();

                txtLoginAdd.Clear(); 
                txtPasswordAdd.Clear(); 
                txtPostAdd.Clear(); 
                txtLastAdd.Clear(); 
                txtFirstAdd.Clear(); 
                txtMiddleAdd.Clear();

                return 1;
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных!");
                return 0;
            }
        }

        private void Delete(object sender, RoutedEventArgs e)
        {

            int num = Convert.ToInt32(txtIdDelete.Text);
            FunDelete(num);
        }

        public int FunDelete(int id)
        {
            try
            {
                var dRow = db.Users.Where(w => w.Id == id).FirstOrDefault();
                if (dRow == null)
                {
                    MessageBox.Show("Ошибка! Id не найден");

                    return 2;
                }
                else
                {
                    db.Users.Remove(dRow);
                    db.SaveChanges();
                    UsersDB.ItemsSource = db.Users.ToList();
                    txtIdDelete.Clear();
                    return 1;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных!");
                return 0;
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Change(object sender, RoutedEventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtIdChange.Text);
                var uRow = db.Users.Where(w => w.Id == num).FirstOrDefault();
                uRow.Login = txtLoginChange.Text;
                uRow.Password = txtPasswordChange.Text;
                uRow.Post = txtPostChange.Text;
                uRow.LastName = txtLastChange.Text;
                uRow.FirstName = txtFirstChange.Text;
                uRow.MiddleName = txtMiddleChange.Text;

                db.SaveChanges();
                UsersDB.ItemsSource = db.Users.ToList();

                txtIdChange.Clear();
                txtLoginChange.Clear();
                txtPasswordChange.Clear();
                txtLastChange.Clear();
                txtFirstChange.Clear();
                txtMiddleChange.Clear();
            }        
            catch
            {
                MessageBox.Show("Ошибка ввода данных!");
            }

        }
    }
}
