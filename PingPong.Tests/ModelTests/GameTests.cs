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
    public void IsPingPong_ReplaceDivisibleOf3WithPing_Ping()
    {
      Game testGame = new Game();
      Assert.AreEqual("Ping", testGame.IsPingPong(9));
    }

    [TestMethod]
    public void IsPingPong_ReplaceDivisibleOf5WithPong_Pong()
    {
      Game testGame = new Game();
      Assert.AreEqual("Pong", testGame.IsPingPong(10));
    }

    [TestMethod]
    public void IsPingPong_ReplaceDivisibleOf3and5WithPingPong_PingPong()
    {
      Game testGame = new Game();
      Assert.AreEqual("Ping-Pong", testGame.IsPingPong(15));
    }

    [TestMethod]
    public void IsPingPong_ReplaceDivisibleOf7WithSentence_AYYY()
    {
      Game testGame = new Game();
      Assert.AreEqual("AYYYYYYY divisible of 7!", testGame.IsPingPong(14));
    }
  }
}
