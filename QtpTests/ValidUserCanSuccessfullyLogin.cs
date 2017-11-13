using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace QtpTests
{
    [TestClass]
    public class ValidUserCanSuccessfullyLogin
    {
        [TestMethod]
        public void TestMethod1()
        {
            var _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.qtptutorial.net/wp-login.php");

            var _user = _driver.FindElement(By.Id("user_login"));
            _user.Clear();
            _user.SendKeys("seleniumTestUser");

            var _pass = _driver.FindElement(By.Id("user_pass"));
            _pass.Clear();
            _pass.SendKeys("Test12345!!$");

            _driver.FindElement(By.Id("wp-submit")).Click();

            //var _wait =  
        }
    }
}
