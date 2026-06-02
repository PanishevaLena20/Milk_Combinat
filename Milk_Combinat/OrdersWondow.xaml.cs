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
    /// Логика взаимодействия для OrdersWondow.xaml
    /// </summary>
    public partial class OrdersWondow : Window
    {
        public OrdersWondow()
        {
            InitializeComponent();
        }

        private void BtnViewDetails_Click(object sender, RoutedEventArgs e)
        {
            if (lstOrders.SelectedItem != null)
            {
                MessageBox.Show($"Детали заказа:\n{lstOrders.SelectedItem}\n\nТовары:\n- Молоко 2 шт\n- Хлеб 1 шт\n- Сыр 1 шт",
                    "Детали заказа", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Выберите заказ для просмотра!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnViewDetails_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
