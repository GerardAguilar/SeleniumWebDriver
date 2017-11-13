using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Framework2.Pages;

namespace QtpTests
{
    [TestClass]
    public class ValidUserCanSuccessfullyAccessEditProfilePage : TestBase
    {
        [TestMethod]
        public void RunTest() 
        {
            Pages.Login.Goto();
            Pages.Login.Login("gerardaguilar", "R1singWind!");
            Assert.IsTrue(Pages.MyMembership.IsAt(), "A valid user was not able to successfully log in.");

            Pages.MyMembership.EditProfile();
            Assert.IsTrue(Pages.EditProfile.IsAt(), "The user was not able to view the Edit Profile page");
        }

        [TestMethod]
        public void RunTest2()
        {
            Pages.Login.Goto();
            Pages.Login.Login("gerardaguilar", "R1singWind!");
            Assert.IsTrue(Pages.Login.ErrorLogin(), "A valid user name did not lead to the error login page.");
            
        }

        [TestMethod]
        public void StringSearchTest() {
            string searchString = "Selenium";
            Assert.IsTrue(Pages.SearchText(searchString),searchString+" could not be found in the page");
            
        }


    }
}
