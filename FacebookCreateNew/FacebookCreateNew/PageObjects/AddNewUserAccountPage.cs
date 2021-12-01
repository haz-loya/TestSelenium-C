using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;


namespace HelloWorld.PageObjects
{
   public class AddNewUserAccountPage
    {
        WebDriver driver;
        By firstName = By.Name("firstname");
        By lastName = By.Name("lastname");
        By email = By.Name("reg_email__");
        By BirthDayLink = By.Id("age_to_birthday");
        By birthdayMonth = By.Id("month");
        By birthdayDay = By.Id("day");
        By birthdayYear = By.Id("year");
        By SignUpButton = By.Name("websubmit");

        public  Boolean FillTextBoxData(string textBoxName, string TextValue)
        {
            bool isTextBoxFilled = false;
            By Field = null;
           
            switch (textBoxName)
            {
                case "last":
                    driver.FindElement(lastName).SendKeys(TextValue);
                    Field = lastName;
                    break;
                case "first":
                    driver.FindElement(firstName).SendKeys(TextValue);
                    Field = firstName;
                    break;
                case "email":
                    driver.FindElement(email).SendKeys(TextValue);
                    Field = email;
                    break;
               
            }
            if (driver.FindElement(Field).Displayed.ToString().Equals(TextValue))
            {
                isTextBoxFilled = true;
            }
            return isTextBoxFilled;
        }

        public Boolean ClickOnBirthdayLink()
        {

            driver.FindElement(BirthDayLink).Click();
            if (driver.FindElement(birthdayMonth).Displayed)
            {
                return true;
            }
            return false;
        }

        public  Boolean FillbirthdDayDate(string Date)
        {
            string[] dividedDate = Date.Split('/');
            if (dividedDate.Length == 3)
            {
                driver.FindElement(birthdayMonth).SendKeys(dividedDate[0]);
                driver.FindElement(birthdayDay).SendKeys(dividedDate[1]);
                driver.FindElement(birthdayYear).SendKeys(dividedDate[2]);
                return true;
            }
            else return false;
            
        }

        public void ClickOnSignUp()
        {
            driver.FindElement(SignUpButton).Click();
        }

        public Boolean SelectGender(string gender)
        {
            IList<By> genderOptions = (IList<By>)driver.FindElements(By.Name("Sex"));

            switch (gender)
            {
                case "Female":
                    driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div[2]/div/div/div[1]/form/div[1]/div[7]/span/span[1]/input")).Click();
                    break;
                case "Male":
                    driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div[2]/div/div/div[1]/form/div[1]/div[7]/span/span[2]/input")).Click();
                    break;
                case "Custom":
                    driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div[2]/div/div/div[1]/form/div[1]/div[7]/span/span[3]/input")).Click();
                    break;
            }
            return true;
        }

    }

}
