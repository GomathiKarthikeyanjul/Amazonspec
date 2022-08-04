using AmazonProject.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using AmazonProject.Drivers;

namespace AmazonProject.StepDefinition
{
    [Binding]
    public class HomepageSteps :StepDefinitionBase
    {
        private BrowserInstance _browserInstance;

        public HomepageSteps(BrowserInstance browserInstance) : base(browserInstance)
        { 
            _browserInstance = browserInstance;
        }
            

        [Given(@"Navigate to amazon url")]
        public void GivenNavigateToAmazonUrl()
        {
            Homepage.NavigateToAmazon();
        }

        [When(@"Search for a text (.*)")]
        public void WhenSearchForAText(string searchText)
        {
            Homepage.EnterSearchText(searchText);
            Thread.Sleep(2000);
        }

        [Then(@"user click on the Search button")]
        public void ThenUserClickOnTheSearchButton()
        {
            Homepage.ClickSearchButton();
        }

        [Then(@"user should be able to see the reuslts for the  (.*)")]
        public void ThenUserShouldBeAbleToSeeTheReusltsForThe(string searchText)
        {
            Assert.AreEqual(searchText, Homepage.VerifySearchResult());
        }

        [Then(@"user should be able to select each value present in search dropdown")]
        public void ThenUserShouldBeAbleToSelectEachValuePresentInSearchDropdown()
        {                         
                Assert.IsTrue(Homepage.SelectValueFromDropdown().Contains(Homepage.VerifySelectedValue()));            
        }

        [Given(@"amazon homepage toolbar contains the following values")]
        public void GivenAmazonHomepageToolbarContainsTheFollowingValues(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                foreach (String value in row.Values)
                {                  
                       Assert.IsTrue(Homepage.VerifyToolbar().Contains(value));                    
                }
            }
        }

        [When(@"user click on AmazonPay")]
        public void WhenUserClickOnAmazonPay()
        {
            Homepage.ClickAmazonPay();
        }

        [Then(@"user should see be able the following header values")]
        public void ThenUserShouldSeeBeAbleTheFollowingHeaderValues(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                foreach (String value in row.Values)
                {
                    Assert.IsTrue(Homepage.VerifyAmazonPayHeader().Contains(value));
                }
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    }

