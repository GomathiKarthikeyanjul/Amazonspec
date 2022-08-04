using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using AmazonProject.Drivers;

namespace AmazonProject.PageObjects
{
     public class CreateAccountPage
    {
        private IWebDriver _driver;
        private BrowserInstance _browserInstance;
        public CreateAccountPage(BrowserInstance browserInstance)
        {
            _driver = browserInstance.Driver();
            _browserInstance = browserInstance;
        }

        IWebElement fullName => _driver.FindElement(By.Id("ap_customer_name"));
        IWebElement mobileNumber => _driver.FindElement(By.Id("ap_phone_number"));
        IWebElement email => _driver.FindElement(By.Id("ap_email"));

        IWebElement password => _driver.FindElement(By.Id("ap_password"));
        IWebElement continuePage => _driver.FindElement(By.Id("continue"));

        public void EnterFullName(String fullname) => fullName.SendKeys(fullname);

        public void EnterMobile(String mobile) => mobileNumber.SendKeys(mobile);
        public void EnterEmail(string fullName)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(0, 1000);
            email.SendKeys(fullName.Replace(" ","_").ToLower() + randomInt + "@gmail.com");
        }
         
        public void EnterPassword(String pass) => password.SendKeys(pass);
        public void ClickContinue() => continuePage.Click();

    }
}
