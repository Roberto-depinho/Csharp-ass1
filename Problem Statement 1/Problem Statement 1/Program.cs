using System;

class Program
{
    static void Main()



    {   
        string UserChoice = string.Empty;
              
        Console.WriteLine("Welcome to Problem Statement 1");

        Console.WriteLine("Please enter a number");

        int number1 = Convert.ToInt32(Console.ReadLine());

       

        Console.WriteLine("Please enter another number");

        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The sum of your two numbers = {0} ", (number1 + number2));

        do
        {

            Console.WriteLine("We have reached the end of problem statement 1. Do you wish to continue to problem statement 2 - Yes or No?");

            UserChoice = Console.ReadLine().ToUpper();

            if (UserChoice != "YES" && UserChoice != "NO")
            {
                Console.WriteLine("Invalid choice, please say Yes or No");
            }
        } while (UserChoice != "YES" && UserChoice != "NO");


        Console.WriteLine("Welcome to Problem Statement 2");

        int number, multiplier;

        Console.WriteLine("Please enter a number");

        number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Multiplication of {0} to 4", number);

        for (multiplier = 1; multiplier <= 4; multiplier++)
        {
            Console.WriteLine("{0} * {1} = {2}", number, multiplier, (number * multiplier));
        }
        do
        {

            Console.WriteLine("We have reached the end of problem statement 3. Do you wish to continue to problem statement 2 - Yes or No?");

            UserChoice = Console.ReadLine().ToUpper();

            if (UserChoice != "YES" && UserChoice != "NO")
            {
                Console.WriteLine("Invalid choice, please say Yes or No");
            }

        } while (UserChoice != "YES" && UserChoice != "NO");


        Console.WriteLine("Welcome to Problem Statement 3");


        int numberofrows, rows, emptyspace, asterix;  //Here we are declaring 4 variables.

        numberofrows = 4; //number of rows (you can put as much as you like)


        //main outter loop to print as many rows as you'd like 

        for (rows = 1; rows <= numberofrows; rows++)
        {
            //print the empty spaces
            for (emptyspace = 1; emptyspace <= numberofrows - rows; emptyspace++) //numberofrows-rows = 4 in this case 
            {
                Console.Write(" "); //We printing an empty space
            }
            //print the asterix
            for (asterix = 1; asterix <= rows; asterix++) //if 3 empty space is printed, 2 stars will be printed (thats the logic)
            {
                Console.Write("* "); //need empty space for perfect pyramid 
            }

            //after stars and space is printed, need to go to new line

            Console.WriteLine();


        }
        Console.WriteLine("We have reached the end of problem statement 3");
    }
}






