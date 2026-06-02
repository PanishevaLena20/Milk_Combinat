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

namespace Milk_Combinat
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtLogin.KeyDown += (s, e) => { if (e.Key == Key.Enter) BtnLogin_Click(s, e); };
            txtPassword.KeyDown += (s, e) => { if (e.Key == Key.Enter) BtnLogin_Click(s, e); };
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Password.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            

                if (login == "admin" && password == "admin123")
            {
                MessageBox.Show("Добро пожаловать, Администратор!", "Успешный вход", MessageBoxButton.OK, MessageBoxImage.Information);
                MessageBox.Show("Открывается панель администратора...", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                AdminWindow adminWindow = new AdminWindow("Администратор");
                adminWindow.Show();

                this.Close();
                return;
            }

            if (login == "user" && password == "user123")
            {
                MessageBox.Show("Добро пожаловать, Пользователь!", "Успешный вход", MessageBoxButton.OK, MessageBoxImage.Information);
                MessageBox.Show("Открывается панель пользователя...", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

                UserWindow userWindow = new UserWindow("Пользователь");
                userWindow.Show();
                return;
            }

            MessageBox.Show("Неверный логин или пароль!", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
            txtPassword.Clear();
            txtLogin.Focus();


        }
    }
}