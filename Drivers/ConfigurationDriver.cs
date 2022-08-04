using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProject.Drivers
{
    public class ConfigurationDriver
    {
        public string SeleniumBaseUrl => Environment.GetEnvironmentVariable("__BaseUrl");
    }
}
