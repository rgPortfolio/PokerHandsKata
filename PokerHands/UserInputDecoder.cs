using System.Collections.Generic;
using System.Linq;

namespace PokerHands {
  public static class UserInputDecoder {
    private static Dictionary<char, CardValues> _cardDictionary = new Dictionary<char, CardValues> {
      {'2', CardValues.Two},
      {'3', CardValues.Three},
      {'4', CardValues.Four},
      {'5', CardValues.Five},
      {'6', CardValues.Six},
      {'7', CardValues.Seven},
      {'8', CardValues.Eight},
      {'9', CardValues.Nine},
      {'t', CardValues.Ten},
      {'j', CardValues.Jack},
      {'q', CardValues.Queen},
      {'k', CardValues.King},
      {'a', CardValues.Ace}
    };

    private static Dictionary<char, Suits> _suitsDictionary = new Dictionary<char, Suits> {
      {'s', Suits.Spades},
      {'h', Suits.Hearts},
      {'d', Suits.Diamonds},
      {'c', Suits.Clubs},
    };

    public static List<Card> DecodePlayerHandFromUser(string[] hand) {
      return hand.Select(card => new Card(_cardDictionary[char.ToLower(card[0])], _suitsDictionary[char.ToLower(card[1])])).ToList();
    }
  }
}