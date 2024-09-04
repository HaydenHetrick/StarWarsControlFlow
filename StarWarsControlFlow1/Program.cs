using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsControlFlow1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of a Star Wars character:");
            string character = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(character))
            {
                Console.WriteLine("Character name cannot be empty.");
            }

            if (character == "Luke Skywalker" || character == "Yoda")
            {
                Console.WriteLine($"{character} is a Jedi.");
            }
            else if (character == "Darth Vader" || character == "Emperor Palpatine")
            {
                Console.WriteLine($"{character} is a Sith.");
            }
            else
            {
                Console.WriteLine($"{character} is neither Jedi nor Sith.");
            }
            Console.WriteLine("\nEnter the name of a Star Wars ship:");
            string ship = Console.ReadLine();

            switch (ship)
            {
                case "Millennium Falcon":
                    Console.WriteLine("This is Han Solo's ship.");
                    break;
                case "X-Wing":
                    Console.WriteLine("This is a Rebel starfighter.");
                    break;
                case "TIE Fighter":
                    Console.WriteLine("This is an Imperial starfighter.");
                    break;
                default:
                    Console.WriteLine("Unknown ship.");
                    break;
            }
        }
    }
}
