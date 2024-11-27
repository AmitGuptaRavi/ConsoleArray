using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleArray
{
    public static class Linq
    {


        public static string filter()
        {
            //Where(): Filters elements based on a predicate (condition).
            int[] a = { 10, 20, 4, 685, 564, 14, 8564, 56, 48 };


            int[] c = a.Where(x => x % 2 == 0).OrderBy(x => x).ToArray();

            int[] b = a.OrderBy(x => x).ToArray();

            foreach (int i in c)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            return "";
        }
        public static string smallestArray()
        {
            int[] a = { 10, 20, 4, 685, 564, 14, 8564, 56, 48 };

            int b = a.Min();

            Console.WriteLine("Smallest number = : " + b);

            Console.ReadLine();
            return "";
        }

        public static string Projection()
        {//Select(): Projects each element of a collection into a new form.
            int[] a = { 10, 20, 4, 685, 564, 14, 8564, 56, 48 };

            int[] b = a.Select(n => n * 2).OrderBy(a => a).ToArray();


            foreach (int i in b)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            return "";
        }

        public static string JoiningMethods()
        {//Join(): Performs an inner join on two collections.
            var students = new[] {
               new { Id = 1, Name = "John" },
               new { Id = 2, Name = "Alice" }
           };

            var courses = new[] {
            new { StudentId = 1, Course = "Math" },
            new { StudentId = 2, Course = "Science" }
           };

            var studentCourses = students.Join(courses, student => student.Id, course => course.StudentId, (student, course) => new { student.Name, course.Course });
            var studentcourse = students.Join(courses, s => s.Id, c => c.StudentId, (students, courses) => new { students.Name, courses.Course });

            foreach (var sc in studentCourses)
            {
                Console.WriteLine($"{sc.Name} is enrolled in {sc.Course}");
                // Output: John is enrolled in Math
                // Output: Alice is enrolled in Science
            }
            return "";
        }

        public static string Sorting()
        {
            //OrderBy(): Sorts elements in ascending order.
            //OrderByDescending(): Sorts elements in descending order.
            int[] a = { 10, 20, 4, 685, 564, 14, 8564, 56, 48 };
            int[] b = a.OrderBy(x => x).ToArray();
            foreach (var i in b)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            return "";
        }

        public static string Reverse()
        {
            int[] a = { 10, 20, 4, 685, 564, 14, 8564, 56, 48 };
            int[] b = a.OrderBy(x => x).ToArray();
            int[] c = b.Reverse().ToArray();
            foreach (var i in c)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            return "";
        }
        public static string Grouping()
        {  //GroupBy(): Groups elements by a key.
            var students = new[] { new { Name = "John", Grade = "A" }, new { Name = "Alice", Grade = "B" }, new { Name = "Bob", Grade = "A" } };
            var groupedByGrade = students.GroupBy(x => x.Grade);
            foreach (var group in groupedByGrade)
            {
                Console.WriteLine(group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student.Name);
                }
            }
            return "";
        }

        public static string Aggregation()
        {
            // Sum(): Calculates the sum of elements.
            //Average(): Calculates the average of elements.
            //Min(): Finds the minimum value.
            //Max(): Finds the maximum value.
            //Count(): Counts the number of elements.
            //Aggregate(): Performs a custom aggregation.


            var students = new[] { new { Name = "John", Grade = "A" }, new { Name = "Alice", Grade = "B" }, new { Name = "Bob", Grade = "A" } };
            var groupedByGrade = students.GroupBy(x => x.Grade);
            foreach (var group in groupedByGrade)
            {
                Console.WriteLine(group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student.Name);
                }
            }
            Console.ReadLine();
            return "";
        }

        public static string SetMethod()
        {
            //Distinct(): Removes duplicate elements.
            //Union(): Combines two collections, removing duplicates.
            //Intersect(): Returns the common elements between two collections.
            //Except(): Returns elements in the first collection but not in the second.
            var numbers1 = new int[] { 1, 2, 3, 4 };
            var numbers2 = new int[] { 3, 4, 5, 6 };

            var commonNumbers = numbers1.Intersect(numbers2);
            foreach (var num in commonNumbers)
            {
                Console.WriteLine(num); // Output: 3, 4
            }
            Console.ReadLine();
            return "";
        }

        public static string ElementMethods()
        {
            // First(): Returns the first element.
            //FirstOrDefault(): Returns the first element, or a default value if no element is found.
            //Last(): Returns the last element.
            //LastOrDefault(): Returns the last element, or a default value if no element is found.
            //Single(): Returns the only element, throws an exception if more than one element is found.
            //SingleOrDefault(): Returns the only element, or a default value if no element is found.
            var numbers = new int[] { 1, 2, 3, 4 };
            var firstNumber = numbers.First();
            Console.WriteLine(firstNumber); // Output: 1
            Console.ReadLine();
            return "";

        }

        public static string ConversionMethods()
        {
            //ToList(): Converts the collection to a list.
            //ToArray(): Converts the collection to an array.
            //ToDictionary(): Converts the collection to a dictionary.

            var numbers = new int[] { 1, 2, 3, 4 };
            var numberList = numbers.ToList();
            numberList.ForEach(n => Console.WriteLine(n)); // Output: 1, 2, 3, 4
            Console.ReadLine();
            return "";
        }




        public static string Callmethod()
        {
            //Reverse();
            //Sorting();
            //Projection();
            // Grouping();
            ConversionMethods();

            return "";
        }
    }
}
