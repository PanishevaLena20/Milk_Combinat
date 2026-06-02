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

namespace Milk_Combinat
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow(string userName)
        {
            InitializeComponent();
            lblWelcome.Text = $"Здравствуйте, {userName}!";
        }

        private void BtnViewProducts_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открывается каталог товаров...", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnViewOrders_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открываются мои заказы...", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnProfile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открывается профиль пользователя...", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
        }

        private void btnViewProducts_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnViewOrders_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnProfile_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
