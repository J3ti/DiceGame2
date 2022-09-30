// See https://aka.ms/new-console-template for more information

using DiceGame;

UI drawMainMenu = new UI();
GuessNumber guess = new GuessNumber();

string yesOrNo = drawMainMenu.DrawUI();

guess.PlayGame(yesOrNo);

