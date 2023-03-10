using MVPSt_2023_Feb_Competition.Utilities;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
//using OpenQA.Selenium.DevTools.V107.Browser;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static MVPSt_2023_Feb_Competition.Utilities.CommonDriver;
//using AutoIt;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using AventStack.ExtentReports;

namespace MVPSt_2023_Feb_Competition.Pages
{
    public class ShareSkillPage
    {
        // page objects
        private IWebElement titleTextbox => driver.FindElement(By.Name("title"));
        //private IWebElement savedtitleTextbox => driver.FindElement(By.XPath(savedtitleTextboxXP));
        private IWebElement descriptionTextbox => driver.FindElement(By.Name("description"));
        private IWebElement categoryDropDown => driver.FindElement(By.XPath(categoryDropDownXP));
        private IWebElement subcategoryDropDown => driver.FindElement(By.XPath(subcategoryDropDownXP));
        private IWebElement tagsTextbox => driver.FindElement(By.XPath(tagsTextboxXP));
        //private IWebElement remove1sttagTextbox = FindElement(By.XPath(remove1sttagTextboxXP));
        private IWebElement hourlyservicetypeRadioButton => driver.FindElement(By.XPath(hourlyservicetypeRadioButtonXP));
        private IWebElement oneoffservicetypeRadioButton => driver.FindElement(By.XPath(oneoffservicetypeRadioButtonXP));
        private IWebElement onsitelocationRadioButton => driver.FindElement(By.XPath(onsitelocationRadioButtonXP));
        private IWebElement onlinelocationRadioButton => driver.FindElement(By.XPath(onlinelocationRadioButtonXP));
        private IWebElement startdatedayTextbox => driver.FindElement(By.XPath(startdatedayTextboxXP));
        private IWebElement enddatedayTextbox => driver.FindElement(By.XPath(enddatedayTextboxXP));

        private IWebElement sunCheckbox => driver.FindElement(By.XPath(sunCheckboxXP));
        private IWebElement monCheckbox => driver.FindElement(By.XPath(monCheckboxXP));
        private IWebElement tueCheckbox => driver.FindElement(By.XPath(tueCheckboxXP));
        private IWebElement wedCheckbox => driver.FindElement(By.XPath(wedCheckboxXP));
        private IWebElement thuCheckbox => driver.FindElement(By.XPath(thuCheckboxXP));
        private IWebElement friCheckbox => driver.FindElement(By.XPath(friCheckboxXP));
        private IWebElement satCheckbox => driver.FindElement(By.XPath(satCheckboxXP));

        private IWebElement sunstarttimeTextbox => driver.FindElement(By.XPath(sunstarttimeTextboxXP));
        private IWebElement sunendtimeTextbox => driver.FindElement(By.XPath(sunendtimeTextboxXP));
        private IWebElement monstarttimeTextbox => driver.FindElement(By.XPath(monstarttimeTextboxXP));
        private IWebElement monendtimeTextbox => driver.FindElement(By.XPath(monendtimeTextboxXP));
        private IWebElement tuestarttimeTextbox => driver.FindElement(By.XPath(tuestarttimeTextboxXP));
        private IWebElement tueendtimeTextbox => driver.FindElement(By.XPath(tueendtimeTextboxXP));
        private IWebElement wedstarttimeTextbox => driver.FindElement(By.XPath(wedstarttimeTextboxXP));
        private IWebElement wedendtimeTextbox => driver.FindElement(By.XPath(wedendtimeTextboxXP));
        private IWebElement thustarttimeTextbox => driver.FindElement(By.XPath(thustarttimeTextboxXP));
        private IWebElement thuendtimeTextbox => driver.FindElement(By.XPath(thuendtimeTextboxXP));
        private IWebElement fristarttimeTextbox => driver.FindElement(By.XPath(fristarttimeTextboxXP));
        private IWebElement friendtimeTextbox => driver.FindElement(By.XPath(friendtimeTextboxXP));
        private IWebElement satstarttimeTextbox => driver.FindElement(By.XPath(satstarttimeTextboxXP));
        private IWebElement satendtimeTextbox => driver.FindElement(By.XPath(satendtimeTextboxXP));
        private IWebElement skillexchangeskilltradeRadioButton => driver.FindElement(By.XPath(skillexchangeskilltradeRadioButtonXP));
        private IWebElement creditskilltradeRadioButton => driver.FindElement(By.XPath(creditskilltradeRadioButtonXP));
        private IWebElement skillexchangeTextbox => driver.FindElement(By.XPath(skillexchangeTextboxXP));
        private IWebElement creditTextbox => driver.FindElement(By.XPath(creditTextboxXP));
        private IWebElement worksamplesicon => driver.FindElement(By.XPath(worksamplesiconXP));
        private IWebElement activeRadioButton => driver.FindElement(By.XPath(activeRadioButtonXP));
        private IWebElement hiddenRadioButton => driver.FindElement(By.XPath(hiddenRadioButtonXP));
        private IWebElement saveButton => driver.FindElement(By.XPath(saveButtonXP));
        private IWebElement cancelButton => driver.FindElement(By.XPath(cancelButtonXP));



        // Get elements used to validate Actual against Expected data
        //private string savedtitleTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input";
        //private IWebElement savedCategory;

        // XPath of elements
        // error message boxes
        private string titleerrormessageXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[2]/div";
        private string descriptionerrormessageXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[2]/div";
        private string startenddateerrormessageXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div[2]";

        private string categoryDropDownXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select";
        private string subcategoryDropDownXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select";
        private string tagsTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input";
        private string remove1sttagTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/span[1]/a";
        private string hourlyservicetypeRadioButtonXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input";
        private string oneoffservicetypeRadioButtonXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input";
        private string onsitelocationRadioButtonXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input";
        private string onlinelocationRadioButtonXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input";
        private string startdatedayTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input";
        private string enddatedayTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input";
        
