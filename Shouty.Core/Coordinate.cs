using System;

namespace Shouty
{
  public class Coordinate
  {
    private readonly int xCoord;
    private readonly int yCoord;

    public Coordinate(int xCoord, int yCoord)
    {
      this.xCoord = xCoord;
      this.yCoord = yCoord;
    }

    public int DistanceFrom(Coordinate coordinate)
    {
      var dx = Math.Abs(xCoord - coordinate.xCoord);
      var dy = Math.Abs(yCoord - coordinate.yCoord);

      return ( int ) Math.Sqrt(dx * dx + dy * dy);

    }
  }
}
