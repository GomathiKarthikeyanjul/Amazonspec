using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using AmazonProject.Interfaces;
using AmazonProject.PageObjects;

namespace AmazonProject
{
    public class DriverHelper
    {
        public IWebDriver Driver { get; set; }
       
        }
}
