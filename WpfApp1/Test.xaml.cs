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
    /// Interaction logic for Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Test1 test1 = new Test1(1);
            test1.ShowDialog();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Test1 test1 = new Test1(2);
            test1.ShowDialog();
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            Test1 test1 = new Test1(3);
            test1.ShowDialog();
        }
        private void Image_MouseDow3(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
