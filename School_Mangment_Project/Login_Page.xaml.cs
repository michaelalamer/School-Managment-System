using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data.SqlClient;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace School_Mangment_Project
{
    /// <summary>
    /// Interaction logic for Login_Page.xaml
    /// </summary>
    public partial class Login_Page : Window
    {
        string LoginType;
        string ForgetType;
        string SignUpType;
        public Login_Page()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            LoginType = "Admin";
           // MessageBox.Show(LoginType);
        }

        private void Check1_Click(object sender, RoutedEventArgs e)
        {
            LoginType = "Teacher";
            //MessageBox.Show(LoginType);
        }

        private void Check2_Click(object sender, RoutedEventArgs e)
        {
            LoginType = "Parent";
            //MessageBox.Show(LoginType);
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginType=="Admin")
            {
                var Admin_PAge = new Admin_Page();
                Admin_PAge.Show();
                this.Close();

            }
            else if (LoginType == "Teacher")
            {
                var Teacher_Page = new Teacher_Page();
                Teacher_Page.Show();
                this.Close();
            }
            else if (LoginType == "Parent")
            {
                var Parent = new Parent_Page();
                Parent.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You should select Login type", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        //.........................................................................................................................................

        private void FCheck_Click(object sender, RoutedEventArgs e)
        {
            ForgetType = "Admin";
        }

        private void FCheck1_Click(object sender, RoutedEventArgs e)
        {
            ForgetType = "Teacher";
        }

        private void FCheck2_Click(object sender, RoutedEventArgs e)
        {
            ForgetType = "Parent";
        }

        private void FLogin_Button_Click(object sender, RoutedEventArgs e)
        {
            if (ForgetType == "Admin")
            {

            }
            else if (ForgetType == "Teacher")
            {
                var Teacher_Page = new Teacher_Page();
                Teacher_Page.Show();
                this.Close();
            }
            else if (ForgetType == "Parent")
            {

            }
            else
            {
                MessageBox.Show("You should select Forget Type", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

//...........................................................................................................................................
        private void SCheck_Click(object sender, RoutedEventArgs e)
        {
            SignUpType = "Admin";
        }

        private void SCheck1_Click(object sender, RoutedEventArgs e)
        {
            SignUpType = "Teacher";
        }

        private void SCheck2_Click(object sender, RoutedEventArgs e)
        {
            SignUpType = "Parent";
        }

        private void SignUp_Button_Click(object sender, RoutedEventArgs e)
        {
            if (SignUpType == "Admin")
            {

            }
            else if (SignUpType == "Teacher")
            {
                var Teacher_Page = new Teacher_Page();
                Teacher_Page.Show();
                this.Close();
            }
            else if (SignUpType == "Parent")
            {

            }
            else
            {
                MessageBox.Show("You should select SignUp Type", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void SignUP_Click()
        {

        }
    }
}
