using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Deck52Cards
    {
        static void Main()
        {

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        char[] colors = {'\u2660', '\u2663', '\u2666', '\u2665'};

        string[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "K", "J", "Q"};

        foreach (var card in cards)
        {
            foreach (var color in colors)
            {
                Console.Write(card + color);
            }

            Console.WriteLine();
        }

        }
    }

