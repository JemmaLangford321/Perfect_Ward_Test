using OpenQA.Selenium;
using PerfectWardChallenge.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PerfectWardChallenge.Drivers
{
    class Navigation
    {
        public IWebDriver driver = WebHooks.driver;
        public void NavigateToHomePage()
        {
            //put this URL in config file
            driver.Navigate().GoToUrl("https://www.perfectward.com");
        }

        public void BuildUrl(string page)
        {
            //put this URL in config file
            driver.Navigate().GoToUrl("https://www.perfectward.com" + "/" + page);
        }

    }
}
