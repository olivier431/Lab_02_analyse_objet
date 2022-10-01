using System.Collections;

namespace Lab_02_Analyse;

public abstract class Application
{
    public List<Document> Document = new ();
    public List<Factory> Factory = new ();
    public abstract List<Document> CreateDocument();
    public abstract List<Factory> CreateFactory();

}