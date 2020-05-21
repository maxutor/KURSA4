using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        ObservableCollection<Chair> Chairs { get; set; }
        ChairManager manager;

        public MainWindow()
        {
            InitializeComponent();

            manager = new ChairManager();
            manager.Filters = new List<string>();

            Chairs = new ObservableCollection<Chair>(manager.Get_all_chairs_by_category("all_chairs"));

            chairsList.ItemsSource = Chairs;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Chairs = new ObservableCollection<Chair>(manager.Get_filtered_sorted_chairs());
            chairsList.ItemsSource = Chairs;
        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvItem = (TreeViewItem)sender;
            switch (tvItem.Header.ToString())
            {
                case "Dinning":
                    manager.category = "dinner_chairs";
                    break;
                case "Pads":
                    manager.category = "pads_chairs";
                    break;
                case "Children`s":
                    manager.category = "children`s_chairs";
                    break;
                case "Desk":
                    manager.category = "desk_chairs";
                    break;
                case "High":
                    manager.category = "high_chairs";
                    break;
                case "Stool_b":
                    manager.category = "stools_and_brenches";
                    break;
                case "Cafe":
                    manager.category = "cafe_chairs";
                    break;
                case "All chairs":
                    manager.category = "all_chairs";
                    break;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            manager.Filters.Add("avaible");
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            manager.Filters.Remove("avaible");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            manager.Filters.Add("more than 200");
        }

        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            manager.Filters.Remove("more than 200");
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            manager.Filters.Add("less than 201");
        }

        private void RadioButton_Unchecked_1(object sender, RoutedEventArgs e)
        {
            manager.Filters.Remove("less than 201");
        }

        private void chairsList_SelectionChanged(object sender, SelectionChangedEventArgs e)   
        {
            Chair c = (Chair)chairsList.SelectedItem;
            if (c != null)
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(c.ImagePath, UriKind.Absolute);
                bitmap.EndInit();

                last_item.Source = bitmap;
                last_item_label.Text = c.Name_of_chair;

                InfoWindow taskWindow = new InfoWindow(c);
                taskWindow.Owner = this;

                taskWindow.Show();
            }
        }

        private void TreeViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvItem = (TreeViewItem)sender;
            switch (tvItem.Header.ToString())
            {
                case "ASC":
                    manager.option = "ASC";
                    break;
                case "DESC":
                    manager.option = "DESC";
                    break;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            manager.Search_option_color = (textBox.Text.ToString()).ToLower();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            manager.Search_option_material = (textBox.Text.ToString()).ToLower();
        }
    }
}
