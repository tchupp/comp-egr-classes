using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ComputerEngineeringScheduling
{
    internal class CourseDatabase
    {
        private readonly List<Course> _allCourseList;
        private readonly List<Course> _unfinishedCourseList;
        private readonly List<Course> _finishedCourseList;
        private readonly List<Course> _plannedCourseList;

        public CourseDatabase()
        {
            _allCourseList = new List<Course>();
            _unfinishedCourseList = new List<Course>();
            _finishedCourseList = new List<Course>();
            _plannedCourseList = new List<Course>();
        }

        public void PopulateDatabaseFromFile(String filepath)
        {
            // clears all current lists
            _allCourseList.Clear();
            _unfinishedCourseList.Clear();
            _finishedCourseList.Clear();
            _plannedCourseList.Clear();

            // reads csv into database
            StreamReader streamReader = new StreamReader(filepath);
            while (!streamReader.EndOfStream)
            {
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
                    _allCourseList.Add(course);
                    _unfinishedCourseList.Add(course);
                }
            }
        }

        public void UpdateCourseList(ListBox unfinishedCourseList, ListBox finishedCourseList)
        {
            // initially clear the lists
            unfinishedCourseList.Items.Clear();
            finishedCourseList.Items.Clear();

            // add all the courses from _unfinishedCourseList
            foreach (Course course in _unfinishedCourseList)
            {
                unfinishedCourseList.Items.Add(course.GetCourseName());
            }

            // add all the courses from _finishedCourseList
            foreach (Course course in _finishedCourseList)
            {
                finishedCourseList.Items.Add(course.GetCourseName());
            }
        }

        // matches a course's name to the object in the allCourseList
        private Course IdentifyCourse(String courseName)
        {
            foreach (Course course in _allCourseList)
            {
                if (course.GetCourseName().Equals(courseName))
                {
                    return course;
                }
            }
            return new Course("", 0, new List<string>());
        }

        public void AddCourse(String courseName)
        {
            Course course = IdentifyCourse(courseName);

            if (_allCourseList.Contains(course))
            {
                _finishedCourseList.Add(course);
                _unfinishedCourseList.Remove(course);
            }
        }

        public void RemoveCourse(String courseName)
        {
            Course course = IdentifyCourse(courseName);

            if (_allCourseList.Contains(course))
            {
                _unfinishedCourseList.Add(course);
                _finishedCourseList.Remove(course);
            }
        }
    }
}