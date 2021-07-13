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
using System.Data.SqlClient;
using System.Data;

namespace School_Mangment_Project.Admin_Pages
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        string picloc = "";
        SqlConnection cn = new SqlConnection("Server=DESKTOP-7TUPQHQ;DataBase=Company_DataBase;Integrated Security=false;User ID=sa;Password=123456;");
        public Profile()
        {
            InitializeComponent();
        }

        private void prof_pic_edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.* ";
            if (dlg.ShowDialog() == true)
            {
                Stream stream;
                stream = File.Open(dlg.FileName, FileMode.Open);
                BitmapImage imgsrc = new BitmapImage();
                imgsrc.BeginInit();
                imgsrc.StreamSource = stream;
                imgsrc.EndInit();
                ImageBrush myBrush = new ImageBrush();
                myBrush.ImageSource = imgsrc;
                profile_picture.Fill = myBrush;
                picloc = dlg.FileName.ToString();
                    stream.Close();
            }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            finally
            {
               
            }

        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            FirstName.IsReadOnly = true;
            LastName.IsReadOnly = true;
            Age.IsReadOnly = true;
            Email.IsReadOnly = true;
            PhoneNumber.IsReadOnly = true;


            try
            {
                byte[] img = null;



                FileStream fs = new FileStream(picloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                SqlCommand cmd = new SqlCommand("insert into Images (Image) values (@img) ", cn);
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show(x.ToString() + "Recorder save");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                cn.Close();
            }



            try
            {
                SqlCommand cmd = new SqlCommand("select Image from Images where Name='" + "MM" + "' ", cn);
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    byte[] img = (byte[])(dr[0]);
                    if (img == null)
                        profile_picture.Fill = null;
                    else
                    {
                        
                        MemoryStream ms = new MemoryStream(img);
                        var imageSource = new BitmapImage();
                        imageSource.BeginInit();
                        imageSource.StreamSource = ms;
                        imageSource.EndInit();

                        ImageBrush myBrush = new ImageBrush();
                        myBrush.ImageSource = imageSource;

                        profile_picture.Fill = myBrush;


                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            FirstName.IsReadOnly = false;
            LastName.IsReadOnly = false;
            Age.IsReadOnly = false;
            Email.IsReadOnly = false;
            PhoneNumber.IsReadOnly = false;


            SqlCommand cmd = new SqlCommand("insert into Images (Name) values ('"+"kljnkn"+"') ", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }
    }
}
