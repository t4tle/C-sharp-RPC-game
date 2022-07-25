using System;

namespace game
{
    class player 
    {
        public string name;
        public int wins;
        public int rounds;

       // Constructor
        public player(
            string name, 
            int wins,
            int rounds)
        {
            this.name = name;
            this.wins = wins;
            this.rounds = rounds;
        }
        

    }
}