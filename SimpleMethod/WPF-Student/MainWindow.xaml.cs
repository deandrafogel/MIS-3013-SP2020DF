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

namespace WPF_Student
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btn_Student_Click(object sender, RoutedEventArgs e)
        {
            
            WPFStudent Student1 = new WPFStudent();
            
            Student1.FirstName = txtFirstName1.Text;
            Student1.LastName = txtLastName.Text;
            Student1.FavoriteColor = txtFavColor.Text;
            Student1.StudentID = Convert.ToInt32(txtStudentID.Text);


            lstStudent.Items.Add(Student1.ToString());

            txtFirstName1.Text = "";
            txtLastName.Text = "";
            txtStudentID.Text = "";
            txtFavColor.Text = "";





        }
        //public static string[] ReadAllLines (string path)
        //{

            //string path =
            //return string[] readText = File.ReadAllLines(path);
            //tried to do Problem #2, could not get the CSV files to download on the parallels side of my laptop
        //}
    }
}
