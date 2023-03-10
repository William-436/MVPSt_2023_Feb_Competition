using AventStack.ExtentReports;
using MVPSt_2023_Feb_Competition.Utilities;
using OpenQA.Selenium;
//using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MVPSt_2023_Feb_Competition.Utilities.CommonDriver;

namespace MVPSt_2023_Feb_Competition.Pages
{
    public class HomePage
    {
        // page objects
        private IWebElement managelistingsButton => driver.FindElement(By.XPath(managelistingsButtonXP));
        private IWebElement shareskillButton => driver.FindElement(By.XPath(shareskillButtonXP));

        // Miscellaneous objects
        private IWebElement signoutButton => driver.FindElement(By.XPath(signoutButtonXP));
        private IWebElement signinLink => driver.FindElement(By.XPath(signinLinkXP));

        // find the login button
        //[FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        //IWebElement loginButton;

        // XPath of elements
        // custom-built XPath for signoutButtonXP
        private string signoutButtonXP = "//div[1]/div[2]/div/a[2]/button";
        private string signinLinkXP = "//*[@id=\"home\"]/div/div/div[1]/div/a";
        private string managelistingsButtonXP = "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]";

        // custom XPath for title of page on Manage Listings page
        private string managelistingsTitleXP = "//div[2]/h2";
        private string shareskillButtonXP = "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a";
        private string cancelButtonXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[2]";
        //private string supportcolumnheadingXP = "//*[@id=\"listing-management-section\"]/section[2]/div/div/div/div[3]/h3";

        // constructor
        //public HomePage()
        //{
            // initialize elements
            //PageFactory.InitElements(Utilities.CommonDriver.driver, this);
        //}

        public void NavigateToShareSkill()
        {
            // find and click the Share Skill button
            shareskillButton.Click();

            // wait for the last element on the Share Skill page to load
            //Wait.WaitForElementToBeClickable("XPath", cancelButtonXP, 5);
        }

        public void NavigateToManageListings()
        {
            // find and click the Manage Listings link
            managelistingsButton.Click();

            // wait for the manage listings heading to load on the Manage Listings page
            Wait.WaitForElementToExist("XPath", managelistingsTitleXP, 6);

            // wait for Support column title to be loaded at the bottom of the page
            //Wait.WaitForElementToExist("XPath", supportcolumnheadingXP, 4);
            //Thread.Sleep(2000);
        }

        public bool SignOut()
        {
            // sign out of Trade Your Skills portal
            // wait for Sign Out button to be clickable
            Wait.WaitForElementToBeClickable("XPath", signoutButtonXP, 4);

            // button label must = Sign Out - if not, then write message and return to calling program
            if (signoutButton.Text != "Sign Out")
            {
                Console.WriteLine("FAIL: Sign Out button not found - Quitting program");
                test.Log(Status.Fail, "Sign Out button not found - Quitting program");
                return false;
            }

            // click the Sign Out button
            signoutButton.Click();

            // wait for the Sign In link to appear
            Wait.WaitForElementToBeClickable("XPath", signinLinkXP, 2);

            // if link label is Sign In, then set variable to true, otherwise false
            if (signinLink.Text == "Sign In")
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
