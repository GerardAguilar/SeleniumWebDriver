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
        public void GivenValidUser_SuccessfullyLogin() 
        {
            Pages.Login.Goto();
            Pages.Login.Login("gerard.aguilar@live.com", "EmberMachina1!");
            Assert.IsTrue(Pages.MyMembership.IsAt(), "A valid user was not able to successfully log in.");

            Pages.MyMembership.EditProfile();
            //Assert.IsTrue(Pages.EditProfile.IsAt(), "The user was not able to view the Edit Profile page");
        }

        [TestMethod]
        public void GivenInvalidUser_UnsuccessfullyLogin()
        {
            Pages.Login.Goto();
            Pages.Login.Login("invaliduser", "EmberMachina1!");
            Assert.IsTrue(Pages.Login.ErrorLogin(), "A valid user name did not lead to the error login page.");
            
        }

        [TestMethod]
        public void StringSearchTest() {
            string searchString = "Selenium";
            Assert.IsTrue(Pages.SearchText(searchString),searchString+" could not be found in the page");
            
        }


    }
}
