using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Course course1 = new Course();
            course1.nameOfCourse = "C#";
            course1.teacher = "Engin Demiroğ";
            course1.watchingRate = 17;


            Course course2 = new Course();
            course2.nameOfCourse = "Python";
            course2.teacher = "Muratcan Kara";
            course2.watchingRate = 99;

            
            
            
            Course[] courses = new Course[] {
            
            course1,
            course2
            
            
            };


            foreach (Course course in courses)
            {
                Console.WriteLine(course.nameOfCourse + course.teacher + course.watchingRate);
            }


        }
    }


    class Course
    {
        public string nameOfCourse { get; set; }
        public string teacher { get; set; }
        public int watchingRate { get; set; }

    }


}
