using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using AmazonProject.Drivers;

namespace AmazonProject.PageObjects
{
    public class Homepage
    {
        private IWebDriver _driver;
        private BrowserInstance _browserInstance;
        public Homepage(BrowserInstance browserInstance)
        {
            _driver = browserInstance.Driver();
            _browserInstance = browserInstance;
        }

        IWebElement SearchTab => _driver.FindElement(By.Id("twotabsearchtextbox"));

        IList<IWebElement> toolBarItems => _driver.FindElements(By.XPath("//*[@id='nav-xshop']/a"));

        IList<IWebElement> amazonPayHeaderValues => _driver.FindElements(By.XPath("//*[@class='slot-headertext-desktop']"));   

        

        IWebElement SearchDropdownBox => _driver.FindElement(By.Id("searchDropdownBox"));

        IWebElement SearchDropdownText => _driver.FindElement(By.Id("nav-search-label-id"));

        IWebElement SearchButton => _driver.FindElement(By.Id("nav-search-submit-text"));

        IWebElement SearchResult => _driver.FindElement(By.XPath("//*[@id='search']/span/div/h1/div/div[1]/div/div/span[3]"));

        IWebElement AmazonPay => _driver.FindElement(By.XPath("//*[contains(text(),'Amazon Pay')]"));

        public void NavigateToAmazon()
        {
            
            _driver.Navigate().GoToUrl("https://www.amazon.in/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.Manage().Window.Maximize();
        }


        public void ClickSearchTab() => SearchTab.Click();

        public void EnterSearchText(String text) => SearchTab.SendKeys(text);

     

        public void ClickAmazonPay()
        {
            AmazonPay.Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void ClickSearchButton() => SearchButton.Click();

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


        public IList<String> VerifyToolbar()
        {
            IList<string> listString = new List<string>();
            foreach(WebElement value in toolBarItems)
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
