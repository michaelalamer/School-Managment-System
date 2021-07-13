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

namespace School_Mangment_Project.Teachers_Pages
{
    /// <summary>
    /// Interaction logic for Attendance_By_Grade.xaml
    /// </summary>
    public partial class Attendance_By_Grade : Page
    {
        public Attendance_By_Grade()
        {
            InitializeComponent();
            Grade.Items.Add("Grade 1");
            Grade.Items.Add("Grade 2");
            Grade.Items.Add("Grade 3");
            Grade.Items.Add("Grade 4");
        }
    }
}
