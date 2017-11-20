using System;


namespace NumberGuesser
{   

    //Main Class
    class Program
    {   
        //Entry Point Method
        static void Main(string[] args)
        {
            //Run GetAppInfo function 
            GetAppInfo();

            //Ask for user name and greet
            GreetUser();

            while (true)
            {



                //Init correct number
                //int correctNumber = 7;

                //Create new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);


                //Init guess var

                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    //Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //Keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess with correct number
                    if (guess != correctNumber)
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number! Try again!");
                    }


                }

                //Output success message

                PrintColorMessage(ConsoleColor.Yellow, "Correct! You guessed it!");

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }

                else if( answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }    

        }
       
        //Get and display app info
        static void GetAppInfo()
        {
            //Set App vars

            string appName = "Name Guesser";
            string appVersion = "1.0.";
            string appAuthor = "Ciprian";

            // Change text colors
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out console info
            Console.WriteLine("{0}:Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }
        
        //Ask users name and greet
        static void GreetUser()
        {
            //Ask user' name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text colors
            Console.ForegroundColor = color;

            //Tell user it's the wrong number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
            
    }
}
