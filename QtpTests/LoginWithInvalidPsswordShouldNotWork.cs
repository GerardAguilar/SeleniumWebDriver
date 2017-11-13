using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Framework2.Pages;

namespace QtpTests
{
    [TestClass]
    public class LoginWithInvalidPsswordShouldNotWork : TestBase
    {
        [TestMethod]
        public void TestMethod2()
        {
            Pages.Login.Goto();

            //var _driver = new ChromeDriver();
            //_driver.Navigate().GoToUrl("https://www.qtptutorial.net/wp-login.php");

            Pages.Login.Login("seleniumTestUser", "SeleniumRocksMySocks");
            //var _user = _driver.FindElement(By.Id("user_login"));
            //_user.Clear();
            //_user.SendKeys("InvalidUsername");

            //var _pass = _driver.FindElement(By.Id("user_pass"));
            //_pass.Clear();
            //_pass.SendKeys("Test12345!!$");

            Assert.IsFalse(Pages.MyMembership.IsAt());
            //_driver.FindElement(By.Id("wp-submit")).Click();

            //var error = _driver.FindElement(By.Id("login_error"));
            //Assert.IsTrue(error.Displayed, "The error message for a user with an invalid user name was not displayed");
        }
    }
}
