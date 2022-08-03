using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonProject.PageObjects
{
    public class Homepage
    {
        private IWebDriver Driver;

        public Homepage(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement SearchTab => Driver.FindElement(By.Id("twotabsearchtextbox"));

        IWebElement Login => Driver.FindElement(By.Id("nav-link-accountList"));

        IWebElement LoginText => Driver.FindElement(By.XPath("//*[contains(text(),'Sign-In')]"));

        IList<IWebElement> toolBarItems => Driver.FindElements(By.XPath("//*[@id='nav-xshop']/a"));

        IWebElement AmazonPay => Driver.FindElement(By.XPath("//*[contains(text(),'Amazon Pay')]"));
        IList<IWebElement> amazonPayHeaderValues => Driver.FindElements(By.XPath("//*[@class='slot-headertext-desktop']"));

        IWebElement SearchDropdownBox => Driver.FindElement(By.Id("searchDropdownBox"));

        IWebElement SearchDropdownText => Driver.FindElement(By.Id("nav-search-label-id"));

        IWebElement SearchButton => Driver.FindElement(By.Id("nav-search-submit-text"));

        IWebElement SearchResult => Driver.FindElement(By.XPath("//*[@id='search']/span/div/h1/div/div[1]/div/div/span[3]"));
        public void ClickSearchTab() => SearchTab.Click();

        public void EnterSearchText(String text) => SearchTab.SendKeys(text);

        public void ClickLoginLink() => Login.Click();

        public void ClickSearchButton() => SearchButton.Click();

        public void ClickAmazonPay()
        {
            AmazonPay.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public String VerifySearchResult()
        {
            String searchResult = SearchResult.Text.Replace('"', ' ').Trim();
            return searchResult;
        }

        public String SelectValueFromDropdown()
        {
            SelectElement dropdown = new SelectElement(SearchDropdownBox);
            string valueName = "";
            foreach (IWebElement option in dropdown.Options)
            {
                option.Click();
                valueName = option.Text.ToString();

            }
            return valueName;
        }

        public String VerifySelectedValue()
        {
            string selectedValue = SearchDropdownText.Text.ToString();
            return selectedValue;
        }

        public String VerifySignInText()
        {
            String signinText = LoginText.Text;
            return signinText;
        }
        public IList<String> VerifyToolbar()
        {
            IList<string> listString = new List<string>();
            foreach (WebElement value in toolBarItems)
            {
                listString.Add(value.Text);
            }
            return listString;
        }
        public IList<String> VerifyAmazonPayHeader()
        {
            IList<string> listString = new List<string>();
            foreach (WebElement value in amazonPayHeaderValues)
            {
                listString.Add(value.Text);
            }
            return listString;
        }
    }
}

