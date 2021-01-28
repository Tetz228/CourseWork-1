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
using System.Data.Objects;


namespace Kursovay
{
    public partial class EquipmentWindow : Window
    {
        gr683_zkaEntities db = new gr683_zkaEntities();

        public EquipmentWindow()
        {
            InitializeComponent();
           
        }
       
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            EquipmentBD.ItemsSource = db.Equipment.ToList();
        }    

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtIdDelete.Text);
                var dRow = db.Equipment.Where(w => w.Id == num).FirstOrDefault();

                db.Equipment.Remove(dRow);
                db.SaveChanges();
                EquipmentBD.ItemsSource = db.Equipment.ToList();

                txtIdDelete.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtIdСhange.Text);
                var uRow = db.Equipment.Where(w => w.Id == num).FirstOrDefault();
                uRow.Name = txtNameChange.Text;
                uRow.IdTypeName = Convert.ToInt32(txtTypeChange.Text);
                uRow.Quantity = Convert.ToInt32(txtQuantityChange.Text);
                uRow.IdStorage = Convert.ToInt32(txtStorageChange.Text);
                db.SaveChanges();
                EquipmentBD.ItemsSource = db.Equipment.ToList();

                txtNameChange.Clear();
                txtTypeChange.Clear();
                txtQuantityChange.Clear();
                txtStorageChange.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Equipment equipment = new Equipment();

                equipment.Name = txtNameAdd.Text;
                equipment.IdTypeName = Convert.ToInt32(txtTypeAdd.Text);
                equipment.Quantity = Convert.ToInt32(txtQuantityAdd.Text);
                equipment.IdStorage = Convert.ToInt32(txtStorageAdd.Text);

                db.Equipment.Add(equipment);
                db.SaveChanges();
                EquipmentBD.ItemsSource = db.Equipment.ToList();

                txtNameAdd.Clear();
                txtTypeAdd.Clear();
                txtQuantityAdd.Clear();
                txtStorageAdd.Clear();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
