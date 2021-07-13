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
    /// Interaction logic for confirm_Page.xaml
    /// </summary>
    public partial class confirm_Page : Page
    {
        public confirm_Page()
        {
            InitializeComponent();
            ConfirmView.Items.Add("michael");
            ConfirmView.Items.Add("fdsf");
            ConfirmView.Items.Add("dsgsmdg");
            ConfirmView.Items.Add("michael");
        }
        private void ConfirmView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(ConfirmView.SelectedValue.ToString());
            functions_frame.Content =new Admin_Pages.ConfimPerson_page();
        }
    }
}
