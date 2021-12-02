using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestSpecflowSelenium.Drivers;

namespace TestSpecflowSelenium.Steps
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        IWebDriver driver;

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public LoginStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"User navigates to Facebook using ""(.*)""")]
        public void GivenUserNavigatesToFacebookUsing(string navigator)
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            driver.Url = "https://facebook.com";
        }


        [Given(@"User clicks on ""(.*)"" button")]
        public void GivenUserClicksOnButton(string button)
        {
            Assert.IsTrue(_scenarioContext.Get<SeleniumDriver>("SeleniumDriver").ClickOnAddNew());

        }

        [Given(@"User adds the following new user data:")]
        public void GivenUserAddsTheFollowingNewUserData(Table table)
        {
           var UserData = table.CreateInstance<NewUserData>();

            _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").ClickOnBirthdayLink();
            Assert.IsTrue(_scenarioContext.Get<SeleniumDriver>("SeleniumDriver").FillTextBoxData("firstName", UserData.FirstName));
            Assert.IsTrue(_scenarioContext.Get<SeleniumDriver>("SeleniumDriver").FillTextBoxData("lastName", UserData.LastName));
            Assert.IsTrue(_scenarioContext.Get<SeleniumDriver>("SeleniumDriver").FillTextBoxData("email", UserData.FirstName));
            Assert.IsTrue(_scenarioContext.Get<SeleniumDriver>("SeleniumDriver").FillbirthdDayDate(UserData.Birthday));
            Assert.IsTrue(_scenarioContext.Get<SeleniumDriver>("SeleniumDriver").SelectGender(UserData.Gender));
        }

        [When(@"User clicks on ""(.*)"" button")]
        public void WhenUserClicksOnButton(string p0)
        {
            _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").ClickOnSignUp();
        }

        [Then(@"User validates Warining sign on ""(.*)"" textbox")]
        public void ThenUserValidatesWariningSignOnTextbox(string textboxName)
        {
            Assert.IsTrue(_scenarioContext.Get<SeleniumDriver>("SeleniumDriver").findWarningEmail());
        }


    }
}
