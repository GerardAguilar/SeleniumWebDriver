using OpenQA.Selenium;
using System.Threading;

namespace Framework2.Pages
{
    public class MyMembershipPage
    {

        private static int PAGE_LOAD_TIMEOUT = 10;

        public bool IsAt() {
            ////Implicit wait Sleeps for 10s
            //Thread.Sleep(10000);
            //(Browser.Title.Contains("My Membership"));
            By element = By.XPath(".//h2[contains(text(),'Basic Information')]");

            return Browser.WaitUntilELementIsDisplayed(element, PAGE_LOAD_TIMEOUT);
        }

        public void EditProfile() {
            //var editProfile = Browser.Driver.FindElement(By.LinkText("Edit Profile"));
            var editProfile = Browser.FindElement(By.LinkText("Manage account"));
            editProfile.Click();
            var editPreferences = Browser.FindElement(By.LinkText("Edit preferences"));
            editPreferences.Click();
            var pass = Browser.FindElement(By.Id("forum_signature"));
            pass.Clear();
            pass.SendKeys("How about a burger at Shake Shack?");
            var submit = Browser.FindElement(By.Id("submit"));
            submit.Click();
            Browser.FindElement(By.LinkText("Continue")).Click();
        }

    }
}