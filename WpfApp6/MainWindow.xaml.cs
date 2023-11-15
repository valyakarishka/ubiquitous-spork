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

namespace WpfApp6
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

        private void Summ_Click(object sender, RoutedEventArgs e)
        {

            int I = int.Parse(ITextBox.Text);
            int II = int.Parse(IITextBox.Text);
            int III = int.Parse(IIITextBox.Text);

            int SP = I + II + III;
            int PS = I * II * III;

            SPTextBox.Text = SP.ToString();
            PSTextBox.Text = PS.ToString();
        }
    }
}
