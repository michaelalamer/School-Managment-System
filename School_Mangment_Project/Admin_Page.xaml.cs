using Microsoft.Win32;
using System.IO;
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

namespace School_Mangment_Project
{
    /// <summary>
    /// Interaction logic for Admin_Page.xaml
    /// </summary>
    public partial class Admin_Page : Window
    {
        public Admin_Page()
        {
            InitializeComponent();
            //Listt.Items.Add("kwjrkar");
        }
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Teachers_Button_Selected(object sender, RoutedEventArgs e)
        {
            functions_frame.Content = new Admin_Pages.Teacher_Page();
        }

        private void Courses_Button_Selected(object sender, RoutedEventArgs e)
        {
            functions_frame.Content = new Admin_Pages.Courses_Page();
        }
        private void open_Click(object sender, RoutedEventArgs e)
        {
            open.Visibility = Visibility.Collapsed;
            close.Visibility = Visibility.Visible;

        }


        private void close_Click(object sender, RoutedEventArgs e)
        {
            open.Visibility = Visibility.Visible;
            close.Visibility = Visibility.Collapsed;
        }

        private void Students_Button_Selected(object sender, RoutedEventArgs e)
        {
            functions_frame.Content = new Admin_Pages.Student();
        }

        private void enroll_student_Selected(object sender, RoutedEventArgs e)
        {
            functions_frame.Content = new Admin_Pages.Enroll_Student();
        }

        private void logout_Selected(object sender, RoutedEventArgs e)
        {
            Login_Page li = new Login_Page();
            this.Hide();
            li.Show();
        }

        private void settings_button_Click(object sender, RoutedEventArgs e)
        {
            functions_frame.Content = new Admin_Pages.Profile();
        }

        private void confirm_Selected(object sender, RoutedEventArgs e)
        {
            functions_frame.Content = new Admin_Pages.confirm_Page();
        }
    }
}
