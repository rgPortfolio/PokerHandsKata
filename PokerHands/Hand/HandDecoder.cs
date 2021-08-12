using System.Collections.Generic;

namespace PokerHands {
  public static class HandDecoder {
    public static HandValue DecodeHandType(List<Card> hand) {
      if(CheckHand.CheckStraightFlush(hand)) {
        return new HandValue(0, HandTypes.StraightFlush);
      }

      if(CheckHand.CheckFourOfAKind(hand)) {
        return new HandValue(0, HandTypes.FourOfAKind);
      }

      if(CheckHand.CheckFullHouse(hand)) {
        return new HandValue(0, HandTypes.FullHouse);
      }

      if(CheckHand.CheckFlush(hand)) {
        return new HandValue(0, HandTypes.Flush);
      }

      if(CheckHand.CheckStraight(hand)) {
        return new HandValue(0, HandTypes.Straight);
      }

      if(CheckHand.CheckThreeOfAKind(hand)) {
        return new HandValue(0, HandTypes.ThreeOfAKind);
      }

      if(CheckHand.CheckTwoPair(hand)) {
        return new HandValue(0, HandTypes.TwoPair);
      }

      if(CheckHand.CheckPair(hand)) {
        return new HandValue(0, HandTypes.Pair);
      }

      return new HandValue(ScoringOfPlayerHand.GetHighCard(hand), HandTypes.HighCard);
    }
  }
}