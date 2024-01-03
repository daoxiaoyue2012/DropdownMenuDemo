using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DropdownMenuDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> ImageList { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            ImageList = new List<string>();

            string[] files = Directory.GetFiles("C:\\Users\\java2\\Desktop\\icons");
            foreach (var file in files)
            {
                if (System.IO.Path.GetExtension(file).Equals(".png", StringComparison.OrdinalIgnoreCase))
                {
                    ImageList.Add(file);
                }
            }
            DataContext = this;
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((MenuItem)sender).Header.ToString());
        }
    }
}
