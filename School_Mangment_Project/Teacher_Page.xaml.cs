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

namespace School_Mangment_Project
{
    /// <summary>
    /// Interaction logic for Teacher_Page.xaml
    /// </summary>
    public partial class Teacher_Page : Window
    {
        public Teacher_Page()
        {
            InitializeComponent();
        }
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void listViewItem4_Selected(object sender, RoutedEventArgs e)
        {
            var newform = new Login_Page(); //create your new form.
            newform.Show(); //show the new form.
            this.Close(); //only if you want to close the current form.
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Main_Content.Content = new Teachers_Pages.Profile();
        }

        private void listViewItem_Selected(object sender, RoutedEventArgs e)
        {
            Main_Content.Content = new Attenedance();
        }

        private void listViewItem1_Selected(object sender, RoutedEventArgs e)
        {
            Main_Content.Content = new Search();
        }
    }
}
