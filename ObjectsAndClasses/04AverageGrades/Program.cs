using System;
using System.Collections.Generic;
using System.Linq;


namespace _04AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade { get; set; }
    }
    class Program
    {
        static void Main()
        {
            var students = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var allGrades = input.Skip(1).Select(double.Parse).ToArray();
                
                var student = new Student()
                {
                    Name = name,
                    Grades = allGrades,
                    AverageGrade =allGrades.Average()
                };
                students.Add(student);
            }
            students = students.OrderBy(a => a.Name).ThenByDescending(a => a.AverageGrade).Where(a => a.AverageGrade >= 5.00).ToList();
            foreach (var nameGradesAverage in students)
            {
                Console.WriteLine($"{nameGradesAverage.Name} -> {nameGradesAverage.AverageGrade:f2}");
            }
        }
    }
}
