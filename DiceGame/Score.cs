using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Score
    {
        private string name;
        private int guess;

        public Score() 
        { 
        }

        public String Name
        {
            set { name = value; }
            get { return name; }
        }

        public int Guess
        {
            set { guess = value; }
            get { return guess; }
        }


    }
}


