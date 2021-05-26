using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpecflowDemo.Pages
{
   public class GoogleSearch
    {
        private IWebDriver _driver;
        public GoogleSearch(IWebDriver webdriver)
        {
            _driver = webdriver;
        }
        public void OpenGooglePage()
        {
            _driver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(5000);
        }
        public void SearchSomething(string value)
        {
            _driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[2]/div[1]/div[1]/div/div[2]/input")).SendKeys(value);
            Thread.Sleep(5000);
        }
    }
}
