using System;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn == true)
            {
                MovieDatabase MovieDb = new MovieDatabase();
                Console.WriteLine("Welcome to the Movie List!");
                string userInput = GetUserInput("Please choose from this list of genres: SciFi, Action, Noir, and Horror!");

                MovieDb.PrintMoviesByGenre(userInput);

                //MovieDb.PrintMovieNames();

                //MovieDb.PrintGenre();
                goOn = Continue();
            }
            
        }

        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string userinput = Console.ReadLine();
            return userinput;
        }
        public static bool Continue()
        {
            {
                string response = GetUserInput("Would you like to know more about another genre? y/n");

                if (response == "y")
                {
                    return true;
                }
                else if (response == "n")
                {
                    Console.WriteLine("Good bye!");
                    return false;

                }
                else
                {
                    Console.WriteLine("That was not a valid response, please try again!");
                    return Continue();
                }
            }
        }
    }
}
