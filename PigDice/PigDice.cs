using System;
using System.Collections.Generic;
using System.Text;

namespace PigDice
{
    class PigDice
    {
        Random rnd = new Random();
        //public void Play()   for one game
        public int Play()
        {
            var total = 0;
            var die = Roll();
            while(die !=1)
            {
                total += die;
                die = Roll();
            }
            return total;
            //Console.WriteLine($"Score is {total}.");
        }
        int Roll()
        {
            return rnd.Next(1, 7);
        }

    }
}
