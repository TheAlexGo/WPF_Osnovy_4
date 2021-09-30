using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Window1 w1 = new Window1();
        Window2 w2 = new Window2();
        Window3 w3 = new Window3();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            w1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            w2.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            w3.Show();
        }
    }
}