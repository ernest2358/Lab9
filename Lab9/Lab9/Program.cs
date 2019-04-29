using System;
using System.Collections.Generic;

namespace OurClassLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<string>() { "John", "Susan", "Jill", "Tucker", "Wendy" };

            var age = new List<int>() {28, 20, 31, 29, 36};

            var favColor = new List<string>() { "blue", "baby blue", "purple", "orange", "red"};

            var hometown = new List<string>() { "Detoit, Mi", "Oakland, California", "Tulsa, Oklahoma", "Seattle, Washington", "Atlanta, Georgia"};

            var again = "";
            var knowMore = "";
            int yesMore;
            var newStu = "";

            do
            {
                Console.WriteLine("Which student would you like to learn more about? Please enter a number 0-4.");
                var input = int.Parse(Console.ReadLine());
                Console.WriteLine("The student you have chosen is " + students[input]);
                try
                {
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                do
                {
                    Console.WriteLine("Would you like to know more about " + students[input] + "? y/n?");
                    knowMore = Console.ReadLine();
                    if (knowMore == "y" || knowMore == "Y")
                    {
                        Console.WriteLine("Would you like to know " + students[input] + "'s 1- age, 2- hometown, or 3- favorite color. (Please select numbers 1-3)");

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

                Console.WriteLine("Would you like to choose another student? y/n?");
                again = Console.ReadLine();
            } while (again == "y" || again == "Y");

            Console.WriteLine("Would you like to add another student? y/n?");
            var input2 = Console.ReadLine();
            if (input2 == "y" || input2 == "Y")
            {
                try
                {
                    Console.WriteLine("Please enter in the name of the new student.");
                    newStu = Console.ReadLine();
                    students.Add(newStu);
                    Console.WriteLine("Please enter new students age.");
                    var newStuAge = int.Parse(Console.ReadLine());
                    age.Add(newStuAge);
                    Console.WriteLine("Please enter new students hometown");
                    var newStuHometown = Console.ReadLine();
                    hometown.Add(newStuHometown);
                    Console.WriteLine("Please enter new students favorite color");
                    var newStuColor = Console.ReadLine();
                    favColor.Add(newStuColor);
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("Hope you had fun. Goodbye!");
        }
    }
}

