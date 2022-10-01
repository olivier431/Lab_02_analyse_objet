
using SixLabors.ImageSharp;
using Point = SixLabors.ImageSharp.Point;

namespace ShapesAscii;

public class AsciiHLine : AsciiLine
{
    public int Width { get; set; }

    public AsciiHLine(Point start, int width, Color drawColor) 
        : base(start, new Point(start.X + width - 1, start.Y), drawColor)
    {
        Width = width;
    }

    public AsciiHLine(Point start, int width) : this(start, width, DefaultDrawColor)
    {
    }

    public static Color DefaultDrawColor { get; set; }

    public AsciiHLine(AsciiHLine hLine) : this(hLine.Start, hLine.Width, hLine.DrawColor)
    {
    }
}