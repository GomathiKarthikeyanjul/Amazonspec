using AmazonProject.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AmazonProject.StepDefinition
{
    [Binding]
    public class HomepageSteps
    {
        private DriverHelper _driverHelper;
        Homepage homePage;

        public HomepageSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new Homepage(_driverHelper.Driver);
        }


        [Given(@"Navigate to amazon url")]
        public void GivenNavigateToAmazonUrl()
        {
            _driverHelper.Driver.Navigate().GoToUrl("https://www.amazon.in/");
        }

        [When(@"Search for a text (.*)")]
        public void WhenSearchForAText(string searchText)
        {
            homePage.EnterSearchText(searchText);
            Thread.Sleep(2000);
        }

        [Then(@"user click on the Search button")]
        public void ThenUserClickOnTheSearchButton()
        {
            homePage.ClickSearchButton();
        }

        [Then(@"user should be able to see the reuslts for the  (.*)")]
        public void ThenUserShouldBeAbleToSeeTheReusltsForThe(string searchText)
        {
            Assert.AreEqual(searchText, homePage.VerifySearchResult());
        }

        [Then(@"user should be able to select each value present in search dropdown")]
        public void ThenUserShouldBeAbleToSelectEachValuePresentInSearchDropdown()
        {
            Assert.IsTrue(homePage.SelectValueFromDropdown().Contains(homePage.VerifySelectedValue()));
        }
        [When(@"Click on the sign in link")]
        public void WhenClickOnTheSignInLink()
        {
            homePage.ClickLoginLink();
            Thread.Sleep(3000);
        }
        [Then(@"user should be able to view the sign in text")]
        public void ThenUserShouldBeAbleToViewTheSignInText()
        {
            Assert.That("Sign-In", Is.EqualTo(homePage.VerifySignInText()));
            Thread.Sleep(5000);

        }

        [Given(@"amazon homepage toolbar contains the following values")]
        public void GivenAmazonHomepageToolbarContainsTheFollowingValues(Table table)
        {
            _driverHelper.Driver.Navigate().GoToUrl("https://www.amazon.in/");
            foreach (TableRow row in table.Rows)
            {
                foreach (String value in row.Values)
                {
                    Assert.IsTrue(homePage.VerifyToolbar().Contains(value));
                }
            }
        }

        [When(@"user click on AmazonPay")]
        public void WhenUserClickOnAmazonPay()
        {
            homePage.ClickAmazonPay();
        }

        [Then(@"user should see be able the following header values")]
        public void ThenUserShouldSeeBeAbleTheFollowingHeaderValues(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                foreach (String value in row.Values)
                {
                    Assert.IsTrue(homePage.VerifyAmazonPayHeader().Contains(value));
                }
            }
        }



    }
}
