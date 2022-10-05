using ShapesCanva;
using SixLabors.ImageSharp;
namespace Lab_02_Analyse
{
    public abstract class Shape
    {
        public static Color DefaultDrawColor { get; set; } = Color.Yellow;
        public Color DrawColor { get; set; }

        protected Shape(Color drawColor)
        {
            DrawColor = drawColor;
        }
    
        protected Shape() : this(DefaultDrawColor)
        {
        }

        public abstract void Draw(Document doc);
    }
}