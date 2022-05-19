using System;
using Assignment1;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Please select from the below options to which Problem Statement you would like to be prompted to: \n 1. Sum of 2 numbers \n 2. Multiplication Table \n 3. Star Pattern \n ");
        string userInput = string.Empty;
        do
        {
            Console.Write("Please enter your selection: ");
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    {
                        Calculator C1 = new Calculator();
                        C1.CalculateSumof2();
                        break;
                    }
                case 2:
                    {
                        MultiplierTable MT1 = new MultiplierTable();
                        MT1.Multiplier();
                        break;
                    }
                case 3:
                    {
                        AsteriksTable A1 = new AsteriksTable();
                        A1.makingAsteriks();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid selection, please enter a valid option");
                        break;
                    }
            }
            do
            {

                Console.WriteLine("Do you want to view another Problem Statement? - Yes or No ? ");
                userInput = Console.ReadLine().ToUpper();
                if (userInput != "YES" && userInput != "NO")
                {
                    Console.WriteLine("Invalid input, please enter YES or NO");
                }
            } while (userInput != "YES" && userInput != "NO");
            Console.Clear();
        } while (userInput == "YES");
    }
}






//using System;
//using Assignment1;


//class Program
//{
//    static void Main()



//    {   


//        Calculator C = new Calculator();
//        //string UserChoice = "";

//        Console.WriteLine("Please select which problem statement you would like to view");
//        Console.WriteLine("1. Problem Statement 1 - Addition of two numbers");
//        Console.WriteLine("2. Problem Statement 2 - Multiplication Table");
//        Console.WriteLine("3. Problem Statement 3 - Star Pyramid");

//        int decision = int.Parse(Console.ReadLine());
//        switch (decision)
//        {
//            case 1:
//                Console.WriteLine("You are now being prompted to Problem Statement 1");
//                break;
//            case 2:
//                Console.WriteLine("You are now being prompted to Problem Statement 2");
//                break;
//            case 3:
//                Console.WriteLine("You are now being prompted to Problem Statement 3");
//                break;
//            default:
//                Console.WriteLine("You have made an invalid selection. Please select which Problem Statement you would like to be prompted to.");
//                break;
//        }

//    }
//}






