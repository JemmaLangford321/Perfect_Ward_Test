using OpenQA.Selenium;
using PerfectWardChallenge.Hooks;
using System;
using System.Collections.Generic;
using System.Text;


namespace PerfectWardChallenge.PageObject
{
    class BookADemoPages
    {
        public IWebDriver driver = WebHooks.driver;

        private By btnBookaDemo = By.XPath("//*[@id=\"navbar\"]/div/div[3]/a");
        private By btnBookMyDemo = By.XPath("//*[@id=\"Book a Demo\"]/div[9]/div/button");



        public void ButtonEnabledAndClickable()
        {
            if (!driver.FindElement((By)btnBookaDemo).Enabled)
                return;
            driver.FindElement(btnBookaDemo).Click();
        }


        public string IsBookMyDemoVisible(string buttonText)
        {
            var button = driver.FindElement(btnBookMyDemo);
            var demoButtonText = button.GetAttribute("innerText");
            return demoButtonText;
        }


    }
}