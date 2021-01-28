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
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.Entity;
using System.Data.EntityClient;

namespace Kursovay
{
    public partial class PersonnelWindow : Window
    {
        gr683_zkaEntities db = new gr683_zkaEntities();
        public PersonnelWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PersonnelDB.ItemsSource = db.Personnel.ToList();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            FunAdd(txtLastAdd.Text, txtFirstAdd.Text, txtMiddleAdd.Text, txtPostAdd.Text);
        }

        public int FunAdd(string last, string first, string middle, string post)
        {
            try
            {
                Personnel personnel = new Personnel();

                personnel.LastName = last;
                personnel.FirstName = first;
                personnel.MiddleName = middle;
                personnel.Post = post;

                db.Personnel.Add(personnel);
                db.SaveChanges();
                PersonnelDB.ItemsSource = db.Personnel.ToList();

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
                var dRow = db.Personnel.Where(w => w.Id == id).FirstOrDefault();
                if (dRow == null)
                {
                    MessageBox.Show("Ошибка! Id не найден");

                    return 2;
                }
                else
                {
                    db.Personnel.Remove(dRow);
                    db.SaveChanges();
                    PersonnelDB.ItemsSource = db.Personnel.ToList();
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

        private void Сhange(object sender, RoutedEventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtIdСhange.Text);
                var uRow = db.Personnel.Where(w => w.Id == num).FirstOrDefault();
                uRow.LastName = txtLastСhange.Text;
                uRow.FirstName = txtFirstСhange.Text;
                uRow.MiddleName = txtMiddleСhange.Text;
                uRow.Post = txtPostСhange.Text;
                db.SaveChanges();
                PersonnelDB.ItemsSource = db.Personnel.ToList();

                txtFirstСhange.Clear();
                txtLastСhange.Clear();
                txtMiddleСhange.Clear();
                txtPostСhange.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
            
        }
    }
}
