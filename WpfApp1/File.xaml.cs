using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for File.xaml
    /// </summary>
    public partial class File : Window
    {
        string GuidePath;
        public File(int fileNumber)
        {
            InitializeComponent();
            switch(fileNumber)
            {
                case 1:
                    GuidePath = Environment.CurrentDirectory + "\\1.pdf";
                    break;
                case 2:
                    GuidePath = Environment.CurrentDirectory + "\\2.pdf";
                    break;
                case 3:
                    GuidePath = Environment.CurrentDirectory + "\\3.pdf";
                    break;
                case 4:
                    GuidePath = Environment.CurrentDirectory + "\\4.pdf";
                    break;
                case 5:
                    GuidePath = Environment.CurrentDirectory + "\\5.pdf";
                    break;
                case 6:
                    GuidePath = Environment.CurrentDirectory + "\\6.pdf";
                    break;
            }
            webBrowser1.Navigate(new Uri(GuidePath));
        }
    }
}
