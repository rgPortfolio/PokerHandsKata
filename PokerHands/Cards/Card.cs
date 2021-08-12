namespace PokerHands {
  public class Card {
    public CardValues Value;
    public Suits Suit;
    public Card() { }

    public Card(CardValues cardValue, Suits suit) {
      Value = cardValue;
      Suit = suit;
    }
  }
}