using ShapesAscii;
using SixLabors.ImageSharp;
using Point = SixLabors.ImageSharp.Point;

namespace ShapesAscii;

public class AsciiTriangle : AsciiPolygon
{
    public Point Vertex1 { get; set; }
    public Point Vertex2 { get; set; }
    public Point Vertex3 { get; set; }

    public AsciiTriangle(Point vertex1, Point vertex2, Point vertex3)
        : this(vertex1, vertex2, vertex3, DefaultDrawColor)
    {
    }

    public AsciiTriangle(Point vertex1, Point vertex2, Point vertex3, Color drawColor)
        : base(drawColor, vertex1, vertex2, vertex3)
    {
        Vertex1 = vertex1;
        Vertex2 = vertex2;
        Vertex3 = vertex3;
    }

    public AsciiTriangle(AsciiTriangle triangle)
        : this(triangle.Vertex1, triangle.Vertex2, triangle.Vertex3, triangle.DrawColor)
    {
    }
}