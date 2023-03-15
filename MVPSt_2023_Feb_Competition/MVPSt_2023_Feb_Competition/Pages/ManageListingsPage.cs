using OpenQA.Selenium;
using static MVPSt_2023_Feb_Competition.Utilities.CommonDriver;
using MVPSt_2023_Feb_Competition.Utilities;
using AventStack.ExtentReports;

namespace MVPSt_2023_Feb_Competition.Pages
{
    public class ManageListingsPage
    {
        // page objects

        // objects used for obtaining count of number of listings -- uncomment when solution is found to identify dynamic, next page navigation control
        //private IWebElement profileLink => driver.FindElement(By.XPath(profileLinkXP));
        //private IWebElement managelistingsMessage => driver.FindElement(By.XPath(managelistingsMessageXP));
        //private IWebElement tableofListings => driver.FindElement(By.XPath(tableofListingsXP));
        //private IWebElement nextpageLink => driver.FindElement(By.XPath(nextpageLinkXP));
        //private IWebElement nextpageLink => (IWebElement)driver.FindElement(By.PartialLinkText(">"));
        //private IWebElement disablednextpageLink => driver.FindElement(By.ClassName("ui disabled button otherPage"));
        private IWebElement shareskillButton => driver.FindElement(By.XPath(shareskillButtonXP));

