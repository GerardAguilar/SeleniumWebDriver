namespace Framework2.Pages
{
    public class BrowserTestsPage
    {
        public void Goto()
        {
            Browser.Goto("http://www.qtptutorial.net/data:text/html,<span id=\"hello\">Hello</span>");
        }
    }
}