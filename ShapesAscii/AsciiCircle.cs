
using System.Reflection.Metadata;
using SixLabors.ImageSharp;

namespace ShapesAscii;

public class AsciiCircle : ShapeAscii
{
    private ShapeAscii _shapeAsciiImplementation;
    public Point Centre { get; set; }
    public int Radius { get; set; }
    public Color DrawColor { get; set; }

    public AsciiCircle(Point centre, int radius, Color drawColor)
    {
        Centre = centre;
        Radius = radius;
        DrawColor = drawColor;
    }
    
    public override void Draw(Lab_02_Analyse.Document doc)
    {
        throw new NotImplementedException();

    }

    public override void Draw(Document doc)
    {
        throw new NotImplementedException();
    }
}