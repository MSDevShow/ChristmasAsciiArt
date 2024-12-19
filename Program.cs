using System;

namespace ChristmasAsciiArt
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateMenu();
        }

        static void GenerateMenu()
        {
            Console.WriteLine("Select which kind of Christmas tree you desire to constuct:");
            Console.WriteLine("1. ASCII-Tree");
            Console.WriteLine("2. Emoji-Tree");
            Console.WriteLine();
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    new ChristmasTree().Decorate(35);
                    break;
                case "2":
                    new EmojiTree().Decorate(35);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    GenerateMenu();
                    break;
            }


            // Allow the console to pause for screenshots.
            Console.Read();
        }
    }
}
