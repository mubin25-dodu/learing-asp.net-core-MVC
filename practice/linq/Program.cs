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

            // Filter: students with marks >= 85, then display their Name and marks.
            var f1 = students.Where(s=> s.marks >= 85).ToList();
            // Sort: order students by marks descending, then by Age ascending.
            var f2 = students.OrderByDescending(s=>s.marks).ToList();
            var f3 = students.OrderBy(s=>s.Age).ToList();

            //  f2.Add(new Student
            //  {
            //      Id =20
            //  });
            // Top 2: get the top 2 students by marks and print them.
            var f4 = students.OrderByDescending(s => s.marks).Take(2).ToList();
            // Average: compute average marks of all students.
            var f5 = students.Average(s=>s.marks);
            System.Console.WriteLine(f5);
            // Group: group students by Age, then show each age with the count of students.
            // Max/Min: find the student with highest marks and lowest marks.
            // Projection: create a new list of anonymous objects with Name and marks only.
            // Names list: get a list of all names sorted alphabetically.
            // Range: students with marks between 80 and 90 inclusive.
            // Any/All: check if any student has marks < 80, and if all students have Age >= 19.
            foreach (var item in f4)
            {
                item.ShowInfo();
            }
        }
    }
}
