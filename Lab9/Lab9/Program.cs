using System;
using System.Collections.Generic;

namespace OurClassLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which student would you like to learn more about? Please enter a number.");
            var input = int.Parse(Console.ReadLine());
            var again = "";

            var students = new List<string>() { "John", "Susan", "Jill", "Tucker", "Wendy" };

            foreach (var student in students)
            {
               Console.WriteLine(student);
            }
            //Cannot figure out how to take in the users input to index through students List to find student of users choice


            //As well not sure how to associate collection below with student List. Attempted to use student names as key words which assciated with ,output.
            Dictionary<string, int> age = new Dictionary<string, int>();
            age.Add("John", 28);
            age.Add("Susan", 20);
            age.Add("Jill", 31);
            age.Add("Tucker", 29);
            age.Add("Wendy", 36);

            Dictionary<string, string> hometown = new Dictionary<string, string>();
            hometown.Add("John", "Detoit, Mi");
            hometown.Add("Susan", "Oakland, California");
            hometown.Add("Jill", "Tulsa, Oklahoma");
            hometown.Add("Tucker", "Seattle, Washington");
            hometown.Add("Wendy", "Atlanta, Georgia");

            Dictionary<string, string> favColor = new Dictionary<string, string>();
            favColor.Add("John", "blue");
            favColor.Add("John", "baby blue");
            favColor.Add("John", "purple");
            favColor.Add("John", "orange");
            favColor.Add("John", "red");

            do
            {
                Console.WriteLine("Would you like to continue? y/n?");
                again = Console.ReadLine();
            } while (again == "y" || again == "Y");
        }
    }
}

