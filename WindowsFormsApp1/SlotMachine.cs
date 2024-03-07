using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class SlotMachine
    {
        public string Name { get; set; }
        public double MinCost { get; set; }
        public double WinFrequency { get; set; }

        public SlotMachine(string name, double minCost, double winFrequency)
        {
            Name = name;
            MinCost = minCost;
            WinFrequency = winFrequency;
        }

        public void StartMachine()
        {
            Console.WriteLine($"Слот-машина '{Name}' запускается...");
            Random random = new Random();
            double randomValue = random.NextDouble();
            if (randomValue < WinFrequency)
            {
                Console.WriteLine("Поздравляем! Вы выиграли");
            }
            else
            {
                Console.WriteLine("В следующий раз повезет!");
            }
        }
    }

    
        
    
}
