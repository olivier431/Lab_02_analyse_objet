using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace ShapesAscii
{
    public class Ascii 
    {
        public static int DefaultWidth => 100;
        public static int DefaultHeight => 100;
        public static Color DefaultBackgroundColor => Color.Black;

        public int Width { get; }
        public int Height { get; }
        public Color BackgroundColor { get; set; }
        public Image<Rgb24> Image { get; }

        public Color this[int x, int y]
        {
            get => GetPixel(x, y);
            set => SetPixel(x, y, value);
        }

        public Ascii() : this(DefaultWidth, DefaultHeight, DefaultBackgroundColor)
        {
        }

        public Ascii(int width) : this(width, width, DefaultBackgroundColor)
        {
        }

        public Ascii(int width, int height) : this(width, height, DefaultBackgroundColor)
        {
        }


        public Ascii(int width, int height, Color backgroundColor)
        {
            throw new NotImplementedException();

        }

        public void Clear(Color clearColor)
        {
            throw new NotImplementedException();

        }

        public Color GetPixel(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void SetPixel(int x, int y, Color drawColor)
        {
            throw new NotImplementedException();

        }

        public void Save(string filename)
        {
            throw new NotImplementedException();
        }
    }
}
