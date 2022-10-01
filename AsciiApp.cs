namespace Lab_02_Analyse;

public class AsciiApp : Application
{
    public override List<Document> CreateDocument()
    {
        List<Document> new_document = new ();
        new_document.Add(new AsciiDoc());
        Document.Clear();
        Document = new_document;
        return new_document;
    }

    public override List<Factory> CreateFactory()
    {
        List<Factory> new_factory = new();
        new_factory.Add(new AsciiFactory());
        Factory.Clear();
        Factory = new_factory;
        return new_factory;
    }
}