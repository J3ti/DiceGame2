using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DiceGame;
namespace DiceGame
{
  public class UI
  {

    HighScore showList = new HighScore();
    // new private List<int> scoreList = new HighScore();
    public String DrawUI()
    {
      string draw = "*****************************" +
                  "\n" +
                  "Välkommen till gissa Nummer!" +
                  "\n" +
                  "*****************************" +
                  "\n" +
                  "Här ser du tidigare gissningar!:  " +
                  "\n";
      string draw2 = //Kod för att ta fram antal gissningar om det är noll antal spelare så det skrivas ut så som instruktionerna. +
                  "\n" +
                  "Vill du spela? (Ja/nej)"
                  + ("\n");

      Console.WriteLine(draw);
      showList.PrintScore();//Skriver ut listan
      Console.WriteLine(draw2);

      string svar = Console.ReadLine();
      return svar;
    }
  }
}
