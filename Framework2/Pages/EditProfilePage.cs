using OpenQA.Selenium;

namespace Framework2.Pages
{
    public class EditProfilePage
    {
        private static int PAGE_LOAD_TIMEOUT = 10;
        public bool IsAt()
        {
            ////Implicit wait Sleeps for 10s
            //Thread.Sleep(10000);
            //(Browser.Title.Contains("My Membership"));
            By element = By.XPath(".//h1[contains(text(),'Edit Profile')]");
            if (!Browser.WaitUntilELementIsDisplayed(element, 3)) {
                Browser.SwitchTabs(1);
            }           
            return Browser.WaitUntilELementIsDisplayed(element, PAGE_LOAD_TIMEOUT);
        }


    }
}