using System.Text;

namespace SimpleHtmlBuilderCSharp
{
    public class HtmlPage
    {
        private StringBuilder _htmlStringBuilder = new StringBuilder();

        public string Title { get; set; }
        public List<HtmlElement> Elements { get; set; } = new List<HtmlElement>();

        public override string ToString()
        {
            _htmlStringBuilder
                .AppendLine("<!DOCTYPE html>")
                .AppendLine("<html>");

            AddTitle();
            AddBody();

            _htmlStringBuilder.AppendLine("</html>");

            return _htmlStringBuilder.ToString();
        }

        private void AddTitle()
        {
            if (string.IsNullOrEmpty(Title)) return;

            _htmlStringBuilder.AppendLine("<head>")
                .Append("<title>")
                .Append(Title)
                .AppendLine("</title>")
                .AppendLine("</head>");

        }

        private void AddBody()
        {
            if (Elements == null || !Elements.Any()) return;

            _htmlStringBuilder.AppendLine("<body>");

            foreach (HtmlElement element in Elements)
            {
                _htmlStringBuilder.AppendLine(element.ToString());
            }

            _htmlStringBuilder.AppendLine("</body>");
        }
    }

}