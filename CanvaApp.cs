namespace Lab_02_Analyse;

public class CanvaApp : Application
{
    public override List<Document> CreateDocument()
    {
        Document.Clear();
        Document.Add(new CanvaDoc());
        return Document;
    }

    public override List<Factory> CreateFactory()
    {
        Factory.Clear();
        Factory.Add(new CanvaFactory());
        return Factory;
    }
}