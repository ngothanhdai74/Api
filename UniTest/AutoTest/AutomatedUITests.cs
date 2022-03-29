using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.AutoTest
{
    public class AutomatedUITests : IDisposable
    {
        private readonly IWebDriver _driver;
        public AutomatedUITests() => _driver = new ChromeDriver();
        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }
        public void TestEdoc()
        {
            _driver.Navigate().GoToUrl("https://edoctc.mof.gov.vn");
        }
    }
}
