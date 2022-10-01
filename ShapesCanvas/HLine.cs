using SixLabors.ImageSharp;

namespace ShapesCanva;

public class HLine : Line
{
    public int Width { get; set; }
    public Color DrawColor { get; set; }

    public HLine(Point start, int width, Color drawColor) 
        : base(start, new Point(start.X + width - 1, start.Y), drawColor)
    {
        Width = width;
    }

    public HLine(Point start, int width) : this(start, width, DefaultDrawColor)
    {
    }

    public static Color DefaultDrawColor { get; set; }

    public HLine(HLine hLine) : this(hLine.Start, hLine.Width, hLine.DrawColor)
    {
    }
}