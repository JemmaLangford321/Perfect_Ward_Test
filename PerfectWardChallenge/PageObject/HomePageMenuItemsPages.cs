using OpenQA.Selenium;
using PerfectWardChallenge.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PerfectWardChallenge.PageObject
{
    public class HomePageMenuItemsPages
    {
        public IWebDriver driver = WebHooks.driver;

  

        private IList<IWebElement> GetMenuItems()
        {
            var menuIcons = driver.FindElements(By.CssSelector(".inline-block:nth-child(n) > a"));
            return menuIcons;
        }


        public void ClickOnMenuOption(string menuItem)
        {
            foreach (var topLevelItem in GetMenuItems())
            {
                if (topLevelItem.Text.Equals(menuItem))
                {
                    topLevelItem.Click();
                    break;
                }
            }
        }
               
            public string ConfirmURLContains(string page)
            {
                String GetURL = driver.Url;
                return GetURL;

            }

        
    }
}
