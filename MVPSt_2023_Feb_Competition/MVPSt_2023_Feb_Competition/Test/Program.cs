using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MVPSt_2023_Feb_Competition.Pages;
using MVPSt_2023_Feb_Competition.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
//using OpenQA.Selenium.DevTools.V107.Runtime;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace MVPSt_2023_Feb_Competition.Test
{
    [TestFixture]
    public class TheDriver : CommonDriver
    //public class TheDriver
    {

        ManageListingsPage manageListingsPageObj;

        //[TestCase(1)] // headers
        //[TestCase(2)] // Happy path TC_004_02
        //[TestCase(3)] // Negative test TC_008_01 rows 3 - 5 in spreadsheet
        //[TestCase(4)]

        //public void Example(int i)
        //{
        //}

        static string? TestCaseID;
        static string? NumberOfExistingListings;
        static string? ActionOfTest;
        static string? ValidInvalid;
        static string? ActionButton;
        static string? FollowupAction;
        static string? Title;
        static string? TitleError;
        static string? Description;
        static string? DescriptionError;
        static string? Category;
        static string? Subcategory;
        static string? Tags;
        static string? ServiceType;
        static string? Location;
        static string? StartDate;
        static string? EndDate;
        static string? StartEndDateError;
        static string? Sun;
        static string? SunStartTime;
        static string? SunEndTime;
        static string? Mon;
        static string? MonStartTime;
        static string? MonEndTime;
        static string? Tue;
        static string? TueStartTime;
        static string? TueEndTime;
        static string? Wed;
        static string? WedStartTime;
        static string? WedEndTime;
        static string? Thu;
        static string? ThuStartTime;
        static string? ThuEndTime;
        static string? Fri;
        static string? FriStartTime;
        static string? FriEndTime;
        static string? Sat;
        static string? SatStartTime;
        static string? SatEndTime;
        static string? SkillTrade;
        static string? SkillExchange;
        static string? Credit;
        static string? WorkSamples;
        static string? Active;
        static string? ExpectedPopupMessage;
        static string? ExpectedFollowupPopupMessage;

        [Test]
        //public void DetermineAction(int i)
        public void DetermineAction()
        {
            Console.WriteLine("In the Program test");

            // define Pages and Page objects
            HomePage homePageObj;
            ShareSkillPage shareSkillPageObj;

            // initialize Page objects
            homePageObj = new HomePage();
            shareSkillPageObj = new ShareSkillPage();
            manageListingsPageObj = new ManageListingsPage();

            // Miscellaneous
            string? returnedMessage;
            bool doneyet;
            bool finishedadding;
            int NumberOfExistingListingsInt;
            //int numberofListingsbeforeAction;
            //int numberofListingsafterAction;

            // call method to read all rows of external data file into an internal table
            ExcelLib.PopulateIntoCollection(filePath3, sheetName3);

            // begin assigning data from internal table to variables
            // that will be passed as parameters to the method that creates a Share Skill listing
            //
            // how do I get sheetName3RowInt to retain it's value established in Nunit's [Setup] hook in CommonDriver?
            // -- by moving it above the [Setup] hook
            // and using int.Parse instead of int32.TryParse to set its value
            //



            // try to call the method to read all of the internal table values into the variables
            GetRowOfTestData(sheetName3RowInt);

            //// get test case ID which may or may not be used by this script
            //string TestCaseID = ExcelLib.ReadData(sheetName3RowInt, "TestCaseID");

            //// get number of existing listings (driving info) from internal, populated collection
            //string NumberOfExistingListings = ExcelLib.ReadData(sheetName3RowInt, "NumberOfExistingListings");
            ////string NumberOfExistingListings = ExcelLib.ReadData(2, "NumberOfExistingListings");

            //// get action of test (driving info) from internal, populated collection
            ////string ActionOfTest = ExcelLib.ReadData(sheetName3RowInt, "ActionOfTest");
            //string ActionOfTest = ExcelLib.ReadData(sheetName3RowInt, "ActionOfTest");

            //// removed ValidInvalid from spreadsheet -- it was returned
            //// get valid/invalid (driving info) from internal, populated collection
            //string ValidInvalid = ExcelLib.ReadData(sheetName3RowInt, "ValidInvalid");

            //// get action button (driving info) from internal, populated collection
            //string ActionButton = ExcelLib.ReadData(sheetName3RowInt, "ActionButton");

            //// get followup action (driving info) from internal, populated collection
            //string FollowupAction = ExcelLib.ReadData(sheetName3RowInt, "FollowupAction");

            //// get title
            //string Title = ExcelLib.ReadData(sheetName3RowInt, "Title");

            //// get the rest of the test data for the Share Skill page
            //string TitleError = ExcelLib.ReadData(sheetName3RowInt, "TitleError");
            //string Description = ExcelLib.ReadData(sheetName3RowInt, "Description");
            //string DescriptionError = ExcelLib.ReadData(sheetName3RowInt, "DescriptionError");
            //string Category = ExcelLib.ReadData(sheetName3RowInt, "Category");
            //string Subcategory = ExcelLib.ReadData(sheetName3RowInt, "Subcategory");
            //string Tags = ExcelLib.ReadData(sheetName3RowInt, "Tags");
            //string ServiceType = ExcelLib.ReadData(sheetName3RowInt, "ServiceType");
            //string Location = ExcelLib.ReadData(sheetName3RowInt, "Location");
            //string StartDate = ExcelLib.ReadData(sheetName3RowInt, "StartDate");
            //string EndDate = ExcelLib.ReadData(sheetName3RowInt, "EndDate");
            //string StartEndDateError = ExcelLib.ReadData(sheetName3RowInt, "StartEndDateError");
            //string Sun = ExcelLib.ReadData(sheetName3RowInt, "Sun");
            //string SunStartTime = ExcelLib.ReadData(sheetName3RowInt, "SunStartTime");
            //string SunEndTime = ExcelLib.ReadData(sheetName3RowInt, "SunEndTime");
            //string Mon = ExcelLib.ReadData(sheetName3RowInt, "Mon");
            //string MonStartTime = ExcelLib.ReadData(sheetName3RowInt, "MonStartTime");
            //string MonEndTime = ExcelLib.ReadData(sheetName3RowInt, "MonEndTime");
            //string Tue = ExcelLib.ReadData(sheetName3RowInt, "Tue");
            //string TueStartTime = ExcelLib.ReadData(sheetName3RowInt, "TueStartTime");
            //string TueEndTime = ExcelLib.ReadData(sheetName3RowInt, "TueEndTime");
            //string Wed = ExcelLib.ReadData(sheetName3RowInt, "Wed");
            //string WedStartTime = ExcelLib.ReadData(sheetName3RowInt, "WedStartTime");
            //string WedEndTime = ExcelLib.ReadData(sheetName3RowInt, "WedEndTime");
            //string Thu = ExcelLib.ReadData(sheetName3RowInt, "Thu");
            //string ThuStartTime = ExcelLib.ReadData(sheetName3RowInt, "ThuStartTime");
            //string ThuEndTime = ExcelLib.ReadData(sheetName3RowInt, "ThuEndTime");
            //string Fri = ExcelLib.ReadData(sheetName3RowInt, "Fri");
            //string FriStartTime = ExcelLib.ReadData(sheetName3RowInt, "FriStartTime");
            //string FriEndTime = ExcelLib.ReadData(sheetName3RowInt, "FriEndTime");
            //string Sat = ExcelLib.ReadData(sheetName3RowInt, "Sat");
            //string SatStartTime = ExcelLib.ReadData(sheetName3RowInt, "SatStartTime");
            //string SatEndTime = ExcelLib.ReadData(sheetName3RowInt, "SatEndTime");
            //string SkillTrade = ExcelLib.ReadData(sheetName3RowInt, "SkillTrade");
            //string SkillExchange = ExcelLib.ReadData(sheetName3RowInt, "SkillExchange");
            //string Credit = ExcelLib.ReadData(sheetName3RowInt, "Credit");
            //string WorkSamples = ExcelLib.ReadData(sheetName3RowInt, "WorkSamples");
            //string Active = ExcelLib.ReadData(sheetName3RowInt, "Active");
            //string ExpectedPopupMessage = ExcelLib.ReadData(sheetName3RowInt, "ExpectedPopupMessage");
            //string ExpectedFollowupPopupMessage = ExcelLib.ReadData(sheetName3RowInt, "ExpectedFollowupPopupMessage");

            //// for Extent Reports
            //test = null;
            //test = extent.CreateTest(TestCaseID).Info("Add Share Skill");

            // convert string parameter to integer variable
            NumberOfExistingListingsInt = Int32.Parse(NumberOfExistingListings);

            // capture # of rows of listings on all of the Manage Listings pages before proceeding
            //homePageObj.NavigateToManageListings();
            //numberofListingsbeforeAction = manageListingsPageObj.CountAllListings();
            //Console.WriteLine("numberofListingsbeforeAction = " + numberofListingsbeforeAction);

            //if (numberofListingsbeforeAction != NumberOfExistingListingsInt)
            //{
            //    Console.WriteLine("FAIL: Number of actual listings '" + numberofListingsbeforeAction + "' do(does) not match expected number '" + NumberOfExistingListingsInt + "'");
            //    Assert.Fail("Number of actual listings '" + numberofListingsbeforeAction + "' do(does) not match expected number '" + NumberOfExistingListingsInt + "'");
            //    //Console.WriteLine("Ending program... by clearning ActionOfTest parameter");
            //    ActionOfTest = null;
            //}

            //manageListingsPageObj.NavigateToProfileHome();

            if (ActionOfTest == "AddShareSkillValid")
            {
                homePageObj.NavigateToShareSkill();
                //manageListingsPageObj.NavigateToShareSkill();
                //if (shareSkillPageObj.CreateShareSkill(ActionButton, FollowupAction, Title, Description, Category, Subcategory, Tags, ServiceType, Location, StartDate, EndDate, Sun, SunStartTime, SunEndTime, Mon, MonStartTime, MonEndTime, Tue, TueStartTime, TueEndTime, Wed, WedStartTime, WedEndTime, Thu, ThuStartTime, ThuEndTime, Fri, FriStartTime, FriEndTime, Sat, SatStartTime, SatEndTime, SkillTrade, SkillExchange, Credit, WorkSamples, Active, ExpectedPopupMessage, ExpectedFollowupPopupMessage) == false)
                //returnedMessage = shareSkillPageObj.CreateShareSkill(ActionButton, FollowupAction, Title, Description, Category, Subcategory, Tags, ServiceType, Location, StartDate, EndDate, Sun, SunStartTime, SunEndTime, Mon, MonStartTime, MonEndTime, Tue, TueStartTime, TueEndTime, Wed, WedStartTime, WedEndTime, Thu, ThuStartTime, ThuEndTime, Fri, FriStartTime, FriEndTime, Sat, SatStartTime, SatEndTime, SkillTrade, SkillExchange, Credit, WorkSamples, Active, ExpectedPopupMessage, ExpectedFollowupPopupMessage);
                //finishedadding = false;
                //do
                //{
                shareSkillPageObj.CreateShareSkill(ActionOfTest, ValidInvalid, ActionButton, FollowupAction, Title, TitleError, Description, DescriptionError, Category, Subcategory, Tags, ServiceType, Location, StartDate, EndDate, StartEndDateError, Sun, SunStartTime, SunEndTime, Mon, MonStartTime, MonEndTime, Tue, TueStartTime, TueEndTime, Wed, WedStartTime, WedEndTime, Thu, ThuStartTime, ThuEndTime, Fri, FriStartTime, FriEndTime, Sat, SatStartTime, SatEndTime, SkillTrade, SkillExchange, Credit, WorkSamples, Active, ExpectedPopupMessage, ExpectedFollowupPopupMessage);

                ////////// should there be a check of the ActionButton = "Save"?
                /// Yes, if Cancel add share skill test cases use this same path via an OR condition in the ActionOfTest condition
                /// No, if Cancel add share skill test cases use a different path for its different ActionOfTest value


                //Thread.Sleep(3000);
                // verify number of listings on Manage Listings page has increased by 1
                //numberofListingsafterAction = manageListingsPageObj.CountAllListings();
                //Console.WriteLine("numberofListingsafterAction = " + numberofListingsafterAction);

                /////// force match because still trying the get CountAllListings to work -- unable to determine how to know whether or not the dynamic web element is enabled
                //numberofListingsafterAction++;

                //if (numberofListingsafterAction == NumberOfExistingListingsInt + 1)
                //{
                //    Console.WriteLine("Number of actual listings '" + numberofListingsafterAction + "' matches expected number '" + (NumberOfExistingListingsInt + 1) + "'");
                //}
                //else
                //{
                //    Console.WriteLine("FAIL: Number of actual listings '" + numberofListingsafterAction + "' do(does) not match expected number '" + (NumberOfExistingListingsInt + 1) + "'");
                //    Assert.Fail("Number of actual listings '" + numberofListingsafterAction + "' do(does) not match expected number '" + (NumberOfExistingListingsInt + 1) + "'");
                //}

                // FollowupAction is only relevant for multiple rows of invalid data
                //    if (FollowupAction == "Yes")
                //    {
                //        // add 1 to the row number and read the next row of test data
                //        sheetName3RowInt++;
                //        GetRowOfTestData(sheetName3RowInt);
                //    }
                //    else
                //    {
                //        finishedadding = true;
                //    }
                //}
                //while (finishedadding = false);

                //shareSkillPageObj.CreateShareSkill(ValidInvalid, ActionButton, FollowupAction, Title, Description, Category, Subcategory, Tags, ServiceType, Location, StartDate, EndDate, Sun, SunStartTime, SunEndTime, Mon, MonStartTime, MonEndTime, Tue, TueStartTime, TueEndTime, Wed, WedStartTime, WedEndTime, Thu, ThuStartTime, ThuEndTime, Fri, FriStartTime, FriEndTime, Sat, SatStartTime, SatEndTime, SkillTrade, SkillExchange, Credit, WorkSamples, Active, ExpectedPopupMessage, ExpectedFollowupPopupMessage);
                //if (ActionButton == "Save") // must also consider ValidInvalid because Save with invalid data is a valid test -- removed from spreadsheet, combined with ActionOfTest
                //{
                //if (returnedMessage != ExpectedPopupMessage)
                //{
                //    Console.WriteLine("Actual message '" + returnedMessage + "' did not match expected message '" + ExpectedPopupMessage + "' so exiting program from Program.cs");
                //    //Cleanup();
                //}

                // what page is the user on? Look for the Save button -- if found then still on the Share Skill page; otherwise, on Manage Listings page

                //if (saveButton
                //{

                //}
                //else
                //{
                //    // call method to compare actual results on Manage Listings page, including verifying total number of listings (rows in table)
                //    // and return true if all values match or false if 1 or more values do not match
                //    // most recently created listing is the top listing on the Manage Listings page
                //    Thread.Sleep(6000);

                if (ValidateManageListingsValues(NumberOfExistingListingsInt, Category, Title, Description, ServiceType, SkillTrade, Active) == true)
                //if (manageListingsPageObj.CompareManageListingsValues(NumberOfExistingListings, Category, Title, Description, ServiceType, SkillTrade, Active) == true)
                {
                    Console.WriteLine("Pass: Values on Manage Listings page match expected values");
                    test.Log(Status.Pass, "Values on Manage Listings page match expected values");

                    // call method to compare actual results from the Share Skills page by editing the listing that was created in this test (top of listings)
                    manageListingsPageObj.Edit1stListing();
                    if (shareSkillPageObj.CompareShareSkillValues(ActionOfTest, Title, Description, Category, Subcategory, Tags, ServiceType, Location, StartDate, EndDate, Sun, SunStartTime, SunEndTime, Mon, MonStartTime, MonEndTime, Tue, TueStartTime, TueEndTime, Wed, WedStartTime, WedEndTime, Thu, ThuStartTime, ThuEndTime, Fri, FriStartTime, FriEndTime, Sat, SatStartTime, SatEndTime, SkillTrade, SkillExchange, Credit, WorkSamples, Active) == true)
                    {
                        Console.WriteLine("Pass: Values on Share Skill page match expected values");
                        test.Log(Status.Pass, "Values on Share Skill page match expected values");
                    }
                    else
                    {
                        Console.WriteLine("FAIL: 1 or more values on Share Skill page do not match expected values");
                        test.Log(Status.Fail, "1 or more values on Share Skill page do not match expected values");
                        Assert.Fail("1 or more values on Share Skill page do not match expected values");
                    }
                }
                else
                {
                    Console.WriteLine("FAIL: 1 or more values on Manage Listings page do not match expected values");
                    test.Log(Status.Fail, "1 or more values on Manage Listings page do not match expected values");
                    Assert.Fail("1 or more values on Manage Listings page do not match expected values");
                }
                //{
                    //// call method to compare actual results from the Share Skills page by editing the listing that was created in this test (top of listings)
                    //manageListingsPageObj.Edit1stListing();
                    //if (shareSkillPageObj.CompareShareSkillValues(Title, Description, Category, Subcategory, Tags, ServiceType, Location, StartDate, EndDate, Sun, SunStartTime, SunEndTime, Mon, MonStartTime, MonEndTime, Tue, TueStartTime, TueEndTime, Wed, WedStartTime, WedEndTime, Thu, ThuStartTime, ThuEndTime, Fri, FriStartTime, FriEndTime, Sat, SatStartTime, SatEndTime, SkillTrade, SkillExchange, Credit, WorkSamples, Active) == true)
                    //{
                    //    Console.WriteLine("Values on Share Skill page match expected values");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("FAIL: 1 or more values on Share Skill page do not match expected values");
                    //    //Cleanup();
                    //}
                //}
            }
            //else
            //{
            //    if (ActionButton == "Cancel")
            //    {
            //        // user returns to page they were on when the Share Skill button was pressed -- in our case, Profile/Home
            //        // verify # of listings remains unchanged by capturing # of rows of listings on the Manage Listings page

            //    }
            //}
            // do these 2 conditions need to be brought inside the "AddShareSkill" condition or can they be made generic to remain outside the condition?
            // must consider values of Action Button:
            // -- if Cancel, then # of listings must remain the same
            // -- if Save, and ValidInvalid = Valid, then # of listings must be 1 more than Number of Existing Listings
            // -- if Save, and ValidInvalid = Invalid, then # of listings must remain the same

            //if (NumberOfExistingListings == "1")
            //{
            //    // get # of rows on Manage Listings page and make sure it is "2", otherwise; throw an error
            //}

            //if (ValidInvalid == "Valid")
            //{
            //    // make sure Action Button = 
            //}

            // perform the Teardown steps of signing out and closing and quitting the driver
            //Cleanup();

            if (ActionOfTest == "AddShareSkillInvalid")
            {
                homePageObj.NavigateToShareSkill();
                //manageListingsPageObj.NavigateToShareSkill();
                //returnedMessage = shareSkillPageObj.CreateShareSkill(ActionButton, FollowupAction, Title, Description, Category, Subcategory, Tags, ServiceType, Location, StartDate, EndDate, Sun, SunStartTime, SunEndTime, Mon, MonStartTime, MonEndTime, Tue, TueStartTime, TueEndTime, Wed, WedStartTime, WedEndTime, Thu, ThuStartTime, ThuEndTime, Fri, FriStartTime, FriEndTime, Sat, SatStartTime, SatEndTime, SkillTrade, SkillExchange, Credit, WorkSamples, Active, ExpectedPopupMessage, ExpectedFollowupPopupMessage);
                finishedadding = false;
                //test.Log(AventStack.ExtentReports.Status.Info, "Go to Share Skill page to add Invalid data");
                do
                {
                    shareSkillPageObj.CreateShareSkill(ActionOfTest, ValidInvalid, ActionButton, FollowupAction, Title, TitleError, Description, DescriptionError, Category, Subcategory, Tags, ServiceType, Location, StartDate, EndDate, StartEndDateError, Sun, SunStartTime, SunEndTime, Mon, MonStartTime, MonEndTime, Tue, TueStartTime, TueEndTime, Wed, WedStartTime, WedEndTime, Thu, ThuStartTime, ThuEndTime, Fri, FriStartTime, FriEndTime, Sat, SatStartTime, SatEndTime, SkillTrade, SkillExchange, Credit, WorkSamples, Active, ExpectedPopupMessage, ExpectedFollowupPopupMessage);
                    if (FollowupAction == "Yes")
                    {
                        // add 1 to the row number and read the next row of test data
                        sheetName3RowInt++;
                        GetRowOfTestData(sheetName3RowInt);
                    }
                    else // FollowupAction is not "Yes", it could be empty, null, whitespace, or "No"
                    {
                        finishedadding = true;
                    }
                }
                while (finishedadding == false);

                // call a method to click the Cancel button on the Share Skill page to load the Manage Listings page
                shareSkillPageObj.ClickTheCancelButton();

                // verify number of listings on Manage Listings page remains unchanged
                //numberofListingsafterAction = manageListingsPageObj.CountAllListings();

                //if (numberofListingsafterAction != NumberOfExistingListingsInt)
                //{
                //    Console.WriteLine("FAIL: Number of actual listings '" + numberofListingsafterAction + "' do(does) not match expected number '" + NumberOfExistingListingsInt + "'");
                //    Assert.Fail("Number of actual listings '" + numberofListingsafterAction + "' do(does) not match expected number '" + NumberOfExistingListingsInt + "'");
                //}
            }

            if (ActionOfTest == "EditShareSkillValid")
            {
                //manageListingsPageObj.NavigateToShareSkill();
                homePageObj.NavigateToManageListings();
                // even presuming the listing at top of the Manage Listings page is the listing to edit
                // still verify the category, title, description, and service type match before editing
                manageListingsPageObj.Edit1stListing();
                shareSkillPageObj.CreateShareSkill(ActionOfTest, ValidInvalid, ActionButton, FollowupAction, Title, TitleError, Description, DescriptionError, Category, Subcategory, Tags, ServiceType, Location, StartDate, EndDate, StartEndDateError, Sun, SunStartTime, SunEndTime, Mon, MonStartTime, MonEndTime, Tue, TueStartTime, TueEndTime, Wed, WedStartTime, WedEndTime, Thu, ThuStartTime, ThuEndTime, Fri, FriStartTime, FriEndTime, Sat, SatStartTime, SatEndTime, SkillTrade, SkillExchange, Credit, WorkSamples, Active, ExpectedPopupMessage, ExpectedFollowupPopupMessage);

                if (ValidateManageListingsValues(NumberOfExistingListingsInt, Category, Title, Description, ServiceType, SkillTrade, Active) == true)
                {
                    Console.WriteLine("Pass: Values on Manage Listings page match expected, edited values");
                    test.Log(Status.Pass, "Values on Manage Listings page match expected, edited values");

                    // call method to compare actual results from the Share Skills page by editing the listing that was edited in this test (top of listings)
                    manageListingsPageObj.Edit1stListing();
        // need a variation to CompareShareSkillValues because existed Tags were edited !!! -- NO!! Validate Tags only when ActionOfTest is not = EditShareSkillValid
                    if (shareSkillPageObj.CompareShareSkillValues(ActionOfTest, Title, Description, Category, Subcategory, Tags, ServiceType, Location, StartDate, EndDate, Sun, SunStartTime, SunEndTime, Mon, MonStartTime, MonEndTime, Tue, TueStartTime, TueEndTime, Wed, WedStartTime, WedEndTime, Thu, ThuStartTime, ThuEndTime, Fri, FriStartTime, FriEndTime, Sat, SatStartTime, SatEndTime, SkillTrade, SkillExchange, Credit, WorkSamples, Active) == true)
                    {
                        Console.WriteLine("Pass: Values on Share Skill page match expected, edited values");
                        test.Log(Status.Pass, "Values on Share Skill page match expected, edited values");
                    }
                    else
                    {
                        Console.WriteLine("FAIL: 1 or more values on Share Skill page do not match expected, edited values");
                        test.Log(Status.Fail, "1 or more values on Share Skill page do not match expected, edited values");
                        Assert.Fail("1 or more values on Share Skill page do not match expected, edited values");
                    }
                }
                else
                {
                    Console.WriteLine("FAIL: 1 or more values on Manage Listings page do not match expected, edited values");
                    test.Log(Status.Fail, "1 or more values on Manage Listings page do not match expected, edited values");
                    Assert.Fail("1 or more values on Manage Listings page do not match expected, edited values");
                }
            }
        }

        static void GetRowOfTestData(int newRow)
        {
            // get test case ID which may or may not be used by this script
            TestCaseID = ExcelLib.ReadData(newRow, "TestCaseID");

            // get number of existing listings (driving info) from internal, populated collection
            NumberOfExistingListings = ExcelLib.ReadData(newRow, "NumberOfExistingListings");

            // get action (driving info) from internal, populated collection
            ActionOfTest = ExcelLib.ReadData(newRow, "ActionOfTest");

            // removed ValidInvalid from spreadsheet -- it was returned
            // get valid/invalid (driving info) from internal, populated collection
            ValidInvalid = ExcelLib.ReadData(newRow, "ValidInvalid");

            // get action button (driving info) from internal, populated collection
            ActionButton = ExcelLib.ReadData(newRow, "ActionButton");

            // get followup action (driving info) from internal, populated collection
            FollowupAction = ExcelLib.ReadData(newRow, "FollowupAction");

            // get title
            Title = ExcelLib.ReadData(newRow, "Title");

            // get the rest of the test data for the Share Skill page
            TitleError = ExcelLib.ReadData(newRow, "TitleError");
            Description = ExcelLib.ReadData(newRow, "Description");
            DescriptionError = ExcelLib.ReadData(newRow, "DescriptionError");
            Category = ExcelLib.ReadData(newRow, "Category");
            Subcategory = ExcelLib.ReadData(newRow, "Subcategory");
            Tags = ExcelLib.ReadData(newRow, "Tags");
            ServiceType = ExcelLib.ReadData(newRow, "ServiceType");
            Location = ExcelLib.ReadData(newRow, "Location");
            StartDate = ExcelLib.ReadData(newRow, "StartDate");
            EndDate = ExcelLib.ReadData(newRow, "EndDate");
            StartEndDateError = ExcelLib.ReadData(newRow, "StartEndDateError");
            Sun = ExcelLib.ReadData(newRow, "Sun");
            SunStartTime = ExcelLib.ReadData(newRow, "SunStartTime");
            SunEndTime = ExcelLib.ReadData(newRow, "SunEndTime");
            Mon = ExcelLib.ReadData(newRow, "Mon");
            MonStartTime = ExcelLib.ReadData(newRow, "MonStartTime");
            MonEndTime = ExcelLib.ReadData(newRow, "MonEndTime");
            Tue = ExcelLib.ReadData(newRow, "Tue");
            TueStartTime = ExcelLib.ReadData(newRow, "TueStartTime");
            TueEndTime = ExcelLib.ReadData(newRow, "TueEndTime");
            Wed = ExcelLib.ReadData(newRow, "Wed");
            WedStartTime = ExcelLib.ReadData(newRow, "WedStartTime");
            WedEndTime = ExcelLib.ReadData(newRow, "WedEndTime");
            Thu = ExcelLib.ReadData(newRow, "Thu");
            ThuStartTime = ExcelLib.ReadData(newRow, "ThuStartTime");
            ThuEndTime = ExcelLib.ReadData(newRow, "ThuEndTime");
            Fri = ExcelLib.ReadData(newRow, "Fri");
            FriStartTime = ExcelLib.ReadData(newRow, "FriStartTime");
            FriEndTime = ExcelLib.ReadData(newRow, "FriEndTime");
            Sat = ExcelLib.ReadData(newRow, "Sat");
            SatStartTime = ExcelLib.ReadData(newRow, "SatStartTime");
            SatEndTime = ExcelLib.ReadData(newRow, "SatEndTime");
            SkillTrade = ExcelLib.ReadData(newRow, "SkillTrade");
            SkillExchange = ExcelLib.ReadData(newRow, "SkillExchange");
            Credit = ExcelLib.ReadData(newRow, "Credit");
            WorkSamples = ExcelLib.ReadData(newRow, "WorkSamples");
            Active = ExcelLib.ReadData(newRow, "Active");
            ExpectedPopupMessage = ExcelLib.ReadData(newRow, "ExpectedPopupMessage");
            ExpectedFollowupPopupMessage = ExcelLib.ReadData(newRow, "ExpectedFollowupPopupMessage");
        }

        public bool ValidateManageListingsValues(int NumberOfExistingListingsInt, string Category, string Title, string Description, string ServiceType, string SkillTrade, string Active)
        {
            if (manageListingsPageObj.CompareManageListingsValues(NumberOfExistingListingsInt, Category, Title, Description, ServiceType, SkillTrade, Active) == true)
            {
                //Console.WriteLine("Pass: Values on Manage Listings page match expected values");
                return true;
            }
            else
            {
                //Console.WriteLine("FAIL: 1 or more values on Manage Listings page do not match expected values");
                return false;
            }
        }
    }
}
