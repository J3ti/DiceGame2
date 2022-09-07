using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class HighScore
    {
        new private FileStream fStream;
        new private StreamWriter sStream;
        new private StreamReader sReader;



        public HighScore() { }
        public  bool SaveScore(List<Score> yeet)
        {
            return true;
        }

    }

    
}
