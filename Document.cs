using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using ShapesAscii;
using ShapesCanva;

namespace Lab_02_Analyse;
public abstract class Document
{
    
    private int defaultWidth;
    private int defaultHeight;
    private int width;
    private int height;
    private Color defaultBackground = Color.White;
    private Color background;

    public int DefaultWidth() { return defaultWidth; }
    public int DefaultHeight() { return defaultHeight; }
    public Color DefaultBackground() { return defaultBackground; }

    public int Width() { return width; }
    public int Height() { return height; }
    public Color Background() { return background; }
    
    public Canvas canvas;
    public Ascii ascii;
}