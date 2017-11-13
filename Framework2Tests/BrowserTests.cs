using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework2;
using OpenQA.Selenium;
using QtpTests;

namespace Framework2Tests
{
    [TestClass]
    public class BrowserTests: TestBase
    {
        [TestMethod]
        public void GivenValidElement_WhenElementIsVisible_ElementIsDisplayedFindsElement()
        {
            //Browser.Goto("");
            //Browser.Goto("data:text/html,<span id=\"hello\">Hello</span>");
            //Pages.BrowserTests.Goto();
            //Browser.Initialize();
            //The problem was that the BrowserTests didn't extend TestBase
            Browser.Goto("data:text/html,<span id=\"hello\">Hello</span>", false);
            Assert.IsTrue(Browser.ElementIsDisplayed(By.Id("hello")), "ElementIsDisplayed did not find an element when it was supposed to");
        }
        [TestMethod]
        public void GivenValidElement_WhenElementIsHidden_ElementIsDisplayedDoesNotFindElement()
        {
            //Browser.Goto("");
            //Browser.Goto("data:text/html,<span id=\"hello\">Hello</span>");
            //Pages.BrowserTests.Goto();
            //Browser.Initialize();
            //The problem was that the BrowserTests didn't extend TestBase
            Browser.Goto("data:text/html,<span id=\"hello\" style=\"absolute;left:-9000px; width:0;overflo>Hello</span>", false);
            Assert.IsFalse(Browser.ElementIsDisplayed(By.Id("hello")), 
            "ElementIsDisplayed found a hidden element invalidly");
        }
        [TestMethod]
        public void GivenValidElement_WhenElementDoesNotHaveId_ElementIsDisplayedDoesNotFindElement()
        {
            //Browser.Goto("");
            //Browser.Goto("data:text/html,<span id=\"hello\">Hello</span>");
            //Pages.BrowserTests.Goto();
            //Browser.Initialize();
            //The problem was that the BrowserTests didn't extend TestBase
            Browser.Goto("data:text/html,Hello", false);
            Assert.IsFalse(Browser.ElementIsDisplayed(By.Id("hello")), 
            "ElementIsDisplayed found an element that should not have been found");
        }
    }
}
