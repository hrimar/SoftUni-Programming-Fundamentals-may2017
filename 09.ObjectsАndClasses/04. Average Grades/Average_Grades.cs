using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade => this.Grades.Average();  // за смятане на ср. оценка !!!!!
    }
    class Average_Grades
    {
        static void Main()
        {
            var students = new List<Student>(); // имената на студентите се повтарят затова е List, ne Disctionary

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split();
                var name = inputLine[0];
                var grades = inputLine.Skip(1).Select(double.Parse).ToArray(); // inputLine[1]

                var student = new Student()
                {
                    Name = name,
                   Grades = grades
                };
                students.Add(student);
            }
            students = students.Where(a=>a.AverageGrade>=5.00)
                       .OrderBy(a => a.Name).ThenByDescending(a => a.AverageGrade).ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }
}
