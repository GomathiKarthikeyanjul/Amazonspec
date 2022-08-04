using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProject.Drivers
{
    public class BrowserInstance
    {
        private readonly WebDriver _webDriver;
        private readonly ConfigurationDriver _configurationDriver;

        public BrowserInstance(WebDriver webDriver, ConfigurationDriver configurationDriver)
        {
            _webDriver = webDriver;
            _configurationDriver = configurationDriver;
        }

        public void OpenBasePage()
        {
            _webDriver.Current.Url = _configurationDriver.SeleniumBaseUrl;
        }

        public void Close()
        {
            _webDriver.Dispose();
        }

        public IWebDriver Driver() => _webDriver.Current;
    }
}
