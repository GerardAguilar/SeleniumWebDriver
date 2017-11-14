using OpenQA.Selenium;
using System;

namespace Framework2.Pages
{
    public class LoginPage
    {
        public void Goto()
        {
            Browser.Goto("login");
        }

        public void Login(string userName, string password)
        {
            var user = Browser.FindElement(By.Id("login_email"));
            user.Clear();
            user.SendKeys(userName);
            //SendKeys("user_login", userName);

            var pass = Browser.FindElement(By.Id("login_password"));
            pass.Clear();
            pass.SendKeys(password);
            //SendKeys("user_pass", password);

            //ClickButton("wp-submit");
            Browser.FindElement(By.Id("login_submit")).Click();

        }

        public bool ErrorLogin() 
        {
            //check for error
            var errorElement = Browser.FindElement(By.Id("login_error"));            
            if (errorElement != null) {
                return true;
            }
            return false;
        }

        public string ErrorMessage()
        {
            //display error
            //var errorMessage = Browser.FindElement(By.Id("login_error")).Text;
            var errorMessage = Browser.FindElement(By.XPath(".//*[contains(text(),'Invalid Login')]")).Text;
            return errorMessage;
        }


    }
}