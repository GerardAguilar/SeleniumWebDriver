using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Framework2
{
    //the class that interacts with the web browser
    public static class Browser
    {
        private static IWebDriver _webDriver;
        private static string _baseUrl = "http://www.qtptutorial.net/";

        public static void Goto(string url, bool useBaseUrl = true)
        {
            if (useBaseUrl)
            {
                _webDriver.Navigate().GoToUrl(string.Format("{0}/{1}", _baseUrl, url));
            }
            else {
                _webDriver.Navigate().GoToUrl(string.Format("{0}", url));
            }
            
        }

        internal static IWebElement FindElement(By by)
        {
            return _webDriver.FindElement(by);
        }

        internal static void SwitchTabs(int tabIndex)
        {
            var windows = _webDriver.WindowHandles;

            _webDriver.SwitchTo().Window(windows[tabIndex]);
        }

        internal static bool WaitUntilELementIsDisplayed(By element, int timeoutInSeconds)
        {
            for (int i = 0; i < timeoutInSeconds; i++) {
                if (ElementIsDisplayed(element))
                {
                    return true;
                }
                else {
                    Thread.Sleep(1000);
                }
            }
            return false;

            

        }

        public static bool ElementIsDisplayed(By element)
        {
            var present = false;
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            try
            {
                present = _webDriver.FindElement(element).Displayed;
            }
            catch (NoSuchElementException)
            {

            }
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            return present;
        }

        public static ISearchContext Driver { get { return _webDriver; } }

        public static string Title { get { return _webDriver.Title; } }

        public static void Initialize() {
            //_webDriver = GetDriver(Drivers.Chrome);
            _webDriver = new ChromeDriver();
            //_webDriver.Navigate().GoToUrl(_baseUrl);
            Goto("");
        }

       

        public static void Close() {
            _webDriver.Close();
        }
    }
}