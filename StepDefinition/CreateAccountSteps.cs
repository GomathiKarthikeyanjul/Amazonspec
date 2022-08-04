
using System.Threading;
using TechTalk.SpecFlow;
using AmazonProject.Drivers;

namespace AmazonProject.StepDefinition
{
    [Binding]
    public class CreateAccountSteps : StepDefinitionBase
    {
        private BrowserInstance _browserInstance;

        public CreateAccountSteps(BrowserInstance browserInstance) : base(browserInstance)
        {
            _browserInstance = browserInstance;
        }


        [Then(@"Navigate to create account page")]
        public void ThenNavigateToCreateAccountPage()
        {

            LoginPage.ClickCreateAccount();
        }

        [Then(@"user provide the email using (.*) in correct format")]
        public void ThenUserProvideTheEmailUsingInCorrectFormat(string name)
        {
            CreateAccount.EnterEmail(name);
            Thread.Sleep(3000);
        }
        
        [Then(@"user provide the (.*) full name of customer")]
        public void ThenUserProvideTheFullNameOfCustomer(string fullName)
        {
            CreateAccount.EnterFullName(fullName);
        }
        
        [Then(@"user provide the (.*) mobile number of customer")]
        public void ThenUserProvideTheMobileNumberOfCustomer(string mobileNumber)
        {
            CreateAccount.EnterMobile(mobileNumber);
        }
        
        [Then(@"user provide the (.*) password for customer")]
        public void ThenUserProvideThePasswordForCustomer(string password)
        {
            CreateAccount.EnterPassword(password);
        }
        
        [Then(@"user click on create button")]
        public void ThenUserClickOnCreateButton()
        {
            CreateAccount.ClickContinue();
            Thread.Sleep(5000);

        }

        [When(@"Click on the sign in link")]
        public void WhenClickOnTheSignInLink()
        {
            LoginPage.ClickLoginLink();
        }

        [Then(@"user should be able to view the sign in text")]
        public void ThenUserShouldBeAbleToViewTheSignInText()
        {
            LoginPage.VerifySignInText();
        }

    }
}
