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
    /// Interaction logic for Parent_Page.xaml
    /// </summary>
    public partial class Parent_Page : Window
    {
        public Parent_Page()
        {
            InitializeComponent();
        }

        private void attendance_Selected(object sender, RoutedEventArgs e)
        {
            Main_Content.Content = new Parent_Pages.Attendance();
        }

        private void grade_Selected(object sender, RoutedEventArgs e)
        {
            Main_Content.Content = new Parent_Pages.Grades();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void logout_Selected(object sender, RoutedEventArgs e)
        {
            Login_Page li = new Login_Page();
            this.Hide();
            li.Show();
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

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void contact_teacher_Selected(object sender, RoutedEventArgs e)
        {
            Main_Content.Content = new Parent_Pages.Contact_Teacher();
        }
    }
}
