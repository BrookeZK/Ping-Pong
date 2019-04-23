using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class GameTest
  {
    [TestMethod]
    public void
    ConvertStringToNum_CovertUserInputIntoAnInt_Int()
    {
      Game testGame = new Game();
      Assert.AreEqual(3, testGame.ConvertStringToNum("3"));
    }

    [TestMethod]
    public void IsNumberAbove0_IsUserInputANumberAbove0_True()
    {
      Game testGame = new Game();
      Assert.AreEqual(true, testGame.IsNumberAbove0(1));
    }

    [TestMethod]
    public void IsNumberAbove0_IsUserInputANumberAbove0_False()
    {
      Game testGame = new Game();
      Assert.AreEqual(false, testGame.IsNumberAbove0(0));
    }

    [TestMethod]
    public void
    MakeList_CreateAListOfNum0ToUserInput_List()
    {
      Game testGame = new Game();
      Assert.AreEqual({2,1}, testGame.MakeList(2));
    }
  }
}
