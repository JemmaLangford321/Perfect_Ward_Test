using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PerfectWardChallenge.Hooks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PerfectWardChallenge.PageObject
{
    class ContactUsPages
    {
        public IWebDriver driver = WebHooks.driver;

        private By txtBoxFirstName = By.Id("form-input-firstName");
        private By txtBoxLastName = By.Id("form-input-lastName");
        private By txtBoxEmail = By.Id("form-input-email");
        private By txtBoxTelephone = By.Id("form-input-telephone");

        private By roleMenuIcon = By.Id("form-input-roles");
        private By selectedRole = By.CssSelector("#form-input-roles > option:nth-child(19)");
        
        private By sectorMenuIcon = By.Id("form-input-sectors");
        private By selectedSector = By.CssSelector("#form-input-sectors > option:nth-child(12)");

        private By txtBoxOrganisation = By.Id("form-input-companyName");

        private By referalMenuIcon = By.Id("form-input-referralChannel");
        private By referalOption = By.CssSelector("#form-input-referralChannel > option:nth-child(2)");

        private By errorMessage  = By.XPath("//*[@id=\"General Enquiry\"]/div[1]");
        private By txtBoxMessage = By.CssSelector("#form-input-message");
        

        public void EnterNamesEmailTelePhone(string name, string lastNme, string email, string telephone)
        {
            driver.FindElement(txtBoxFirstName).SendKeys(name);
            driver.FindElement(txtBoxLastName).SendKeys(lastNme);
            driver.FindElement(txtBoxEmail).SendKeys(email);
            driver.FindElement(txtBoxTelephone).SendKeys(telephone);
        }

        public void SelectRole()
        {
            driver.FindElement(roleMenuIcon).Click();
            driver.FindElement(selectedRole).Click();
        }

        public void SelectSector()
        {
            driver.FindElement(sectorMenuIcon).Click();
            driver.FindElement(selectedSector).Click();
        }

        public void EnterOrganisation(string organisation)
        {
            driver.FindElement(txtBoxOrganisation).SendKeys(organisation);
        }

        public void SelectHeardAbout()
        {
            driver.FindElement(referalMenuIcon).Click();
            driver.FindElement(referalOption).Click();
        }

        public void SubmitClick()
        {
            var btnSubmit = driver.FindElement(By.XPath("//button[text()=\"Submit\"]"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].scrollIntoView(true);", btnSubmit);
            executor.ExecuteScript("arguments[0].click();", btnSubmit);

            
        }

        public string ErrorMessge(string errorMessagedisplaied)
        {
            var messageBanner = driver.FindElement(errorMessage);
            var messageText = messageBanner.GetAttribute("innerText");
            return messageText; 
        }
    }
}
