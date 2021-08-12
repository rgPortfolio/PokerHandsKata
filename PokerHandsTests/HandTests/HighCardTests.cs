using System.Collections.Generic;
using NUnit.Framework;
using PokerHands;

namespace PokerHandsTests {

  public class HighCard {
    private List<Card> _cards;

    [SetUp]
    public void SetUp() {
      _cards = new List<Card> {
          new Card(CardValues.Ten, Suits.Clubs),
          new Card(CardValues.Two, Suits.Diamonds),
          new Card(CardValues.Five, Suits.Clubs),
          new Card(CardValues.Eight, Suits.Hearts),
          new Card(CardValues.Ace, Suits.Spades)
        };
    }

    [Test]
    public void ScoredByHighestValueCardInHand() {
      Assert.AreEqual(14, ScoringOfPlayerHand.GetHighCard(_cards));

    }
  }
}
