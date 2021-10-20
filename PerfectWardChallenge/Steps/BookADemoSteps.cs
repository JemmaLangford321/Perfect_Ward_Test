using OpenQA.Selenium;
using PerfectWardChallenge.Drivers;
using PerfectWardChallenge.Hooks;
using PerfectWardChallenge.PageObject;
using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace PerfectWardChallenge.Steps
{
    [Binding]
    public class BookADemoSteps
    {

        public IWebDriver driver = WebHooks.driver;
        Navigation _navigation = new Navigation();
        BookADemoPages _bookADemoPages = new BookADemoPages();
        HomePageMenuItemsPages _homePageMenuItemsPages = new HomePageMenuItemsPages();

        [Given(@"a user has selected a ""(.*)""")]
        public void GivenAUserHasSelectedA(string page)
        {
            _navigation.BuildUrl(page);
        }
        
        [Then(@"the Book a Demo button should be active")]
        public void ThenTheBookADemoButtonShouldBeActive()
        {
             _bookADemoPages.ButtonEnabledAndClickable();
        }

        [Given(@"a user has selected a ""(.*)"" on the Perfect Ward Website")]
        public void GivenAUserHasSelectedAOnThePerfectWardWebsite(string page)
        {
            _navigation.BuildUrl(page);
        }


        [When(@"the user clicks the Book a Demo button")]
        public void WhenTheUserClicksTheBookADemoButton()
        {
            _bookADemoPages.ButtonEnabledAndClickable();
        }

        [Then(@"the shoud be redirected to ""(.*)""")]
        public void ThenTheShoudBeRedirectedTo(string page)
        {
            var x = _homePageMenuItemsPages.ConfirmURLContains(page);
            x.Should().Contain(page);
        }


        [Then(@"the ""(.*)"" button is present")]
        public void ThenTheButtonIsPresent(string buttonText)
        {
            var demoButtonText = _bookADemoPages.IsBookMyDemoVisible(buttonText);
            demoButtonText.Should().Equals(buttonText);
        }

    }
}
