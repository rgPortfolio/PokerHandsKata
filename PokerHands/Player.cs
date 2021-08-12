using System.Collections.Generic;

namespace PokerHands {
  public class Player {
    private List<Card> _cards = new List<Card>();
    public bool HandWon = false;
    public HandValue HandValue { get; } = new HandValue();
    public Player() { }

    public Player(IEnumerable<Card> cards) {
      _cards.AddRange(cards);
    }

    public int GetCardCount() {
      return _cards.Count;
    }

    public List<Card> GetCards() {
      return _cards;
    }

    public void SetPlayerHand(HandValue newHandValue) {
      HandValue.Value = newHandValue.Value;
      HandValue.HandType = newHandValue.HandType;
    }
  }
}