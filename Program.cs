using System;
using Chessboard.Queen;

namespace Chessboard
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a Y (1-8) coordinate for the Queen:");
      string yStringQueen = Console.ReadLine();
      int yCoordQueen = int.Parse(yStringQueen);

      Console.WriteLine("Enter an X (1-8) coordinate for the Queen:");
      string xStringQueen = Console.ReadLine();
      int xCoordQueen = int.Parse(xStringQueen);

      Console.WriteLine("Enter a Y (1-8) coordinate for the opposing piece:");
      string yStringOpponent = Console.ReadLine();
      int yCoordOpponent = int.Parse(yStringOpponent);

      Console.WriteLine("Enter an X (1-8) coordinate for the opposing piece:");
      string xStringOpponent = Console.ReadLine();
      int xCoordOpponent = int.Parse(xStringOpponent);

      Coords queen = new Coords(yCoordQueen, xCoordQueen, yCoordOpponent, xCoordOpponent);

      Console.WriteLine((queen.CanAttack()).ToString());
    }
  }
}