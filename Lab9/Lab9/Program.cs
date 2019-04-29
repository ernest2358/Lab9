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


            //Cannot figure out how to take in the users input to index through students List to find student of users choice
            for (int i = 0; i < students.Capacity; i++)
            {
                Console.WriteLine("The student you have chosen is " + students[input]);
                break;
            }
            do
            {
                var knowMore = "";
                var yesMore = int.Parse("");
                Console.WriteLine("Would you like to know more about " + students[input] + "? y/n?");
                knowMore = Console.ReadLine();
                if (knowMore == "y" || knowMore =="Y")
                {
                    Console.WriteLine("Would you like to know " + students[input] + " 1- age, 2- hometown, or 3- favorite color. (Please selcet numbers 1-3)");
                    //how can dictionaries connect with list? (tried making key name same as student name)
                    //thought of using swtich statment for knowMore
                    if (yesMore == 1)
                    {

                        Console.WriteLine("The student " + students[input] + "'s age is " + students[ho]);
                    }
                    else if (yesMore == 2)
                    {

                    }

                }

                Console.WriteLine("Would you like to continue? y/n?");
                again = Console.ReadLine();
            } while (again == "y" || again == "Y");

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
            favColor.Add("Susan", "baby blue");
            favColor.Add("Jill", "purple");
            favColor.Add("Tucker", "orange");
            favColor.Add("Wendy", "red");

            //Of course all code should be placed into do while loop. Sat to sick to figure out code first. Or could use while loop.
            do
            {
                Console.WriteLine("Would you like to continue? y/n?");
                again = Console.ReadLine();
            } while (again == "y" || again == "Y");
        }
    }
}

