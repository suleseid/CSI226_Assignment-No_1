using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI226_Assignment_No_1
{
    class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }
    class Program
    {
       static List<Player> Players = new List<Player>();
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("1. Display all players");
                Console.WriteLine("2. Display players with odd numbers");
                Console.WriteLine("3. Display players with names that start with a letter");
                Console.WriteLine("4. Add Player");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        DisplayAllPlayers();
                        break;
                    case 2:
                        DisplayPlayersWithOddNumbers();
                        break;
                    case 3:
                        DisplayPlayersWithLetter();
                        break;
                    case 4:
                        AddPlayer();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
        static void DisplayAllPlayers()
        {
            Console.WriteLine("All Players: { Wilson, Messi, Ronaldo, Mahomes, Jems, David, Rodgers, Tom Brady, Lamar Jacksen, Zack }");
            foreach (var player in Players)
            {
                Console.WriteLine($"Name: {player.Name}, Number: {player.Number}");
            }
        }
        static void DisplayPlayersWithOddNumbers()
        {
            Console.WriteLine("Players with Odd Numbers: {(Ronaldo, 7), (Mahomes, 1), (Lamar jacksen, 3) (Zack, 9)}");
            foreach (var player in Players)
            {
                if (player.Number % 2 != 0)
                {
                    Console.WriteLine($"Name: {player.Name}, Number: {player.Number}");
                }
            }
        }
        static void DisplayPlayersWithLetter()
        {
            Console.Write("Enter a letter to filter by: ");
            char letter = Console.ReadLine().ToLower()[0];

            Console.WriteLine("Players with names starting with 'r':{Ronaldo, Rodger} ");
            foreach (var player in Players)
            {
                if (player.Name.ToLower()[0] == letter)
                {
                    Console.WriteLine($"Name: {player.Name}, Number: {player.Number}");
                }
            }
        }
        static void AddPlayer()
        {
            Console.Write("Enter player's name: name {Suleman, John, Will, Emry} ");
            string name = Console.ReadLine();

            Console.Write("Enter player's number: Number { 12, 6, 49, 10 } ");
            int number;
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid number. Player not added. {5} ");
                return;
            }

            Players.Add(new Player { Name = name, Number = number });
            Console.WriteLine($"Player {name} with number {number} added.");
        }
    }
}

