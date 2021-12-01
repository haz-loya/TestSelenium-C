
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace HelloWorld.Drivers
{
   public class EntryPoint
    {
        WebDriver driver;
        By CreateNewButton = By.XPath("//*[@data-testid='open - registration - form - button']");
        public void SetUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");

            Thread.Sleep(3000);

        }

        public  Boolean ClickOnCreateNewAccount()
        {
            driver.FindElement(CreateNewButton).Click();
            return true;
        }

        public static void clickOnButton(string button)
        {
            switch(button)
            {
                case "Create new account":
                
                break;
            }
        }

    }
}
