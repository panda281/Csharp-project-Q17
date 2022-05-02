using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_project_Q17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("These are all the 52 cards in a standard deck");

            //var spadesSymbol = '\u2660';
            //var heartsSymbol = '\u2665';
            //var diamondsSymbol = '\u2666';
            //var clubsSymbol = '\u2663';
            Console.WriteLine();
            for (int i = 0; i < 13; i++)// "for" loop used to change the card
            {

                for (int j = 0; j < 4; j++) // "for" loop used to change the color of the card
                {
                    string color = "";
                    char[] colorSymbol = new char[4];
                    colorSymbol[0] = '\u2663';
                    colorSymbol[1] = '\u2666';
                    colorSymbol[2] = '\u2665';
                    colorSymbol[3] = '\u2660';
                    switch (j) // switch case used for the color of the card
                    {
                        case 0:
                            color = "Clubs";
                            Console.ResetColor();// reset the console color
                            break;
                        case 1:
                            color = "Diamonds";
                            Console.ForegroundColor = ConsoleColor.Red;// make the console color red

                            break;
                        case 2:
                            color = "Hearts";
                            Console.ForegroundColor = ConsoleColor.Red;// make the console color red

                            break;
                        case 3:
                            color = "Spades";
                            Console.ResetColor();// reset the console color

                            break;
                        default:
                            Console.WriteLine("There is a mistake!");
                            break;
                    }

                    switch (i) // switch case used for the card
                    {
                        case 0:
                            Console.WriteLine("A{0}: Ace of {1}", colorSymbol[j], color);
                            break;
                        case 1:
                            Console.WriteLine("2{0}: Two of {1}", colorSymbol[j], color);
                            break;
                        case 2:
                            Console.WriteLine("3{0}: Three of {1}", colorSymbol[j], color);
                            break;
                        case 3:
                            Console.WriteLine("4{0}: Four of {1}", colorSymbol[j], color);
                            break;
                        case 4:
                            Console.WriteLine("5{0}: Five of {1}", colorSymbol[j], color);
                            break;
                        case 5:
                            Console.WriteLine("6{0}: Six of {1}", colorSymbol[j], color);
                            break;
                        case 6:
                            Console.WriteLine("7{0}: Seven of {1}", colorSymbol[j], color);
                            break;
                        case 7:
                            Console.WriteLine("8{0}: Eight of {1}", colorSymbol[j], color);
                            break;
                        case 8:
                            Console.WriteLine("9{0}: Nine of {1}", colorSymbol[j], color);
                            break;
                        case 9:
                            Console.WriteLine("10{0}: Ten of {1}", colorSymbol[j], color);
                            break;
                        case 10:
                            Console.WriteLine("J{0}: Jack of {1}", colorSymbol[j], color);
                            break;
                        case 11:
                            Console.WriteLine("Q{0}: Queen of {1}", colorSymbol[j], color);
                            break;
                        case 12:
                            Console.WriteLine("K{0}: King of {1}", colorSymbol[j], color);
                            break;
                        default:
                            Console.WriteLine("error!");
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
