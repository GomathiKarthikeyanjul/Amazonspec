using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmazonProject.Configuration;

namespace AmazonProject.Interfaces
{
    public interface IConfig
    {
        BrowserType? GetBrowser();
        string GetWebsite();
        int GetPageLoadTimeOut();
        int GetElementLoadTimeOut();

    }
}
