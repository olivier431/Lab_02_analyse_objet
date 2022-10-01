using ShapesCanva;

namespace Lab_02_Analyse
{
    public abstract class Factory
    {
        protected Factory()
        {
            this.shapes = new List<Shape>();
        }

        public List<Shape> shapes { get; set; }

        public abstract void addPoint(int x1, int y1);

        public abstract void addLine(int x1, int y1 , int x2 , int y2);
        public abstract void addCircle(int x1, int y1 , int radius);

        public abstract void addHLine(int x1, int y1 , int width);

        public abstract void addVLine(int x1, int y1 , int heigth);

        public abstract void addRectangle(int x1, int y1 , int x2, int y2 ,int x3, int y3 ,int x4, int y4);

        public abstract void addTriangle( int x1, int y1 , int x2, int y2 ,int x3, int y3);
        public abstract Document saveFile(Document document);


    }
}