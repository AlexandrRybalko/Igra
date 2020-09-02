using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6ClassLibrary
{
    public class OrdinaryPlayer : IPlayer
    {
        public new string Name;
        public override int GuessTheWeight()
        {
            Random random = new Random();
            return random.Next(40, 140);
        }
        public OrdinaryPlayer(string name)
        {
            Name = name;
        }
    }
}
