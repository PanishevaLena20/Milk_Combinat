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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow(string userName)
        {
            InitializeComponent();
            lblWelcome.Text = $"Здравствуйте, {userName}!";
        }
        private void btnManageUsers_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открывается управление пользователями...", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

            UsersManagementWindow usersManagementWindow = new UsersManagementWindow();
            usersManagementWindow.Show();
        }

        private void btnManageProducts_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открывается управление товарами...", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

            ProductsManagementWindow productsManagementWindow = new ProductsManagementWindow();
            productsManagementWindow.Show();
        }

        private void btnViewOrders_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Открывается просмотр заказов...", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

            OrdersWondow ordersViewWindow = new OrdersWondow();
            ordersViewWindow.Show();
        }

        private void btnExit_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();

            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
        }
    }
}