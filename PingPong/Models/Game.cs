using System;
// using System.Collections.Generic;

namespace PingPong
{
  public class Game
  {

    public int ConvertStringToNum(string stringUserInput)
    {
      int intUserInput = int.Parse(stringUserInput);
      return intUserInput;
    }

    public bool IsNumberAbove0(int intUserInput)
    {
      if (intUserInput >= 1)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public string IsPingPong(int intUserInput)
    {
      string output;

      if (intUserInput % 7 == 0)
      {
        output = "AYYYYYYY divisible of 7!";
        return output;
      }

      else if (intUserInput % 5 == 0 && intUserInput % 3 == 0)
      {
        output = "Ping-Pong";
        return output;
      }
      else if (intUserInput % 5 == 0)
      {
        output = "Pong";
        return output;
      }
      else if (intUserInput % 3 == 0)
      {
        output = "Ping";
        return output;
      }
      else
      {
        output = intUserInput.ToString();
        return output;
      }
    }
  }
}
