public interface IDocumentProcessing
{
    void Accept(IDocumentVisitor visitor);
}

public class TextFile : IDocumentProcessing
{
    public void Accept(IDocumentVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class SpreadSheet : IDocumentProcessing
{
    public void Accept(IDocumentVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class Presentation : IDocumentProcessing
{
    public void Accept(IDocumentVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public interface IDocumentVisitor
{
    void Visit(TextFile file);
    void Visit(SpreadSheet file);
    void Visit(Presentation file);
}

public class CountingWordsVisitor : IDocumentVisitor
{
    public void Visit(TextFile file)
    {
        Console.WriteLine("cont words for text file");
    }

    public void Visit(SpreadSheet file)
    {
        Console.WriteLine("cont words for spread sheet file");
    }

    public void Visit(Presentation file)
    {
        Console.WriteLine("cont words for presentation file");
    }
}

public class ExtractTextVisitor : IDocumentVisitor
{
    public void Visit(TextFile file)
    {
        Console.WriteLine("text extracted from text file");
    }

    public void Visit(SpreadSheet file)
    {
        Console.WriteLine("text extracted from spread sheet file");
    }

    public void Visit(Presentation file)
    {
        Console.WriteLine("text extracted from presentation file");
    }
}

public class FormatTextVisitor : IDocumentVisitor
{
    public void Visit(TextFile file)
    {
        Console.WriteLine("format text for text file");
    }

    public void Visit(SpreadSheet file)
    {
        Console.WriteLine("format text for spread sheet file");
    }

    public void Visit(Presentation file)
    {
        Console.WriteLine("format text for presentation file");
    }
}

public class Program
{
    public static void Main()
    {
        var files = new List<IDocumentProcessing> { new TextFile(), new SpreadSheet(), new Presentation() };

        files.ForEach(x => {
            x.Accept(new CountingWordsVisitor());
            x.Accept(new ExtractTextVisitor());
            x.Accept(new FormatTextVisitor());
        });
    }
}