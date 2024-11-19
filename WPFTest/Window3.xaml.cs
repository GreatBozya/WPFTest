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

namespace WPFTest
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        int r = 0;
        public Window3()
        {
            InitializeComponent();
        }
        private void a1_Checked(object sender, RoutedEventArgs e)
        {
            r = 1;
        }
        private void a2_Checked(object sender, RoutedEventArgs e)
        {
            r = 1;
        }
        private void a3_Checked(object sender, RoutedEventArgs e)
        {
            r = 1;
        }
        private void a4_Checked(object sender, RoutedEventArgs e)
        {
            r = 1;
        }
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (r == 1)
            {
                this.Close();
                MessageBoxButton btn = 0;
                MessageBox.Show("Вы прошли тест на славянина", "Поздравлем!", btn);
            }
        }
    }
}
