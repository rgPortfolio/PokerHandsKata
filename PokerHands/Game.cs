using System;
using System.Collections.Generic;

namespace PokerHands {
  public class Game {
    public Player PlayerOne;
    public Player PlayerTwo;
    public bool Draw = false;
    public IUserIO UserIO;
    public Game() { }

    public Game(IUserIO userIO) {
      UserIO = userIO;
    }

    public void DisplayGameStartAndRules() {
      UserIO.WriteLine("Welcome to the Poker Palace");
      UserIO.WriteLine("Please enjoy yourself...");

      UserIO.WriteLine("Here, we let you decide the cards to give the players and see the results. Just two players though.");
      UserIO.WriteLine("We are looking for the format of 4D 5D 6D 7D 8D . This resulted in a royal flush.");
    }

    public void GetPlayerOneCardsFromUser() {
      UserIO.Write("Enter the cards for Player One: ");
      var playerOneCards = UserIO.ReadLine();
      var playerOneHand = playerOneCards.Split(' ');
      PlayerOne = new Player(UserInputDecoder.DecodePlayerHandFromUser(playerOneHand));
    }

    public void GetPlayerTwoCardsFromUser() {
      UserIO.Write("Enter the cards for Player Two: ");
      var playerTwoCards = UserIO.ReadLine();
      var playerTwoHand = playerTwoCards.Split(' ');
      PlayerTwo = new Player(UserInputDecoder.DecodePlayerHandFromUser(playerTwoHand));
    }

    public void ComparePlayerHands() {
      HandComparison.SetHandWinner(this);
    }

    public void DisplayWinner() {
      UserIO.WriteLine($"Player one hand : value {PlayerOne.HandValue.Value} , type {PlayerOne.HandValue.HandType}");
      UserIO.WriteLine($"Player two hand : value {PlayerTwo.HandValue.Value} , type {PlayerTwo.HandValue.HandType}");
      if(PlayerOne.HandWon) {
        UserIO.WriteLine("Player One Wins!");
      } else if(PlayerTwo.HandWon) {
        UserIO.WriteLine("Player Two Wins");
      } else {
        UserIO.WriteLine("Draw!");
      }
    }
  }
}