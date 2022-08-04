using AmazonProject.PageObjects;
using AmazonProject.Drivers;

namespace AmazonProject.StepDefinition
{
    public class StepDefinitionBase
    {
        private BrowserInstance _browserInstance;

        Homepage _homepage;
        CreateAccountPage _createAccount;
        LoginPageObject _loginPage;

        public StepDefinitionBase(BrowserInstance browserInstance)
        {           
            _browserInstance = browserInstance;
        }

        protected Homepage Homepage => _homepage ?? (_homepage = new Homepage(_browserInstance));

        protected CreateAccountPage CreateAccount => _createAccount ?? (_createAccount = new CreateAccountPage(_browserInstance));

        protected LoginPageObject LoginPage => _loginPage ?? (_loginPage = new LoginPageObject(_browserInstance));

    }
}
