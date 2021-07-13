using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {

        public Profile()
        {
            InitializeComponent();
        }

        private void Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            FirstName.IsReadOnly = false;
            LastName.IsReadOnly = false;
            Age.IsReadOnly = false;
            Email.IsReadOnly = false;
            PhoneNumber.IsReadOnly = false;
        }
        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            FirstName.IsReadOnly = true;
            LastName.IsReadOnly = true;
            Age.IsReadOnly = true;
            Email.IsReadOnly = true;
            PhoneNumber.IsReadOnly = true;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.* ";
                if (dlg.ShowDialog() == true)
                {
                    Stream stream = File.Open(dlg.FileName, FileMode.Open);
                    BitmapImage imgsrc = new BitmapImage();
                    imgsrc.BeginInit();
                    imgsrc.StreamSource = stream;
                    imgsrc.EndInit();
                    ImageBrush myBrush = new ImageBrush();
                    myBrush.ImageSource = imgsrc;
                    Pic.Fill = myBrush;
                }
        }
    }
}
