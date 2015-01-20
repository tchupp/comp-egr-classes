using System;
using System.Windows.Forms;

namespace ComputerEngineeringScheduling
{
    public partial class MainWindow : Form
    {
        private CourseDatabase _database;

        public MainWindow()
        {
            _database = new CourseDatabase();
            InitializeComponent();

            _database.UpdateAllCoursesList(allCourseList);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            object selected = allCourseList.SelectedItem;
            allCourseList.Items.Remove(selected);
            finishedCourseList.Items.Add(selected);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            object selected = finishedCourseList.SelectedItem;
            allCourseList.Items.Add(selected);
            finishedCourseList.Items.Remove(selected);
        }
    }
}
