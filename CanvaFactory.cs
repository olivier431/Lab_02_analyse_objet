using System.Runtime.CompilerServices;
using ShapesCanva;
using SixLabors.ImageSharp;

namespace Lab_02_Analyse
{
    public class CanvaFactory : Factory
    {
        public override void addPoint(int x1, int y1)
        {
            shapes.Add(new ShapesCanva.Point(x1,y1));
        }
        public override void addLine(int x1, int y1, int x2, int y2)
        {
            shapes.Add(new Line(new ShapesCanva.Point(x1,x2), new ShapesCanva.Point(x2,y2)));
        }

        public override void addCircle(int x1, int y1, int radius)
        {
            shapes.Add(new Circle(new ShapesCanva.Point(x1,y1), radius, Color.Aqua));
        }

        public override void addHLine(int x1, int y1, int width)
        {
            shapes.Add(new HLine(new ShapesCanva.Point(x1,y1), width));        
        }

        public override void addVLine(int x1, int y1, int heigth)
        {
            shapes.Add(new VLine(new ShapesCanva.Point(x1,y1), heigth));        
        }

        public override void addRectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            shapes.Add(new Polygon(new ShapesCanva.Point(x1,y1),new ShapesCanva.Point(x2,y2),new ShapesCanva.Point(x3,y3),new ShapesCanva.Point(x4,y4)));
        }

        public override void addTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            shapes.Add( new Triangle(new ShapesCanva.Point(x1,y1),new  ShapesCanva.Point(x2,y2),new  ShapesCanva.Point(x3,y3) ));
        }

        public override Document saveFile(Document document)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw(document);
            }
            document.canvas.Save("CanvaImage.png");
            return document;
        }
    }
}