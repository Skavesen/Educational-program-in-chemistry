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
using System.Text.RegularExpressions;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Sostav.xaml
    /// </summary>
    public partial class Sostav : Window
    {
        public Sostav()
        {
            InitializeComponent();
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void TextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Keyboard.ClearFocus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (T1.Text=="2" && T2.Text == "2" && T3.Text == "2" && T4.Text == "4" && T5.Text == "2" && T6.Text == "3" && T7.Text == "3")
            {
                textoblako.Opacity = 0;
                textoneprav.Opacity = 0;
                textoprav.Opacity = 1;
            }
            else
            {
                textoblako.Opacity = 0;
                textoprav.Opacity = 0;
                textoneprav.Opacity = 1;
            }
        }
    }
}
