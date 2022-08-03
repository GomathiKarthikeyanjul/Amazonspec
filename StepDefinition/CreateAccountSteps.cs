using AmazonProject.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
namespace AmazonProject.StepDefinition
{
    [Binding]
    public class CreateAccountSteps
    {
        private DriverHelper _driverHelper;
        CreateAccountPage createAccount;
        LoginPageObject loginPage;

        public CreateAccountSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            createAccount = new CreateAccountPage(_driverHelper.Driver);
        }

        [Then(@"Navigate to create account page")]
        public void ThenNavigateToCreateAccountPage()
        {
            loginPage = new LoginPageObject(_driverHelper.Driver);
            loginPage.ClickCreateAccount();
        }

        [Then(@"user provide the email using (.*) in correct format")]
        public void ThenUserProvideTheEmailUsingInCorrectFormat(string name)
        {
            createAccount.EnterEmail(name);
            Thread.Sleep(3000);
        }
        
        [Then(@"user provide the (.*) full name of customer")]
        public void ThenUserProvideTheFullNameOfCustomer(string fullName)
        {
            createAccount.EnterFullName(fullName);
        }
        
        [Then(@"user provide the (.*) mobile number of customer")]
        public void ThenUserProvideTheMobileNumberOfCustomer(string mobileNumber)
        {
            createAccount.EnterMobile(mobileNumber);
        }
        
        [Then(@"user provide the (.*) password for customer")]
        public void ThenUserProvideThePasswordForCustomer(string password)
        {
            createAccount.EnterPassword(password);
        }
        
        [Then(@"user click on create button")]
        public void ThenUserClickOnCreateButton()
        {
            createAccount.ClickContinue();
            Thread.Sleep(5000);

        }
    }
}
