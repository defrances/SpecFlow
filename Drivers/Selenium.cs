using System;
using System.Globalization;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace SpecflowDemo.Drivers
{
    public class Selenium
    {
        private IWebDriver _driver;
        public IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    Console.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff", CultureInfo.InvariantCulture)
                        + " driver is null");
                    InitDriver();
                }
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss.ffff", CultureInfo.InvariantCulture)
                    + " return driver : " + _driver.CurrentWindowHandle);
                return _driver;
            }
        }

        private void InitDriver()
        {
            _driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory, GetChromeOptions());
            //_driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), GetChromeOptions());
        }
        private ChromeOptions GetChromeOptions()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--disable-infobars");
            return options;
        }

        public void CloseBrowser()
        {
            if (_driver == null) return;
            _driver.Quit();
            _driver.Dispose();
            _driver = null;
        }
    }
}
