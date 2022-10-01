using Lab_02_Analyse;
using SixLabors.ImageSharp;
using Document = System.Reflection.Metadata.Document;

namespace ShapesAscii;

public abstract class ShapeAscii : Shape
{
    protected ShapeAscii(Color drawColor)
    {
        DrawColor = drawColor;
    }
    
    protected ShapeAscii() : this(DefaultDrawColor)
    {
    }

    public abstract void Draw(Document doc);
}