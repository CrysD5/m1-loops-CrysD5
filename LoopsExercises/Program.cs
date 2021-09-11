using System;

namespace LoopsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("LOOPING EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Print Numbers in Reverse Order");
                Console.WriteLine("2. Reverse Counting");
                Console.WriteLine("3. Print the Square of Even Numbers");
                Console.WriteLine("4. Guess the Magic Number");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        NumbersInReverse();
                        break;
                    case "2":
                        ReverseCounting();
                        break;
                    case "3":
                        SquareOfEvenNumbers();
                        break;
                    case "4":
                        GuessMagicNumber();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void NumbersInReverse()
        {
            // Print out numbers from 5 to 1.

            Console.Clear();
            Console.WriteLine("PRINT NUMBERS IN REVERSE ORDER\n");

            // Enter your solution here
           

            for(int i = 5; i >= 1; i--)
            {
                Console.WriteLine(i);
                
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }


        static void ReverseCounting()
        {
            // Ask the user for a number between 1-20. Starting at the number given,
            // count backwards to 1 and print the numbers to the console.

            Console.Clear();
            Console.WriteLine("REVERSE COUNTING\n");

            // Enter your solution here

            Console.WriteLine("Enter a number between 1-20");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("I will count down to 1 from the number you entered: {0} \n", a);

            while (a > 0)

            {
                
                Console.WriteLine(a);

                a--;

            }



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void SquareOfEvenNumbers()
        {
            // Print the squares (the number multiplied by itself) for even numbers between 1-9. For the odd numbers, just print them.

            Console.Clear();
            Console.WriteLine("PRINT THE SQUARE OF EVEN NUMBERS\n");

            // Enter your solution here
            for (int n = 1; n < (9 + 1); n++)
            {
                if(n % 2 == 0)
                {
                    Console.WriteLine(n * n);
                }
                else
                {
                    Console.WriteLine(n);
                }
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void GuessMagicNumber()
        {
            // Write a console application that asks the user for an integer.
            // If that integer is evenly divisible by 3, then print “You Won!”.
            // If it isn’t, ask the user to “Try again.”
            // Keep asking them for a number (looping) until they win.

            Console.Clear();
           // Console.WriteLine("GUESS THE MAGIC NUMBER\n");

            //int userInput = Convert.ToInt32(Console.ReadLine()); // This reads the user's input and converts it to an integer. We'll assume that users can only input integers.
            // Enter your solution here

          
            bool hasWon = false;

            while(hasWon == false)
            {
                //get user guess
                Console.WriteLine("Please enter a number: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if((guess%3) == 0)
                {
                    //meet winning condition
                    hasWon = true;
                    Console.WriteLine("You Won!");
                }
                else
                {
                    hasWon = false;
                    Console.WriteLine("Try again.");
                }

            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

    }
}
