using System;

namespace Assignment1
{
    public class Calculator
    {

        public void CalculateSumof2()
        {
            string UserChoice = string.Empty;

            Console.WriteLine("Welcome to Problem Statement 1");

            Console.WriteLine("Please enter a number");

            int number1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please enter another number");

            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of your two numbers = {0}", (number1 + number2));
        }
    }
}


        

//        do
//        {

//            Console.WriteLine("We have reached the end of problem statement 1. Do you wish to continue to problem statement 2 - Yes or No?");

//            UserChoice = Console.ReadLine().ToUpper();

//            if (UserChoice != "YES" && UserChoice != "NO")
//            {
//                Console.WriteLine("Invalid choice, please say Yes or No");
//            }
//} while (UserChoice != "YES" && UserChoice != "NO");
//    }
//}
