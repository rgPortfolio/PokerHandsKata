namespace PokerHands {
  class Program {
    static void Main(string[] args) {
      var game = new Game(new ConsoleIO());
      game.DisplayGameStartAndRules();
      game.GetPlayerOneCardsFromUser();
      game.GetPlayerTwoCardsFromUser();
      game.ComparePlayerHands();
      game.DisplayWinner();
    }
  }
}