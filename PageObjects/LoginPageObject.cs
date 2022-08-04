using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using AmazonProject.Drivers;

namespace AmazonProject.PageObjects
{
    public class LoginPageObject
    {
        private IWebDriver _driver;
        private BrowserInstance _browserInstance;
        public LoginPageObject(BrowserInstance browserInstance)
        {
            _driver = browserInstance.Driver();
            _browserInstance = browserInstance;
        }


        IWebElement createAccountButton => _driver.FindElement(By.Id("createAccountSubmit"));

        IWebElement Login => _driver.FindElement(By.Id("nav-link-accountList"));

        IWebElement LoginText => _driver.FindElement(By.XPath("//*[contains(text(),'Sign-In')]"));


        public void ClickLoginLink() => Login.Click();
        public void ClickCreateAccount() => createAccountButton.Click();

        public String VerifySignInText()
        {
            String signinText = LoginText.Text;
            return signinText;
        }

    }
}


