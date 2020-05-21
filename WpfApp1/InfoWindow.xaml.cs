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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для InfoWindow.xaml
    /// </summary>

    public partial class InfoWindow : Window
    {
        private Chair chair { get; set; }

        private readonly BitmapImage bitmap;

        public InfoWindow(Chair c)
        {
            InitializeComponent();
            chair = c;
            bitmap = Initialize_bitmap();

            Info.Text = chair.RenderResponse();
            DImage.Source = bitmap;
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            chair.Buy_chair();
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).last_bought.Source = bitmap;
                    (window as MainWindow).last_bought_label.Text = chair.Name_of_chair;
                }
            }
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private BitmapImage Initialize_bitmap()
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(chair.ImagePath, UriKind.Absolute);
            bitmap.EndInit();
            return bitmap;
        }
    }
}
