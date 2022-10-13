using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
  public class Score : IComparable<Score>
  {
    private string name;
    private int guess;

    public String Name
    {
      set { name = value; }
      get { return name; }
    }

    public int Guess
    {
      get; set;
    }

    public Score() { }

    public int CompareTo(Score other)
    {
      return other.Guess.CompareTo(this.Guess);

    }
  }
}


