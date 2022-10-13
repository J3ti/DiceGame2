using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
namespace DiceGame
{

  //Skriver in till en fil som heter "HighScore.txt" och behåller
  //information från de tidigare spelen
  class HighScore
  {
    private FileStream fs;
    private StreamWriter sw;
    private StreamReader sr;

    public bool SaveScore(List<Score> game)
    {
      try
      {//Filestream tar fram vart vi ska skriva in filen
        FileStream fs = new FileStream("HighScore.txt", FileMode.Append);
        sw = new StreamWriter(fs);

        foreach (var player in game)
        {
          sw.WriteLine(player.Name + " || " + player.Guess);
        }

        return true;
      }
      catch (Exception e)
      {
        string fel = "Något Gick fel";
        return false;
      }
      finally
      {

        sw.Close();
      }



    }

    public void PrintScore()
    {
      List<Score> game = new List<Score>();
      fs = new FileStream("HighScore.txt", FileMode.Open);
      sr = new StreamReader(fs);
      string line = sr.ReadLine();

      if (line == null)
      {
        Console.WriteLine("Bli den första som spelar");
      }

      while (line != null)
      {
        string phrase = line;
        string[] temp = phrase.Split("||");
        Score score = new Score();
        score.Name = temp[0];
        score.Guess = Convert.ToInt32(temp[1]);
        game.Add(score);

        line = sr.ReadLine();
      }


      fs.Close();
      sr.Close();

      game.Sort();
      Console.WriteLine("High Score!");
      foreach(Score score in game)
      {
        Console.WriteLine($"{score.Guess} av spelaren {score.Name}");

      }
    }

  }


}


//  string path = "C:\\Users\\Jespe\\Source\\Repos\\DiceGame2\\DiceGame\\HighScore.txt";