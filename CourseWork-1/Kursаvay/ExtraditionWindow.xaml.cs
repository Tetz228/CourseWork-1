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
    /// Логика взаимодействия для ExtraditionWindow.xaml
    /// </summary>
    public partial class ExtraditionWindow : Window
    {
        gr683_zkaEntities db = new gr683_zkaEntities();
        public ExtraditionWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ExtraditionDB.ItemsSource = db.Extradition.ToList();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            try
            {
                Extradition extradition = new Extradition();

                extradition.IdEquipment = Convert.ToInt32(txtIdEquipmentAdd.Text);
                extradition.Quantity = Convert.ToInt32(txtQuantityAdd.Text);
                extradition.IdStorages = Convert.ToInt32(txtIdStoragesAdd.Text);
                extradition.IdPersonnel = Convert.ToInt32(txtIdPersonnelAdd.Text);
                extradition.IdUsers = Convert.ToInt32(txtIdUsersAdd.Text);
                extradition.Date = Convert.ToString(txtDateAdd.Text);

                db.Extradition.Add(extradition);
                db.SaveChanges();
                ExtraditionDB.ItemsSource = db.Extradition.ToList();

                txtIdEquipmentAdd.Clear();
                txtQuantityAdd.Clear();
                txtIdStoragesAdd.Clear();
                txtIdPersonnelAdd.Clear();
                txtIdUsersAdd.Clear();
                txtDateAdd.Clear();
        }
            catch
            {

                MessageBox.Show("Ошибка ввода данных!");

            }
}

        private void Сhange(object sender, RoutedEventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtIdСhange.Text);
                var uRow = db.Extradition.Where(w => w.Id == num).FirstOrDefault();
                uRow.IdEquipment = Convert.ToInt32(txtIdEquipmentChange.Text);
                uRow.Quantity = Convert.ToInt32(txtQuantityChange.Text);
                uRow.IdStorages = Convert.ToInt32(txtIdStoragesChange.Text);
                uRow.IdPersonnel = Convert.ToInt32(txtIdPersonnelChange.Text);
                uRow.IdUsers = Convert.ToInt32(txtIdUsersChange.Text);
                uRow.Date = Convert.ToString(txtDateChange.Text);
                db.SaveChanges();
                ExtraditionDB.ItemsSource = db.Extradition.ToList();

                txtIdСhange.Clear();
                txtIdEquipmentChange.Clear();
                txtQuantityChange.Clear();
                txtIdStoragesChange.Clear();
                txtIdPersonnelChange.Clear();
                txtIdUsersChange.Clear();
                txtDateChange.Clear();
        }
            catch
            {
                MessageBox.Show("Ошибка ввода данных!");
 
            }

}

        private void Delete(object sender, RoutedEventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtIdDelete.Text);
                var dRow = db.Extradition.Where(w => w.Id == num).FirstOrDefault();

                db.Extradition.Remove(dRow);
                db.SaveChanges();
                ExtraditionDB.ItemsSource = db.Extradition.ToList();

                txtIdDelete.Clear();
            }

            catch
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
