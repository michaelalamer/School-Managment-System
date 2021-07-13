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
    /// Interaction logic for Attenedance.xaml
    /// </summary>
    public partial class Attenedance : Page
    {
        //string Attendance_type;
        //bool Attendance;
        public Attenedance()
        {
            InitializeComponent();
            
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            Main_Content.Content = new Teachers_Pages.Attendance_By_SpisficStudent();
        }

        private void Check1_Click(object sender, RoutedEventArgs e)
        {
            Main_Content.Content = new Teachers_Pages.Attendance_By_Grade();
        }
    }
}
