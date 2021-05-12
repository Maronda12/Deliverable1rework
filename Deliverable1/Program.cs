using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            double trueAmount; 
        Start:
            Console.WriteLine("Lets Get to Converting!");


            Console.WriteLine("Please enter your measurement type?");
            string userType = Console.ReadLine();
            Console.WriteLine("Now enter an amount.");
            double userAmount = double.Parse(Console.ReadLine());


           

            if (userType == "inch")
            {
               trueAmount = userAmount *= 3.5;
                if (trueAmount != 1)
                {
                    Console.WriteLine("Equals");
                    Console.WriteLine(trueAmount + " Fidget Spinners");
                }
                else
                { 
                    Console.WriteLine("Equals");
                    Console.WriteLine(trueAmount + " Fidget Spinner");

                }
            }

            else if (userType == "fidget spinners")
            {
                trueAmount = userAmount /= 3.5;
                if (trueAmount != 1)
                {
                    Console.WriteLine("Equals");
                    Console.WriteLine(trueAmount + " Inches");
                }
                else
                {
                    Console.WriteLine("Equals");
                    Console.WriteLine(trueAmount + " Inch");
                }  
            }

            else if (userType == "foot")
            {
                trueAmount = userAmount *= 5;
                if (trueAmount != 1)
                {
                    Console.WriteLine("Equals");
                    Console.WriteLine(trueAmount +  " Memes");
                }
                else
                {
                    Console.WriteLine("Equals");
                    Console.WriteLine(trueAmount + " Meme");
                }
                
            }
            else if (userType == "memes")
            {
                trueAmount = userAmount /= 5; 
                if (trueAmount != 1)
                {
                    Console.WriteLine("Equals");
                    Console.WriteLine(trueAmount + " Feet");
                }
                else
                {
                    Console.WriteLine("Equals");
                    Console.WriteLine(trueAmount + " Foot");
                }
            }

            Console.WriteLine("Would you like to convert another measurement?");
            string userResponse = Console.ReadLine();
            if (userResponse == "yes")
            {
                Console.WriteLine("Great!");
                goto Start;
            }
            else
            {
                Console.WriteLine("Thank you Goodbye!");
            }










        }
    }
}


