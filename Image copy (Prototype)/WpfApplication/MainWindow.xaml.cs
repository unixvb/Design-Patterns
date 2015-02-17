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

namespace WpfApplication
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BitmapImage image1 = new BitmapImage();
        BitmapImage image2 = new BitmapImage();
        BitmapImage image3 = new BitmapImage();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openfile = new Microsoft.Win32.OpenFileDialog();
            openfile.DefaultExt = "*.jpg";
            openfile.Filter = "Image Files|*.jpg";
            Nullable<bool> result = openfile.ShowDialog();
            if (result == true)
            {
                image1 = new BitmapImage(new Uri(openfile.FileName));
                Image1.Source = image1;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Image2.Source = image1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            image3 = image1;
            Image3.Source = image3;
        }
    }
}
