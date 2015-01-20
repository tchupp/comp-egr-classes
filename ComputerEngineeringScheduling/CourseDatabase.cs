using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ComputerEngineeringScheduling
{
    internal class CourseDatabase
    {
        private readonly List<Course> _courseList;
        private readonly string _coursesFilePath;

        public CourseDatabase()
        {
            _coursesFilePath =
                "D:/Users/Theo/Documents/Visual Studio 2013/workspaceCSharp/ComputerEngineeringScheduling/ComputerEngineeringScheduling/courses.csv";
            _courseList = new List<Course>();

            PopulateDatabase();
        }

        private void PopulateDatabase()
        {
            StreamReader streamReader = new StreamReader(_coursesFilePath);
            int x = 0;
            while (!streamReader.EndOfStream)
            {
                x++;
                string strline = streamReader.ReadLine();
                string[] values = strline.Split(',');

                if (values.Length > 0 && values[0].Trim().Length > 0)
                {
                    string name = values[0];
                    int credits = Convert.ToInt32(values[1]);
                    List<string> prereqs = new List<string>();

                    for (int i = 2; i < values.Length; i++)
                    {
                        prereqs.Add(values[i]);
                    }

                    Course course = new Course(name, credits, prereqs);
                    _courseList.Add(course);
                }
            }
        }

        public void UpdateAllCoursesList(ListBox allCourseList)
        {
            foreach (Course course in _courseList)
            {
                allCourseList.Items.Add(course.GetCourseName());
            }
        }
    }
}