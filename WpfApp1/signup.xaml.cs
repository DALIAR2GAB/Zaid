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
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class signup : Page
    {
        studentEntities db=new studentEntities();
        public signup()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                student_log sl = new student_log();
                if (user != null && password != null && con != null)
                {
                    sl.user_namee = user.Text;
                    sl.passwordd = password.Text;
                    sl.passwordd = con.Text;
                    db.student_log.Add(sl);
                    db.SaveChanges();
                    MessageBox.Show("Secusfully sign up");
                    login l = new login();
                    this.NavigationService.Navigate(l);
                }
            
        }
       
    }
}
