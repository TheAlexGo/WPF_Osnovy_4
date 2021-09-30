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

namespace Praktikum_4
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            TextBlockResult.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(TextBoxA.Text);
            double b = double.Parse(TextBoxB.Text);
            double c = double.Parse(TextBoxC.Text);

            double x1 = 0;
            double x2 = 0;

            double d = Math.Pow(b, 2) - 4 * a * c;
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);

            TextBlockResult.Text = $"Результат: x1 = {x1};\n x2 = {x2}";
            TextBlockResult.Visibility = Visibility.Visible;
        }
    }
}
