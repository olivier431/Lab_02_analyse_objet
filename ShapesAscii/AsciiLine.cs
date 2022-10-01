using System.Reflection.Metadata;
using SixLabors.ImageSharp;
using Point = SixLabors.ImageSharp.Point;

namespace ShapesAscii;

public class AsciiLine : ShapeAscii
{
    public Point Start { get; set; }
    public Point End { get; set; }

    public AsciiLine(Point start, Point end, Color drawColor) : base(drawColor)
    {
        Start = start;
        End = end;
    }

    public AsciiLine(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    public AsciiLine(AsciiLine line) : this(line.Start, line.End, line.DrawColor)
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