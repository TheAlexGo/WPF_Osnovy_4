using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        SaveFileDialog _saveDialog = new SaveFileDialog();
        public Window1()
        {
            InitializeComponent();
        }

        public void UpdateWindow(string[] imagesArray)
        {
            foreach (string image in imagesArray)
            {
                ListBoxImages.Items.Add(image);
            }
        }

        private void ListBoxImages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ImagesContent.Source = new BitmapImage(new Uri(ListBoxImages.SelectedItem.ToString()));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _saveDialog.Filter = "Text files (*.PNG)|*.png|All Files (*.*)|*.*";
            if (_saveDialog.ShowDialog() == true)
            {
                Bitmap myBitmap = new Bitmap(ListBoxImages.SelectedItem.ToString());
                myBitmap.Save(_saveDialog.FileName);
            }
        }
    }
}
