using System;
using System.Collections.Generic;

namespace ChristmasAsciiArt
{
    public class EmojiTree
    {
        private readonly ConsoleColor ChristmasTreeColor = ConsoleColor.DarkGreen;
        private Random r;
        private EmojiOrnamentFactory ornamentFactory;

        /// <summary>
        /// Generates and decorates a tree with the specified width in ASCII characters. Height is calculated on width.
        /// </summary>
        /// <param name="treeWidth">Number of ASCII characters wide</param>
        public void Decorate(int treeWidth)
        {
            r = new Random(DateTime.Now.Millisecond);
            ornamentFactory = new EmojiOrnamentFactory();
            GenerateTree(treeWidth);
        }

        private void GenerateTree(int treeWidth)
        {
            // Calculate height
            var height = (treeWidth + 1) / 2;

            // Add the star
            AddStar(treeWidth);

            // Add all of the tree layers
            for (int h = 1; h < height; h++)
            {
                var padding = new string(' ', treeWidth + 2 - h + 1);
                Console.Write(padding);
                GenerateTreeLayer((h * 2) + 1);
            }

            // Add the base
            AddBase(treeWidth);
        }

        private void GenerateTreeLayer(int layerWidth)
        {
            Console.ForegroundColor = ChristmasTreeColor;
            // Always begin with this bracket
            Console.Write(">");

            for (int i = 0; i < layerWidth - 2; i++)
            {
                // Roughly add ornaments every 4th character.
                if (r.Next(4) == 0)
                {
                    
                    Console.Write(ornamentFactory.GenerateEmoji());
                    i++; // Most of the included emoji take up two spots, adjusting for the extra width
                    
                    // The following loop is to ensure that ornaments aren't too close together, and also don't overflow 
                    // the boundaries of the tree
                    for (int j = 0; j < 2; j++)
                    {
                        if (layerWidth - 2 - i > 2)
                        {
                            AddNeedle();
                            i++;
                        }
                    }
                }
                else
                {
                    AddNeedle();
                }
            }
            Console.ForegroundColor = ChristmasTreeColor;
            // Always end with this bracket
            Console.WriteLine("<");
        }

        private void AddNeedle()
        {
            Console.ForegroundColor = ChristmasTreeColor;
            // Alternate needle direction randomly
            Console.Write(r.Next(2) == 0 ? "<" : ">");
        }

        private void AddBase(int treeWidth)
        {
            // I really wish I could specify brown. 
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(new string(' ', treeWidth - 2));
            Console.WriteLine("_ __| |__ _ 🎁📦");
        }

        private void AddStar(int treeWidth)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(new string(' ', treeWidth + 3));
            Console.WriteLine("|");
            Console.Write(new string(' ', treeWidth + 2));
            Console.WriteLine(@"\|/");
            Console.Write(new string(' ', treeWidth + 0));
            Console.WriteLine("--✨--");
        }
    }
}
