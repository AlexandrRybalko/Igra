﻿namespace Homework6ClassLibrary
{
    public class UberPlayer : BasePlayer
    {
        private int currentNumber = 40;
        public override int GuessTheWeight()
        {
            return currentNumber++;
        }
        public UberPlayer(string name)
        {
            Name = name;
        }
    }
}
