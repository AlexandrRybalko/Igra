using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6ClassLibrary
{
    public class PlayerNotepad : IPlayer
    {
        public new string Name;
        private List<int> UsedNumbers;
        public override int GuessTheWeight()
        {
            Random random = new Random();
            int result = random.Next(40, 140);
            while (UsedNumbers.Contains(result))
            {
                result = random.Next(40, 140);
            }
            return result;
        }
        public PlayerNotepad(string name)
        {
            UsedNumbers = new List<int>();
            Name = name;
        }
    }
}
