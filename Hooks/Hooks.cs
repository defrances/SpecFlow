using NUnit.Framework;
using SpecflowDemo.Drivers;
using SpecflowDemo.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowDemo.Hooks
{
    [Binding]
   public class Hooks
    {
        private readonly Selenium _selenium = new Selenium();
        private GoogleSearch _googlepage;

        [AfterScenario]
        public void OneTimeTearDown()
        {
            _selenium.CloseBrowser();
        }

        protected GoogleSearch GooglePage
        {
            get
            {
                if (_googlepage == null)
                {
                    _googlepage = new GoogleSearch(_selenium.Driver);
                }

                return _googlepage;
            }
        }

        public virtual void GetSomething()
        {
            Console.WriteLine("Basic logic");
        }
    
    }
}
