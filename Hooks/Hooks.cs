using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using AmazonProject.Drivers;

namespace AmazonProject.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks


        private static BrowserInstance _browserInstance;
        public Hooks(BrowserInstance browserInstance)
        {
            _browserInstance = browserInstance;

        }

        [BeforeStep]
        public void BeforeStep(BrowserInstance browserInstance)
        {
            _browserInstance = browserInstance;
        }

        [AfterStep]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
