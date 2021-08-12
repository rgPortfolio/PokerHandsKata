using System.Collections.Generic;
using System.Linq;

namespace PokerHands {
  public static class ScoringOfPlayerHand {
    public static int GetHighCard(List<Card> cards) {
      var card = new List<Card>(cards.OrderByDescending(c => c.Value));
      return (int) card[0].Value;
    }
  }
}