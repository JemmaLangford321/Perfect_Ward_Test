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
    public class HomePageMenuItemsSteps
    {
        public IWebDriver driver = WebHooks.driver;

        Navigation _navigation = new Navigation();
        HomePageMenuItemsPages _homePageMenuItemsPages = new HomePageMenuItemsPages();


        [Given(@"a user navigates to the Perfect Ward Website")]
        public void GivenAUserNavigatesToThePerfectWardWebsite()
        {
            _navigation.NavigateToHomePage();

        }


        [When(@"selects a ""(.*)""")]
        public void WhenSelectsA(string menuIcon)
        {
            _homePageMenuItemsPages.ClickOnMenuOption(menuIcon);
        }

        [Then(@"the correct page will display ""(.*)""")]
        public void ThenTheCorrectPageWillDisplay(string page)
        {
          var x = _homePageMenuItemsPages.ConfirmURLContains(page);
            x.Should().Contain(page);
        }

    }
}
