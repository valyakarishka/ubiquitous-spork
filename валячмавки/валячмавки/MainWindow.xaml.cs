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

namespace валячмавки
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string[]> GridViewColumn = new List<string[]>();
            GridViewColumn.Add(new string[] { "Кухня", "Город", "Наличными", "Герда" });
            GridViewColumn.Add(new string[] { "Спальня", "Межгород", "Безналичная", "Асмус" });
            GridViewColumn.Add(new string[] {"Гостиная", "Поселки", "Полная", "Малвина" });
            GridViewColumn.Add(new string[] {"Санузлы", "Сады", "Неполная", "Черноваля" });
            ListView.ItemsSource = GridViewColumn;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tabControl1.SelectedItem = tabControl1.Items[1];
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tabControl1.SelectedItem = tabControl1.Items[0];
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ваши варианты добавлены в корзину, для оформления заказа вам нужно зарегистрироваться или войти");
        }
    }
}
