using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] courses = new string[] {

            "course1",
            "course2",
            "course3",
            "course4"

            };

            
            
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("end of the page");



            foreach (string kurs in courses) // We can just apply to strings
            {
                Console.WriteLine(kurs);
            }


        }
    }
}