        private string sunCheckboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input";
        private string monCheckboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input";
        private string tueCheckboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input";
        private string wedCheckboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[1]/div/input";
        private string thuCheckboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[6]/div[1]/div/input";
        private string friCheckboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[7]/div[1]/div/input";
        private string satCheckboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[8]/div[1]/div/input";

        private string sunstarttimeTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input";
        private string sunendtimeTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input";
        private string monstarttimeTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input";
        private string monendtimeTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input";
        private string tuestarttimeTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input";
        private string tueendtimeTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input";
        private string wedstarttimeTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input";
        private string wedendtimeTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input";
        private string thustarttimeTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[6]/div[2]/input";
        private string thuendtimeTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[6]/div[3]/input";
        private string fristarttimeTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[7]/div[2]/input";
        private string friendtimeTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[7]/div[3]/input";
        private string satstarttimeTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[8]/div[2]/input";
        private string satendtimeTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[8]/div[3]/input";
        private string skillexchangeskilltradeRadioButtonXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input";
        private string creditskilltradeRadioButtonXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input";
        private string skillexchangeTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input";
        private string creditTextboxXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/input";
        private string worksamplesiconXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i";
        private string activeRadioButtonXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input";
        private string hiddenRadioButtonXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input";
        private string saveButtonXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]";
        private string cancelButtonXP = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[2]";

