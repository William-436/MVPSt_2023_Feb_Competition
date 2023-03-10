using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;
using static MVPSt_2023_Feb_Competition.Utilities.CommonDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVPSt_2023_Feb_Competition.Utilities;
using AventStack.ExtentReports;

namespace MVPSt_2023_Feb_Competition.Pages
{
    public class ManageListingsPage
    {
        // page objects

        private IWebElement profileLink => driver.FindElement(By.XPath(profileLinkXP));
        private IWebElement managelistingsMessage => driver.FindElement(By.XPath(managelistingsMessageXP));
        private IWebElement tableofListings => driver.FindElement(By.XPath(tableofListingsXP));
        //private IWebElement nextpageLink => driver.FindElement(By.XPath(nextpageLinkXP));
        //private IWebElement nextpageLink => (IWebElement)driver.FindElement(By.PartialLinkText(">"));
        //private IWebElement disablednextpageLink => driver.FindElement(By.ClassName("ui disabled button otherPage"));
        private IWebElement shareskillButton => driver.FindElement(By.XPath(shareskillButtonXP));

        // Get elements used to validate Actual against Expected data
        private IWebElement savedCategory => driver.FindElement(By.XPath(savedCategoryXP));
        private IWebElement savedTitle => driver.FindElement(By.XPath(savedTitleXP));
        private IWebElement savedDescription => driver.FindElement(By.XPath(savedDescriptionXP));
        // Service Type = Hourly or One-off
        private IWebElement savedServiceType => driver.FindElement(By.XPath(savedServiceTypeXP));
        // Skill Trade = Skill-exchange or Credit
        private IWebElement savedSkillTradeIcon => driver.FindElement(By.XPath(savedSkillTradeIconXP));
        // Active = Active or Hidden
        //private IWebElement savedActive => driver.FindElement(By.XPath(savedActiveXP));
        private IWebElement firstroweditIcon => driver.FindElement(By.XPath(firstroweditIconXP));


