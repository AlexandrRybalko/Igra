using System;

namespace Homework6ClassLibrary
{
    public class OrdinaryPlayer : BasePlayer
    {
        public override int GuessTheWeight()
        {
            Random random = new Random();
            return random.Next(40, 141);
        }
        public OrdinaryPlayer(string name)
        {
            Name = name;
        }
    }
}
