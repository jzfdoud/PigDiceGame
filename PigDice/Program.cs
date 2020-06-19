using System;

namespace PigDice
{
    class Program
    {
        static void Main(string[] args)
        {
            var pigdice = new PigDice();
            var highscore = 0;
            while (highscore < 713)
            //for (var count = 1; count <= 1000000000; count++)
            {
                var score = pigdice.Play();
                if (score > highscore)
                {
                    highscore = score;
                }
            }
            Console.WriteLine($"High Score is {highscore}.");
        }
    }
}
