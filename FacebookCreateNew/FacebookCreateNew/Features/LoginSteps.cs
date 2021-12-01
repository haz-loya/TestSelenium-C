using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace HelloWorld.Features
{
    [Binding]
    public class LoginSteps
    {
        WebDriver driver;
        By CreateNewButton = By.XPath("//*[@data-testid='open - registration - form - button']");
        By firstName = By.Name("firstname");
        By lastName = By.Name("lastname");
        By email = By.Name("reg_email__");
        By BirthDayLink = By.Id("age_to_birthday");
        By birthdayMonth = By.Id("month");
        By birthdayDay = By.Id("day");
        By birthdayYear = By.Id("year");
        By SignUpButton = By.Name("websubmit");
        public void SetUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");

            Thread.Sleep(3000);
        }

        [Given(@"User clicks on ""(.*)"" button")]
        public void GivenUserClicksOnButton(string button)
        {
            driver.FindElement(CreateNewButton).Click();
        }

        [Given(@"User adds the following new user data:")]
        public void GivenUserAddsTheFollowingNewUserData(Table table)
        {
            
        }
        
        [When(@"User clicks on ""(.*)"" button")]
        public void WhenUserClicksOnButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"User validates the error message ""(.*)""")]
        public void ThenUserValidatesTheErrorMessage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
