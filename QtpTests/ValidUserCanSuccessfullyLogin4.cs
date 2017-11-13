using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Framework2.Pages;

namespace QtpTests
{
    [TestClass]
    public class ValidUserCanSuccessfullyLogin4 : TestBase
    {
        [TestMethod]
        public void RunTest() {
            Pages.Login.Goto();
            Pages.Login.Login("seleniumTestUser", "Test12345!!$");
            Assert.IsTrue(Pages.MyMembership.IsAt(), "A valid user was not able to successfully log in.");
        }

        [TestMethod]
        public void StringSearchTest() {
            string searchString = "Selenium";
            Assert.IsTrue(Pages.SearchText(searchString),searchString+" could not be found in the page");
            
        }
    }
}