        // Miscellaneous
        static bool emptynullorwhitespace;
        private int numberofDelimiters;
        private int numberofSkills;
        public static DateTime calculatedDate;
        public static string stringDate;
        public static string ReformattedDate;
        public static string finalDate;
        public static string timeString;
        public static string reformattedtime;
        public static string AutoITuploadscript = "C:\\Users\\User\\Documents\\MVP Studio Projects\\MVPSt_2023_Feb_Competition\\MVPSt_2023_Feb_Competition\\MVPSt_2023_Feb_Competition\\Utilities\\AutoITScripts\\UploadFileScript.exe";
        //public static string savedMessage;
        //public static string capturedMessage;

    
        public void CreateShareSkill(string ActionOfTest, string ValidInvalid, string ActionButton, string FollowupAction, string Title, string TitleError, string Description, string DescriptionError, string Category, string Subcategory, string Tags, string ServiceType, string Location, string StartDate, string EndDate, string StartEndDateError, string Sun, string SunStartTime, string SunEndTime, string Mon, string MonStartTime, string MonEndTime, string Tue, string TueStartTime, string TueEndTime, string Wed, string WedStartTime, string WedEndTime, string Thu, string ThuStartTime, string ThuEndTime, string Fri, string FriStartTime, string FriEndTime, string Sat, string SatStartTime, string SatEndTime, string SkillTrade, string SkillExchange, string Credit, string WorkSamples, string Active, string ExpectedPopupMessage, string ExpectedFollowupPopupMessage)
        {
            test.Log(Status.Info, "Attempting to add or edit a listing on the Share Skill page");

            // this method must be able to accept valid and invalid data: purpose of ValidInvalid parameter
            // valid: add or edit !! in-progress !! (will presume removing 1 tag and adding a new tag [and Skill-exchange tag, if selected])
            // invalid: clear data for invalid (negative) tests

            // parse Tags and Skill-Exchange to separate items by delimiter (,) from the Excel file and 
            // perform a loop to enter each item separately in their own textbox -- NO! send comma (,) at end of each tag to cause application to close current
            // textbox and open new textbox
            // ALSO parse each day's start and end time to remove leading datestamp (use space char as delimiter and ignore first index[begin with index 1])

            Wait.WaitForElementToExist("Name", "title", 7);
            // wait for the Share Skill page to load by waiting for the Save button to be clickable
            //Wait.WaitForElementToBeClickable("XPath", "savebuttonXP", 10);

            // if Title parameter is empty, null, or whitespace, then check ValidInvalid parm  - if 'Invalid', then clear Title textbox
            // if Title paramater is NOT empty, null, or whitespace, then find and enter the Title
            emptynullorwhitespace = string.IsNullOrWhiteSpace(Title);
            if (emptynullorwhitespace == true)
            {
                if (ValidInvalid == "Invalid") // invalid test ensuring empty Title generates an error
                {
                    // clear the Title textbox and move the focus to the Description textbox
                    titleTextbox.Clear();
                    descriptionTextbox.Click();
                }
            }
            else
            {
                titleTextbox.Clear();
                titleTextbox.SendKeys(Title);
            }

            // if Description parameter is empty, null, or whitespace, then check ValidInvalid parm - if 'Invalid', then clear Description textbox
            // if Description parameter is NOT empty, null, or whitespace, then find and enter the Description
            emptynullorwhitespace = string.IsNullOrWhiteSpace(Description);
            if (emptynullorwhitespace == true)
            {
                if (ValidInvalid == "Invalid") // invalid test ensuring empty Description generates an error
                {
                    // clear the Description textbox
                    descriptionTextbox.Clear();
                }
            }
            else
            {
                descriptionTextbox.Clear();
                descriptionTextbox.SendKeys(Description);
            }

            // if Category parameter is not empty, null, or whitespace, then select category from Category drop-down list
            emptynullorwhitespace = string.IsNullOrWhiteSpace(Category);
            if (emptynullorwhitespace != true)
            {
                // create object for new SelectElement class
                SelectElement selectacategory = new SelectElement(categoryDropDown);
                selectacategory.SelectByText(Category);
            }

            // if Subcategory parameter is not empty, null, or whitespace, then select subcategory from Subcategory drop-down list
            emptynullorwhitespace = string.IsNullOrWhiteSpace(Subcategory);
            if (emptynullorwhitespace != true)
            {
                // create object for new SelectElement class
                SelectElement selectasubcategory = new SelectElement(subcategoryDropDown);
                selectasubcategory.SelectByText(Subcategory);
            }

            // if Tags parameter is not empty, null, or whitespace, then check if this is an Edit test case -- if yes, then delete/remove 1st tag, then
            // look for delimiter character (,) in tags
            // if found (numberofTags > 0), then will need to parse the tags and enter each tag into separate textbox
            emptynullorwhitespace = string.IsNullOrWhiteSpace(Tags);
            if (emptynullorwhitespace != true)
            {
                if (ActionOfTest == "EditShareSkillValid")
                {
                    IWebElement remove1sttagTextbox = driver.FindElement(By.XPath(remove1sttagTextboxXP));
                    remove1sttagTextbox.Click();
                }

                numberofDelimiters = Tags.ToCharArray().Count(ct => ct == ',');
                if (numberofDelimiters > 0)
                {
                    String[] arrayofTags = Tags.Split(",");
                    for (int arrayofTagsIndex = 0; arrayofTagsIndex < arrayofTags.Length; arrayofTagsIndex++)
                    {
                        if (arrayofTagsIndex == 0)
                        {
                            // do not know how to send enter key to close current textbox and open new textbox
                            // so simply added a comma which accomplishes the same result
                            tagsTextbox.SendKeys(arrayofTags[arrayofTagsIndex] + ",");
                        }
                        else
                        {
                            driver.SwitchTo().ActiveElement().SendKeys(arrayofTags[arrayofTagsIndex] + ",");
                        }

                        //Console.WriteLine("inside for loop, Tag = " + arrayofTags[arrayofTagsIndex]);
                    }
                }
                else
                {
                    tagsTextbox.SendKeys(Tags + ",");
                }
            }

            // find and select the matching Service Type's radio button -- if empty, null, or whitespace, then do nothing because it contains a default value
            if (ServiceType == "Hourly")
            {
                hourlyservicetypeRadioButton.Click();
            }
            if (ServiceType == "One-off")
            {
                oneoffservicetypeRadioButton.Click();
            }

            // find and select the matching Location Type's radio button -- if empty, null, or whitespace, then do nothing because it contains a default value
            if (Location == "On-site")
            {
                onsitelocationRadioButton.Click();
            }
            if (Location == "Online")
            {
                onlinelocationRadioButton.Click();
            }

            // if StartDate is not empty, null, or whitespace, then convert it to dd/mm/yyyy format
            bool emptynullorwhitespaceSD = string.IsNullOrWhiteSpace(StartDate);
            if (emptynullorwhitespaceSD == true)
            {
                // place focus on the day portion of the Start date, then
                // send the Tab key 3 times to move the focus to the day portion of the End Date
                // because Start Date defaults to Today when adding new listing
                //startdatedayTextbox.Click();
                //driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab, Keys.Tab, Keys.Tab);
                //driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                //driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                //driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);

                // move the focus to the day portion of the End Date
                enddatedayTextbox.Click();
            }
            else
            {
                string convertedDate = ConvertDate(StartDate); // returns dd/mm/yyyy
                
                // must enter dd mm yyyy separately
                startdatedayTextbox.SendKeys(convertedDate.Substring(0,2));
                driver.SwitchTo().ActiveElement().SendKeys(convertedDate.Substring(3,2));
                driver.SwitchTo().ActiveElement().SendKeys(convertedDate.Substring(6,4));

                // move focus from Start Date year to day portion of End Date by sending the Tab key once
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
            }

            // if EndDate is empty, null, or blank, then move the focus to Sunday's checkbox
            bool emptynullorwhitespaceED = string.IsNullOrWhiteSpace(EndDate);
            if (emptynullorwhitespaceED == true)
            {
                Console.Write("End Date is empty");
                // move focus to Sunday's checkbox by sending 3 Tab keys because unable to identify Sunday's checkbox
                //sunCheckbox.Click();
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                // following 2 Tab keys failed to move the focus, focus remained in End Date's mm field
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
            }
            else
            {
                string convertedDate = ConvertDate(EndDate);

                // must enter returned format dd/mm/yyyy separately
                //enddatedayTextbox.SendKeys(convertedDate.Substring(0, 2));
                // having trouble recognizing the XPath for the day portion of the End Date so simply forcing a tab key to
                // move cursor from the year portion of the Start Date into the day portion of the End Date by pressing Tab key Twice
                // -- or the Escape key once followed by the Tab key once
                //driver.SwitchTo().ActiveElement().SendKeys(Keys.Escape);
                //driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                driver.SwitchTo().ActiveElement().SendKeys(convertedDate.Substring(0, 2));
                // tab did not change focus
                //driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                driver.SwitchTo().ActiveElement().SendKeys(convertedDate.Substring(3, 2));
                //driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                driver.SwitchTo().ActiveElement().SendKeys(convertedDate.Substring(6, 4));

                // after entering the year send the tab key to place the focus in the Sunday checkbox
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
            }

            // if Sunday = Y, then ensure Sunday's checkbox is ticked, otherwise; ensure Sunday's checkbox is Not ticked
            if (Sun == "Y")
            {
                // if Sunday's checkbox is Not ticked, then tick it
                if (!sunCheckbox.Selected)
                {
                    sunCheckbox.Click();
                    //driver.SwitchTo().ActiveElement().SendKeys(Keys.Space);
                }
            }
            else   // Sunday is Not = "Y"
            {
                // if Sunday's checkbox is ticked, then untick it
                if (sunCheckbox.Selected)
                {
                    sunCheckbox.Click();
                }
            }

            // if days' start and end time are not blank, then reformat the time to hhmmAM/PM
            if (string.IsNullOrWhiteSpace(SunStartTime) == true) // time contains no data
            {
                // move focus to Sunday's End Time
                sunendtimeTextbox.Click();
            }
            else // time contains data
            {
                reformattedtime = Reformat3TimeElements(SunStartTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + SunStartTime);
                sunstarttimeTextbox.SendKeys(reformattedtime.Substring(0, 6));

                // move focus to Sunday's End Time
                sunendtimeTextbox.Click();
            }

            if (string.IsNullOrWhiteSpace(SunEndTime) == true) // time contains no data
            {
                // move focus to Monday's checkbox by sending 3 Tab keys
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);

            }
            else // time contains data
            {
                reformattedtime = Reformat3TimeElements(SunEndTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + SunEndTime);
                sunendtimeTextbox.SendKeys(reformattedtime.Substring(0, 6));

                // move focus to Monday's checkbox by sending 1 Tab key
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
            }

