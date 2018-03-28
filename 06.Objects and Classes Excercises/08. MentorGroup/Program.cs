using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _08_Mentor_Group
{
    public class Program
    {
        public static void Main()
        {
            var students = new SortedDictionary<string, Student>();

            var input = Console.ReadLine().Split(' ', ',');
            while (input[0] != "end")
            {
                var attendDates = new List<DateTime>();

                for (int i = 1; i < input.Length; i++)
                {
                    attendDates.Add(DateTime.ParseExact(input[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }
                if (students.ContainsKey(input[0]))
                {
                    students[input[0]].Attendency.AddRange(attendDates);
                }
                else
                {
                    var newStudent = new Student
                    {
                        Name = input[0],
                        Attendency = attendDates,
                        Comments = new List<string>()

                    };
                    students[input[0]] = newStudent;
                }

                input = Console.ReadLine().Split(' ', ',');
            }

            input = Console.ReadLine().Split('-');
            while (input[0] != "end of comments")
            {
                if (students.ContainsKey(input[0]))
                {
                    students[input[0]].Comments.Add(input[1]);
                }

                input = Console.ReadLine().Split('-');
            }

            foreach (var student in students)
            {
                Console.WriteLine(student.Key);
                Console.WriteLine("Comments:");

                foreach (var comment in student.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");
                
                foreach (var date in student.Value.Attendency.OrderBy(d => d))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
        }
    }
}
