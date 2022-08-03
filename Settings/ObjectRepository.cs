using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using AmazonProject.Interfaces;
using AmazonProject.PageObjects;

namespace AmazonProject.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
    }
}
