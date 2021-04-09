using CreateAnAccountAsNewUser.Hooks;
using CreateAnAccountAsNewUser.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CreateAnAccountAsNewUser.Steps
{
    [Binding]
    public class NewUserSteps
    {
        public IWebDriver driver = WebHook.driver;
        NewUserPage newUserPage = new NewUserPage();


        [Given(@"that I am a user on Giftrete website \( www\.giftrete\.com\)")]
        public void GivenThatIAmAUserOnGiftreteWebsiteWww_Giftrete_Com()
        {
            driver.Navigate().GoToUrl("https://www.qa2020.giftrete.com/");
            driver.Manage().Window.Maximize();
        }
        
        [Given(@"User click on create account button")]
        public void GivenUserClickOnCreateAccountButton()
        {
            newUserPage.CreateAccountButton();
        }
        
        [Given(@"User enter email address")]
        public void GivenUserEnterEmailAddress()
        {
            newUserPage.EmailAddress();
        }
        
        [Given(@"User enter first name")]
        public void GivenUserEnterFirstName()
        {
            newUserPage.FirstName();
        }
        
        [Given(@"User enter last name")]
        public void GivenUserEnterLastName()
        {
            newUserPage.LastName();
        }
        
        [Given(@"User enter phone number")]
        public void GivenUserEnterPhoneNumber()
        {
            newUserPage.PhoneNumber();
        }
        
        [Given(@"User enter password")]
        public void GivenUserEnterPassword()
        {
            newUserPage.Password();
        }
        
        [Given(@"User re-enter password to confirm password")]
        public void GivenUserRe_EnterPasswordToConfirmPassword()
        {
            newUserPage.ConfirmPassword();
        }
        
        [When(@"User click on register now!")]
        public void WhenUserClickOnRegisterNow()
        {
            newUserPage.ResgisterNow();
        }
        
        [Then(@"User must be successfully registered")]
        public void ThenUserMustBeSuccessfullyRegistered()
        {
            
        }
    }
}
