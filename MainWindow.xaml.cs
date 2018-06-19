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

namespace U5_Quadratic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ImageBrush Img_Background = new ImageBrush(new BitmapImage(new Uri("Background.png", UriKind.Relative)));
        public MainWindow()
        {
            InitializeComponent();
            Stack_Mainwindow.Background = Img_Background;
            Stack_Mainwindow.Background.Opacity = 0.7;
        }
        

    }
}