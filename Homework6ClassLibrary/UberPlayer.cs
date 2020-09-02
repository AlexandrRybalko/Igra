using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6ClassLibrary
{
    public class UberPlayer : IPlayer
    {
        private int CurrentNumber { get; set; }
        public override int GuessTheWeight()
        {
            CurrentNumber += 1;
            return CurrentNumber;
        }
        public UberPlayer()
        {
            CurrentNumber = 40;
        }
    }
}
