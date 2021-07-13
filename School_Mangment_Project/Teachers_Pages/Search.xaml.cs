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
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Page
    {
        public Search()
        {
            InitializeComponent();
            Grade.Items.Add("MideTerm 1");
            Grade.Items.Add("MideTerm 2");
            Grade.Items.Add("MideTerm 3");
            Grade.Items.Add("MideTerm 4");
        }

        private void Quiz_Name_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Quiz_Grade.Text = Grade.SelectedValue.ToString();
        }

        private void Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            Quiz_Grade.IsReadOnly = false;
            Save_Button.Visibility = Visibility.Visible;
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            Save_Button.Visibility = Visibility.Hidden;
            Quiz_Grade.IsReadOnly = true;
        }
    }
}
