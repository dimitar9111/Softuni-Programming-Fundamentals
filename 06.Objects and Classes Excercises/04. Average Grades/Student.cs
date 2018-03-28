using System.Collections.Generic;
using System.Linq;

namespace _04.Average_Grades
{
    public class Student
    {
        public string Name { get; set; }

        public List<double> AllGrades { get; set; }

        public double AverageGrade => AllGrades.Average();
    }
}
