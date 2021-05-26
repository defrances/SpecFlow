using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowDemo.Steps
{
   public class GoogleSteps:Hooks.Hooks
    {
        [Given(@"The user open google page")]
        public void GivenTheUserOpenGooglePage()
        {
            Console.WriteLine("First Step");
            //GooglePage.OpenGooglePage();
        }

        [When(@"The user start search '(.*)'")]
        public void WhenTheUserStartSearch(string item)
        {
            Console.WriteLine("Second Step");
            //GooglePage.SearchSomething(item);
            //GetSomething();
            //base.GetSomething();
        }

        public new void GetSomething()
        {
            Console.WriteLine("Custome Logic");
        }

    }
}
