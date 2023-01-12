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
    /// Interaction logic for Test1.xaml
    /// </summary>
    public partial class Test1 : Window
    {
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
        int countTrueAnswer;
        int count;
        int test;
        public Test1(int test)
        {
            InitializeComponent();
            switch (test)
            {
                case 1:
                    vopros11.Visibility = Visibility.Visible;
                    break;
                case 2:
                    vopros21.Visibility = Visibility.Visible;
                    break;
                case 3:
                    vopros31.Visibility = Visibility.Visible;
                    break;
            }
            countTrueAnswer = 0;
            count = 1;
            this.test = test;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(count == 1 && test==1)
            {
                if (radio111.IsChecked == false && radio112.IsChecked == false && radio113.IsChecked == false && radio114.IsChecked == true)
                { 
                    countTrueAnswer++;
                }
                count++;
                vopros11.Visibility = Visibility.Collapsed;
                vopros12.Visibility = Visibility.Visible;
                return;
            }
            if (count == 2 && test == 1)
            {
                if (radio121.IsChecked == false && radio122.IsChecked == true && radio123.IsChecked == false && radio124.IsChecked == false)
                {
                    countTrueAnswer++;
                }
                count++;
                vopros12.Visibility = Visibility.Collapsed;
                vopros13.Visibility = Visibility.Visible;
                return;
            }
            if (count == 3 && test == 1)
            {
                if (radio131.IsChecked == false && radio132.IsChecked == false && radio133.IsChecked == true && radio134.IsChecked == false)
                {
                    countTrueAnswer++;
                }
                count++;
                vopros13.Visibility = Visibility.Collapsed;
                vopros14.Visibility = Visibility.Visible;
                return;
            }
            if (count == 4 && test == 1)
            {
                if (radio141.IsChecked == true && radio142.IsChecked == false && radio143.IsChecked == false && radio144.IsChecked == false)
                {
                    countTrueAnswer++;
                }
                count++;
                vopros14.Visibility = Visibility.Collapsed;
                vopros15.Visibility = Visibility.Visible;
                return;
            }
            if (count == 5 && test == 1)
            {
                if (radio151.IsChecked == false && radio152.IsChecked == false && radio153.IsChecked == true && radio154.IsChecked == false)
                {
                    countTrueAnswer++;
                }
                count++;
                vopros15.Visibility = Visibility.Collapsed;
                vopros16.Visibility = Visibility.Visible;
                return;
            }
            if (count == 6 && test == 1)
            {
                if (radio161.IsChecked == true && radio162.IsChecked == false && radio163.IsChecked == false && radio164.IsChecked == false)
                {
                    countTrueAnswer++;
                }
                count++;
                vopros16.Visibility = Visibility.Collapsed;
                vopros17.Visibility = Visibility.Visible;
                return;
            }
            if (count == 7 && test == 1)
            {
                if (radio171.IsChecked == false && radio172.IsChecked == false && radio173.IsChecked == false && radio174.IsChecked == true)
                {
                    countTrueAnswer++;
                }
                count++;
                vopros17.Visibility = Visibility.Collapsed;
                vopros18.Visibility = Visibility.Visible;
                return;
            }
            if (count == 8 && test == 1)
            {
                if (radio181.IsChecked == false && radio182.IsChecked == true && radio183.IsChecked == false && radio184.IsChecked == false)
                {
                    countTrueAnswer++;
                }
                count=0;
                vopros18.Visibility = Visibility.Collapsed;
                answer.Visibility = Visibility.Visible;
                answerstring.Text = "Правильных ответов " + countTrueAnswer + " из 8";
                return;
            }
            if (count == 1 && test == 2)
            {
                if (radio211.IsChecked == false && radio212.IsChecked == true && radio213.IsChecked == true && radio214.IsChecked == false && radio215.IsChecked == false)
                {
                    countTrueAnswer++;
                }
                count++;
                vopros21.Visibility = Visibility.Collapsed;
                vopros22.Visibility = Visibility.Visible;
                return;
            }
            if (count == 2 && test == 2)
            {
                if (radio221.IsChecked == true && radio222.IsChecked == true && radio223.IsChecked == false && radio224.IsChecked == false && radio225.IsChecked == false)
                {
                    countTrueAnswer++;
                }
                count++;
                vopros22.Visibility = Visibility.Collapsed;
                vopros23.Visibility = Visibility.Visible;
                return;
            }
            if (count == 3 && test == 2)
            {
                if (radio231.IsChecked == true && radio232.IsChecked == false && radio233.IsChecked == false && radio234.IsChecked == true && radio235.IsChecked == false)
                {
                    countTrueAnswer++;
                }
                count++;
                vopros23.Visibility = Visibility.Collapsed;
                vopros24.Visibility = Visibility.Visible;
                return;
            }
            if (count == 4 && test == 2)
            {
                if (radio241.IsChecked == true && radio242.IsChecked == false && radio243.IsChecked == false && radio244.IsChecked == true && radio245.IsChecked == false)
                {
                    countTrueAnswer++;
                }
                count=0;
                vopros24.Visibility = Visibility.Collapsed;
                answer.Visibility = Visibility.Visible;
                answerstring.Text = "Правильных ответов " + countTrueAnswer + " из 4";
                return;
            }
            if (count == 1 && test == 3)
            {
                if (T1.Text == "жидкое, твердое, газообразное")
                {
                    countTrueAnswer++;
                }
                count++;
                vopros31.Visibility = Visibility.Collapsed;
                vopros32.Visibility = Visibility.Visible;
                return;
            }
            if (count == 2 && test == 3)
            {
                if (T2.Text == "изотопы")
                {
                    countTrueAnswer++;
                }
                count++;
                vopros32.Visibility = Visibility.Collapsed;
                vopros33.Visibility = Visibility.Visible;
                return;
            }
            if (count == 3 && test == 3)
            {
                if (T3.Text == "Относительная атомная масса - величина, показывающая, во сколько раз масса атома больше 1/12 массы атома углерода.")
                {
                    countTrueAnswer++;
                }
                count=0;
                vopros33.Visibility = Visibility.Collapsed;
                vopros34.Visibility = Visibility.Visible;
                answertext.Text = "Правильных ответов " + countTrueAnswer + " из 3";
                return;
            }
            if (count == 0)
            {
                Close();
            }
        }
    }
}
