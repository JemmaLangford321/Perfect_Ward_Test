using OpenQA.Selenium;
using PerfectWardChallenge.Hooks;
using PerfectWardChallenge.PageObject;
using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace PerfectWardChallenge.Steps
{
    [Binding]
    public class ContactUsSteps
    {
        public IWebDriver driver = WebHooks.driver;
        ContactUsPages _contactUsPages = new ContactUsPages();

        [When(@"types ""(.*)"", ""(.*)"", ""(.*)"" and ""(.*)""")]
        public void WhenTypesAnd(string name, string lastName, string email, string telephone)
        {
            _contactUsPages.EnterNamesEmailTelePhone(name, lastName, email, telephone);
        }

        [When(@"Selects a Nurse from the dropdown options")]
        public void WhenSelectsANurseFromTheDropdownOptions()
        {
            _contactUsPages.SelectRole();
        }


        [When(@"Selects a Clinic from the dropdown options")]
        public void WhenSelectsAClinicFromTheDropdownOptions()
        {
            _contactUsPages.SelectSector();
        }

        [When(@"enters ""(.*)""")]
        public void WhenEnters(string organisation)
        {
            _contactUsPages.EnterOrganisation(organisation);
        }


        [When(@"Chooses Google from the How did you hear about us dropdown")]
        public void WhenChoosesGoogleFromTheHowDidYouHearAboutUsDropdown()
        {
            _contactUsPages.SelectHeardAbout();
        }

      

        [When(@"Clicks Submit")]
        public void WhenClicksSubmit()
        {
            _contactUsPages.SubmitClick();
        }


        [Then(@"the user should see ""(.*)""")]
        public void ThenTheUserShouldSee(string errorMassage)
        {
            var message = _contactUsPages.ErrorMessge(errorMassage);
            message.Should().Equals(errorMassage);
        }


      

  

       
    }
}
