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
  /// Själva spelets funktioner
  /// </summary>
  public class GuessNumber
  {
    public GuessNumber() { }
    private List<Score> gameScore = new List<Score>();
    private HighScore scoreList = new HighScore();
    List<int> gissningar = new List<int>();

   //Spelets variabler//
    private bool runGame;
    private int numberOfTries = 0;
    private int numberOfTries2 = 0;
    private bool rätt = false;
    private bool rätt2 = false;
    //Kontrollera vad parametern innehåller
    //genom att anropa WillPlay och få tillbaka
    //en boolean som läggs in i runGame-fältet.

    public void PlayGame(string answearPlay)
    {
      runGame = WillPlay(answearPlay);

      while (runGame == true)
      {
        Score player1 = new Score();
        Score player2 = new Score();
        int numberOfTries = 0;
        int numberOfTries2 = 0;

        Console.WriteLine("Vad heter spelare 1?");
        player1.Name = Console.ReadLine();//tar in spelarens namn



        /***********************************************************************/
        //Spelare1 runda
        /***************************************************************************/
        Console.WriteLine("hur många sidor på tärningen vill du ha?");
        string answer = Console.ReadLine();
        int intAnswer = Int32.Parse(answer);//tar in antal sidor på tärningen
        int[] dice = new GuessNumber().SidesDice(intAnswer); //Creates a new dice as a array
        int roll = new GuessNumber().NewNumber(dice.Length);//Roll the dice

        while (!rätt)
        {
          Console.WriteLine("Gissa nummer mellan 0-" + dice.Length);
          answer = Console.ReadLine();
          int svarNumber = Int32.Parse(answer);
          numberOfTries++;

          if (roll < svarNumber)
          {
            Console.WriteLine("Svaret är mindre");

          }
          else if (roll > svarNumber)
          {
            Console.WriteLine("Svaret är större");

          }
          else
          {

            Console.WriteLine("Du fick rätt! Det tog dig " + numberOfTries + " gånger tills du fick rätt.");
            player1.Guess = numberOfTries;
            rätt = true;

          }
        }
        /***********************************************************************/
        //Spelare2 runda
        /****************************************************************************/
        Console.WriteLine("Nu är det spelare två som ska gissa, men...");

        Console.WriteLine("Vad heter spelare 2?");
        player2.Name = Console.ReadLine();
        int roll2 = new GuessNumber().NewNumber(dice.Length);//Kastar tärningen då vi redan har skapat
                                                             //tärning som spelarna ska gissa sig fram på.

        while (!rätt2)
        {
          Console.WriteLine("Gissa nummer mellan 0-" + dice.Length);
          string answer2 = Console.ReadLine();
          int svarNumber2 = Int32.Parse(answer2);
          numberOfTries2++;

          if (roll2 < svarNumber2)
          {
            Console.WriteLine("Svaret är mindre");

          }
          else if (roll2 > svarNumber2)
          {
            Console.WriteLine("Svaret är större");

          }
          else
          {

            Console.WriteLine("Du fick rätt! Det tog dig " + numberOfTries2 + " gånger tills du fick rätt.");
            player2.Guess = numberOfTries2;
            rätt2 = true;

          }
        }

        /******************************************************************************************/
        //Annonserar vem som vann eller om det blev oavgjort och laddar ner matchens information//
        /*******************************************************************************************/

        gameScore.Add(player1);
        gameScore.Add(player2);
        scoreList.SaveScore(gameScore);

        if (numberOfTries < numberOfTries2)
        {
          Console.WriteLine(player1.Name+"Vann");
        }
        else if (numberOfTries > numberOfTries2)
        {
          Console.WriteLine(player2.Name + "Vann");

        }
        else
        {
          Console.WriteLine("Det blev lika");
        }
        Console.WriteLine("Så här ser ställningen ut!");

        Console.WriteLine("Vill ni spela igen? JA/NEJ");

        string kanske = Console.ReadLine();
        string upperCaseKanske = kanske.ToUpper();

        if (upperCaseKanske == "JA")
        {
          runGame = true;
          continue;
        }
        else
        {
          
          Console.WriteLine("Klicka enter för att avsluta programmet");
          if (Console.ReadKey().Key == ConsoleKey.Enter)
          {
            Environment.Exit(0);
          }

        }
        //Lagra spelaren1 information

      }




    }

    private bool WillPlay(string input1)
    {
      if (input1.ToUpper() == "JA")
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
      int number = random.Next(1, dice + 1);
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


