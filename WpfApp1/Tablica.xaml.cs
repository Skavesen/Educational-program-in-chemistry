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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Tablica.xaml
    /// </summary>
    public partial class Tablica : Window
    {
        public Tablica()
        {
            InitializeComponent();
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
             if (image.Height == 450)
            {
                DoubleAnimation daw = new DoubleAnimation
                {
                    To = 1200,
                    FillBehavior = FillBehavior.HoldEnd,
                    Duration = TimeSpan.FromMilliseconds(250)
                };
                image.BeginAnimation(WidthProperty, daw);
                DoubleAnimation dah = new DoubleAnimation
                {
                    To = 1000,
                    FillBehavior = FillBehavior.HoldEnd,
                    Duration = TimeSpan.FromMilliseconds(250)
                };
                image.BeginAnimation(HeightProperty, dah);

                DoubleAnimation dat = new DoubleAnimation
                {
                    To = 10,
                    FillBehavior = FillBehavior.HoldEnd,
                    Duration = TimeSpan.FromMilliseconds(250)
                };
                image.BeginAnimation(TopProperty, dat);
                imageoblako.Opacity = 0;
                textoblako.Opacity = 0;
            }
            else
            {
                DoubleAnimation daw = new DoubleAnimation
                {
                    To = 600,
                    FillBehavior = FillBehavior.HoldEnd,
                    Duration = TimeSpan.FromMilliseconds(250)
                };
                image.BeginAnimation(WidthProperty, daw);
                DoubleAnimation dah = new DoubleAnimation
                {
                    To = 450,
                    FillBehavior = FillBehavior.HoldEnd,
                    Duration = TimeSpan.FromMilliseconds(250)
                };
                image.BeginAnimation(HeightProperty, dah);

                DoubleAnimation dat = new DoubleAnimation
                {
                    To = 192,
                    FillBehavior = FillBehavior.HoldEnd,
                    Duration = TimeSpan.FromMilliseconds(250)
                };
                image.BeginAnimation(TopProperty, dat);
                imageoblako.Opacity = 1;
                textoblako.Opacity = 1;
            }
        }
    }
}
