using System;

namespace Chessboard.Queen {

  public class Coords
  {
    public int YCoordQueen { get; set; }
    public int XCoordQueen { get; set; }
    public int YCoordOpponent { get; set; }
    public int XCoordOpponent { get; set; }

    public Coords(int yCoordQueen, int xCoordQueen, int yCoordOpponent, int xCoordOpponent)
    {
      YCoordQueen = yCoordQueen;
      XCoordQueen = xCoordQueen;
      YCoordOpponent = yCoordOpponent;
      XCoordOpponent = xCoordOpponent;
    }

    public bool CanAttack()
    {
      if (YCoordQueen == YCoordOpponent || XCoordQueen == YCoordOpponent || (Math.Abs(YCoordQueen - YCoordOpponent) == Math.Abs(XCoordQueen - XCoordOpponent)))
      {
        return true;
      } 
      else
      {
        return false;
      }
    }
  }
}