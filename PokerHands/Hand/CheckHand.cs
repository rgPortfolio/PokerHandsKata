using System.Collections.Generic;
using System.Linq;

namespace PokerHands {
  public static class CheckHand {
    public static bool CheckPair(List<Card> cards) {
      return cards.GroupBy(card => card.Value).Count(group => group.Count() == 2) == 1;
    }

    public static bool CheckTwoPair(List<Card> cards) {
      return cards.GroupBy(card => card.Value).Count(group => group.Count() >= 2) == 2;
    }

    public static bool CheckThreeOfAKind(List<Card> cards) {
      return cards.GroupBy(card => card.Value).Any(group => group.Count() == 3);
    }

    public static bool CheckStraight(List<Card> cards) {
      var cardsInOrder = cards.OrderByDescending(a => a.Value).ToList();
      if(cardsInOrder.First().Value == (CardValues) 14) {
        if(IsLowStraight(cards) || IsHighStraight(cards)) {
          return true;
        }
      } else {
        return IsStraight(cardsInOrder);
      }
      return false;
    }

    private static bool IsLowStraight(List<Card> cards) {
      var lowStraight = cards.Count(a => a.Value == (CardValues) 2 || a.Value == (CardValues) 3 || a.Value == (CardValues) 4 || a.Value == (CardValues) 5) == 4;
      return lowStraight;
    }

    private static bool IsHighStraight(List<Card> cards) {
      var highStraight = cards.Count(a => a.Value == (CardValues) 10 || a.Value == (CardValues) 11 || a.Value == (CardValues) 12 || a.Value == (CardValues) 13) == 4;
      return highStraight;
    }

    private static bool IsStraight(List<Card> cardsInOrder) {
      var nextCard = cardsInOrder.First().Value - 1;

      foreach(var card in cardsInOrder) {
        if(card.Value - 1 != nextCard) {
          return false;
        }
        nextCard = nextCard - 1;
      }
      return true;
    }

    public static bool CheckFlush(List<Card> cards) {
      return cards.GroupBy(card => card.Suit).Any(group => group.Count() == 5);
    }

    public static bool CheckFullHouse(List<Card> cards) {
      return CheckPair(cards) && CheckThreeOfAKind(cards);
    }

    public static bool CheckFourOfAKind(List<Card> cards) {
      return cards.GroupBy(card => card.Value).Any(group => group.Count() == 4);
    }

    public static bool CheckStraightFlush(List<Card> cards) {
      return CheckFlush(cards) && CheckStraight(cards);
    }
  }
}