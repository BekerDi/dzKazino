using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class CardGame
    {
        private string gameName;
        private int numberOfCards;
        private int numberOfPlayers;

        public CardGame(string name, int cards, int players)
        {
            gameName = name;
            numberOfCards = cards;
            numberOfPlayers = players;
        }

        public void Deal()
        {
            Console.WriteLine($"Раздача {numberOfCards} карт {numberOfPlayers} игрокам в игре {gameName}.");
        }

        public void DrawCard()
        {
            Console.WriteLine($"Игрок бере ткарту в игре {gameName}.");
        }
    }
}
