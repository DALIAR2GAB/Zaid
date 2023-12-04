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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        studentEntities db=new studentEntities();
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            signup ss= new signup();    
            this.NavigationService.Navigate(ss);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(com.Text=="Student")
            {
                student_log sv= new student_log();
                sv = db.student_log.FirstOrDefault(x => x.user_namee== username.Text && x.passwordd == pass.Text);
                if(sv!=null)
                {
                    student hh=new student();
                    this.NavigationService.Navigate(hh);
                }
                else
                {
                    MessageBox.Show("Error login");
                }
            }
            if(com.Text=="Teacher")
            {
                teacher_log s = new teacher_log();
                s = db.teacher_log.FirstOrDefault(x => x.user_namee == username.Text && x.passwordd == pass.Text);
                if (s != null)
                {
                    teacher S= new teacher ();
                    this.NavigationService.Navigate(S);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
