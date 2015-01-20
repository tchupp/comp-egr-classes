using System.Collections.Generic;

namespace ComputerEngineeringScheduling
{
    class Course
    {
        private string courseName;
        private int courseCredit;
        private List<string> coursePrereqs;

        public Course(string name, int credit, List<string> prereq)
        {
            courseName = name;
            courseCredit = credit;
            coursePrereqs = prereq;
        }

        public string GetCourseName()
        {
            return courseName;
        }
    }
}
