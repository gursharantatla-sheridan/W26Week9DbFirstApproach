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

namespace W26Week9DbFirstApproach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SchoolDBEntities db = new SchoolDBEntities();

        public MainWindow()
        {
            InitializeComponent();
            LoadStandards();
        }

        private void LoadStudents()
        {
            var students = db.Students.ToList();
            grdStudents.ItemsSource = students;
        }

        private void LoadStandards()
        {
            var standards = db.Standards.ToList();
            cmbStandard.ItemsSource = standards;
            cmbStandard.DisplayMemberPath = "StandardName";
            cmbStandard.SelectedValuePath = "StandardId";
        }

        private void btnLoadStudents_Click(object sender, RoutedEventArgs e)
        {
            LoadStudents();
        }
    }
}
