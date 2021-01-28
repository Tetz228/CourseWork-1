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
    /// Логика взаимодействия для TypeEquipmentWindow.xaml
    /// </summary>
    public partial class TypeEquipmentWindow : Window
    {
        gr683_zkaEntities db = new gr683_zkaEntities();
        public TypeEquipmentWindow()
        {
            InitializeComponent();
        }

        private void Change(object sender, RoutedEventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtIdChange.Text);
                var uRow = db.TypeEquipment.Where(w => w.Id == num).FirstOrDefault();
                uRow.Name = txtNameChange.Text;
                db.SaveChanges();
                TypeEquipmentDB.ItemsSource = db.TypeEquipment.ToList();

                txtNameChange.Clear();
                txtIdChange.Clear();
            }     
            catch
            {
                MessageBox.Show("Ошибка ввода данных!");
            }

        }

        private void Add(object sender, RoutedEventArgs e)
        {
            FunAdd(txtNameAdd.Text);
        }

        public int FunAdd(string name)
        {
            try
            {
                TypeEquipment typeEquipment = new TypeEquipment();
                typeEquipment.Name = name;

                db.TypeEquipment.Add(typeEquipment);
                db.SaveChanges();
                TypeEquipmentDB.ItemsSource = db.TypeEquipment.ToList();

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
                var dRow = db.TypeEquipment.Where(w => w.Id == id).FirstOrDefault();
                if (dRow == null)
                {
                    MessageBox.Show("Ошибка! Id не найден");

                    return 2;
                }
                else
                {
                    db.TypeEquipment.Remove(dRow);
                    db.SaveChanges();
                    TypeEquipmentDB.ItemsSource = db.TypeEquipment.ToList();
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TypeEquipmentDB.ItemsSource = db.TypeEquipment.ToList();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
