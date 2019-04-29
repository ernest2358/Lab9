using System;
using System.Collections.Generic;

namespace OurClassLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<string>() { "John", "Susan", "Jill", "Tucker", "Wendy" };

            var age = new List<int>();
            age.Add(28);
            age.Add(20);
            age.Add(31);
            age.Add(29);
            age.Add(36);

            var favColor = new List<string>();
            favColor.Add("blue");
            favColor.Add("baby blue");
            favColor.Add("purple");
            favColor.Add("orange");
            favColor.Add("red");

            var hometown = new List<string>();
            hometown.Add("Detoit, Mi");
            hometown.Add("Oakland, California");
            hometown.Add("Tulsa, Oklahoma");
            hometown.Add("Seattle, Washington");
            hometown.Add("Atlanta, Georgia");

            var again = "";
            var knowMore = "";
            int yesMore;

            do
            {
                Console.WriteLine("Which student would you like to learn more about? Please enter a number.");
                var input = int.Parse(Console.ReadLine());

                Console.WriteLine("The student you have chosen is " + students[input]);

                do
                {
                    Console.WriteLine("Would you like to know more about " + students[input] + "? y/n?");
                    knowMore = Console.ReadLine();
                    if (knowMore == "y" || knowMore == "Y")
                    {
                        Console.WriteLine("Would you like to know " + students[input] + "'s 1- age, 2- hometown, or 3- favorite color. (Please selcet numbers 1-3)");

                        yesMore = int.Parse(Console.ReadLine());
                        if (yesMore == 1)
                        {
                            Console.WriteLine(students[input] + "'s age is " + age[input] + ".");
                        }
                        else if (yesMore == 2)
                        {
                            Console.WriteLine(students[input] + "'s hometown is " + hometown[input] + ".");
                        }
                        else if (yesMore == 3)
                        {
                            Console.WriteLine(students[input] + "'s favorite color is " + favColor[input] + ".");
                        }
                        else
                        {
                            Console.WriteLine("Input chosen is not listed above please chose options 1-3.");
                        }
                    }
                } while (knowMore == "y" || knowMore == "Y");

                Console.WriteLine("Would you like to chose another student? y/n?");
                again = Console.ReadLine();
            } while (again == "y" || again == "Y");

            Console.WriteLine("Hope you had fun. Goodbye!");
        }
    }
}

