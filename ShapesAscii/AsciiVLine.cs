
using SixLabors.ImageSharp;
using Point = SixLabors.ImageSharp.Point;

namespace ShapesAscii;

public class AsciiVLine : AsciiLine
{
    public int Height { get; set; }

    public AsciiVLine(Point start, int height, Color drawColor)
        : base(start, new Point(start.X, start.Y + height - 1), drawColor)
    {
        Height = height;
    }

    public AsciiVLine(Point start, int height) : this(start, height, DefaultDrawColor)
    {
    }

    public AsciiVLine(AsciiVLine vLine) : this(vLine.Start, vLine.Height, vLine.DrawColor)
    {
    }
}

