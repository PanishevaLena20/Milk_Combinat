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
    /// Логика взаимодействия для UsersManagementWindow.xaml
    /// </summary>
    public partial class UsersManagementWindow : Window
    {
            public UsersManagementWindow()
            {
                InitializeComponent();
            }

            private void BtnAdd_Click(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("Добавление нового пользователя", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            private void BtnEdit_Click(object sender, RoutedEventArgs e)
            {
                if (lstUsers.SelectedItem != null)
                {
                    MessageBox.Show($"Редактирование: {lstUsers.SelectedItem}", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Выберите пользователя для редактирования!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

            private void BtnDelete_Click(object sender, RoutedEventArgs e)
            {
                if (lstUsers.SelectedItem != null)
                {
                    MessageBoxResult result = MessageBox.Show($"Удалить {lstUsers.SelectedItem}?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        lstUsers.Items.Remove(lstUsers.SelectedItem);
                        MessageBox.Show("Пользователь удалён!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите пользователя для удаления!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

            private void BtnClose_Click(object sender, RoutedEventArgs e)
            {
                this.Close();
            }

        private void btnAdd_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnEdit_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
    }
