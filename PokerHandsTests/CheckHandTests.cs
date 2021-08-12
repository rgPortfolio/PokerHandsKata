using System.Collections.Generic;
using NUnit.Framework;
using PokerHands;

namespace PokerHandsTests {
  public class CheckHandTests {
    [Test]
    public void PairIsFound() {
      var cards = new List<Card> {
        new Card(CardValues.Four, Suits.Clubs),
        new Card(CardValues.Four, Suits.Diamonds),
        new Card(CardValues.Ten, Suits.Clubs),
        new Card(CardValues.Queen, Suits.Hearts),
        new Card(CardValues.Six, Suits.Spades)
      };
      var hand = new HandValue(0, HandTypes.Pair);
      var decodedHand = HandDecoder.DecodeHandType(cards);

      Assert.AreEqual(hand.HandType,decodedHand.HandType);
    }

    [Test]
    public void TwoPairIsFound() {
      var cards = new List<Card> {
        new Card(CardValues.Four, Suits.Clubs),
        new Card(CardValues.Four, Suits.Diamonds),
        new Card(CardValues.Ten, Suits.Clubs),
        new Card(CardValues.Ten, Suits.Hearts),
        new Card(CardValues.Six, Suits.Spades)
      };

      var hand = new HandValue(0, HandTypes.TwoPair);
      var decodedHand = HandDecoder.DecodeHandType(cards);

      Assert.AreEqual(hand.HandType, decodedHand.HandType);

    }

    [Test]
    public void ThreeOfAKindIsFound() {
      var cards = new List<Card> {
        new Card(CardValues.Four, Suits.Clubs),
        new Card(CardValues.Four, Suits.Diamonds),
        new Card(CardValues.Four, Suits.Clubs),
        new Card(CardValues.Queen, Suits.Hearts),
        new Card(CardValues.Six, Suits.Spades)
      };

      var hand = new HandValue(0, HandTypes.ThreeOfAKind);
      var decodedHand = HandDecoder.DecodeHandType(cards);

      Assert.AreEqual(hand.HandType, decodedHand.HandType);
    }

    [Test]
    public void StraightIsFound() {
      var cards = new List<Card> {
        new Card(CardValues.Four, Suits.Clubs),
        new Card(CardValues.Five, Suits.Diamonds),
        new Card(CardValues.Six, Suits.Clubs),
        new Card(CardValues.Seven, Suits.Hearts),
        new Card(CardValues.Three, Suits.Spades)
      };

      var hand = new HandValue(0, HandTypes.Straight);
      var decodedHand = HandDecoder.DecodeHandType(cards);

      Assert.AreEqual(hand.HandType, decodedHand.HandType);
    }

    [Test]
    public void FlushIsFound() {
      var cards = new List<Card> {
        new Card(CardValues.Four, Suits.Clubs),
        new Card(CardValues.Four, Suits.Clubs),
        new Card(CardValues.Ten, Suits.Clubs),
        new Card(CardValues.Queen, Suits.Clubs),
        new Card(CardValues.Six, Suits.Clubs)
      };

      var hand = new HandValue(0, HandTypes.Flush);
      var decodedHand = HandDecoder.DecodeHandType(cards);

      Assert.AreEqual(hand.HandType, decodedHand.HandType);
    }

    [Test]
    public void FullHouseIsFound() {
      var cards = new List<Card> {
        new Card(CardValues.Four, Suits.Clubs),
        new Card(CardValues.Four, Suits.Diamonds),
        new Card(CardValues.Ten, Suits.Clubs),
        new Card(CardValues.Ten, Suits.Hearts),
        new Card(CardValues.Ten, Suits.Spades)
      };

      var hand = new HandValue(0, HandTypes.FullHouse);
      var decodedHand = HandDecoder.DecodeHandType(cards);

      Assert.AreEqual(hand.HandType, decodedHand.HandType);
    }

    [Test]
    public void FourOfAKindIsFound() {
      var cards = new List<Card> {
        new Card(CardValues.Four, Suits.Clubs),
        new Card(CardValues.Four, Suits.Diamonds),
        new Card(CardValues.Four, Suits.Clubs),
        new Card(CardValues.Four, Suits.Hearts),
        new Card(CardValues.Six, Suits.Spades)
      };

      var hand = new HandValue(0, HandTypes.FourOfAKind);
      var decodedHand = HandDecoder.DecodeHandType(cards);

      Assert.AreEqual(hand.HandType, decodedHand.HandType);
    }

    [Test]
    public void StraightFlushIsFound() {
      var cards = new List<Card> {
        new Card(CardValues.Ace, Suits.Diamonds),
        new Card(CardValues.Two, Suits.Diamonds),
        new Card(CardValues.Three, Suits.Diamonds),
        new Card(CardValues.Four, Suits.Diamonds),
        new Card(CardValues.Five, Suits.Diamonds)
      };

      var hand = new HandValue(0, HandTypes.StraightFlush);
      var decodedHand = HandDecoder.DecodeHandType(cards);

      Assert.AreEqual(hand.HandType, decodedHand.HandType);
    }
  }
}
