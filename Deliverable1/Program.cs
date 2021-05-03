using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("Lets Get to Converting!");


            Console.WriteLine("Please enter your measurement type?");
            string userType = Console.ReadLine();
            Console.WriteLine("Now enter an amount.");
            double userAmount = double.Parse(Console.ReadLine());


            double trueAmount = userAmount *= 3.5;
            double trueAmount2 = userAmount /= 1;
            double trueAmount3 = userAmount *= 5; 

            if (userType == "inch")
            {
                Console.WriteLine("Equals");
                Console.WriteLine(trueAmount + " fidget spinners");
            }
            else if (userType == "fidget spinners")
            {
                Console.WriteLine("Equals");
                Console.WriteLine(trueAmount2 + " inch");
            }
            else if (userType == "foot")
            {
                Console.WriteLine("Equals");
                Console.WriteLine(trueAmount3 + " memes ");
            }
            else if (userType == "memes")
            {
                Console.WriteLine("Equals");
                Console.WriteLine(trueAmount2 + " foot");
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


