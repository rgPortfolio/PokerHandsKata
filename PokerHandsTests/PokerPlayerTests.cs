using System.Collections.Generic;
using PokerHands;
using NUnit.Framework;

namespace PokerHandsTests {
  public class PokerPlayerTests {
    [Test]
    public void StartsWithZeroCards() {
      var player = new Player(new List<Card>());
      Assert.AreEqual(0, player.GetCardCount());
    }
  }
}
