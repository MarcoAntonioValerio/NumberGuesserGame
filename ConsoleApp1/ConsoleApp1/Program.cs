using System;


namespace ConsoleApp1
{
    //Small little game to try the .net framework
    class Program
    {
        static void Main(string[] args)
        {
            //Refactored method to output the  app infos
            GetAppInfos();

            //Asks for user nam and then greets them to the game
            GreetUser();

            while (true)
            {

                //Using the type random to create randomness
                Random randomValue = new Random();
                //Sets correct number
                int correctNumber = randomValue.Next(1, 10);

                //Init Guess var
                int guess = 0;

                //Games start
                ColoursMethod(ConsoleColor.Blue, "Try to gess a number between 1 and 10!");



                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    //Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        ColoursMethod(ConsoleColor.Red, "Not a Number!");

                        //Continue will not stop the application in case of an error.
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Print error  message
                    if (guess != correctNumber)
                    {
                        ColoursMethod(ConsoleColor.Red, "Wrong Number, please try again!");
                    }
                }

                ColoursMethod(ConsoleColor.Yellow, "You are correct, good job!");

                Console.WriteLine("Play again? [Y or N]");

                //Converts lower case to upper case
                string answer = Console.ReadLine().ToUpper();

                //To check if the player wants to continue
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
           
            }


        }

        //Get and display app infos
        static void GetAppInfos()
        {
            //Set app vars
            string appName = "NumberGuesser";
            string appVersion = "1.0.0";
            string authorName = "Marco A. Valerio";

            //Changes the console colour to Green
            Console.ForegroundColor = ConsoleColor.Green;

            //Writes a line in the console
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, authorName);

            //Resets the console text colour so only the first line is green
            Console.ResetColor();
        }

        //Get player name and greets them
        static void GreetUser()
        {
            //Asks user's name
            Console.WriteLine("What is your name?");

            //stores whatever the players writes in this variable, and then prints it to the console
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}. Have fun!", inputName);
        }

        static void ColoursMethod(ConsoleColor color, string message)
        {
            //Changes the console colour to blue
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            //Resets the console text colour so only the first line is green
            Console.ResetColor();
        }

    }
}