        // elements used to validate Actual against Expected data
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
        //private string profileLinkXP = "//*[@id=\"listing-management-section\"]/section[1]/div/a[2]";
        //private string managelistingsMessageXP = "//*[@id=\"listing-management-section\"]/div[2]/h3";
        //private string tableofListingsXP = "//tbody[1]";
        //private string previouspageLinkXP = "//button[text()='<']";
        //private string nextpageLinkXP = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[2]/button[3]";
        //private string nextpageLinkXP = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[2]/button[4]";
        //private string nextpageLinkXP = "//button[text()='>']";
        private string shareskillButtonXP = "//*[@id=\"listing-management-section\"]/section[1]/div/div[2]/a";
        private string savedCategoryXP = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]";
        private string savedTitleXP = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]";
        private string savedDescriptionXP = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]";
        private string savedServiceTypeXP = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[5]";
        private string savedSkillTradeIconXP = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[6]/i";
        //private string savedActiveXP = "";
        private string firstroweditIconXP = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i";

        // Miscellaneous

        // variables used for the counting of number of listings -- commented out until find solution to recognizing dynamic, next page navigation control
        //int numberofrows;
        //int numberofListings;
        //string nextpageLinkstring;
        //string continuecounting;

        private bool boolflag;
        private string? attributeValue;

        //public int CountAllListings() // still need to find solution to finding and clicking next page navigation arrow when web element is enabled
        //{
        //    // count the number of rows on every page by looping through all pages
        //    // if message 'You do not have any service listings!' displays on page, then set numberofListings to zero; otherwise, begin counting

        //    numberofListings = 0;
            
        //    int result = driver.FindElements(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/h3")).Count;
        //    if (result > 0) // the message element was found
        //    {
        //        if (managelistingsMessage.Text == "You do not have any service listings!") // the only known text when a message exists
        //        {
        //            numberofListings = 0;
        //            return numberofListings;
        //        }
        //        else
        //        {
        //            Console.WriteLine("FAIL: Message on Manage Listings page '" + managelistingsMessage.Text + "' does not match expected message of 'You do not have any service listings!");
        //            Console.WriteLine("Ending the program");
        //            test.Log(Status.Fail, "Message on Manage Listings page '" + managelistingsMessage.Text + "' does not match expected message of 'You do not have any service listings!");
        //            //GrabScreenShot(TestCaseID);
        //            Assert.Fail("Message on Manage Listings page '" + managelistingsMessage.Text + "' does not match expected message of 'You do not have any service listings!");
        //            Cleanup();
        //            return numberofListings;
        //        }
        //    }
        //    else // message element does not exist, therefore 1 or more pages of listings exist
        //    {
        //        //numberofListings = driver.FindElements(By.TagName("tr")).Count; // Page 1

        //        //Console.WriteLine("number of listings on Page 1 = " + numberofListings);

        //        //        // following definitions do not work
        //        //        //IWebElement nextpageLink = driver.FindElement(By.PartialLinkText(">"));
        //        //        //IWebElement nextpageLink = driver.FindElement(By.CssSelector("u1[role='button'>>]"));
        //        //        // move the following lines inside the do/while loop if they work
        //        //        IWebElement nextpageLink = driver.FindElement(By.TagName("ui buttons semantic-ui-react-button-pagination"));
        //        IWebElement nextpageLink = driver.FindElement(By.XPath(nextpageLinkXP));

        //        nextpageLinkstring = nextpageLink.GetAttribute("");
        //        if (nextpageLinkstring.Contains("disabled"))
        //        {
        //            Console.WriteLine("next page control is disabled");
        //        }
        //        else
        //        {
        //            Console.WriteLine("next page control is enabled");
        //        }

        //        //        // -- design: 1. count # of rows on current page by adding rows to a total row count, 2. if next page icon is enabled, then click it AND
        //        //        // -- perform step 1. again. Must do step 1 a miniumum of 1 time!
        //        continuecounting = "Yes";
        //        do
        //        {
        //            numberofrows = 0;
        //            IList<IWebElement> tablerow = tableofListings.FindElements(By.TagName("tr"));
        //            numberofrows = tablerow.Count;
        //            numberofListings += numberofrows; // adds numberofrows to numberofListings
        //            //if next page icon is enabled, then click it, else set continuecounting to 'No'
        //            if (nextpageLink.Enabled == true)
        //            {
        //                nextpageLink.Click();
        //                Wait.WaitForElementToBeClickable("XPath", previouspageLinkXP, 5);
        //            }
        //            else
        //            {
        //                continuecounting = "No";
        //            }
        //        }
        //        // while next page navigation icon is enabled
        //        while (continuecounting == "Yes");

        //        return numberofListings;
        //    }
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

        // the following Check...OnManageListings methods are only called by positive test cases because equal/matching comparisons are
        // considered a success -- but a negative test ie. invalid data on Share Skill page would be rejected/not saved so a match of invalid data
        // on the 1st row on the Manage Listings page would be a failure so... maybe pass the ValidInvalid parm to ensure both scenarios can be handled properly
        // NO !! because a negative test could use some valid and some invalid parms where the valid parms might match the existing listing at the top of
        // the Manage Listings page and the ValidInvalid parm represents the entire listing, not the individual parm

        // the following method must be able to process comparison for Adding and Editing both valid and invalid data scenarios
        //public bool CheckNumberOfListingsOnManageListings(int NumberOfListingsToCompare, string ActionOfTest, string ValidInvalid) // after an action has been performed
        //{
        //    // set default value of returned value to false
        //    boolflag = false;
        //    int currentnumberoflistings = CountAllListings();

        //    if (ActionOfTest.Substring (1, 3) == "Add")
        //    {
        //        if (ValidInvalid == "Valid") // added 1 listing to pre-action count
        //        {
        //            if (NumberOfListingsToCompare + 1 == currentnumberoflistings)
        //            {
        //                boolflag = true;
        //            }
        //            else
        //            {
        //                boolflag = false;
        //            }
        //        }
        //        else // pre-action count should be unchanged
        //        {
        //            if (NumberOfListingsToCompare == currentnumberoflistings)
        //            {
        //                boolflag = true;
        //            }
        //            else
        //            {
        //                boolflag = false;
        //            }
        //        }
        //    }
        //    else // Action is Not 'Add...', therefore both Valid and Invalid 'Edit' actions should not alter the total listing count
        //    {
        //        if (NumberOfListingsToCompare == currentnumberoflistings)
        //        {
        //            boolflag = true;
        //        }
        //        else
        //        {
        //            boolflag = false;
        //        }
        //    }

        //    if (boolflag == true)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool CheckCategoryOnManageListings(string Category)
        {
            if (savedCategory.Text == Category)
            {
                return true;
            }
            else
            {
                Console.WriteLine("FAIL: Manage Listings Category '" + savedCategory.Text + "' does not match expected value '" + Category + "'");
                test.Log(Status.Fail, "Manage Listings Category '" + savedCategory.Text + "' does not match expected value '" + Category + "'");
                return false;
            }
        }

        public bool CheckTitleOnManageListings(string Title)
        {
            if (savedTitle.Text == Title)
            {
                return true;
            }
            else
            {
                Console.WriteLine("FAIL: Manage Listings Title '" + savedTitle.Text + "' does not match expected value '" + Title + "'");
                test.Log(Status.Fail, "Manage Listings Category '" + savedTitle.Text + "' does not match expected value '" + Title + "'");
                return false;
            }
        }

        public bool CheckDescriptionOnManageListings(string Description)
        {
            if (savedDescription.Text == Description)
            {
                return true;
            }
            else
            {
                Console.WriteLine("FAIL: Manage Listings Description '" + savedDescription.Text + "' does not match expected value '" + Description + "'");
                test.Log(Status.Fail, "Manage Listings Description '" + savedDescription.Text + "' does not match expected value '" + Description);
                return false;
            }
        }

        public bool CheckServiceTypeOnManageListings(string ServiceType)
        {
            if (savedServiceType.Text == ServiceType)
            {
                return true;
            }
            else
            {
                Console.WriteLine("FAIL: Manage Listings Service Type '" + savedServiceType.Text + "' does not match expected value '" + ServiceType + "'");
                test.Log(Status.Fail, "Manage Listings Service Type '" + savedServiceType.Text + "' does not match expected value '" + ServiceType + "'");
                return false;
            }
        }

        public bool CheckSkillTradeOnManageListings(string SkillTrade)
        {
            boolflag = false;

            attributeValue = savedSkillTradeIcon.GetAttribute("class");

            if (SkillTrade == "Skill-exchange") //&& attributeValue == "blue check circle outline large icon")
            {
                if (attributeValue == "blue check circle outline large icon")
                {
                    boolflag = true;
                }
                else
                {
                    Console.WriteLine("FAIL: Manage Listings Skill Trade does not match expected value for Skill-exchange");
                    test.Log(Status.Fail, "Manage Listings Skill Trade does not match expected value for Skill-exchange");
                    boolflag = false;
                }
            }

            if (SkillTrade == "Credit") //&& attributeValue == "grey remove circle large icon")
            {
                if (attributeValue == "grey remove circle large icon")
                {
                    boolflag = true;
                }
                else
                {
                    Console.WriteLine("FAIL: Manage Listings Skill Trade does not match expected value for Credit");
                    test.Log(Status.Fail, "Manage Listings Skill Trade does not match expected value for Credit");
                    boolflag = false;
                }
            }

            if (SkillTrade != "Skill-exchange" && SkillTrade != "Credit")
            {
                Console.WriteLine("FAIL: Skill Trade input value '" + SkillTrade + "' is invalid");
                test.Log(Status.Fail, "Skill Trade input value '" + SkillTrade + "' is invalid");
                boolflag = false;
            }

            if (boolflag == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // commented out until solution is found to identify on/off status of Active icon
        //public bool CheckActiveOnManageListings(string Active)
        //{
            // how to check Active slider bar / checkbox to know if it is on or off / Active (blue) or Hidden (grey)
            //    // XPaths for Active and Hidden, respectively
            //    //*[@id="listing-management-section"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[7]/div
            //    //*[@id="listing-management-section"]/div[2]/div[1]/div[1]/table/tbody/tr[2]/td[7]/div/input
        //}

        public void Edit1stListing()
        {
            // wait for edit icon to be clickable
            Wait.WaitForElementToBeClickable("XPath", firstroweditIconXP, 3);

            firstroweditIcon.Click();
        }
    }
}
