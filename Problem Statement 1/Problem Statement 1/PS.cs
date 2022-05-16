//Problem Statement 3

using System;


   class PS
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! I am amazing");
            int n, x, y, z;  //Here we are declaring 4 variables.

        n = 4; //number of rows (you can put as much as you like)


        //main outter loop to print as many rows as you'd like 
        for (x = 1; x <= n; x++)
        {
            //print the empty spaces
            for (y = 1; y <= n - x; y++) //n-x = 4 in this case 
            {
                Console.Write(" ");
            }
            //print the asterix
            for (z = 1; z <= x; z++) //if 3 empty space is printed, 2 stars will be printed (thats the logic)
            {
                Console.Write("* "); //need empty space for perfect pyramid 
            }

            //after stars and space is printed, need to go to new line

            Console.WriteLine();
        }
    }


}


//Problem Statement 1

//using System;

//class Program
//{
// static void Main()
//    {
//        Console.WriteLine("Please enter a number");

//        int number1 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Please enter another number");

//        int number2 = Convert.ToInt32(Console.ReadLine());

//        int answer = number1 + number2;

//        Console.WriteLine("The sum of your two numbers = {0} ", answer);


//    }
//}

//Problem Statement 2 

//using System;
//    class Program
//    {
//        static void Main(string[] args)
//        {
//        Console.WriteLine("Multiplication table of 2 to 4");

//        int number = 2, multiplier;  //Here we are declaring 4 variables.

//            for (multiplier = 1; multiplier <= 4; multiplier = multiplier + 1)
//            {
//                Console.WriteLine("{0} * {1} = {2}", number, multiplier, (number * multiplier));
//            }


//        }

//    }

