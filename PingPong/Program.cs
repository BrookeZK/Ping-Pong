using System;
using System.Collections.Generic;

namespace PingPong {

  public class Program
  {
    public static void Main()
    {
      Game newGame = new Game();
      Console.WriteLine("Enter a positive integer: ");
      string input = Console.ReadLine();
      int userInput = newGame.ConvertStringToNum(input);
      newGame.IsNumberAbove0(userInput);
      if (newGame.IsNumberAbove0(userInput) == false)
      {
        Console.WriteLine("Enter a number greater than 0");
        Main();
      }
      else
      {
        Console.WriteLine("-------------");
        for (int i = 1; i <= userInput; i++)
        {
          Console.WriteLine(newGame.IsPingPong(i));
        }
      }
    }
  }
}
