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
    /// Interaction logic for student.xaml
    /// </summary>
    public partial class student : Page
    {
        studentEntities db=new studentEntities();   
        public student()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            student SS= new student();
            SS.Name = name.Text;
            SS.birthdate =Convert.ToDateTime( birth.Text);
            SS.gender = gen.Text;
            SS.grade =int.Parse(g1.Text);
            SS.course=cou.Text;
            db.students.Add(SS);
            db.SaveChanges();
            MessageBox.Show("done add");
        }
    }
}
