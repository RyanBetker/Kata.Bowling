using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Bowling
{
    /* By Ryan Betker
     * 8/7/15
     */
 
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();

            var random = new Random();

            for (int i = 0; i < 21; i++)
            {
                var pinsHit = random.Next(0, 10);
                game.Roll(pinsHit);

                Console.WriteLine("You knocked {0} pins down and the score is {1}", pinsHit, game.Score());
            }

        }
    }
}
