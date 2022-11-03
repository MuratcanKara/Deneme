using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            String categoryLabel = "Categories";
            int numberOfStudents = 32000;
            double interestRate = 1.8;
            bool login = false;
            double dollarYesterday = 7.35;
            double dollarToday = 7.35;

            if (dollarYesterday > dollarToday)
            {
                Console.WriteLine("There's an decrease image!");
            }
            else if (dollarYesterday < dollarToday)
            {
                Console.WriteLine("There's an increase image!");
            }
            else
            {
                Console.WriteLine("There's not any changes image!");
            }




        }
    }
}