            // if Monday = Y, then ensure Monday's checkbox is ticked, otherwise; ensure Monday's checkbox is Not ticked
            if (Mon == "Y")
            {
                // if Monday's checkbox is Not ticked, then tick it
                if (!monCheckbox.Selected)
                {
                    monCheckbox.Click();
                    //driver.SwitchTo().ActiveElement().SendKeys(Keys.Space);
                }
            }
            else   // Monday is Not = "Y"
            {
                // if Monday's checkbox is ticked, then untick it
                if (monCheckbox.Selected)
                {
                    monCheckbox.Click();
                }
            }

            if (string.IsNullOrWhiteSpace(MonStartTime) == true) // time contains no data
            {
                // move focus to Monday's End Time
                monendtimeTextbox.Click();
            }
            else // time contains data
            {
                reformattedtime = Reformat3TimeElements(MonStartTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + MonStartTime);
                monstarttimeTextbox.SendKeys(reformattedtime.Substring(0, 6));

                // move focus to Tuesday's End Time
                monendtimeTextbox.Click();

            }
            if (string.IsNullOrWhiteSpace(MonEndTime) == true) // time contains no data
            {
                // move focus to Tuesday's checkbox by sending 3 Tab keys
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);

            }
            else // time contains data
            {
                reformattedtime = Reformat3TimeElements(MonEndTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + MonEndTime);
                monendtimeTextbox.SendKeys(reformattedtime.Substring(0, 6));

                // move focus to Tuesday's checkbox by sending 1 Tab key
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
            }

            // if Tuesday = Y, then ensure Tuesday's checkbox is ticked, otherwise; ensure Tuesday's checkbox is Not ticked
            if (Tue == "Y")
            {
                // if Tuesday's checkbox is Not ticked, then tick it
                if (!tueCheckbox.Selected)
                {
                    tueCheckbox.Click();
                    //driver.SwitchTo().ActiveElement().SendKeys(Keys.Space);
                }
            }
            else   // Tuesday is Not = "Y"
            {
                // if Tuesday's checkbox is ticked, then untick it
                if (tueCheckbox.Selected)
                {
                    tueCheckbox.Click();
                }
            }

            if (string.IsNullOrWhiteSpace(TueStartTime) == true) // time contains no data
            {
                // move focus to Tuesday's End Time
                tueendtimeTextbox.Click();
            }
            else // time contains data
            {
                reformattedtime = Reformat3TimeElements(TueStartTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + TueStartTime);
                tuestarttimeTextbox.SendKeys(reformattedtime.Substring(0, 6));

                // move focus to Tuesday's End Time
                tueendtimeTextbox.Click();

            }
            if (string.IsNullOrWhiteSpace(TueEndTime) == true) // time contains no data
            {
                // move focus to Wednesday's checkbox by sending 3 Tab keys
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);

            }
            else // time contains data
            {
                reformattedtime = Reformat3TimeElements(TueEndTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + TueEndTime);
                tueendtimeTextbox.SendKeys(reformattedtime.Substring(0, 6));

                // move focus to Wednesday's checkbox by sending 1 Tab key
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
            }

            // if Wednesday = Y, then ensure Wednesday's checkbox is ticked, otherwise; ensure Wednesday's checkbox is Not ticked
            if (Wed == "Y")
            {
                // if Wednesday's checkbox is Not ticked, then tick it
                if (!wedCheckbox.Selected)
                {
                    wedCheckbox.Click();
                    //driver.SwitchTo().ActiveElement().SendKeys(Keys.Space);
                }
            }
            else   // Wednesday is Not = "Y"
            {
                // if Wednesday's checkbox is ticked, then untick it
                if (wedCheckbox.Selected)
                {
                    wedCheckbox.Click();
                }
            }

            if (string.IsNullOrWhiteSpace(WedStartTime) == true) // time contains no data
            {
                // move focus to Wednesday's End Time
                wedendtimeTextbox.Click();
            }
            else // time contains data
            {
                reformattedtime = Reformat3TimeElements(WedStartTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + WedStartTime);
                wedstarttimeTextbox.SendKeys(reformattedtime.Substring(0, 6));

                // move focus to Wednesday's End Time
                wedendtimeTextbox.Click();

            }
            if (string.IsNullOrWhiteSpace(WedEndTime) == true) // time contains no data
            {
                // move focus to Thursday's checkbox by sending 3 Tab keys
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);

            }
            else // time contains data
            {
                reformattedtime = Reformat3TimeElements(WedEndTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + WedEndTime);
                wedendtimeTextbox.SendKeys(reformattedtime.Substring(0, 6));

                // move focus to Thursday's checkbox by sending 1 Tab key
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
            }

            // if Thursday = Y, then ensure Thursday's checkbox is ticked, otherwise; ensure Thursday's checkbox is Not ticked
            if (Thu == "Y")
            {
                // if Thursday's checkbox is Not ticked, then tick it
                if (!thuCheckbox.Selected)
                {
                    thuCheckbox.Click();
                    //driver.SwitchTo().ActiveElement().SendKeys(Keys.Space);
                }
            }
            else   // Thursday is Not = "Y"
            {
                // if Thursday's checkbox is ticked, then untick it
                if (thuCheckbox.Selected)
                {
                    thuCheckbox.Click();
                }
            }

            if (string.IsNullOrWhiteSpace(ThuStartTime) == true) // time contains no data
            {
                // move focus to Thursday's End Time
                thuendtimeTextbox.Click();
            }
            else // time contains data
            {
                reformattedtime = Reformat3TimeElements(ThuStartTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + ThuStartTime);
                thustarttimeTextbox.SendKeys(reformattedtime.Substring(0, 6));

                // move focus to Thursday's End Time
                thuendtimeTextbox.Click();

            }
            if (string.IsNullOrWhiteSpace(ThuEndTime) == true) // time contains no data
            {
                // move focus to Friday's checkbox by sending 3 Tab keys
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);

            }
            else // time contains data
            {
                reformattedtime = Reformat3TimeElements(ThuEndTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + ThuEndTime);
                thuendtimeTextbox.SendKeys(reformattedtime.Substring(0, 6));

                // move focus to Friday's checkbox by sending 1 Tab key
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
            }

            // if Friday = Y, then ensure Friday's checkbox is ticked, otherwise; ensure Friday's checkbox is Not ticked
            if (Fri == "Y")
            {
                // if Friday's checkbox is Not ticked, then tick it
                if (!friCheckbox.Selected)
                {
                    friCheckbox.Click();
                    //driver.SwitchTo().ActiveElement().SendKeys(Keys.Space);
                }
            }
            else   // Friday is Not = "Y"
            {
                // if Friday's checkbox is ticked, then untick it
                if (friCheckbox.Selected)
                {
                    friCheckbox.Click();
                }
            }

            if (string.IsNullOrWhiteSpace(FriStartTime) == true) // time contains no data
            {
                // move focus to Friday's End Time
                friendtimeTextbox.Click();
            }
            else // time contains data
            {
                reformattedtime = Reformat3TimeElements(FriStartTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + FriStartTime);
                fristarttimeTextbox.SendKeys(reformattedtime.Substring(0, 6));

                // move focus to Friday's End Time
                friendtimeTextbox.Click();

            }
            if (string.IsNullOrWhiteSpace(FriEndTime) == true) // time contains no data
            {
                // move focus to Saturday's checkbox by sending 3 Tab keys
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);

            }
            else // time contains data
            {
                reformattedtime = Reformat3TimeElements(FriEndTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + FriEndTime);
                friendtimeTextbox.SendKeys(reformattedtime.Substring(0, 6));

                // move focus to Saturday's checkbox by sending 1 Tab key
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
            }

            // if Saturday = Y, then ensure Saturday's checkbox is ticked, otherwise; ensure Saturday's checkbox is Not ticked
            if (Sat == "Y")
            {
                // if Saturday's checkbox is Not ticked, then tick it
                if (!satCheckbox.Selected)
                {
                    satCheckbox.Click();
                    //driver.SwitchTo().ActiveElement().SendKeys(Keys.Space);
                }
            }
            else   // Saturday is Not = "Y"
            {
                // if Saturday's checkbox is ticked, then untick it
                if (satCheckbox.Selected)
                {
                    satCheckbox.Click();
                }
            }

            if (string.IsNullOrWhiteSpace(SatStartTime) == true) // time contains no data
            {
                // move focus to Saturday's End Time
                satendtimeTextbox.Click();
            }
            else // time contains data
            {
                reformattedtime = Reformat3TimeElements(SatStartTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + SatStartTime);
                satstarttimeTextbox.SendKeys(reformattedtime.Substring(0, 6));

                // move focus to Saturday's End Time
                satendtimeTextbox.Click();

            }
            if (string.IsNullOrWhiteSpace(SatEndTime) == false) // time contains data
            {
                reformattedtime = Reformat3TimeElements(SatEndTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + SatEndTime);
                satendtimeTextbox.SendKeys(reformattedtime.Substring(0, 6));
            }

            // find and select the matching Skill Trade's radio button -- if empty, null, or whitespace, then do nothing because it contains a default value
            if (SkillTrade == "Skill-exchange")
            {
                skillexchangeskilltradeRadioButton.Click();

                // enter skill exchanges into the skill exchange textbox
                // look for delimiter character (,) in skill exchange
                // if found (numberofSkills > 0), then will need to parse the skills and enter each skill into separate textbox
                numberofSkills = SkillExchange.ToCharArray().Count(ct => ct == ',');
                if (numberofSkills > 0)
                {
                    String[] arrayofSkills = SkillExchange.Split(",");
                    for (int arrayofSkillsIndex = 0; arrayofSkillsIndex < arrayofSkills.Length; arrayofSkillsIndex++)
                    {
                        if (arrayofSkillsIndex == 0)
                        {
                            // do not know how to send enter key to close current textbox and open new textbox
                            // so simply added a comma which accomplishes the same result
                            skillexchangeTextbox.SendKeys(arrayofSkills[arrayofSkillsIndex] + ",");
                        }
                        else
                        {
                            driver.SwitchTo().ActiveElement().SendKeys(arrayofSkills[arrayofSkillsIndex] + ",");
                        }

                        //Console.WriteLine("inside for loop, Tag = " + arrayofSkills[arrayofSkillsIndex]);
                    }
                }
                else
                {
                    skillexchangeTextbox.SendKeys(SkillExchange + ",");
                }
            }
            if (SkillTrade == "Credit")
            {
                creditskilltradeRadioButton.Click();
                creditTextbox.Clear();
                creditTextbox.SendKeys(Credit);
            }

            // if work samples contains data, then click the upload button and call the AutoIT script to complete the upload
            if (string.IsNullOrWhiteSpace(WorkSamples) == false) // Work Samples contains 1 or more files to upload
            {
                // don't know how to send variable file path & filename to AutoIT script so only using 1 hard-coded file path in AutoIT script
                worksamplesicon.Click();
                Process.Start(AutoITuploadscript).WaitForExit(8000);
            }


            // find and select the matching active radio button -- if empty, null, or whitespace, then do nothing because it contains a default value
            if (Active == "Active")
            {
                activeRadioButton.Click();
            }
            if (Active == "Hidden")
            {
                hiddenRadioButton.Click();
            }

            // click the Save or Cancel button per the ActionButton parameter
            if (ActionButton == "Save")
            {
                // click the Save button
                saveButton.Click();
                Thread.Sleep(8000);

                // capture the message in the pop-up window
                //savedMessage = GetMessageWhenSaving();

                // if message is 'successful', then user is taken to the Manage Listings page; otherwise, user remains on Share Skill page with error message
                // message could also match the expected message which tells the user to fix the input data -- which is a negative test using Invalid data

                //if(savedMessage == ExpectedPopupMessage)
                //{
                //    return true;
                //}
                //else
                //{
                //    Console.WriteLine("Pop-up message '" + savedMessage + "' does not match expected message '" + ExpectedPopupMessage + "'");
                //    return false;
                //}
                //Assert.That

                // check which page the user is on by looking for the Save button
                // -- if Save button is found, then still on the Share Skill page due to invalid data
                // -- if Save button is NOT found, then presume user is on the Manage Listings page due to valid data being accepted and a new listing was created

                //Wait.WaitForElementToExist("XPath", saveButtonXP, 4);
                int numberofSaveButtons = driver.FindElements(By.XPath(saveButtonXP)).Count;
                if (numberofSaveButtons > 0) // still on Share Skills page because Save button was found due to an error caused by invalid data
                {
                    if (ValidInvalid == "Valid")
                    {
                        Console.WriteLine("FAIL: Still on Share Skill page when valid data was entered");
                        Console.WriteLine("Ending program");
                        test.Log(Status.Fail, "Still on Share Skill page when valid data was entered");
                        Assert.Fail("FAIL: Still on Share Skill page when valid data was entered");
                    }
                    else // invalid data is ok
                    {
                        // FollowupAction can be read in program.cs
                        // may not need to return any boolean value

                        // this path is for invalid data where user clicks Save button but remains on the Share Skill page so...
                        // just click the Cancel button for this scenario to exit this path and then verify listing count on Manage Listings page is unchanged
                        ///// changed my mind -- do not click Cancel because invalid test data on Share Skill page reads multiple rows until FollowupAction not = Yes
                        ///// and must therefore remain on the Share Skill page and not be returned to any other page when the Cancel button is clicked so...
                        ///// just write a line acknowledging a valid error on the Share Skill page is present
                        //cancelButton.Click(); // per all negative test cases where invalid data is entered, and not corrected, on the Share Skills page
                        Console.WriteLine("Invalid data has been entered on this Shared Skill page resulting in an error message that appears on the screen");
                        if (string.IsNullOrWhiteSpace(TitleError) == false) // TitleError contains data
                        {
                            IWebElement titleerrormessage = driver.FindElement(By.XPath(titleerrormessageXP));
                            if (titleerrormessage.Text == TitleError)
                            {
                                Console.WriteLine("Actual title error message '" + titleerrormessage.Text + "' matches expected error");
                                test.Log(Status.Pass, "Actual title error message '" + titleerrormessage.Text + "' matches expected error");
                            }
                            else
                            {
                                Console.WriteLine("FAIL: Actual title error message '" + titleerrormessage.Text + "' does not match expected error '" + TitleError);
                                test.Log(Status.Fail, "Actual title error message '" + titleerrormessage.Text + "' does not match expected error '" + TitleError + "'");
                            }
                        }

                        if (string.IsNullOrWhiteSpace(DescriptionError) == false) // DescriptionError contains data
                        {
                            IWebElement descriptionerrormessage = driver.FindElement(By.XPath(descriptionerrormessageXP));
                            if (descriptionerrormessage.Text == DescriptionError)
                            {
                                Console.WriteLine("Actual description error message '" + descriptionerrormessage.Text + "' matches expected error");
                                test.Log(Status.Pass, "Actual description error message '" + descriptionerrormessage.Text + "' matches expected error");
                            }
                            else
                            {
                                Console.WriteLine("FAIL: Actual description error message '" + descriptionerrormessage.Text + "' does not match expected error '" + DescriptionError);
                                test.Log(Status.Fail, "Actual description error message '" + descriptionerrormessage.Text + "' does not match expected error '" + DescriptionError + "'");
                            }
                        }

                        if (string.IsNullOrWhiteSpace(StartEndDateError) == false) // StartEndDateError contains data
                        {
                            IWebElement startenddateerrormessage = driver.FindElement(By.XPath(startenddateerrormessageXP));
                            if (startenddateerrormessage.Text == StartEndDateError)
                            {
                                Console.WriteLine("Actual start date / end date error message '" + startenddateerrormessage.Text + "' matches expected error");
                                test.Log(Status.Pass, "Actual start date / end date error message '" + startenddateerrormessage.Text + "' matches expected error");
                            }
                            else
                            {
                                Console.WriteLine("Actual start date / end date error message '" + startenddateerrormessage.Text + "' does not match expected error '" + StartEndDateError);
                                test.Log(Status.Fail, "Actual start date / end date error message '" + startenddateerrormessage.Text + "' does not match expected error '" + StartEndDateError + "'");
                            }
                        }
                    }
                } // Save button was not found so presumed to be on the Manage Listings page
            }

            if (ActionButton == "Cancel")
            {
                // click the Cancel button
                cancelButton.Click();

                // user is taken back to the page where they were when they clicked the Share Skill button

                // set savedMessage to empty because no pop-up message appears which would need to be verified
                //savedMessage = "";
            }

            //return savedMessage;
            
            // if ValidInvalid parameter = Valid, then message should be successful, otherwise; the message will be unsuccessful
            // must be able to handle test case where invalid data are corrected and successfully saved in same test case
        }

        public string Reformat3TimeElements(string TimetoReformat)
        {
            // return 6 character string containing: 2-digit hour, 2-digit minutes, and 2 character AM/PM

            timeString = "";

            if (TimetoReformat.Substring(1, 1) == ":")
            {
                timeString = ("0" + TimetoReformat.Substring(0, 1) + TimetoReformat.Substring(2, 2) + TimetoReformat.Substring(5, 2));
            }
            else
            if (TimetoReformat.Substring(2, 1) == ":")
            {
                timeString = (TimetoReformat.Substring(0,2) + TimetoReformat.Substring(3, 2) + TimetoReformat.Substring(6,2));
            }
            else
            {
                Console.WriteLine("FAIL: Invalid time of " + TimetoReformat);
                test.Log(Status.Fail, "Invalid time of '" + TimetoReformat + "'");
            }
            return timeString;
        }

        public string ConvertDate(string DatetoConvert)
        {
            // expected values/format: Today, Today+nnn, Today-nnn, or variations of ddmmyyyy (Not always 2-digit day and 2-digit month)
            // must return dd/mm/yyyy using ReformatDate method
            // search for: 1. Today, then 2. ' ' after 'y' in Today, then 3. '+' after 'y' in Today, then 4. '-' after 'y' in Today,
            // add or subtract nnn days to/from today's date accordingly
            //Console.WriteLine("in ConvertDate method");
            if (DatetoConvert.Substring(0, 5) == "Today")
            {
                int todaylength = DatetoConvert.Length;
                if (todaylength == 5) // there is no '+' or '-' following Today
                {
                    calculatedDate = DateTime.Today;
                    stringDate = calculatedDate.ToString();
                    finalDate = ReformatDate(stringDate);
                    //Console.Write("DatetoConvert is today's date = " + finalDate);
                    return finalDate;
                    //}
                }
                else // todaylength > 5 so look for '+' and/or '-'
                {
                    if (DatetoConvert.Substring(5, 1) == "+")
                    {
                        int stringlength = DatetoConvert.Length;
                        int numberofdigits = stringlength - 6;
                        string justdaysstring = DatetoConvert.Substring(6, numberofdigits);
                        int justdaysint;
                        bool isParsable = Int32.TryParse(justdaysstring, out justdaysint);
                        if (isParsable)
                        {
                            calculatedDate = DateTime.Today.AddDays(justdaysint);
                            stringDate = calculatedDate.ToString();
                            finalDate = ReformatDate(stringDate);
                            //Console.WriteLine("DatetoConvert is Today+ a positive number resulting in " + finalDate);
                            return finalDate;
                        }
                        else
                        {
                            Console.WriteLine("FAIL: " + DatetoConvert + " could not be parsed");
                            test.Log(Status.Fail, DatetoConvert + " could not be parsed");
                            return DatetoConvert;
                        }
                    }
                    else
                    {
                        if (DatetoConvert.Substring(5, 1) == "-") // negative sign is for testing invalid data (negative testing) because Start and End dates cannot be back-dated
                        {
                            int stringlength = DatetoConvert.Length;
                            int numberofdigits = stringlength - 6;
                            string dayswithnegativesign = DatetoConvert.Substring(5, numberofdigits + 1);
                            int justdaysint;
                            bool isParsable = Int32.TryParse(dayswithnegativesign, out justdaysint);
                            if (isParsable)
                            {
                                calculatedDate = DateTime.Today.AddDays(justdaysint);
                                stringDate = calculatedDate.ToString();
                                finalDate = ReformatDate(stringDate);
                                //Console.WriteLine("DatetoConvert is Today- a negative number resulting in " + finalDate);
                                return finalDate;
                            }
                            else
                            {
                                Console.WriteLine("FAIL: " + DatetoConvert + " could not be parsed");
                                test.Log(Status.Fail, DatetoConvert + " could not be parsed");
                                return DatetoConvert;
                            }
                        }
                        else
                        {
                            Console.WriteLine("FAIL: Invalid characters after 'Today' " + DatetoConvert);
                            return DatetoConvert;
                        }
                    }
                }
                }
            else  // Date does NOT begin with 'Today'
            {
                // variation of dd/mm/yyyy
                // just reformat the string - don't use Parse

                //calculatedDate = DateTime.ParseExact(DatetoConvert, "dd/mm/yyyy", CultureInfo.InvariantCulture);
                // have to reformat in order to put leading zero back in dd field that Parse removed
                //finalDate = ReformatDate(calculatedDate);
                finalDate = ReformatDate(DatetoConvert);
                //Console.Write("DatetoConvert is " + DatetoConvert + " and was reformatted to " + finalDate);
                return finalDate;

                // require the excel sheet to use dd/mm/yyyy [when not using Today...], then no conversion or reformat will be necessary
            }
        }

        //public string ReformatDate(DateTime DatetoReformat)
        public string ReformatDate(string DatetoReformat)
        {
            // date values of d/m/yyyy, d/mm/yyyy, and dd/m/yyyy will be reformatted to dd/mm/yyyy

            if (DatetoReformat.Substring(1, 1) == "/")
            {
                if (DatetoReformat.Substring(3, 1) == "/")
                {
                    // original format is d/m/yyyy
                    ReformattedDate = ("0" + DatetoReformat.Substring(0, 1) + "/0" + DatetoReformat.Substring(2, 1) + "/" + DatetoReformat.Substring(4, 4));
                    //Console.WriteLine("uncalculated date of " + DatetoReformat + " was reformatted as " + ReformattedDate);
                    return ReformattedDate;
                }
                else
                {
                    // original format is d/mm/yyyy
                    ReformattedDate = ("0" + DatetoReformat.Substring(0, 1) + "/" + DatetoReformat.Substring(2, 2) + "/" + DatetoReformat.Substring(5, 4));
                    //Console.WriteLine("uncalculated date of " + DatetoReformat + " was reformatted as " + ReformattedDate);
                    return ReformattedDate;
                }
            }
            else
            {
                if (DatetoReformat.Substring(4, 1) == "/")
                {
                    // original format is dd/m/yyyy
                    ReformattedDate = (DatetoReformat.Substring(0, 2) + "/0" + DatetoReformat.Substring(3, 1) + "/" + DatetoReformat.Substring(5, 4));
                    //Console.WriteLine("uncalculated date of " + DatetoReformat + " was reformatted as " + ReformattedDate);
                    return ReformattedDate;
                }
                else
                {
                    // original format is dd/mm/yyyy -- just return the original value as it requires no reformat
                    ReformattedDate = DatetoReformat;
                    //Console.WriteLine("uncalculated date of " + DatetoReformat + " required no reformat and was returned as " + ReformattedDate);
                    return ReformattedDate;
                }
            }
        }

        // this method is only called by positive test cases containing valid data
        public bool CompareShareSkillValues(string ActionOfTest, string Title, string Description, string Category, string Subcategory, string Tags, string ServiceType, string Location, string StartDate, string EndDate, string Sun, string SunStartTime, string SunEndTime, string Mon, string MonStartTime, string MonEndTime, string Tue, string TueStartTime, string TueEndTime, string Wed, string WedStartTime, string WedEndTime, string Thu, string ThuStartTime, string ThuEndTime, string Fri, string FriStartTime, string FriEndTime, string Sat, string SatStartTime, string SatEndTime, string SkillTrade, string SkillExchange, string Credit, string WorkSamples, string Active)
        {
            test.Log(Status.Info, "Beginning comparisons on Share Skill page");

            bool shareskillmatchingflag = true;

            // wait for Share Skill page to load and the Title textbox to be clickable
            Wait.WaitForElementToBeClickable("Name", "title", 5);
            
            //wait for Share Skill page to load by waiting for the Save button to be clickable
            //Wait.WaitForElementToBeClickable("XPath", saveButtonXP, 10);

            // title was stored into 'value', not 'text'
            if (titleTextbox.GetAttribute("value") != Title)
            {
                shareskillmatchingflag = false;
                Console.WriteLine("FAIL - Actual Title '" + titleTextbox.Text + "' does not match expected Title '" + Title + "'");
                test.Log(Status.Fail, "Actual Title '" + titleTextbox.Text + "' does not match expected Title '" + Title + "'");
            }

            if (descriptionTextbox.Text != Description)
            {
                shareskillmatchingflag = false;
                Console.WriteLine("FAIL - Actual Description '" + descriptionTextbox.Text + "' does not match expected Description '" + Description + "'");
                test.Log(Status.Fail, "Actual Description '" + descriptionTextbox.Text + "' does not match expected Description '" + Description + "'");
            }

            SelectElement status = new SelectElement(driver.FindElement(By.Name("categoryId")));
            IWebElement savedCategory = status.SelectedOption;
            if (savedCategory.Text != Category)
            {
                shareskillmatchingflag = false;
                Console.WriteLine("FAIL - Actual Category '" + savedCategory.Text + "' does not match expected Category '" + Category + "'");
                test.Log(Status.Fail, "Actual Category '" + savedCategory.Text + "' does not match expected Category '" + Category + "'");
            }

            SelectElement status2 = new SelectElement(driver.FindElement(By.Name("subcategoryId")));
            IWebElement savedsubCategory = status2.SelectedOption;
            if (savedsubCategory.Text != Subcategory)
            {
                shareskillmatchingflag = false;
                Console.WriteLine("FAIL - Actual Subcategory '" + savedsubCategory.Text + "' does not match expected Subcategory '" + Subcategory + "'");
                test.Log(Status.Fail, "Actual Subcategory '" + savedsubCategory.Text + "' does not match expected Subcategory '" + Subcategory + "'");
            }

            // compare actual number of tags on edit Share Skill page to expected number of tags in data sheet ONLY when ActionOfTest is not = EditShareSkillValid
            // EditShareSkillValid removes 1 of the existing tags and adds a new tag which cannot be reconciled until code removes all tags and adds new tag(s)
            if (ActionOfTest != "EditShareSkillValid")
            {
                int numberoftagsoneditpage = driver.FindElements(By.ClassName("ReactTags__tag")).Count;
                if (numberoftagsoneditpage != numberofDelimiters + 1)
                {
                    shareskillmatchingflag = false;
                    Console.WriteLine("FAIL - Actual number of Tags '" + numberoftagsoneditpage + "' does not match expected number '" + numberofDelimiters + "' plus 1");
                    test.Log(Status.Fail, "Actual number of Tags '" + numberoftagsoneditpage + "' does not match expected number '" + numberofDelimiters + "' plus 1");
                }
            }

            //////// left off here trying to capture text of all of the tags displayed on the edit Share Skill page
            //else
            //{
            //    // verify value of each actual tag to the expected tag value (arrayofTags[arrayofTagsIndex]) that was already parsed into separate tags during the 'Save' action

            //    // capture all actual tags into an array
            //    //String[] arrayofactualtags = driver.FindElement(By.ClassName("ReactTags__tag")).Text;
            //    string arrayofactualtags = driver.FindElement(By.ClassName("ReactTags__tag")).Text;
            //    Console.Write("arrayofactualtage is '" + arrayofactualtags + "'");

                
                
                // from data entry/'Save' action above
                //String[] arrayofTags = Tags.Split(",");
                //for (int arrayofTagsIndex = 0; arrayofTagsIndex < arrayofTags.Length; arrayofTagsIndex++)
                //{
                //    if (arrayofTagsIndex == 0)
                //    {
                //        // do not know how to send enter key to close current textbox and open new textbox
                //        // so simply added a comma which accomplishes the same result
                //        tagsTextbox.SendKeys(arrayofTags[arrayofTagsIndex] + ",");
                //    }
                //    else
                //    {
                //        driver.SwitchTo().ActiveElement().SendKeys(arrayofTags[arrayofTagsIndex] + ",");
                //    }

                //    //Console.WriteLine("inside for loop, Tag = " + arrayofTags[arrayofTagsIndex]);
                //}




            //}
            // parse the number of tags and verify each tag matches the expected results -- can presume same sequence as in data sheet



            if (shareskillmatchingflag == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClickTheCancelButton()
        {
            cancelButton.Click();
        }

        //public string GetMessageWhenSaving()
        //{
        //    // capture message in pop-up window that closes in 5 seconds



        //    //capturedMessage = "This will force an error";
        //    capturedMessage = "Service Listing Added successfully.";

        //    return capturedMessage;
        //}
    }
}
