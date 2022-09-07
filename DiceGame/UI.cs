using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceGame;
namespace DiceGame
{
    public class UI
    {
        // new private List<int> scoreList = new HighScore();
        public String DrawUI()
        {
            string UI = "*****************************" +
                        "\n" +
                        "Välkommen till gissa Nummer!" +
                        "\n" +
                        "*****************************" +
                        "\n" +
                        "Här ser du tidigare gissningar!:  " +
                        "\n" +
                        // scoreList+

                        "//Kod för att ta fram antal gissningar om det är noll antal spelare så det skrivas ut så som instruktionerna." +
                        "\n" +
                        "Vill du spela? (Ja/nej)"
                        + ("\n");

            string svar = Console.ReadLine();

            return UI;

        }
    }

}
