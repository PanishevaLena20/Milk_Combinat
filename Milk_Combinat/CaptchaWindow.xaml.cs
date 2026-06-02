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
    /// Логика взаимодействия для CaptchaWindow.xaml
    /// </summary>
    public partial class CaptchaWindow : Window
    {
        private List<int> _currentOrder;
        private List<Border> _items = new List<Border>();
        private Border _dragSource = null;

        public bool IsCaptchaPassed { get; private set; } = false;

        public CaptchaWindow()
        {
            InitializeComponent();
            Loaded += CaptchaWindow_Loaded;
        }

        private void CaptchaWindow_Loaded(object sender, RoutedEventArgs e)
        {
            GenerateNewPuzzle();
        }

        private void GenerateNewPuzzle()
        {
            _currentOrder = CaptchaHelper.GenerateShuffledOrder();
            RenderPuzzle();
            lblResult.Text = "";
        }

        private void RenderPuzzle()
        {
            puzzleGrid.Children.Clear();
            _items.Clear();

            Brush[] colors = {
                new SolidColorBrush(Color.FromRgb(255, 100, 100)), 
                new SolidColorBrush(Color.FromRgb(100, 255, 100)), 
                new SolidColorBrush(Color.FromRgb(100, 100, 255)), 
                new SolidColorBrush(Color.FromRgb(255, 255, 100))  
            };

            for (int i = 0; i < _currentOrder.Count; i++)
            {
                int imageIndex = _currentOrder[i];
                int row = i / 2;
                int col = i % 2;

                Border border = new Border
                {
                    Margin = new Thickness(5),
                    BorderBrush = Brushes.Gray,
                    BorderThickness = new Thickness(2),
                    CornerRadius = new CornerRadius(8),
                    Background = colors[imageIndex],
                    Tag = imageIndex,
                    Cursor = Cursors.Hand
                };

                TextBlock text = new TextBlock
                {
                    Text = (imageIndex + 1).ToString(),
                    FontSize = 48,
                    FontWeight = FontWeights.Bold,
                    Foreground = Brushes.White,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };
                border.Child = text;

                border.SetValue(Grid.RowProperty, row);
                border.SetValue(Grid.ColumnProperty, col);

                puzzleGrid.Children.Add(border);
                _items.Add(border);
            }

            EnableDragDrop();
        }

        private void EnableDragDrop()
        {
            foreach (Border item in _items)
            {
                item.MouseLeftButtonDown += (s, e) => _dragSource = s as Border;
                item.MouseMove += (s, e) =>
                {
                    if (_dragSource != null && e.LeftButton == MouseButtonState.Pressed)
                    {
                        DragDrop.DoDragDrop(_dragSource, _dragSource, DragDropEffects.Move);
                        _dragSource = null;
                    }
                };
                item.Drop += (s, e) =>
                {
                    Border target = s as Border;
                    Border source = e.Data.GetData(typeof(Border)) as Border;
                    if (source == null || target == null || source == target) return;

                    int sourceIndex = _items.IndexOf(source);
                    int targetIndex = _items.IndexOf(target);

                    var temp = _items[sourceIndex];
                    _items[sourceIndex] = _items[targetIndex];
                    _items[targetIndex] = temp;

                    _currentOrder.Clear();
                    foreach (var it in _items) _currentOrder.Add((int)it.Tag);
                    RenderPuzzle();
                };
                item.AllowDrop = true;
            }
        }

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            if (CaptchaHelper.IsPuzzleComplete(_currentOrder))
            {
                IsCaptchaPassed = true;
                MessageBox.Show("✅ Пазл собран правильно!", "Успех",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                DialogResult = true;
                Close();
            }
            else
            {
                lblResult.Text = "❌ Неправильно! Нужно: 1, 2, 3, 4";
                lblResult.Foreground = Brushes.Red;
                MessageBox.Show("❌ Неправильный порядок! Нужно: 1, 2, 3, 4",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnShuffle_Click(object sender, RoutedEventArgs e)
        {
            GenerateNewPuzzle();
        }

        private void btnCheck_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnShuffle_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
