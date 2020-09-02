using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6ClassLibrary
{
    public class UberCheaterPlayer : IPlayer
    {
        private int[] NotUsedNumbers;
        private int index;
        public override int GuessTheWeight()
        {
            while(NotUsedNumbers[index] == 0)
            {
                index += 1;
            }
            return NotUsedNumbers[index++];
        }
        public UberCheaterPlayer()
        {
            NotUsedNumbers = new int[101];
            index = 0;
            for(int i = 0; i < NotUsedNumbers.Length; i++)
            {
                NotUsedNumbers[i] = i + 40;
            }
        }
    }
}
