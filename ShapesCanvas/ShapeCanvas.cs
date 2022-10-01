using Lab_02_Analyse;
using SixLabors.ImageSharp;

namespace ShapesCanva;

public abstract class ShapeCanvas : Shape
{

    protected ShapeCanvas(Color drawColor)
    {
        DrawColor = drawColor;
    }
    
    protected ShapeCanvas() : this(DefaultDrawColor)
    {
    }

}
