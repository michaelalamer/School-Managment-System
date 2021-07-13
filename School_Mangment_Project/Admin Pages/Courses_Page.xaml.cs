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

namespace School_Mangment_Project.Admin_Pages
{
    /// <summary>
    /// Interaction logic for Courses_Page.xaml
    /// </summary>
    public partial class Courses_Page : Page
    {
        public Courses_Page()
        {
            InitializeComponent();
              alldata.Visibility = Visibility.Hidden;
//            next.Visibility = Visibility.Hidden;
  //          back.Visibility = Visibility.Hidden;
        }
        private void show_all_courses_Click(object sender, RoutedEventArgs e)
        {
              alldata.Visibility = Visibility.Visible;
    //        next.Visibility = Visibility.Visible;
      //      back.Visibility = Visibility.Visible;
        }

        private void instructor_name_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            CourseName.Text = null;
            instructor_name.Items.Clear();
            NumofStudent.Text = null;
            Start_date.Text = null;
            End_date.Text = null;

        }

        private void Update_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
