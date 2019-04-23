using System;
using System.Collections.Generic;

namespace PingPong
{
  public class Game
  {
    public List<int> numList = new List<int> {};
    // public List<int> NumList = numList;

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

    public List<int> MakeList(int intUserInput)
    {
      for(int i = intUserInput; i > 0; i --)
      {
        numList.Add(intUserInput);
      }
      return numList;
    }
  }
}
