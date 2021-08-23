using System;
using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AdvanceTask.Pages;
using AdvanceTask.Utility;
using SkillSwapSpecFlow.Hooks;

namespace SkillSwapSpecFlow.StepDefination
{
    [Binding]
    public class AddProfileDetailsSteps:CommonDriver
    {
       
        [Given(@"User is logged in to Mars")]
        public void GivenUserIsLoggedInToMars()
        {
            Login Obj1 = new Login(driver, 2);
            Obj1.LoginPage(driver);
            
        }
        
        [When(@"Add Profile description")]
        public void WhenAddProfileDescription()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.AddDesCriptionDetails(driver);
        }
        
        [When(@"Add New Language")]
        public void WhenAddNewLanguage()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.AddLanguageDetails(driver);

        }
        
        [When(@"Add New skill")]
        public void WhenAddNewSkill()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.AddSkillDetails(driver);
        }
        
        [When(@"Add New Education")]
        public void WhenAddNewEducation()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.EducationDetails(driver);
        }
        
        [When(@"Add New Certification")]
        public void WhenAddNewCertification()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.CertificationDetails(driver);
        }
        
        [Then(@"The details should be saved")]
        public void ThenTheDetailsShouldBeSaved()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.ValidateAddDesCriptionDetails(driver);
        }
        
        [Then(@"New Language is saved")]
        public void ThenNewLanguageIsSaved()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.ValidateAddLanguageDetails(driver);
        }
        
        [Then(@"New skill is saved")]
        public void ThenNewSkillIsSaved()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.ValidateAddSkillDetails(driver);
        }
        
        [Then(@"New Education is saved")]
        public void ThenNewEducationIsSaved()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.ValidateEducationDetails(driver);
        }
        
        [Then(@"New Certification is saved")]
        public void ThenNewCertificationIsSaved()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.ValidateCertificationDetails(driver);
        }
    }
}
