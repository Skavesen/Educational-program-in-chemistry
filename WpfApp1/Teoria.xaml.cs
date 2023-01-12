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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Teoria.xaml
    /// </summary>
    public partial class Teoria : Window
    {
        public Teoria()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            File file = new File(1);
            file.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            File file = new File(2);
            file.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            File file = new File(3);
            file.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            File file = new File(4);
            file.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            File file = new File(5);
            file.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            File file = new File(6);
            file.ShowDialog();
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
