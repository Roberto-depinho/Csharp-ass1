using System;


namespace Assignment1
{
    public class MultiplierTable

    {
        public void Multiplier()
        {
            Console.WriteLine("Welcome to Problem Statement 2");

            int number, multiplier;

            Console.WriteLine("Please enter a number");

            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplication of {0} to 4", number);

            for (multiplier = 1; multiplier <= 4; multiplier++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, multiplier, (number * multiplier));
            }
        }


    }
}
