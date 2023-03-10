using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVPSt_2023_Feb_Competition.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using MVPSt_2023_Feb_Competition.Utilities;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System.IO;

namespace MVPSt_2023_Feb_Competition.Utilities
{
    [TestFixture]
    public class CommonDriver
    {
        // for Extent Reports
        public static ExtentReports extentReportObj = null;
        public static ExtentTest test = null;

        // Sign Out flag used by SignOut method to determine whether or not to attempt to SignOut
        private static bool signoutBool = false;

        public static IWebDriver driver;

        public static string filePath { get; set; }
        
        // variables from configuration file
        public static string filePath2 { get; set; }
        public static string sheetName2 { get; set; }
        public static string sheetName2Row { get; set; }
        public static string filePath3 { get; set; }
        public static string sheetName3 { get; set; }
        public static string sheetName3Row { get; set; }

        // converted variables from string to integer
        public static int sheetName2RowInt { get; set; }
        public static int sheetName3RowInt { get; set; }

        //// for Extent Reports
        //public static ExtentTest test;
        //public static ExtentReports extent;

        [SetUp]
        public static void SetupActions()
        {
            Console.WriteLine("**Starting 'Trade Your Skills' portal script from CommonDriver");

            // create the Extent Report
            test = extentReportObj.CreateTest("DetermineAction").Info("**Starting 'Trade Your Skills' portal script from CommonDriver");

            // full path of file containing configuration details -- other spreadsheets
            filePath = "C:\\Users\\User\\Documents\\MVP Studio Projects\\MVPSt_2023_Feb_Competition\\MVPSt_2023_Feb_Competition\\MVPSt_2023_Feb_Competition\\ExcelData\\Mars-Config.xlsx";
            string sheetName = "Sheet1";

            // call method to read all rows [only 2] of external configuration file into an internal table
            ExcelLib.PopulateIntoCollection(filePath, sheetName);

            // get fileName, sheetname, and row number of sheet of credentials file from the configuration file
            filePath2 = ExcelLib.ReadData(2, "CredentialsFile");
            sheetName2 = ExcelLib.ReadData(2, "CredentialsFileSheetName");
            sheetName2Row = ExcelLib.ReadData(2, "CredentialsFileSheetNameRow");
            
            // convert string sheetName2Row to integer
            Int32.TryParse(sheetName2Row, out int sheetName2RowInt);

            // get fileName, sheetname, and row number of sheet of test data file from the configuration file
            filePath3 = ExcelLib.ReadData(2, "TestDataFile");
            sheetName3 = ExcelLib.ReadData(2, "TestDataFileSheetName");
            sheetName3Row = ExcelLib.ReadData(2, "TestDataFileSheetNameRow");
            
            // convert string sheetName3Row to integer
            //Int32.TryParse(sheetName3Row, out int sheetName3RowInt);
            sheetName3RowInt = int.Parse(sheetName3Row);

            
            // call method to read all rows of external credentials file into an internal table
            ExcelLib.PopulateIntoCollection(filePath2, sheetName2);

            // get URL from internal, populated collection [originally from the login credentials file]
            string TYSPortalUrl = ExcelLib.ReadData(sheetName2RowInt, "URL");

            // XPath of elements
            string signinLinkXP = "//*[@id=\"home\"]/div/div/div[1]/div/a";

            // define Pages and Page objects
            TYSPortalPage tysportalPageObj;

            // initialize Page objects
            tysportalPageObj = new TYSPortalPage();

            // set driver to the Chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // launch Trade Your Skills portal
            driver.Navigate().GoToUrl(TYSPortalUrl);

            // wait for page to load and Sign In link to be clickable
            Wait.WaitForElementToBeClickable("XPath", signinLinkXP, 4);

            // sign in and check returned boolean value to see if successful
            if (tysportalPageObj.SigninActions(sheetName2RowInt) == true)
            {
                //Console.WriteLine("Successfully Signed into 'Trade Your Skills' portal");
                //test.Log(Status.Info, "Successfully Signed into 'Trade Your Skills' portal");
                signoutBool = true;
            }
            else
            {
                Console.WriteLine("FAIL: Failed to Sign into 'Trade Your Skills' portal");
                Console.WriteLine("Closing browser and exiting program");
                test.Log(Status.Fail, "Failed to Sign into 'Trade Your Skills' portal");
                Cleanup();
            }
        }

        [OneTimeSetUp]
        public void ExtentStart()
        {
            string reportPath = @"C:\Users\User\Documents\MVP Studio Projects\MVPSt_2023_Feb_Competition\MVPSt_2023_Feb_Competition\MVPSt_2023_Feb_Competition\ExtentReports\MVPSt_2023_Feb_Competition.html";
            //var htmlReporter = new ExtentHtmlReporter(reportPath + DateTime.Now.ToString("_ddMMyyyy_hhmmtt") + ".html");
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            extentReportObj = new ExtentReports();
            extentReportObj.AttachReporter(htmlReporter);
        }

        [TearDown]
        public static void Cleanup()
        {
            Console.WriteLine("Made it into TearDown's Cleanup in CommonDriver");
            //if (signoutBool == true)
            //{
            //    Console.WriteLine("signoutBool = true");
            //}
            //if (signoutBool == false)
            //{
            //    Console.WriteLine("signoutBool = false");
            //}

            // define Pages and Page objects
            HomePage homePageObj;

            // initialize Page objects
            homePageObj = new HomePage();

            if (signoutBool == true) // then attempt to Sign Out
            {
                //if (homePageObj.SignOut() == true)
                //{
                //    Console.WriteLine("Successfully Signed out of 'Trade Your Skills' portal");
                //    test.Log(Status.Info, "Successfully Signed out of 'Trade Your Skills' portal");
                //}
                //else
                if (homePageObj.SignOut() == false)
                {
                    Console.WriteLine("FAIL: Failed to Sign Out of 'Trade Your Skills' portal");
                    test.Log(Status.Fail, "Failed to Sign Out of 'Trade Your Skills' portal");
                }
            }
            Console.WriteLine("**Exiting/Ending 'Trade Your Skills' portal script from CommonDriver");
            test.Log(Status.Info, "**Exiting/Ending 'Trade Your Skills' portal script from CommonDriver");
            
            // close browser
            // driver.Close(); is not listed in videos
            //driver.Close();
            driver.Quit();
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extentReportObj.Flush();
        }
    }
}
