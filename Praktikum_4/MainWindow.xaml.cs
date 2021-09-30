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
        OpenFileDialog _openDialog = new OpenFileDialog();
        public MainWindow()
        {
            InitializeComponent();
            w1.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _openDialog.Filter = "Media files (*.PNG)|*.png|All Files (*.*)|*.*";
            _openDialog.Multiselect = true;
            if (_openDialog.ShowDialog() == true)
            {
                w1.UpdateWindow(_openDialog.FileNames);
            }
        }
    }
}