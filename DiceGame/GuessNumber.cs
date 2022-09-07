using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{

    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class GuessNumber
    {
            private bool runGame;
        public GuessNumber()
        {


        }
        //Kontrollera vad parametern innehåller
        //genom att anropa WillPlay och få tillbaka
        //en boolean som läggs in i runGame-fältet.

        void PlayGame(string svar)
        {
             runGame = WillPlay(svar);

            while (runGame = true)
            {

                Console.WriteLine("hur många sidor på tärningen vill du ha?");
                string answer = Console.ReadLine();
                int intAnswer = Int32.Parse(answer);
                //Skicka svaret någonstans

                //fixar tärningen som en array
                int[] dice = new GuessNumber().SidesDice(intAnswer);
                Console.WriteLine("Testar Dice" + dice.Length);

                //Rollar tärning
                int roll = new GuessNumber().NewNumber(dice.Length);
                Console.WriteLine("Testar Roll " + roll);
            }
        }

        private bool WillPlay(string input1)
        {
            if (input1.ToUpper() == "YES")
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public int NewNumber(int dice)
        {
            Random random = new Random();
            int number = random.Next(1, dice);
            return number;
        }

        public int[] SidesDice(int sides)
        {

            int[] newDice = new int[0];
            if (sides == 0)
            {
                return newDice = new int[6];
            }
            newDice = new int[sides];
            return newDice;


        }
    }
}
