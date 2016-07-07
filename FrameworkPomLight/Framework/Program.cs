using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace Framework
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var driver = new FirefoxDriver();
            Operate op = new Operate();
            op.Setup(driver);
            

            op.TearDown(driver);

        }
    }
}
