using System;


namespace Assignment1
{
    public class AsteriksTable
    {
        public void makingAsteriks()
        {
            Console.WriteLine("Welcome to Problem Statement 3");


            int numberofrows, rows, emptyspace, asterix;

            numberofrows = 4;

            for (rows = 1; rows <= numberofrows; rows++)
            {

                for (emptyspace = 1; emptyspace <= numberofrows - rows; emptyspace++)
                {
                    Console.Write(" ");
                }

                for (asterix = 1; asterix <= rows; asterix++)
                {
                    Console.Write("* ");
                }


                Console.WriteLine();


            }
        }
    }
}




//            }
//         do
//            {

//                Console.WriteLine("We have reached the end of problem statement 3. Do you wish to continue to problem statement 2 - Yes or No?");

//                UserChoice = Console.ReadLine().ToUpper();

//                if (UserChoice != "YES" && UserChoice != "NO")
//                {
//                    Console.WriteLine("Invalid choice, please say Yes or No");
//                }

//} while (UserChoice != "YES" && UserChoice != "NO") ;
//        } while (decision == 2) ;


//    Console.WriteLine("We have reached the end of problem statement 3");
//}
//    }
//}
