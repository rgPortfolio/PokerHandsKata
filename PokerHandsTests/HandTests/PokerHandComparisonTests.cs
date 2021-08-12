using System.Collections.Generic;
using NUnit.Framework;
using PokerHands;

namespace PokerHandsTests {
  public class PokerHandComparisonTests {
    private List<Card> _playerOneCards;
    private List<Card> _playerTwoCards;

    [Test]
    public void PlayerOneWinsOnHighCard() {
      var game = new Game();

      _playerOneCards = new List<Card> {
        new Card(CardValues.Four, Suits.Clubs),
        new Card(CardValues.Four, Suits.Diamonds),
        new Card(CardValues.Ten, Suits.Clubs),
        new Card(CardValues.Ace, Suits.Hearts),
        new Card(CardValues.Six, Suits.Spades)
      };

      game.PlayerOne = new Player(_playerOneCards);

      _playerTwoCards = new List<Card> {
        new Card(CardValues.Four, Suits.Clubs),
        new Card(CardValues.Nine, Suits.Diamonds),
        new Card(CardValues.Jack, Suits.Clubs),
        new Card(CardValues.King, Suits.Hearts),
        new Card(CardValues.Four, Suits.Spades)
      };

      game.PlayerTwo = new Player(_playerTwoCards);

      HandComparison.SetHandWinner(game);


      Assert.IsTrue(game.PlayerOne.HandWon);
    }

    [Test]
    public void PlayerTwoWinsOnHighCard() {
      var game = new Game();

      _playerOneCards = new List<Card> {
        new Card(CardValues.Four, Suits.Clubs),
        new Card(CardValues.Three, Suits.Diamonds),
        new Card(CardValues.Ten, Suits.Clubs),
        new Card(CardValues.Queen, Suits.Hearts),
        new Card(CardValues.Six, Suits.Spades)
      };

      game.PlayerOne = new Player(_playerOneCards);

      _playerTwoCards = new List<Card> {
        new Card(CardValues.Eight, Suits.Clubs),
        new Card(CardValues.Nine, Suits.Diamonds),
        new Card(CardValues.Jack, Suits.Clubs),
        new Card(CardValues.King, Suits.Hearts),
        new Card(CardValues.Ace, Suits.Spades)
      };

      game.PlayerTwo = new Player(_playerTwoCards);

      HandComparison.SetHandWinner(game);


      Assert.IsTrue(game.PlayerTwo.HandWon);
    }

    [Test]
    public void GameSetToDrawOnEqualHands() {
      var game = new Game();

      _playerOneCards = new List<Card> {
        new Card(CardValues.Four, Suits.Clubs),
        new Card(CardValues.Three, Suits.Diamonds),
        new Card(CardValues.Ten, Suits.Clubs),
        new Card(CardValues.Queen, Suits.Hearts),
        new Card(CardValues.Six, Suits.Spades)
      };

      game.PlayerOne = new Player(_playerOneCards);

      _playerTwoCards = new List<Card> {
        new Card(CardValues.Eight, Suits.Clubs),
        new Card(CardValues.Nine, Suits.Diamonds),
        new Card(CardValues.Jack, Suits.Clubs),
        new Card(CardValues.Queen, Suits.Hearts),
        new Card(CardValues.Three, Suits.Spades)
      };

      game.PlayerTwo = new Player(_playerTwoCards);

      HandComparison.SetHandWinner(game);

      Assert.IsTrue(game.Draw);

    }

    [Test]
    public void PlayerOneWinsOnHandType() {
      var game = new Game();

      _playerOneCards = new List<Card> {
        new Card(CardValues.Four, Suits.Clubs),
        new Card(CardValues.Five, Suits.Diamonds),
        new Card(CardValues.Seven, Suits.Clubs),
        new Card(CardValues.Eight, Suits.Hearts),
        new Card(CardValues.Six, Suits.Spades)
      };

      game.PlayerOne = new Player(_playerOneCards);

      _playerTwoCards = new List<Card> {
        new Card(CardValues.Eight, Suits.Clubs),
        new Card(CardValues.Nine, Suits.Diamonds),
        new Card(CardValues.Jack, Suits.Clubs),
        new Card(CardValues.Queen, Suits.Hearts),
        new Card(CardValues.Three, Suits.Spades)
      };

      game.PlayerTwo = new Player(_playerTwoCards);

      HandComparison.SetHandWinner(game);

      Assert.IsTrue(game.PlayerOne.HandWon);

    }

    [Test]
    public void PlayerTwoWinsOnHandType() {
      var game = new Game();

      _playerOneCards = new List<Card> {
        new Card(CardValues.Four, Suits.Clubs),
        new Card(CardValues.Five, Suits.Diamonds),
        new Card(CardValues.Seven, Suits.Clubs),
        new Card(CardValues.Eight, Suits.Hearts),
        new Card(CardValues.Six, Suits.Spades)
      };

      game.PlayerOne = new Player(_playerOneCards);

      _playerTwoCards = new List<Card> {
        new Card(CardValues.Eight, Suits.Spades),
        new Card(CardValues.Nine, Suits.Spades),
        new Card(CardValues.Jack, Suits.Spades),
        new Card(CardValues.Queen, Suits.Spades),
        new Card(CardValues.Ten, Suits.Spades)
      };

      game.PlayerTwo = new Player(_playerTwoCards);

      HandComparison.SetHandWinner(game);

      Assert.IsTrue(game.PlayerTwo.HandWon);

    }
  }
}
