using MVPSt_2023_Feb_Competition.Pages;
using MVPSt_2023_Feb_Competition.Utilities;
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

        public bool allvaluesonManageListings { get; private set; }

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
            //string? returnedMessage;
            bool doneyet;
            bool finishedadding;
            int NumberOfExistingListingsInt;
            //int numberofListingsbeforeAction;
            //int numberofListingsafterAction;
            bool allvaluesonManageListings;

            // call method to read all rows of external data file into an internal table
            ExcelLib.PopulateIntoCollection(filePath3, sheetName3);

            // begin assigning data from internal table to variables
            // that will be passed as parameters to the method that creates a Share Skill listing
            //
            // how do I get sheetName3RowInt to retain it's value established in Nunit's [Setup] hook in CommonDriver?
            // -- by moving it above the [Setup] hook
            // and using int.Parse instead of int32.TryParse to set its value
            //
            GetRowOfTestData(sheetName3RowInt);

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
                //returnedMessage = shareSkillPageObj.CreateShareSkill(ActionButton, FollowupAction, Title, Description, Category, Subcategory, Tags, ServiceType, Location, StartDate, EndDate, Sun, SunStartTime, SunEndTime, Mon, MonStartTime, MonEndTime, Tue, TueStartTime, TueEndTime, Wed, WedStartTime, WedEndTime, Thu, ThuStartTime, ThuEndTime, Fri, FriStartTime, FriEndTime, Sat, SatStartTime, SatEndTime, SkillTrade, SkillExchange, Credit, WorkSamples, Active, ExpectedPopupMessage, ExpectedFollowupPopupMessage);

                //shareSkillPageObj.CreateShareSkill(ActionOfTest, ValidInvalid, ActionButton, FollowupAction, Title, TitleError, Description, DescriptionError, Category, Subcategory, Tags, ServiceType, Location, StartDate, EndDate, StartEndDateError, Sun, SunStartTime, SunEndTime, Mon, MonStartTime, MonEndTime, Tue, TueStartTime, TueEndTime, Wed, WedStartTime, WedEndTime, Thu, ThuStartTime, ThuEndTime, Fri, FriStartTime, FriEndTime, Sat, SatStartTime, SatEndTime, SkillTrade, SkillExchange, Credit, WorkSamples, Active, ExpectedPopupMessage, ExpectedFollowupPopupMessage);
                AddAllShareSkillData(ActionOfTest);

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
                //    test.Log(Status.Fail, "Number of actual listings '" + numberofListingsafterAction + "' do(does) not match expected number '" + (NumberOfExistingListingsInt + 1) + "'");
                //    Assert.Fail("Number of actual listings '" + numberofListingsafterAction + "' do(does) not match expected number '" + (NumberOfExistingListingsInt + 1) + "'");
                //}

                // call method to compare actual results on Manage Listings page
                // and return true if all values match or false if 1 or more values do not match
                // most recently created listing is the top listing on the Manage Listings page
                // use numberofListingsbeforeAction as 1st parm when count listings method is working
                //if (ValidateManageListingsValues(NumberOfExistingListingsInt, ActionOfTest, ValidInvalid, Category, Title, Description, ServiceType, SkillTrade, Active) == true)
                if (ValidateManageListingsValues(Category, Title, Description, ServiceType, SkillTrade, Active) == true)
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
                        GrabScreenShot(TestCaseID);
                        Assert.Fail("1 or more values on Share Skill page do not match expected values");
                    }
                }
                else
                {
                    Console.WriteLine("FAIL: 1 or more values on Manage Listings page do not match expected values");
                    test.Log(Status.Fail, "1 or more values on Manage Listings page do not match expected values");
                    GrabScreenShot(TestCaseID);
                    Assert.Fail("1 or more values on Manage Listings page do not match expected values");
                }
            }

            // do these 2 conditions need to be brought inside the "AddShareSkill" condition or can they be made generic to remain outside the condition?
            // must consider values of Action Button:
            // -- if Cancel, then # of listings must remain the same
            // -- if Save, and ValidInvalid = Valid, then # of listings must be 1 more than Number of Existing Listings parameter OR 1 more than the 'pre-action' listing count
            // -- if Save, and ValidInvalid = Invalid, then # of listings must remain the same

            if (ActionOfTest == "AddShareSkillInvalid")
            {
                homePageObj.NavigateToShareSkill();
                finishedadding = false;

                do
                {
                    //shareSkillPageObj.CreateShareSkill(ActionOfTest, ValidInvalid, ActionButton, FollowupAction, Title, TitleError, Description, DescriptionError, Category, Subcategory, Tags, ServiceType, Location, StartDate, EndDate, StartEndDateError, Sun, SunStartTime, SunEndTime, Mon, MonStartTime, MonEndTime, Tue, TueStartTime, TueEndTime, Wed, WedStartTime, WedEndTime, Thu, ThuStartTime, ThuEndTime, Fri, FriStartTime, FriEndTime, Sat, SatStartTime, SatEndTime, SkillTrade, SkillExchange, Credit, WorkSamples, Active, ExpectedPopupMessage, ExpectedFollowupPopupMessage);
                    AddAllShareSkillData(ActionOfTest);
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

                // call a method to click the Cancel button on the Share Skill page because invalid data will not be allowed to be saved
                shareSkillPageObj.ClickTheCancelButton();

                // verify number of listings on Manage Listings page remains unchanged
                //homePageObj.NavigateToManageListings();
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
                // since duplicate listings are permitted, program will not verify the category, title, description, and service type match before editing
                // edit listing at top of page 1 on the Manage Listings page
                manageListingsPageObj.Edit1stListing();
                //shareSkillPageObj.CreateShareSkill(ActionOfTest, ValidInvalid, ActionButton, FollowupAction, Title, TitleError, Description, DescriptionError, Category, Subcategory, Tags, ServiceType, Location, StartDate, EndDate, StartEndDateError, Sun, SunStartTime, SunEndTime, Mon, MonStartTime, MonEndTime, Tue, TueStartTime, TueEndTime, Wed, WedStartTime, WedEndTime, Thu, ThuStartTime, ThuEndTime, Fri, FriStartTime, FriEndTime, Sat, SatStartTime, SatEndTime, SkillTrade, SkillExchange, Credit, WorkSamples, Active, ExpectedPopupMessage, ExpectedFollowupPopupMessage);
                AddAllShareSkillData(ActionOfTest);

                if (ValidateManageListingsValues(Category, Title, Description, ServiceType, SkillTrade, Active) == true)
                {
                    Console.WriteLine("Pass: Values on Manage Listings page match expected, edited values");
                    test.Log(Status.Pass, "Values on Manage Listings page match expected, edited values");

                    // call method to compare actual results from the Share Skills page by editing the listing that was edited in this test (top of listings)
                    manageListingsPageObj.Edit1stListing();

                    if (shareSkillPageObj.CompareShareSkillValues(ActionOfTest, Title, Description, Category, Subcategory, Tags, ServiceType, Location, StartDate, EndDate, Sun, SunStartTime, SunEndTime, Mon, MonStartTime, MonEndTime, Tue, TueStartTime, TueEndTime, Wed, WedStartTime, WedEndTime, Thu, ThuStartTime, ThuEndTime, Fri, FriStartTime, FriEndTime, Sat, SatStartTime, SatEndTime, SkillTrade, SkillExchange, Credit, WorkSamples, Active) == true)
                    {
                        Console.WriteLine("Pass: Values on Share Skill page match expected, edited values");
                        test.Log(Status.Pass, "Values on Share Skill page match expected, edited values");
                    }
                    else
                    {
                        Console.WriteLine("FAIL: 1 or more values on Share Skill page do not match expected, edited values");
                        test.Log(Status.Fail, "1 or more values on Share Skill page do not match expected, edited values");
                        GrabScreenShot(TestCaseID);
                        Assert.Fail("1 or more values on Share Skill page do not match expected, edited values");
                    }
                }
                else
                {
                    Console.WriteLine("FAIL: 1 or more values on Manage Listings page do not match expected, edited values");
                    test.Log(Status.Fail, "1 or more values on Manage Listings page do not match expected, edited values");
                    GrabScreenShot(TestCaseID);
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

        public void AddAllShareSkillData(string ActionOfTest)
        {
            // define Pages and Page objects
            ShareSkillPage shareSkillPageObj;

            // initialize Page objects
            shareSkillPageObj = new ShareSkillPage();

            if (ActionOfTest == "AddShareSkillValid")
            {
                test.Log(Status.Info, "Attempting to add a listing on the Share Skill page using valid data");
            }

            if (ActionOfTest == "AddShareSkillInvalid")
            {
                test.Log(Status.Info, "Attempting to add a listing on the Share Skill page using Invalid data");
            }

            if (ActionOfTest == "EditShareSkillValid")
            {
                test.Log(Status.Info, "Attempting to edit a listing on the Share Skill page using valid data");
            }

            shareSkillPageObj.AddTitle(ValidInvalid, Title);
            shareSkillPageObj.AddDescription(ValidInvalid, Description);
            shareSkillPageObj.AddCategory(Category);
            shareSkillPageObj.AddSubcategory(Subcategory);
            shareSkillPageObj.AddTags(ActionOfTest, Tags);
            shareSkillPageObj.AddServiceType(ServiceType);
            shareSkillPageObj.AddLocation(Location);
            shareSkillPageObj.AddStartDate(StartDate);
            shareSkillPageObj.AddEndDate(EndDate);
            shareSkillPageObj.AddSunday(Sun);
            shareSkillPageObj.AddSundayStartTime(SunStartTime);
            shareSkillPageObj.AddSundayEndTime(SunEndTime);
            shareSkillPageObj.AddMonday(Mon);
            shareSkillPageObj.AddMondayStartTime(MonStartTime);
            shareSkillPageObj.AddMondayEndTime(MonEndTime);
            shareSkillPageObj.AddTuesday(Tue);
            shareSkillPageObj.AddTuesdayStartTime(TueStartTime);
            shareSkillPageObj.AddTuesdayEndTime(TueEndTime);
            shareSkillPageObj.AddWednesday(Wed);
            shareSkillPageObj.AddWednesdayStartTime(WedStartTime);
            shareSkillPageObj.AddWednesdayEndTime(WedEndTime);
            shareSkillPageObj.AddThursday(Thu);
            shareSkillPageObj.AddThursdayStartTime(ThuStartTime);
            shareSkillPageObj.AddThursdayEndTime(ThuEndTime);
            shareSkillPageObj.AddFriday(Fri);
            shareSkillPageObj.AddFridayStartTime(FriStartTime);
            shareSkillPageObj.AddFridayEndTime(FriEndTime);
            shareSkillPageObj.AddSaturday(Sat);
            shareSkillPageObj.AddSaturdayStartTime(SatStartTime);
            shareSkillPageObj.AddSaturdayEndTime(SatEndTime);
            shareSkillPageObj.AddSkillTrade(SkillTrade, SkillExchange, Credit);
            shareSkillPageObj.AddWorkSamples(WorkSamples);
            shareSkillPageObj.AddActive(Active);

            shareSkillPageObj.ProcessTheActionButton(ValidInvalid, ActionButton, TitleError, DescriptionError, StartEndDateError);
        }

        public bool ValidateManageListingsValues(string Category, string Title, string Description, string ServiceType, string SkillTrade, string Active)
        {
            test.Log(Status.Info, "Beginning comparisons of only the top row/listing on Manage Listings page");

            allvaluesonManageListings = true;
            
            if (manageListingsPageObj.CheckCategoryOnManageListings(Category) == false)
            {
                allvaluesonManageListings = false;
            }

            if (manageListingsPageObj.CheckTitleOnManageListings(Title) == false)
            { 
                allvaluesonManageListings = false;
            }

            if (manageListingsPageObj.CheckDescriptionOnManageListings(Description) == false)
            {
                allvaluesonManageListings = false;
            }

            if (manageListingsPageObj.CheckServiceTypeOnManageListings(ServiceType) == false)
            { 
                allvaluesonManageListings = false;
            }

            if (manageListingsPageObj.CheckSkillTradeOnManageListings(SkillTrade) == false)
            {
                allvaluesonManageListings = false;
            }

            //if (manageListingsPageObj.CheckActiveOnManageListings(Active) == false)
            //{
            //    allvaluesonManageListings = false;
            //}


            if (allvaluesonManageListings == true)
            {
                /// force false to generate an error and screenshot
                //return false;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
