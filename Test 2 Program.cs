using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            List<string> games = new List<string>();
            List<string> rank = new List<string>();
            games.Add("Kingdom Hearts 1");
            rank.Add("1");

            string stopWord = "stop";
            string userEnteredGame = "";
            string userEnteredRank = "";

            while (userEnteredGame != stopWord)
            {
                Console.WriteLine("Please enter a game name");
                userEnteredGame = Console.ReadLine();

                Console.WriteLine("Please enter a rank");
                userEnteredRank = Console.ReadLine();

                if (userEnteredGame == "Final Fantasy 7" || userEnteredRank == "1")
                {
                    Console.WriteLine("Please enter another game name or rank - that is already in use.");
                    userEnteredRank = "";
                    userEnteredGame = "";
                }
                else
                {
                    games.Add(userEnteredGame);
                    rank.Add(userEnteredRank);
                }
            }

            Console.WriteLine("What game do you want to see?");
            string gameToSee = "";

            gameToSee = Console.ReadLine();

            Console.WriteLine("Game you wanted to see: ");
            Console.WriteLine("Game: " + games.Contains(gameToSee));
            int indexOfRankofGame = games.IndexOf(gameToSee);
            if (indexOfRankofGame == -1)
            {
                Console.WriteLine("You did not find a game with the name " + gameToSee);
            }
            Console.WriteLine("The rank of the game " + gameToSee + " is " + rank[indexOfRankofGame]);
            Console.ReadLine();
        }
    }
}

