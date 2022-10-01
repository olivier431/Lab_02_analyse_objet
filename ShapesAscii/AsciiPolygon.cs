using System.Reflection.Metadata;
using SixLabors.ImageSharp;

namespace ShapesAscii;

public class AsciiPolygon : ShapeAscii
{
    private ShapeAscii _shapeAsciiImplementation;
    public List<Point> Vertices { get; set; }

    public AsciiPolygon(List<Point> vertices, Color drawColor) : base(drawColor)
    {
        this.Vertices = vertices;
    }

    public AsciiPolygon(List<Point> vertices)
    {
        this.Vertices = vertices;
    }

    public AsciiPolygon(Color drawColor, params Point[] vertices) : base(drawColor)
    {
        this.Vertices = new List<Point>(vertices);
    }

    public AsciiPolygon(params Point[] vertices) : this(DefaultDrawColor, vertices)
    {
    }

    public static Color DefaultDrawColor { get; set; }

    public AsciiPolygon(AsciiPolygon polygon) : this(polygon.Vertices, polygon.DrawColor)
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