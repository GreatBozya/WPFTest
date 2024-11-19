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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        int r = 0;
        public Window2()
        {
            InitializeComponent();
        }
        public void haram()
        {
            MessageBox.Show("ТЫ БЕЗБОЖНИК!", "Увы");
        }
        private void a1_Checked(object sender, RoutedEventArgs e)
        {
            haram();
        }
        private void a2_Checked(object sender, RoutedEventArgs e)
        {
            r = 1;
        }
        private void a3_Checked(object sender, RoutedEventArgs e)
        {
            haram();
        }
        private void a4_Checked(object sender, RoutedEventArgs e)
        {
            haram();
        }
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (r == 1)
            {
                Window3 win = new Window3();
                this.Close();
                win.Show();
            }
        }
    }
}
