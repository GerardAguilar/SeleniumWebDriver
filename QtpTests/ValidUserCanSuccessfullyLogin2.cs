using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace QtpTests
{
    [TestClass]
    public class ValidUserCanSuccessfullyLogin2
    {
        static ChromeDriver _driver = new ChromeDriver();

        [TestMethod]
        public void TestMethod3()
        {
            _driver.Navigate().GoToUrl("https://www.qtptutorial.net/wp-login.php");

            SendKeys("user_login", "seleniumTestUser");
            SendKeys("user_pass", "Test12345!!$");

            //var _user = _driver.FindElement(By.Id("user_login"));
            //_user.Clear();
            //_user.SendKeys("seleniumTestUser");

            //var _pass = _driver.FindElement(By.Id("user_pass"));
            //_pass.Clear();
            //_pass.SendKeys("Test12345!!$");

            _driver.FindElement(By.Id("wp-submit")).Click();

        }

        public void SendKeys(string id, string value) {
            var _pass = _driver.FindElement(By.Id(id));
            _pass.Clear();
            _pass.SendKeys(value);
        }

        public void ClickButton(string id) {
            _driver.FindElement(By.Id(id));
        }
    }
}
