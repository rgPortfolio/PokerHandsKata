namespace PokerHands {
  public static class HandComparison {
    public const int PLAYER_ONE_WINS = 1;
    public const int PLAYER_TWO_WINS = 2;
    public const int DRAW = 0;

    public static void SetHandWinner(Game game) {
      game.PlayerOne.SetPlayerHand(GetHandValue(game.PlayerOne));
      game.PlayerTwo.SetPlayerHand(GetHandValue(game.PlayerTwo));

      var winnerNumber = GetWinner(game.PlayerOne.HandValue, game.PlayerTwo.HandValue);

      switch(winnerNumber) {
        case 1:
          game.PlayerOne.HandWon = true;
          break;
        case 2:
          game.PlayerTwo.HandWon = true;
          break;
        default:
          game.Draw = true;
          break;
      }
    }

    private static HandValue GetHandValue(Player player) {
      var newHandValue = HandDecoder.DecodeHandType(player.GetCards());
      newHandValue.Value = ScoringOfPlayerHand.GetHighCard(player.GetCards());
      return newHandValue;
    }

    private static int GetWinner(HandValue playerOne, HandValue playerTwo) {
      if(playerOne.HandType > playerTwo.HandType) {
        return PLAYER_ONE_WINS;
      }

      if(playerTwo.HandType > playerOne.HandType) {
        return PLAYER_TWO_WINS;
      }

      if(playerOne.HandType == playerTwo.HandType) {
        if(playerOne.Value > playerTwo.Value) {
          return PLAYER_ONE_WINS;
        }

        if(playerTwo.Value > playerOne.Value) {
          return PLAYER_TWO_WINS;
        }
      }

      return DRAW;
    }
  }
}