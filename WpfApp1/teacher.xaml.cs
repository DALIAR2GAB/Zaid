using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for teacher.xaml
    /// </summary>
    public partial class teacher : Page
    {
        studentEntities db=new studentEntities();
        public teacher()
        {
            InitializeComponent();
            datagrid.ItemsSource=db.students.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            student s=new student();
            int id = int.Parse(idd.Text);
            s = db.students.FirstOrDefault(x => x.student_id == id);
            s.grade = int.Parse(gg.Text);
            db.students.AddOrUpdate(s); 
            db.SaveChanges();
            MessageBox.Show("secusfully update");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = db.students.ToList();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            student a=new student();    
            int ide=int.Parse(idd.Text);
            a = db.students.FirstOrDefault(x => x.student_id == ide);
            db.students.Remove(a);
            db.SaveChanges();
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            student ss = new student();
            if (idd.Text != "" && gg.Text != "")
            {
                int id = int.Parse(idd.Text);
                int g = int.Parse(gg.Text);
                datagrid.ItemsSource =db.students.Where(x => x.student_id == id && x.grade == g).ToList();
            }
            else if (idd.Text == "" && gg.Text != "")
            {
                int gb = int.Parse(gg.Text);
                datagrid.ItemsSource = db.students.Where(x => x.grade == gb).ToList();
            }
            else if (idd.Text != "" && gg.Text == "")
            {
                int kk = int.Parse(idd.Text);
                datagrid.ItemsSource = db.students.Where(x => x.student_id == kk).ToList();
            }
            else
            {
                MessageBox.Show("enter the Id or grade");
            }
            
        }
    }
}
