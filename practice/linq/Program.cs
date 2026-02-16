using System;

namespace linq
{
    internal class Program
    {
        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int Id { get; set; }
            public int marks { get; set; }
            public void ShowInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}, Id: {Id}, Marks: {marks}");
            }

            
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", Age = 20, Id = 1, marks = 85 },
                new Student { Name = "Bob", Age = 22, Id = 2, marks = 90 },
                new Student { Name = "Charlie", Age = 19, Id = 3, marks = 78 },
                new Student { Name = "David", Age = 21, Id = 4, marks = 92 },
                new Student { Name = "Eve", Age = 20, Id = 5, marks = 88 }
            };

            foreach (var item in students)
            {
                item.ShowInfo();
            }
        }
    }
}