        // XPath of elements
        private string profileLinkXP = "//*[@id=\"listing-management-section\"]/section[1]/div/a[2]";
        private string managelistingsMessageXP = "//*[@id=\"listing-management-section\"]/div[2]/h3";
        private string tableofListingsXP = "//tbody[1]";
        //private string nextpageLinkXP = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[2]/button[3]";
        //private string nextpageLinkXP = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[2]/button[4]";
        private string shareskillButtonXP = "//*[@id=\"listing-management-section\"]/section[1]/div/div[2]/a";
        private string savedCategoryXP = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]";
        private string savedTitleXP = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]";
        private string savedDescriptionXP = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]";
        private string savedServiceTypeXP = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[5]";
        private string savedSkillTradeIconXP = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[6]/i";
        //private string savedActiveXP = "";
        private string firstroweditIconXP = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i";

        // Miscellaneous
        //int numberofrows;
        //int numberofListings;
        //string continuecounting;

        //public int CountAllListings() // still need to find solution to finding and clicking next page navigation arrow when web element is enabled
        //{
        //    // count the number of rows on every page by looping through all pages
        //    // if message 'You do not have any service listings!' displays on page, then set numberofListings to zero; otherwise, begin counting

        //    // the following line works when true but cannot find the element's XPath when number of listings > 0
        //    //if (managelistingsMessage.Text == "You do not have any service listings!")
        //    //driver.Navigate().Refresh();
        //    //numberofListings = 0;
        //    // count the number of elements that match the XPath for the message element on the Manage Listings page
        //    int result = driver.FindElements(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/h3")).Count;
        //    if (result > 0) // message element was found
        //    {
        //        if (managelistingsMessage.Text == "You do not have any service listings!")
        //        {
        //            numberofListings = 0;
        //        }
        //        else
        //        {
        //            Console.WriteLine("FAIL: Message on Manage Listings page does not match expected message of 'You do not have any service listings!");
        //            Console.WriteLine("Ending the program");
        //            Cleanup();
        //        }
        //    }
        //    else // message element does not exist, therefore 1 or more listings exist
        //    {
        //        // the following line counts all rows from all pages without having to navigate to each page to count rows on each page
        //        // no it does not! it keeps returning 6 even when actual number is 7
        //        //numberofListings = driver.FindElements(By.TagName("tr")).Count;

        //        //Console.WriteLine("number of listings = " + numberofListings);

        //        // following definitions do not work
        //        //IWebElement nextpageLink = driver.FindElement(By.PartialLinkText(">"));
        //        //IWebElement nextpageLink = driver.FindElement(By.CssSelector("u1[role='button'>>]"));
        //        // move the following lines inside the do/while loop if they work
        //        IWebElement nextpageLink = driver.FindElement(By.TagName("ui buttons semantic-ui-react-button-pagination"));

        //        string nextpageLinkstring = nextpageLink.GetAttribute("");
        //        if (nextpageLinkstring.Contains("disabled"))
        //        {
        //            Console.WriteLine("next page control is disabled");
        //        }
        //        else
        //        {
        //            Console.WriteLine("next page control is enabled");
        //        }
                
        //        // just giving a default value until solution to looping issue is found along with how to capture row count for every page
        //        //numberofListings = 1;
        //        // -- design: 1. count # of rows on current page by adding rows to a total row count, 2. if next page icon is enabled, then click it AND
        //        // -- perform step 1. again. Must do step 1 a miniumum of 1 time!
        //        numberofListings = 0;
        //        //continuecounting = "Yes";
        //        //do
        //        //{
        //            numberofrows = 0;
        //            IList<IWebElement> tablerow = tableofListings.FindElements(By.TagName("tr"));
        //            numberofrows = tablerow.Count;
        //            numberofListings += numberofrows; // adds numberofrows to numberofListings
        //        //    // if next page icon is enabled, then click it, else set continuecounting to 'No'
        //        //    if (nextpageLink.Enabled == true)
        //        //    {
        //        //        nextpageLink.Click();
        //        //    }
        //        //    else
        //        //    {
        //        //        continuecounting = "No";
        //        //    }
        //        //}
        //        //// while next page navigation icon is enabled
        //        //while (continuecounting == "Yes");
        //        //bool v = nextpageLink.GetAttribute("disabled") = true;
        //        //while (v)
        //        //{

        //        //}
        //    }
        //    // remove following line after resolving the loop and next page navigation control issue
        //    //numberofListings = 1;
        //    return numberofListings;

        //}
        
        //public void NavigateToProfileHome()
        //{
        //    // find and click the Profile link
        //    profileLink.Click();
        //}

        public void NavigateToShareSkill()
        {
            // find and click the Share Skill button
            shareskillButton.Click();
        }

        // this method is only called by positive test cases containing valid data
        public bool CompareManageListingsValues(int NumberOfExistingListingsInt, string Category, string Title, string Description, string ServiceType, string SkillTrade, string Active)
        {
            test.Log(Status.Info, "Beginning comparisons on top row of Manage Listings page");
            
            bool managelistingsmatchingflag = true;

            // get number of rows of listings on all Manage Listings pages -- when I get it working
            ////////////////////////

            if (savedCategory.Text != Category)
            {
                managelistingsmatchingflag = false;
                Console.WriteLine("FAIL: Manage Listings Category '" + savedCategory.Text + "' does not match expected value '" + Category +"'");
                test.Log(Status.Fail, "Manage Listings Category does not match expected value");
            }

            // force failure
            //Title = "Mrs";
            if (savedTitle.Text != Title)
            {
                managelistingsmatchingflag = false;
                Console.WriteLine("FAIL: Manage Listings Title '" + savedTitle.Text + "' does not match expected value '" + Title + "'");
                test.Log(Status.Fail, "Manage Listings Title does not match expected value");
            }

            if (savedDescription.Text != Description)
            {
                managelistingsmatchingflag = false;
                Console.WriteLine("FAIL: Manage Listings Description '" + savedDescription.Text + "' does not match expected value '" + Description + "'");
                test.Log(Status.Fail, "Manage Listings Description does not match expected value");
            }

            if (savedServiceType.Text != ServiceType)
            {
                managelistingsmatchingflag = false;
                Console.WriteLine("FAIL: Manage Listings Service Type '" + savedServiceType.Text + "' does not match expected value '" + ServiceType + "'");
                test.Log(Status.Fail, "Manage Listings Service Type does not match expected value");
            }

            string attributeValue = savedSkillTradeIcon.GetAttribute("class");
            if (SkillTrade == "Skill-exchange" && attributeValue != "blue check circle outline large icon")
                {
                managelistingsmatchingflag = false;
                Console.WriteLine("FAIL: Manage Listings Skill Trade does not match expected value");
                test.Log(Status.Fail, "Manage Listings Skill Trade does not match expected value for Skill-exchange");
            }

            if (SkillTrade == "Credit" && attributeValue != "grey remove circle large icon")
            {
                managelistingsmatchingflag = false;
                Console.WriteLine("FAIL: Manage Listings Skill Trade does not match expected value");
                test.Log(Status.Fail, "Manage Listings Skill Trade does not match expected value for Credit");
            }

            // how to check Active slider bar / checkbox to know if it is on or off / Active (blue) or Hidden (grey)
            // XPaths for Active and Hidden, respectively
            //*[@id="listing-management-section"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[7]/div
            //*[@id="listing-management-section"]/div[2]/div[1]/div[1]/table/tbody/tr[2]/td[7]/div/input


            if (managelistingsmatchingflag == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Edit1stListing()
        {
            // wait for edit icon to be clickable
            Wait.WaitForElementToBeClickable("XPath", firstroweditIconXP, 3);

            firstroweditIcon.Click();
        }
    }
}
