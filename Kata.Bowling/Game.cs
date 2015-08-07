using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata.Bowling
{
    class Game
    {
        int[] _rolls = new int[21];//won't be filled all the way if strikes happen. Using the next slot to make scoring logic much simpler
        int _rollIndex = 0;

        internal void Roll(int pins)
        {
            _rolls[_rollIndex++] = pins;            
            return;
        }

        //ended up being unused
        //public List<Frame> Frames { get; set; }

        internal int Score()
        {
            int score = 0;

            for (int i = 0; i < 20; i += 2)
            {
                if (IsStrike(i))
                {
                    score += 10 + StrikeBonus(i);
                    i--;//make sure to take one roll backwards because frames with strikes don't use up 2 indexes
                }                
                else if (IsSpare(i))
                {
                    score += 10 + _rolls[i + 2];
                }                
                else
                {
                    score += _rolls[i] + _rolls[i + 1];
                }
            }

            return score;
        }

        private int StrikeBonus(int i)
        {
            return _rolls[i + 1] + _rolls[i + 2];
        }

        private bool IsStrike(int i)
        {
            return _rolls[i] == 10;
        }

        private bool IsSpare(int i)
        {
            return _rolls[i] + _rolls[i + 1] == 10;
        }
    }
}
