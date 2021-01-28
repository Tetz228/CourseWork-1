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

namespace Kursovay
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EquipmentClick(object sender, RoutedEventArgs e)
        {
            EquipmentWindow EquipmentWindow = new EquipmentWindow();
            EquipmentWindow.Show();
        }

        private void StoragesClick(object sender, RoutedEventArgs e)
        {
            StoragesWindow storagesWindow = new StoragesWindow();
            storagesWindow.Show();
        }

        private void PersonnelClick(object sender, RoutedEventArgs e)
        {
            PersonnelWindow personnelWindow = new PersonnelWindow();
            personnelWindow.Show();
        }

        private void UsersClick(object sender, RoutedEventArgs e)
        {
            UsersWindow usersWindow = new UsersWindow();
            usersWindow.Show();
        }

        private void ExtraditionClick(object sender, RoutedEventArgs e)
        {
            ExtraditionWindow extraditionWindow = new ExtraditionWindow();
            extraditionWindow.Show();
        }

        private void TypeEquipmentButton_Click(object sender, RoutedEventArgs e)
        {
            TypeEquipmentWindow typeEquipment = new TypeEquipmentWindow();
            typeEquipment.Show();
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            AuthrizationWindow authrizationWindow = new AuthrizationWindow();
            authrizationWindow.Show();
            this.Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
