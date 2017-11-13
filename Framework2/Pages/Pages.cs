using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework2.Pages
{
    public static partial class Pages
    {
        private static T GetPage<T>() where T: new(){
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        //Login page object, not the method
        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static MyMembershipPage MyMembership 
        { 
            get { return GetPage<MyMembershipPage>(); } 
        }

        public static BrowserTestsPage BrowserTests
        { 
            get { return GetPage<BrowserTestsPage>(); }
        }

        //why are these names so ambiguous?
        //also, couldn't we have created an automata for navigation
        public static EditProfilePage EditProfile { 
            get 
            { 
                return GetPage<EditProfilePage>(); 
            } 
        }

        public static bool SearchText(string searchString)
        {
            IWebElement elementWithString = Browser.FindElement(By.XPath(".//*[contains(text(),'" + searchString + "')]"));
            bool returnValue = false;
            if (elementWithString != null)
            {
                returnValue = true;
            }
            return returnValue;
        }
    }
}