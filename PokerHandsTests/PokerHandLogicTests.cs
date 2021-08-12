using System.Collections.Generic;
using NUnit.Framework;
using PokerHands;
using Rhino.Mocks.Constraints;

namespace PokerHandsTests {

  public class PokerHandLogicTests {
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
        Assert.AreEqual(14, HandLogic.GetHighCard(_cards));

      }
    }

    public class Pair {
      private List<Card> _cards;

      [SetUp]
      public void SetUp() {
        _cards = new List<Card> {
          new Card(CardValues.Ten, Suits.Clubs),
          new Card(CardValues.Ten, Suits.Diamonds),
          new Card(CardValues.Five, Suits.Clubs),
          new Card(CardValues.Eight, Suits.Hearts),
          new Card(CardValues.Ace, Suits.Spades)
        };
      }

      [Test]
      public void ScoredByCardValueWithTwoOccurences() {
        Assert.AreEqual(10, HandLogic.GetPairValue(_cards));
      }
    }

    public class TwoPair {
      private List<Card> _cards;

      [SetUp]
      public void SetUp() {
        _cards = new List<Card> {
          new Card(CardValues.Ten, Suits.Clubs),
          new Card(CardValues.Ten, Suits.Diamonds),
          new Card(CardValues.Five, Suits.Clubs),
          new Card(CardValues.Ace, Suits.Hearts),
          new Card(CardValues.Ace, Suits.Spades)
        };
      }

      [Test]
      public void ScoredByValueOfTwoCardGroupingsWithTwoOccurences() {
        var twoPairValues = HandLogic.GetTwoPairValues(_cards);
        Assert.AreEqual(10, twoPairValues.Item1);
        Assert.AreEqual(14, twoPairValues.Item2);
      }
    }

    public class ThreeOfAKind {
      private List<Card> _cards;

      [SetUp]
      public void Setup() {
        _cards = new List<Card> {
          new Card(CardValues.Two, Suits.Clubs),
          new Card(CardValues.Two, Suits.Diamonds),
          new Card(CardValues.Two, Suits.Clubs),
          new Card(CardValues.King, Suits.Hearts),
          new Card(CardValues.Ace, Suits.Spades)
        };
      }

      [Test]
      public void ScoredByCardValueWithThreeOccurences() {
        Assert.AreEqual(2, HandLogic.GetThreeOfAKindValue(_cards));
      }
    }

    public class Straight {
      private List<Card> _cards;

      [SetUp]
      public void SetUp() {
        _cards = new List<Card> {
          new Card(CardValues.Two, Suits.Clubs),
          new Card(CardValues.Three, Suits.Diamonds),
          new Card(CardValues.Four, Suits.Clubs),
          new Card(CardValues.Five, Suits.Hearts),
          new Card(CardValues.Six, Suits.Spades)
        };
      }

      [Test]
      public void ScoredByTheHighCard() {
        Assert.AreEqual(6, HandLogic.GetStraightValue(_cards));
      }
    }

    public class FullHouse {
      private List<Card> _cards;

      [SetUp]
      public void SetUp() {
        _cards = new List<Card> {
          new Card(CardValues.Seven, Suits.Clubs),
          new Card(CardValues.Seven, Suits.Diamonds),
          new Card(CardValues.Seven, Suits.Clubs),
          new Card(CardValues.Six, Suits.Hearts),
          new Card(CardValues.Six, Suits.Spades)
        };
      }

      [Test]
      public void ScoredByThreeOfAKindValue() {
        Assert.AreEqual(7, HandLogic.GetFullHouseValue(_cards));
      }
    }

    public class FourOfAKind {
      private List<Card> _cards;

      [SetUp]
      public void SetUp() {
        _cards = new List<Card> {
          new Card(CardValues.Seven, Suits.Clubs),
          new Card(CardValues.Seven, Suits.Diamonds),
          new Card(CardValues.Seven, Suits.Clubs),
          new Card(CardValues.Seven, Suits.Hearts),
          new Card(CardValues.Six, Suits.Spades)
        };
      }

      [Test]
      public void ScoredByCardValueWithFourOccurences() {
        Assert.AreEqual(7, HandLogic.GetFourOfAKindValue(_cards));
      }
    }

    public class Flush {
      private List<Card> _cards;

      [SetUp]
      public void SetUp() {
        _cards = new List<Card> {
          new Card(CardValues.Four, Suits.Clubs),
          new Card(CardValues.Five, Suits.Clubs),
          new Card(CardValues.Seven, Suits.Clubs),
          new Card(CardValues.Nine, Suits.Clubs),
          new Card(CardValues.Jack, Suits.Clubs)
        };
      }

      [Test]
      public void ScoredByHighCard() {
        Assert.AreEqual(11, HandLogic.GetFlushValue(_cards));
      }
    }

    public class StraightFlush {
      private List<Card> _cards;

      [SetUp]
      public void SetUp() {
        _cards = new List<Card> {
          new Card(CardValues.Four, Suits.Diamonds),
          new Card(CardValues.Five, Suits.Diamonds),
          new Card(CardValues.Seven, Suits.Diamonds),
          new Card(CardValues.Six, Suits.Diamonds),
          new Card(CardValues.Three, Suits.Diamonds)
        };
      }

      [Test]
      public void ScoredByHighCard() {
        Assert.AreEqual(7, HandLogic.GetStraightFlushValue(_cards));
      }

    }
  }
}
