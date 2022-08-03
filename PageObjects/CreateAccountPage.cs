using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonProject.PageObjects
{
     public class CreateAccountPage
    {
        private IWebDriver Driver;
        public CreateAccountPage(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement fullName => Driver.FindElement(By.Id("ap_customer_name"));
        IWebElement mobileNumber => Driver.FindElement(By.Id("ap_phone_number"));
        IWebElement email => Driver.FindElement(By.Id("ap_email"));

        IWebElement password => Driver.FindElement(By.Id("ap_password"));
        IWebElement continuePage => Driver.FindElement(By.Id("continue"));

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

        //public void ClickEmail() => email.Click();

    }
}
