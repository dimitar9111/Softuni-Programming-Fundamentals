using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Average_Grades
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var studentsGrades = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                var student = new Student();
                string studentName = input[0];
                student.Name = studentName;

                var grades = new List<double>();
                for (int j = 1; j < input.Count; j++)
                {
                    grades.Add(double.Parse(input[j]));
                }

                student.AllGrades = grades;
                studentsGrades.Add(student);
            }

            List<Student> sortedStudents = studentsGrades.OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrade).ToList();
            foreach (var studenT in sortedStudents)
            {
                if (studenT.AverageGrade >= 5.00)
                {
                    Console.WriteLine($"{studenT.Name} -> {studenT.AverageGrade:f2}");
                }
            }
        }
    }
}
