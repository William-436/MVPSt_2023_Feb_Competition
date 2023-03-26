using MVPSt_2023_Feb_Competition.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static MVPSt_2023_Feb_Competition.Utilities.CommonDriver;
using System.Diagnostics;
using AventStack.ExtentReports;
using MongoDB.Driver;

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
        public static int numberofDelimiters;
        public static int numberofSkills;
        public static DateTime calculatedDate;
        public static string stringDate;
        public static string dayswithleadingsign;
        public static string ReformattedDate;
        public static string finalDate;
        public static string timeString;
        public static string reformattedtime;
        public static string AutoITuploadscript = "C:\\Users\\User\\Documents\\MVP Studio Projects\\MVPSt_2023_Feb_Competition\\MVPSt_2023_Feb_Competition\\MVPSt_2023_Feb_Competition\\Utilities\\AutoITScripts\\UploadFileScript.exe";
        //public static string savedMessage;
        //public static string capturedMessage;

        public void AddTitle(string ValidInvalid, string Title)
        {
            Wait.WaitForElementToExist("Name", "title", 7);

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
        }

        public void AddDescription(string ValidInvalid, string Description)
        {
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
        }

        public void AddCategory(string Category)
        {
            // if Category parameter is not empty, null, or whitespace, then select category from Category drop-down list
            emptynullorwhitespace = string.IsNullOrWhiteSpace(Category);
            if (emptynullorwhitespace != true)
            {
                // create object for new SelectElement class
                SelectElement selectacategory = new SelectElement(categoryDropDown);
                selectacategory.SelectByText(Category);
            }
        }

        public void AddSubcategory(string Subcategory)
        {
            // if Subcategory parameter is not empty, null, or whitespace, then select subcategory from Subcategory drop-down list
            emptynullorwhitespace = string.IsNullOrWhiteSpace(Subcategory);
            if (emptynullorwhitespace != true)
            {
                // create object for new SelectElement class
                SelectElement selectasubcategory = new SelectElement(subcategoryDropDown);
                selectasubcategory.SelectByText(Subcategory);
            }
        }

        public void AddTags(string ActionOfTest, string Tags)
        {
            // if Tags parameter is not empty, null, or whitespace, then check if this is an Edit test case -- if yes, then delete/remove 1st tag, then
            // look for delimiter character (,) in tags
            // if numberofDelimiters > 0, then will need to parse the tags and enter each tag into separate textbox;
            // otherwise only 1 tag with no delimiter exists in Tags which needs to be entered into the Tags textbox
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
                    }
                }
                else
                {
                    tagsTextbox.SendKeys(Tags + ",");
                }
            }
        }

        public void AddServiceType(string ServiceType)
        {
            // find and select the matching Service Type's radio button -- if empty, null, or whitespace, then do nothing because it contains a default value
            if (ServiceType == "Hourly")
            {
                hourlyservicetypeRadioButton.Click();
            }
            if (ServiceType == "One-off")
            {
                oneoffservicetypeRadioButton.Click();
            }
        }

        public void AddLocation(string Location)
        {
            // find and select the matching Location Type's radio button -- if empty, null, or whitespace, then do nothing because it contains a default value
            if (Location == "On-site")
            {
                onsitelocationRadioButton.Click();
            }
            if (Location == "Online")
            {
                onlinelocationRadioButton.Click();
            }
        }

        public void AddStartDate(string StartDate)
        {
            // if StartDate is not empty, null, or whitespace, then convert it to dd/mm/yyyy format
            bool emptynullorwhitespaceSD = string.IsNullOrWhiteSpace(StartDate);
            if (emptynullorwhitespaceSD == true)
            {
                // move the focus to the day portion of the End Date
                enddatedayTextbox.Click();
            }
            else
            {
                string convertedDate = ConvertDate(StartDate); // returns dd/mm/yyyy

                // must enter returned format dd/mm/yyyy separately

                startdatedayTextbox.SendKeys(convertedDate.Substring(0, 2));
                driver.SwitchTo().ActiveElement().SendKeys(convertedDate.Substring(3, 2));
                driver.SwitchTo().ActiveElement().SendKeys(convertedDate.Substring(6, 4));

                // move focus from Start Date year to day portion of End Date by sending the Tab key once
                driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
            }
        }

        public void AddEndDate(string EndDate)
        {
            bool emptynullorwhitespaceED = string.IsNullOrWhiteSpace(EndDate);
            if (emptynullorwhitespaceED == false)
            {
                string convertedDate = ConvertDate(EndDate); // returns dd/mm/yyyy

                // must enter returned format dd/mm/yyyy separately

                driver.SwitchTo().ActiveElement().SendKeys(convertedDate.Substring(0, 2));
                driver.SwitchTo().ActiveElement().SendKeys(convertedDate.Substring(3, 2));
                driver.SwitchTo().ActiveElement().SendKeys(convertedDate.Substring(6, 4));
            }
        }

        public void AddSunday(string Sun)
        {
            // if Sunday = Y, then ensure Sunday's checkbox is ticked, otherwise; ensure Sunday's checkbox is Not ticked
            if (Sun == "Y")
            {
                // if Sunday's checkbox is Not ticked, then tick it
                if (!sunCheckbox.Selected)
                {
                    sunCheckbox.Click();
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
        }

        public void AddSundayStartTime(string SunStartTime)
        {
            if (string.IsNullOrWhiteSpace(SunStartTime) == false) // time contains data
            {
                reformattedtime = Reformat3TimeElements(SunStartTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + SunStartTime);
                sunstarttimeTextbox.SendKeys(reformattedtime.Substring(0, 6));
            }
        }

        public void AddSundayEndTime(string SunEndTime)
        {
            if (string.IsNullOrWhiteSpace(SunEndTime) == false) // time contains data
            {
                reformattedtime = Reformat3TimeElements(SunEndTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + SunEndTime);
                sunendtimeTextbox.SendKeys(reformattedtime.Substring(0, 6));
            }
        }

        public void AddMonday(string Mon)
        {
            // if Monday = Y, then ensure Monday's checkbox is ticked, otherwise; ensure Monday's checkbox is Not ticked
            if (Mon == "Y")
            {
                // if Monday's checkbox is Not ticked, then tick it
                if (!monCheckbox.Selected)
                {
                    monCheckbox.Click();
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
        }

        public void AddMondayStartTime(string MonStartTime)
        {
            // if Monday's start time is not blank, then reformat the time to hhmmAM/PM and enter into Monday's start time textbox
            if (string.IsNullOrWhiteSpace(MonStartTime) == false) // time contains data
            {
                reformattedtime = Reformat3TimeElements(MonStartTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + MonStartTime);
                monstarttimeTextbox.SendKeys(reformattedtime.Substring(0, 6));
            }
        }

        public void AddMondayEndTime(string MonEndTime)
        {
            // if Monday's end time is not blank, then reformat the time to hhmmAM/PM and enter into Monday's end time textbox
            if (string.IsNullOrWhiteSpace(MonEndTime) == false) // time contains data
            {
                reformattedtime = Reformat3TimeElements(MonEndTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + MonEndTime);
                monendtimeTextbox.SendKeys(reformattedtime.Substring(0, 6));
            }
        }

        public void AddTuesday(string Tue)
        {
            // if Tuesday = Y, then ensure Tuesday's checkbox is ticked, otherwise; ensure Tuesday's checkbox is Not ticked
            if (Tue == "Y")
            {
                // if Tuesday's checkbox is Not ticked, then tick it
                if (!tueCheckbox.Selected)
                {
                    tueCheckbox.Click();
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
        }

        public void AddTuesdayStartTime(string TueStartTime)
        {
            // if Tuesday's start time is not blank, then reformat the time to hhmmAM/PM and enter into Tuesday's start time textbox
            if (string.IsNullOrWhiteSpace(TueStartTime) == false) // time contains data
            {
                reformattedtime = Reformat3TimeElements(TueStartTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + TueStartTime);
                tuestarttimeTextbox.SendKeys(reformattedtime.Substring(0, 6));
            }
        }

        public void AddTuesdayEndTime(string TueEndTime)
        {
            // if Tuesday's end time is not blank, then reformat the time to hhmmAM/PM and enter into Tuesday's end time textbox
            if (string.IsNullOrWhiteSpace(TueEndTime) == false) // time contains data
            {
                reformattedtime = Reformat3TimeElements(TueEndTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + TueEndTime);
                tueendtimeTextbox.SendKeys(reformattedtime.Substring(0, 6));
            }
        }

        public void AddWednesday(string Wed)
        {
            // if Wednesday = Y, then ensure Wednesday's checkbox is ticked, otherwise; ensure Wednesday's checkbox is Not ticked
            if (Wed == "Y")
            {
                // if Wednesday's checkbox is Not ticked, then tick it
                if (!wedCheckbox.Selected)
                {
                    wedCheckbox.Click();
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
        }

        public void AddWednesdayStartTime(string WedStartTime)
        {
            // if Wednesday's start time is not blank, then reformat the time to hhmmAM/PM and enter into Wednesday's start time textbox
            if (string.IsNullOrWhiteSpace(WedStartTime) == false) // time contains data
            {
                reformattedtime = Reformat3TimeElements(WedStartTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + WedStartTime);
                wedstarttimeTextbox.SendKeys(reformattedtime.Substring(0, 6));
            }
        }

        public void AddWednesdayEndTime(string WedEndTime)
        {
            // if Wednesday's end time is not blank, then reformat the time to hhmmAM/PM and enter into Wednesday's end time textbox
            if (string.IsNullOrWhiteSpace(WedEndTime) == false) // time contains data
            {
                reformattedtime = Reformat3TimeElements(WedEndTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + WedEndTime);
                wedendtimeTextbox.SendKeys(reformattedtime.Substring(0, 6));
            }
        }

        public void AddThursday(string Thu)
        {
            // if Thursday = Y, then ensure Thursday's checkbox is ticked, otherwise; ensure Thursday's checkbox is Not ticked
            if (Thu == "Y")
            {
                // if Thursday's checkbox is Not ticked, then tick it
                if (!thuCheckbox.Selected)
                {
                    thuCheckbox.Click();
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
        }

        public void AddThursdayStartTime(string ThuStartTime)
        {
            // if Thursday's start time is not blank, then reformat the time to hhmmAM/PM and enter into Thursday's start time textbox
            if (string.IsNullOrWhiteSpace(ThuStartTime) == false) // time contains data
            {
                reformattedtime = Reformat3TimeElements(ThuStartTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + ThuStartTime);
                thustarttimeTextbox.SendKeys(reformattedtime.Substring(0, 6));
            }
        }

        public void AddThursdayEndTime(string ThuEndTime)
        {
            // if Thursday's end time is not blank, then reformat the time to hhmmAM/PM and enter into Thursday's end time textbox
            if (string.IsNullOrWhiteSpace(ThuEndTime) == false) // time contains data
            {
                reformattedtime = Reformat3TimeElements(ThuEndTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + ThuEndTime);
                thuendtimeTextbox.SendKeys(reformattedtime.Substring(0, 6));
            }
        }

        public void AddFriday(string Fri)
        {
            // if Friday = Y, then ensure Friday's checkbox is ticked, otherwise; ensure Friday's checkbox is Not ticked
            if (Fri == "Y")
            {
                // if Friday's checkbox is Not ticked, then tick it
                if (!friCheckbox.Selected)
                {
                    friCheckbox.Click();
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
        }

        public void AddFridayStartTime(string FriStartTime)
        {
            // if Friday's start time is not blank, then reformat the time to hhmmAM/PM and enter into Friday's start time textbox
            if (string.IsNullOrWhiteSpace(FriStartTime) == false) // time contains data
            {
                reformattedtime = Reformat3TimeElements(FriStartTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + FriStartTime);
                fristarttimeTextbox.SendKeys(reformattedtime.Substring(0, 6));
            }
        }

        public void AddFridayEndTime(string FriEndTime)
        {
            // if Friday's end time is not blank, then reformat the time to hhmmAM/PM and enter into Friday's end time textbox
            if (string.IsNullOrWhiteSpace(FriEndTime) == false) // time contains data
            {
                reformattedtime = Reformat3TimeElements(FriEndTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + FriEndTime);
                friendtimeTextbox.SendKeys(reformattedtime.Substring(0, 6));
            }
        }

        public void AddSaturday(string Sat)
        {
            // if Saturday = Y, then ensure Saturday's checkbox is ticked, otherwise; ensure Saturday's checkbox is Not ticked
            if (Sat == "Y")
            {
                // if Saturday's checkbox is Not ticked, then tick it
                if (!satCheckbox.Selected)
                {
                    satCheckbox.Click();
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
        }

        public void AddSaturdayStartTime(string SatStartTime)
        {
            // if Saturday's start time is not blank, then reformat the time to hhmmAM/PM and enter into Saturday's start time textbox
            if (string.IsNullOrWhiteSpace(SatStartTime) == false) // time contains data
            {
                reformattedtime = Reformat3TimeElements(SatStartTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + SatStartTime);
                satstarttimeTextbox.SendKeys(reformattedtime.Substring(0, 6));
            }
        }

        public void AddSaturdayEndTime(string SatEndTime)
        {
            // if Saturday's end time is not blank, then reformat the time to hhmmAM/PM and enter into Saturday's end time textbox
            if (string.IsNullOrWhiteSpace(SatEndTime) == false) // time contains data
            {
                reformattedtime = Reformat3TimeElements(SatEndTime);
                Assert.IsNotEmpty(reformattedtime, "Invalid time of " + SatEndTime);
                satendtimeTextbox.SendKeys(reformattedtime.Substring(0, 6));
            }
        }

        public void AddSkillTrade(string SkillTrade, string SkillExchange, string Credit)
        {
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
        }

        public void AddWorkSamples(string WorkSamples)
        {
            // if work samples contains data, then click the upload button and call the AutoIT script to complete the upload
            if (string.IsNullOrWhiteSpace(WorkSamples) == false) // Work Samples contains 1 or more files to upload
            {
                // don't know how to send variable file path & filename to AutoIT script so only using 1 hard-coded file path in AutoIT script
                worksamplesicon.Click();
                Process.Start(AutoITuploadscript).WaitForExit(8000);
            }
        }

        public void AddActive(string Active)
        {
            // find and select the matching active radio button -- if empty, null, or whitespace, then do nothing because it contains a default value
            if (Active == "Active")
            {
                activeRadioButton.Click();
            }
            if (Active == "Hidden")
            {
                hiddenRadioButton.Click();
            }
        }

        public void ProcessTheActionButton(string ValidInvalid, string ActionButton, string TitleError, string DescriptionError, string StartEndDateError)
        {
            // click the Save or Cancel button per the ActionButton parameter
            if (ActionButton == "Save")
            {
                // click the Save button
                saveButton.Click();
                Thread.Sleep(5000);

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

                int numberofSaveButtons = driver.FindElements(By.XPath(saveButtonXP)).Count;
                if (numberofSaveButtons > 0) // still on Share Skills page because Save button was found due to an error caused by invalid data
                {
                    if (ValidInvalid == "Valid")
                    {
                        Console.WriteLine("FAIL: Still on Share Skill page when valid data was entered");
                        Console.WriteLine("Ending program");
                        test.Log(Status.Fail, "Still on Share Skill page when valid data was entered");
                        //GetScreenshot(TestCaseID);
                        Assert.Fail("FAIL: Still on Share Skill page when valid data was entered");
                    }
                    else // invalid data has been entered on the Share Skill page and the ValidInvalid parm is Not = Valid, so this is expected for a negative test
                    {
                        // this path is for invalid data where user clicks Save button but remains on the Share Skill page so...
                        // just click the Cancel button for this scenario to exit this path and then verify listing count on Manage Listings page is unchanged
                        ///// changed my mind -- do not click Cancel because invalid test data on Share Skill page reads multiple rows until FollowupAction not = Yes
                        ///// and must therefore remain on the Share Skill page and not be returned to any other page when the Cancel button is clicked so...
                        ///// just write a line acknowledging a valid error on the Share Skill page is present

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
                                //GetScreenshot(TestCaseID);
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
                                //GetScreenshot(TestCaseID);
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
                                //GetScreenshot(TestCaseID);
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
            // must be able to handle test case where invalid data are corrected and successfully saved in same test case -- using FollowupMessage?
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
            {
                if (TimetoReformat.Substring(2, 1) == ":")
                {
                    timeString = (TimetoReformat.Substring(0, 2) + TimetoReformat.Substring(3, 2) + TimetoReformat.Substring(6, 2));
                }
                else
                {
                    Console.WriteLine("FAIL: Invalid time of " + TimetoReformat);
                    test.Log(Status.Fail, "Invalid time of '" + TimetoReformat + "'");
                }
            }
            return timeString;
        }

        public string ConvertDate(string DatetoConvert)
        {
            // expected input/parm values/format [from Test Data spreadsheet]: Today, Today+nnn, Today-nnn, or variations of ddmmyyyy (Not always 2-digit day and 2-digit month)
            // must return dd/mm/yyyy using ReformatDate method
            // add or subtract nnn days to/from today's date accordingly when DatetoConvert = Today+nnn or Today-nnn using method CalculateTheDate method

            finalDate = null;

            if (DatetoConvert.Substring(0, 5) == "Today")
            {
                int todaylength = DatetoConvert.Length;
                if (todaylength == 5) // there is nothing ['+' or '-'] following Today
                {
                    calculatedDate = DateTime.Today;
                    stringDate = calculatedDate.ToString();
                    finalDate = ReformatDate(stringDate);
                    return finalDate;
                }
                else // todaylength > 5 which means something [presumably '+' or '-'] follows Today; otherwise invalid data follows Today
                {
                    finalDate = CalculateTheDate(DatetoConvert);
                    return finalDate;
                }
            }
            else  // Date does NOT begin with 'Today'
            {
                // DatetoConvert is a variation of dd/mm/yyyy, only yyyy have a fixed, constant length [of 4], dd and mm can be 1 or 2 digits
                // just reformat the string - don't use Parse

                finalDate = ReformatDate(DatetoConvert);
                return finalDate;
            }
        }

        public string CalculateTheDate(string DatetoCalculate)
        {
            dayswithleadingsign = null;

            int stringlength = DatetoCalculate.Length;
            int numberofdigits = stringlength - 6;

            dayswithleadingsign = DatetoCalculate.Substring(5, numberofdigits + 1);
            int justdaysint;
            bool isParsable = Int32.TryParse(dayswithleadingsign, out justdaysint);
            if (isParsable)
            {
                calculatedDate = DateTime.Today.AddDays(justdaysint);
                stringDate = calculatedDate.ToString();
                finalDate = ReformatDate(stringDate);
                return finalDate;
            }
            else
            {
                Console.WriteLine("FAIL: " + DatetoCalculate + " could not be parsed");
                test.Log(Status.Fail, DatetoCalculate + " could not be parsed");
                return DatetoCalculate;
            }
        }

        public string ReformatDate(string DatetoReformat)
        {
            // date values of d/m/yyyy, d/mm/yyyy, and dd/m/yyyy will be reformatted to dd/mm/yyyy

            if (DatetoReformat.Substring(1, 1) == "/")
            {
                if (DatetoReformat.Substring(3, 1) == "/")
                {
                    // original format is d/m/yyyy
                    ReformattedDate = ("0" + DatetoReformat.Substring(0, 1) + "/0" + DatetoReformat.Substring(2, 1) + "/" + DatetoReformat.Substring(4, 4));
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
                    return ReformattedDate;
                }
                else
                {
                    // original format is dd/mm/yyyy -- just return the original value as it requires no reformat
                    ReformattedDate = DatetoReformat;
                    return ReformattedDate;
                }
            }
        }

        // this method is only called by Add & Edit positive test cases containing valid data
        public bool CompareShareSkillValues(string ActionOfTest, string Title, string Description, string Category, string Subcategory, string Tags, string ServiceType, string Location, string StartDate, string EndDate, string Sun, string SunStartTime, string SunEndTime, string Mon, string MonStartTime, string MonEndTime, string Tue, string TueStartTime, string TueEndTime, string Wed, string WedStartTime, string WedEndTime, string Thu, string ThuStartTime, string ThuEndTime, string Fri, string FriStartTime, string FriEndTime, string Sat, string SatStartTime, string SatEndTime, string SkillTrade, string SkillExchange, string Credit, string WorkSamples, string Active)
        {
            test.Log(Status.Info, "Beginning comparisons on Share Skill page");

            bool shareskillmatchingflag = true;

            // wait for Share Skill page to load and the Title textbox to be clickable
            Wait.WaitForElementToBeClickable("Name", "title", 5);

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
                int numberoftagsoneditpage = driver.FindElements(By.ClassName("ReactTags__tag")).Count; // counts both Tags and SkillTrade tags (if selected)
                if (SkillTrade == "Skill-exchange")
                {
                    //justtagscount = 0;
                    //justtagscount = numberoftagsoneditpage - (numberofSkills + 1);
                    numberoftagsoneditpage -= numberofSkills + 1;
                }

                if (numberoftagsoneditpage == (numberofDelimiters + 1))
                {
                    Console.WriteLine("Pass: Actual number of Tags '" + numberoftagsoneditpage + "' matches expected number");
                    test.Log(Status.Pass, "Actual number of Tags '" + numberoftagsoneditpage + "' matches expected number");
                }
                else
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
                // force a failure
                //return false;
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
