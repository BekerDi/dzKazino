using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]

    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Deposit {  get; set; }
        public void SpinDrum()
        {
            Random random= new Random();
            int result = random.Next(2);
            if (result == 0) 
            {
                Shout.FailShout();

            }
            else
            {
                Shout.SuccessShout();
            }
        }
        public ShoutProperty Shout { get; } = new ShoutProperty();
        public class ShoutProperty
        {
            public void SuccessShout()
            {
                Console.WriteLine("Урааа!");
            }
            public void FailShout()
            {
                Console.WriteLine("О нееет!");
            }
        }
    }
}
