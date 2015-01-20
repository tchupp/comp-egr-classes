using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerEngineeringScheduling;

namespace ComputerEngineeringScheduling
{
    public partial class MainWindow : Form
    {
        private CourseDatabase database;

        public MainWindow()
        {
            database = new CourseDatabase();
            InitializeComponent();
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
