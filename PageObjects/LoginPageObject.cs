using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonProject.PageObjects
{
    public class LoginPageObject
    {
        private IWebDriver Driver;

        public LoginPageObject(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement createAccountButton => Driver.FindElement(By.Id("createAccountSubmit"));

      

        public void ClickCreateAccount() => createAccountButton.Click();

    }
}


