using NUnit.Framework;
using PokerHands;
using Rhino.Mocks;

namespace PokerHandsTests {
  public class PokerGameTests {
    [Test]
    public void PlayerTwoWinsWithInputFromConsole() {
      var mockInput = MockRepository.GenerateMock<IUserIO>();
      var game = new Game(mockInput);

      mockInput.Stub(x => x.ReadLine()).Return("4d 4h 4s 4c 9c").Repeat.Once();
      mockInput.Stub(x => x.ReadLine()).Return("2d 2h 2s 5c 5c").Repeat.Once();

      game.GetPlayerOneCardsFromUser();
      game.GetPlayerTwoCardsFromUser();
      game.ComparePlayerHands();

      Assert.IsTrue(game.PlayerOne.HandWon);
    }

  }
}
