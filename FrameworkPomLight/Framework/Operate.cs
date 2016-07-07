using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace Framework
{
    class Operate
    {
        internal void Setup(FirefoxDriver driver)
        {            
            driver.Navigate().GoToUrl("http://login.live.com");
            driver.Manage().Window.Maximize();
        }

        internal void TearDown(FirefoxDriver driverTD)
        {
            driverTD.Quit();
        }
    }
}
