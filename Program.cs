using System;

namespace ChristmasAsciiArt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            new ChristmasTree().Decorate(35);

            // Allow the console to pause for screenshots.
            Console.ReadKey();
        }
    }
}
