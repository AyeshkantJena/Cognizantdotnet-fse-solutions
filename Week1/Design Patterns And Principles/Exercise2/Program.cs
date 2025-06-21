using System;

// Step 2: Define the document interface
public interface IDocument
{
    void Open();
}

// Step 3: Concrete document classes
public class WordDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening Word Document...");
    }
}

public class PdfDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening PDF Document...");
    }
}

public class ExcelDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening Excel Document...");
    }
}

// Step 4: Abstract Factory
public abstract class DocumentFactory
{
    public abstract IDocument CreateDocument();
}

// Concrete factories for each document type
public class WordDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}

public class PdfDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new PdfDocument();
    }
}

public class ExcelDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new ExcelDocument();
    }
}

// Step 5: Test the Factory Method Implementation
public class Program
{
    public static void Main(string[] args)
    {
        // Create a Word document using the factory
        DocumentFactory wordFactory = new WordDocumentFactory();
        IDocument wordDoc = wordFactory.CreateDocument();
        wordDoc.Open();

        // Create a PDF document using the factory
        DocumentFactory pdfFactory = new PdfDocumentFactory();
        IDocument pdfDoc = pdfFactory.CreateDocument();
        pdfDoc.Open();

        // Create an Excel document using the factory
        DocumentFactory excelFactory = new ExcelDocumentFactory();
        IDocument excelDoc = excelFactory.CreateDocument();
        excelDoc.Open();
    }
}
