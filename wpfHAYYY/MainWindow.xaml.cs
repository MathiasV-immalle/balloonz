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

namespace wpfHAYYY
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ellipse elly1 = new Ellipse();
        Ellipse elly2 = new Ellipse();
        int y = 100;
        int x1 = 100;
        int x2 = 150;
        public MainWindow()
        {
            InitializeComponent();
            elly1.Width = 20;
            elly1.Height = 20;
            elly1.Stroke = new SolidColorBrush(Colors.Aqua);
            elly1.StrokeThickness = 3;
            elly1.Fill = new SolidColorBrush(Colors.White);
            elly1.Margin = new Thickness(x1, y, 0, 0);
            canvas.Children.Add(elly1);

            elly2.Width = 20;
            elly2.Height = 20;
            elly2.Stroke = new SolidColorBrush(Colors.Aqua);
            elly2.StrokeThickness = 3;
            elly2.Fill = new SolidColorBrush(Colors.White);
            elly2.Margin = new Thickness(x2, y, 0, 0);
            canvas.Children.Add(elly2);
        }

        private void GrowButton_Click(object sender, RoutedEventArgs e)
        {
            elly1.Height = elly1.Height + 10;
            elly1.Width = elly1.Width+ 10;
            elly2.Height = elly2.Height + 10;
            elly2.Width = elly2.Width + 10;
        }

        private void MoveUpButton_Click(object sender, RoutedEventArgs e)
        {
            y = y - 10;
            elly1.Margin = new Thickness(x1, y, 0, 0);
            elly2.Margin = new Thickness(x2, y, 0, 0);
        }

        private void MoveDownButton_Click(object sender, RoutedEventArgs e)
        {
            y = y + 10;
            elly1.Margin = new Thickness(x1, y, 0, 0);
            elly2.Margin = new Thickness(x2, y, 0, 0);
        }

        private void MoveLeftButton_Click(object sender, RoutedEventArgs e)
        {
            x1 = x1 - 10;
            x2 = x2 - 10;
            elly1.Margin = new Thickness(x1, y, 0, 0);
            elly2.Margin = new Thickness(x2, y, 0, 0);
        }

        private void MoveRightButton_Click(object sender, RoutedEventArgs e)
        {
            x1 = x1 + 10;
            x2 = x2 + 10;
            elly1.Margin = new Thickness(x1, y, 0, 0);
            elly2.Margin = new Thickness(x2, y, 0, 0);
        }
    }
}
