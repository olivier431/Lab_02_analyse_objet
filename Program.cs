using Lab_02_Analyse;
public class Program
{
    static void Main(string[] args)
    {
        List<Application> currentApp = new List<Application>();
        string choix = "";
        string choixEdit = "";
        do
        {
            Console.WriteLine("1- Créer un document Canva");
            Console.WriteLine("2- Créer un document Ascii");
            Console.WriteLine("3- Modifier le dernier Document");
            Console.WriteLine("4- Sauvegarder");
            Console.WriteLine("5- Quitter");

            choix = Console.ReadLine();
            if (choix == "1" || choix == "2")
            {
                if (choix == "1")
                {
                    currentApp.Clear();
                    currentApp.Add(new CanvaApp());
                }
                else if (choix == "2")
                {
                    currentApp.Clear();
                    currentApp.Add(new AsciiApp());
                }

                currentApp.First().CreateDocument();
                currentApp.First().CreateFactory();
            }
            else if (choix == "3")
            {

                do
                {
                    Console.WriteLine("1- un point");
                    Console.WriteLine("2- une Ligne");
                    Console.WriteLine("3- une ligne horizontal");
                    Console.WriteLine("4- une ligne vertical");
                    Console.WriteLine("5- un rectangle (ou carré ou polygon)");
                    Console.WriteLine("6- un cercle");
                    Console.WriteLine("7- un triangle");
                    Console.WriteLine("8- Quitter");
                    
                    choixEdit = Console.ReadLine();
                    if (choixEdit == "1")
                    {
                        Console.WriteLine("point -> X");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("point -> Y");
                        int y1 = int.Parse(Console.ReadLine());
                        currentApp.First().Factory.First().addPoint(x1, y1);
                    }
                    else if (choixEdit == "2")
                    {
                        Console.WriteLine("Debut ligne -> X");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Debut ligne -> Y");
                        int y1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Fin ligne -> X");
                        int x2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Fin ligne -> Y");
                        int y2 = int.Parse(Console.ReadLine());
                        currentApp.First().Factory.First().addLine(x1, y1, x2, y2);
                    }
                    else if (choixEdit == "3")
                    {
                        Console.WriteLine("Debut ligne -> X");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Debut ligne -> Y");
                        int y1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Longueur de la ligne");
                        int width = int.Parse(Console.ReadLine());
                        currentApp.First().Factory.First().addHLine(x1, y1, width);
                    }
                    else if (choixEdit == "4")
                    {
                        Console.WriteLine("Debut ligne -> X");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Debut ligne -> Y");
                        int y1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("hauteur de la ligne");
                        int height = int.Parse(Console.ReadLine());
                        currentApp.First().Factory.First().addHLine(x1, y1, height);
                    }
                    else if (choixEdit == "5")
                    {
                        Console.WriteLine("point -> X");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("point -> Y");
                        int y1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("point -> X");
                        int x2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("point -> Y");
                        int y2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("point -> X");
                        int x3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("point -> Y");
                        int y3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("point -> X");
                        int x4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("point -> Y");
                        int y4 = int.Parse(Console.ReadLine());
                        currentApp.First().Factory.First().addRectangle(x1, y1, x2, y2, x3, y3, x4, y4);
                    }
                    else if (choixEdit == "6")
                    {
                        Console.WriteLine("Centre -> X");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Centre -> Y");
                        int y1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("rayon du cercle");
                        int radius = int.Parse(Console.ReadLine());
                        currentApp.First().Factory.First().addCircle(x1, y1, radius);
                    }
                    else if (choixEdit == "7")
                    {
                        Console.WriteLine("Point - > X");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Point - > Y");
                        int y1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Point - > X");
                        int x2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Point - > Y");
                        int y2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Point - > X");
                        int x3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Point - > Y");
                        int y3 = int.Parse(Console.ReadLine());
                        currentApp.First().Factory.First().addTriangle(x1, y1, x2, y2, x3, y3);
                    }
                    else
                    {
                        Console.WriteLine("INVALID");
                    }
                } while (choixEdit == "8");
            }
            else if (choix == "4")
            {
                currentApp.First().Factory.First().saveFile(currentApp.First().Document.First());
            }
            else
            {
                Console.WriteLine("INVALID");
            }
        } while (choix == "5");
    }
}