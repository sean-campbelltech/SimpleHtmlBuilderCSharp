namespace SimpleHtmlBuilderCSharp
{
    public class HtmlBuilder
    {
        private readonly HtmlPage htmlPage = new HtmlPage();

        public HtmlBuilder AddTitle(String title)
        {
            htmlPage.Title = title;
            return this;
        }

        public HtmlBuilder AddHeader1(String headerText)
        {
            htmlPage.Elements.Add(new HtmlElement("h1", headerText));
            return this;
        }

        public HtmlBuilder AddHeader2(String headerText)
        {
            htmlPage.Elements.Add(new HtmlElement("h2", headerText));
            return this;
        }

        public HtmlBuilder AddHeader3(String headerText)
        {
            htmlPage.Elements.Add(new HtmlElement("h3", headerText));
            return this;
        }

        public HtmlBuilder AddHeader4(String headerText)
        {
            htmlPage.Elements.Add(new HtmlElement("h4", headerText));
            return this;
        }

        public HtmlBuilder AddParagraph(String paragraphText)
        {
            htmlPage.Elements.Add(new HtmlElement("p", paragraphText));
            return this;
        }

        public HtmlPage Build()
        {
            return htmlPage;
        }
    }
}