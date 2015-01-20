using System;
using System.Windows.Forms;

namespace ComputerEngineeringScheduling
{
    public partial class MainWindow : Form
    {
        private readonly CourseDatabase _database;
        private readonly OpenFileDialog _openFileDialog;

        public MainWindow()
        {
            _database = new CourseDatabase();
            _openFileDialog = new OpenFileDialog();
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            object selected = unfinishedCourseList.SelectedItem;
            if (selected != null)
            {
                _database.AddCourse(selected.ToString());
                _database.UpdateCourseList(unfinishedCourseList, finishedCourseList);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            object selected = finishedCourseList.SelectedItem;
            if (selected != null)
            {
                _database.RemoveCourse(selected.ToString());
                _database.UpdateCourseList(unfinishedCourseList, finishedCourseList);
            }
        }

        private void updateCurrentFilePathButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = _openFileDialog.ShowDialog();
            if (DialogResult.OK == dialogResult)
            {
                string selectedPath = _openFileDialog.FileName;
                currentFilePathLabel.Text = selectedPath;

                _database.PopulateDatabaseFromFile(selectedPath);
                _database.UpdateCourseList(unfinishedCourseList, finishedCourseList);
            }
        }
    }
}