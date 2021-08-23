using AdvanceTask.Utility;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TechTalk.SpecFlow;

namespace SkillSwapSpecFlow.Hooks
{
    [Binding]
    public sealed class Hooks:CommonDriver
    {
        public static ExtentTest _test;
        public static ExtentReports _extent;
        //public static string BasePath = AdvanceTask.Resource.Resource1.BasePath;

        //[BeforeTestRun]
        //public static void Setup()
        //{
        //    //var path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
        //    //var actualPath = path.Substring(0, path.LastIndexOf("bin"));
        //    //var projectPath = new Uri(actualPath).LocalPath;
        //    //Directory.CreateDirectory(projectPath.ToString() + "Reports");
        //    var reportPath = (@"C:\Users\Dell\Documents\VB Feb 2021\SpecflowTask\SkillSwapSpecFlow\SkillSwapSpecFlow\" + "Reports\\ExtentReport.html");
        //    var htmlReporter = new ExtentHtmlReporter(reportPath);
        //    _extent = new ExtentReports();
        //    _extent.AttachReporter(htmlReporter);
        //    _extent.AddSystemInfo("Host Name", "LocalHost");
        //    _extent.AddSystemInfo("Environment", "QA");
        //    _extent.AddSystemInfo("UserName", "Mayuri Gohil");
        //}

        //[AfterTestRun]
        //public static void TearDown()
        //{
        //    _extent.Flush();
        //}

        [BeforeScenario]
        public void SetUpBrowser()
        {
            driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void CloseBrowser()
        {

            driver.Quit();
        }
    }
}
