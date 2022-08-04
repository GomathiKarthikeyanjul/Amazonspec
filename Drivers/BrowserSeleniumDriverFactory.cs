using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecRun;

namespace AmazonProject.Drivers
{
    public class BrowserSeleniumDriverFactory
    {
        
        private readonly ConfigurationDriver _configurationDriver;
        private readonly TestRunContext _testRunContext;

        public BrowserSeleniumDriverFactory(ConfigurationDriver configurationDriver, TestRunContext testRunContext)
        {
            _configurationDriver = configurationDriver;
            _testRunContext = testRunContext;
        }

        public IWebDriver GetForBrowser(string browserId)
        {
            string lowerBrowserId = browserId.ToUpper();
            if (ConfigurationManager.AppSettings["environment"].Equals("Local"))
            {
                switch (lowerBrowserId)
                {
                    case "IE": return GetInternetExplorerDriver();
                    case "CHROME": return GetChromeDriver();
                    case "FIREFOX": return GetFirefoxDriver();
                    case string browser: throw new NotSupportedException($"{browser} is not a supported browser");
                    default: throw new NotSupportedException("not supported browser: <null>");
                }
            }
            else
            {
                var options = new FirefoxOptions();
                var driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);
                return driver;
            }
            
        }

        private IWebDriver GetFirefoxDriver()
        {
            return new FirefoxDriver(FirefoxDriverService.CreateDefaultService(_testRunContext.TestDirectory))
            {
                Url = _configurationDriver.SeleniumBaseUrl,

            };
        }

        private IWebDriver GetChromeDriver()
        {
            return new ChromeDriver(ChromeDriverService.CreateDefaultService(_testRunContext.TestDirectory))
            {
                Url = _configurationDriver.SeleniumBaseUrl
            };
        }

        private IWebDriver GetInternetExplorerDriver()
        {
            var internetExplorerOptions = new InternetExplorerOptions
            {
                IgnoreZoomLevel = true,


            };
            return new InternetExplorerDriver(InternetExplorerDriverService.CreateDefaultService(_testRunContext.TestDirectory), internetExplorerOptions)
            {
                Url = _configurationDriver.SeleniumBaseUrl,


            };
        }
    }
}

