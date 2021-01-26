using System;
using System.Collections.Generic;
using System.Text;

namespace PokerGame
{
    class DrawCards
    {
        //draw cards outline (static methods)
        public static void DrawCardOutline(int xcoor, int ycoor)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int x = xcoor * 12;
            int y = ycoor;

            Console.SetCursorPosition(x, y);
            Console.Write(" __________\n");//top edge of the card

            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(x, y + 1 + i);

                if (i != 9)
                    Console.WriteLine("|          |");//left and right edge of the card
                else
                    Console.WriteLine("|__________|");//bottom edge of the card
            }
        }

        internal void Deal()
        {
            throw new NotImplementedException();
        }

        public static void DrawCardSuitValue(Card card, int xcoor, int ycoor)
        {
            string cardSuit = " ";
            int x = xcoor * 12;
            int y = ycoor;

            // Encode each byte array from the CodePage437 into a character
            //hearts  diamonds are red, clubs and spades are black 

            switch(card.MySuit)
            {
                case Card.SUIT.HEARTS:
                    cardSuit = "\u2665";  // HEARTS
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Card.SUIT.DIAMONDS:
                    cardSuit = "\u2666";  //DIAMONDS
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Card.SUIT.CLUBS:
                    cardSuit = "\u2663";  //SPADES
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case Card.SUIT.SPADES:
                    cardSuit = "\u2660";  //C
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }

            //Dispaly the encorded character and value of the card
            Console.SetCursorPosition(x + 5, y + 5);
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write(cardSuit);
            Console.SetCursorPosition(x + 4, y + 7);
            Console.Write(card.MyValue);
        }

        public static implicit operator DrawCards(DealCards v)
        {
            throw new NotImplementedException();
        }
    }
}
