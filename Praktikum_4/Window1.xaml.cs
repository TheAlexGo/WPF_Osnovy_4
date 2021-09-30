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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            TextBlockResult.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string numbers = TextBoxNumbers.Text;
            string[] numbersArr = numbers.Split(' ');
            int sum = 0;
            float result = 0;
            foreach(string num in numbersArr)
            {
                sum += int.Parse(num);
            }
            result = sum / numbersArr.Length;

            TextBlockResult.Text = $"Результат: {result}";
            TextBlockResult.Visibility = Visibility.Visible;
        }
    }
}
