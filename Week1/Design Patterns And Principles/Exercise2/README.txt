Logic For Exercise 2
----------------------

Step 1: Interface and Concrete Classes
An interface IDocument is defined with a method Open().

Three concrete classes (WordDocument, PdfDocument, and ExcelDocument) implement this interface and provide their specific version of the Open() method.

Step 2: Abstract Factory Setup
An abstract class DocumentFactory is defined with an abstract method CreateDocument().

This enforces that every subclass (factory) must implement how to create a specific type of document.

Step 3: Concrete Factory Implementations
Three factory classes (WordDocumentFactory, PdfDocumentFactory, ExcelDocumentFactory) inherit from DocumentFactory.

Each of them overrides CreateDocument() to return a new instance of their specific document type.

Step 4: Execution in Main() Method

	Word Document Creation

	A WordDocumentFactory is instantiated.

		CreateDocument() is called, which returns a WordDocument.

		The Open() method is called on the document: Opening Word Document... is printed.

	PDF Document Creation

		A PdfDocumentFactory is used similarly.

		It returns a PdfDocument, and its Open() method prints: Opening PDF Document...

	Excel Document Creation

		ExcelDocumentFactory creates an ExcelDocument.

		Calling Open() results in: Opening Excel Document...

----------------------------------------------------------------------