using System.Reflection.Metadata;
using SixLabors.ImageSharp;

namespace ShapesAscii;

public class AsciiPoint : ShapeAscii
{
    private int _x;
    private int _y;

    public int X
    {
        get => _x;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("X cannot be negative");
            }

            _x = value;
        }
    }

    public int Y
    {
        get => _y;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Y cannot be negative");
            }

            _y = value;
        }
    }

    public AsciiPoint(int x, int y, Color drawColor) : base(drawColor)
    {
        X = x;
        Y = y;
    }

    public AsciiPoint(int x, int y) : this(x, y, DefaultDrawColor)
    {
    }

    public static Color DefaultDrawColor { get; set; }

    public AsciiPoint(AsciiPoint p) : this(p.X, p.Y, p.DrawColor)
    {
    }

    public Color DrawColor { get; set; }
    public override void Draw(Lab_02_Analyse.Document doc)
    {
        throw new NotImplementedException();
    }

    public override void Draw(Document doc)
    {
        throw new NotImplementedException();
    }
}