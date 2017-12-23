using System;
using System.Collections.Generic;
using System.Linq;

namespace _08MentorGroup
{
    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<string> Dates { get; set; }
    }
    class Program
    {
        static void Main()
        {
            var result = new List<Student>();
            while (true)
            {
                var input = Console.ReadLine();
                if(input=="end of dates")
                {
                    break;
                }
                var inputDetails = input.Split();
                var name = inputDetails[0];
                var dates = inputDetails[1].Split(',').ToList();

                Student student = new Student()
                {
                    Name = name,
                    Dates=dates,
                };
                result.Add(student);
            }
            while (true)
            {
                var comments = Console.ReadLine();
                if (comments == "end of comments")
                {
                    break;
                }
                var nameComment = comments.Split('-');
                var name = nameComment[0];
                var comment = nameComment[1];

           
                foreach (var item in result)
                {
                    if(item.Name.Contains(name))
                    {
                        if (item.Comments==null)
                        {
                            item.Comments = new List<string>(); //!!!
                        }
                        
                        item.Comments.Add(comment);
                    }
                }
              
            }
            // Print:
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("Comments:");
               if (item.Comments != null)
                {
                    foreach (var c in item.Comments)
                    {
                        Console.WriteLine($"- {c}");
                    }
                }
                
                Console.WriteLine("Dates attended:");
                
                if (item.Dates != null)
                {
                    foreach (var d in item.Dates.OrderBy(a=>a))
                    {                        
                            Console.WriteLine($"-- {d:dd/MM/yyyy}");                        
                    }
                    // Console.WriteLine(string.Join("\r\n", item.Dates));
               
                }
                   
            }
        }
    }
}
