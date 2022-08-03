using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using System;
using System.Configuration;
using TechTalk.SpecFlow;
using log4net;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using AmazonProject.Settings;
using AmazonProject.Configuration;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using System.Reflection;
using System.Collections.Concurrent;

//[assembly: Parallelizable(ParallelScope.Fixtures)]

namespace AmazonProject.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        
        private DriverHelper _driverHelper;
        public static ExtentTest featureName;
        [ThreadStatic]
        public ExtentTest scenario;
        public static ConcurrentDictionary<string, ExtentTest> FeatureDictionary = new ConcurrentDictionary<string, ExtentTest>();
        public static ExtentReports extent;
        public string ReportPath;
        private FeatureContext _featureContext;
        private ScenarioContext _scenarioContext;
        private static readonly ILog Logger = LogManager.GetLogger(typeof(Hooks1));
        public Hooks1(DriverHelper driverHelper) => _driverHelper = driverHelper;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            var htmlReporter = new ExtentHtmlReporter(@"D:\User\gkarthikeyan\source\repos\AmazonProject\ExtentReport.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }
        [AfterTestRun]
        public static void TearDownReport()
        {
            //Flush report once test completes
            extent.Flush();
        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            //featureName = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);
            featureName = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);
            FeatureDictionary.TryAdd(featureContext.FeatureInfo.Title, featureName);
            Console.WriteLine("BeforeFeature");
        }

        [AfterStep]
        public void InsertReportingSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            //PropertyInfo pInfo = typeof(ScenarioContext).GetProperty("TestStatus", BindingFlags.Instance | BindingFlags.NonPublic);
            //MethodInfo getter = pInfo.GetGetMethod(nonPublic: true);
            //object TestResult = getter.Invoke(ScenarioContext.Current, null);

            if (_scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (_scenarioContext.TestError != null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(_scenarioContext.TestError.InnerException);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(_scenarioContext.TestError.InnerException);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(_scenarioContext.TestError.Message);
            }



        }




        [BeforeScenario]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {

            ObjectRepository.Config = new AppConfigReader();

            _scenarioContext = scenarioContext;

            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Firefox:
                    _driverHelper.Driver = new FirefoxDriver();
                    Logger.Info(" Using Firefox Driver  ");

                    break;

                case BrowserType.Chrome:
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments("start-maximized");
                    options.AddArguments("--disable-gpu");
                    _driverHelper.Driver = new ChromeDriver(options);
                    Logger.Info(" Using Chrome Driver  ");
                    break;

                case BrowserType.IExplorer:
                    _driverHelper.Driver = new InternetExplorerDriver();
                    Logger.Info(" Using Internet Explorer Driver  ");
                    break;
            }
            _driverHelper.Driver.Manage()
                .Timeouts().PageLoad = TimeSpan.FromSeconds(ObjectRepository.Config.GetPageLoadTimeOut());
            _driverHelper.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut());
            Console.WriteLine("BeforeScenario");
            scenario = featureName.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);



        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Quit();
        }
    }
}
