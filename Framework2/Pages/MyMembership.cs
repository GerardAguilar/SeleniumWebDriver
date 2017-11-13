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
            By element = By.XPath(".//h1[contains(text(),'My Membership')]");

            return Browser.WaitUntilELementIsDisplayed(element, PAGE_LOAD_TIMEOUT);
        }

        public void EditProfile() {
            //var editProfile = Browser.Driver.FindElement(By.LinkText("Edit Profile"));
            var editProfile = Browser.FindElement(By.LinkText("Edit Profile"));
            editProfile.Click();
        }

    }
}