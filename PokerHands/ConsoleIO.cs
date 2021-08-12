﻿using System;

namespace PokerHands {
  public class ConsoleIO : IUserIO {
    public string ReadLine() {
      return Console.ReadLine();
    }

    public void Write(string message) {
      Console.Write(message);
    }

    public void WriteLine(string message) {
      Console.WriteLine(message);
    }
  }
}