using SimpleHtmlBuilderCSharp;

HtmlPage htmlPage = new HtmlBuilder()
                .AddTitle("Builder Pattern")
                .AddHeader1("1. Definition:")
                .AddParagraph("The builder pattern separates the construction of a complex object from its representation...")
                .AddHeader1("2. Class Diagram:")
                .AddHeader2("2.1 Conceptual Diagram")
                .AddParagraph("TODO: Add Conceptual Class Diagram here...")
                .AddHeader2("2.2 HTML Use Case Diagram")
                .AddParagraph("TODO: Add HTML Use Case Class Diagram here...")
                .Build();

Console.WriteLine(htmlPage);
