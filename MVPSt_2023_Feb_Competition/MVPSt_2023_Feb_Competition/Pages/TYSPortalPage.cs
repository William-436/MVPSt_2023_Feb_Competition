using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using MVPSt_2023_Feb_Competition.Utilities;
using OpenQA.Selenium;
//using SeleniumExtras.PageObjects;
//using OpenQA.Selenium.Support.Pages;
//using OpenQA.Selenium.Support.FindBy;
using static MVPSt_2023_Feb_Competition.Utilities.CommonDriver;

namespace MVPSt_2023_Feb_Competition.Pages
{
    public class TYSPortalPage
    {
        // page objects
        private IWebElement signinLink => driver.FindElement(By.XPath(signinLinkXP));
        private IWebElement emailTextbox => driver.FindElement(By.Name(emailTextboxName));
        private IWebElement passwordTextbox => driver.FindElement(By.Name(passwordTextboxName));
        private IWebElement loginButton => driver.FindElement(By.XPath(loginButtonXP));
        private IWebElement signoutButton => driver.FindElement(By.XPath(signoutButtonXP));

        // XPath of elements
        private string signinLinkXP = "//*[@id=\"home\"]/div/div/div[1]/div/a";
        private string loginButtonXP = "/html/body/div[2]/div/div/div[1]/div/div[4]/button";
        private string signoutButtonXP = "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button";

        // Name of elements
        private string emailTextboxName = "email";
        private string passwordTextboxName = "password";

        // all WebElements are identified using FindsBy or @FindBy annotation
        //@FindBy(XPath= "//*[@id=\"home\"]/div/div/div[1]/div/a")
        
        // find the Sign In link
        //[FindsBy(How = How.XPath, Using = "//*[@id=\"home\"]/div/div/div[1]/div/a")]
        //IWebElement signinLink;

        // find the email text box
        //[FindsBy(How = How.Name, Using = "email")]
        //IWebElement emailTextbox;

        // find the password text box
        //[FindsBy(How = How.Name, Using = "password")]
        //IWebElement passwordTextbox;

        // find the login button
        //[FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        //IWebElement loginButton;

        // find the sign out button
        //[FindsBy(How = How.XPath, Using = "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button")]
        //IWebElement signoutButton;

        // constructor
        //public TYSPortalPage()
        //{
            // initialize elements
            //PageFactory.InitElements(Utilities.CommonDriver.driver, this);
        //}
        public bool SigninActions(int sheetName2RowInt)
        {
            Console.WriteLine("Start login from TYSPortalPage");

            //// initialize elements
            //PageFactory.InitElements(driver, this);

            try
            {
                // identify Sign In link and click on it
                signinLink.Click();
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed to launch Trade Your Skills portal page");
                //GrabScreenShot();
                Assert.Fail("Failed to launch Trade Your Skills portal page", ex.Message);
            }

            // wait for email textbox to exist
            Wait.WaitForElementToExist("Name", emailTextboxName, 1);

            // input the email and password from internal table that was already populated from an external datafile

            // get Email from internal, populated collection [originally from the login credentials file]
            string eMail = ExcelLib.ReadData(sheetName2RowInt, "Email");

            // get Password from internal, populated collection [originally from the login credentials file]
            string passWord = ExcelLib.ReadData(sheetName2RowInt, "Password");

            // identify email and password textboxes and input 'Read' values into respective textboxes
            emailTextbox.SendKeys(eMail);
            passwordTextbox.SendKeys(passWord);

            // click login button
            loginButton.Click();

            // wait for the Home page to load by looking for Sign Out button
            Wait.WaitForElementToExist("XPath", signoutButtonXP, 8);

            // if button label is Sign Out, then set variable to (or return) true, otherwise false
            if (signoutButton.Text == "Sign Out")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
