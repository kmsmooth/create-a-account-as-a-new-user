using CreateAnAccountAsNewUser.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CreateAnAccountAsNewUser.PageObject
{
    class NewUserPage
    {
        public IWebDriver driver;

        public NewUserPage()
        {
            driver = WebHook.driver;
        }


        private By createAccountButton = By.XPath("//*[contains(text(),'Create account')]");
        private By emailAddress = By.Id("email");
        private By firstName = By.Id("first_name");
        private By lastName = By.Id("last_name");
        private By phoneNumber = By.Id("mobile");
        private By password = By.Id("password");
        private By confirmPassword = By.Id("confirm_password");
        private By registerNow = By.Id("btn_register");
        public void CreateAccountButton()
        {
            driver.FindElement(createAccountButton).Click();
        }    

        public void EmailAddress()
        {
            Thread.Sleep(2000);
            driver.FindElement(emailAddress).SendKeys("chrissmith01@clerk.com");
        }
        
        public void FirstName()
        {
            driver.FindElement(firstName).SendKeys("Chris");
        }

        public void LastName()
        {
            driver.FindElement(lastName).SendKeys("Smith");
        }

        public void PhoneNumber()
        {
            driver.FindElement(phoneNumber).SendKeys("07989182012");
        }

        public void Password()
        {
            driver.FindElement(password).SendKeys("France98");
        }

        public void ConfirmPassword()
        {
            driver.FindElement(confirmPassword).SendKeys("France98");
        }

        public void ResgisterNow()
        {
            driver.FindElement(registerNow).Click();
        }



    }
}
