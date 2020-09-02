using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework6ClassLibrary;

namespace Homework6ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfTries = 0;
            bool flag = true;
            List<IPlayer> players = new List<IPlayer>();
            int Weight = 136;
            OrdinaryPlayer op1 = new OrdinaryPlayer("op1");
            OrdinaryPlayer op2 = new OrdinaryPlayer("op2");
            PlayerNotepad pn1 = new PlayerNotepad("pn1");
            PlayerNotepad pn2 = new PlayerNotepad("pn2");
            players.Add(op1);
            players.Add(op2);
            players.Add(pn1);
            players.Add(pn2);
            while (flag)
            {
                foreach(var player in players)
                {
                    NumberOfTries += 1;
                    int guessedNumber = player.GuessTheWeight();
                    Console.WriteLine($"{NumberOfTries}. {player.Name}:{guessedNumber}");
                    if(NumberOfTries == 100 || guessedNumber == Weight)
                    {
                        flag = false;
                        break;
                    }
                }
            }
            Console.WriteLine(op1.Name);
            Console.ReadKey();
        }
    }
}
