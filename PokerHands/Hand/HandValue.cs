namespace PokerHands {
  public class HandValue {
    public int Value;
    public HandTypes HandType;
    public HandValue() { }

    public HandValue(int value, HandTypes handType) {
      Value = value;
      HandType = handType;
    }
  }
}