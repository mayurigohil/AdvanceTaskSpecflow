using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AdvanceTask.Pages;
using AdvanceTask.Utility;
using SkillSwapSpecFlow.Hooks;
using TechTalk.SpecFlow;

namespace SkillSwapSpecFlow.StepDefination
{
    [Binding]
    public class EditProfileSteps:CommonDriver
    {
        [Given(@"User logs in")]
        public void GivenUserLogsIn()
        {
            Login Obj1 = new Login(driver, 2);
            Obj1.LoginPage(driver);
        }
        
        [When(@"Edit and save Language")]
        public void WhenEditAndSaveLanguage()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.EditLanguageDetails(driver);
        }
        
        [When(@"Edit and save skill")]
        public void WhenEditAndSaveSkill()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.EditSkillDetails(driver);
        }
        
        [When(@"Edit and save Education")]
        public void WhenEditAndSaveEducation()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.EditEducation(driver);
        }
        
        [When(@"Edit and save Certification")]
        public void WhenEditAndSaveCertification()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.EditCertificateDetails(driver);
        }
        
        [Then(@"Updated Language is saved")]
        public void ThenUpdatedLanguageIsSaved()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.ValidateAddLanguageDetails(driver);
        }
        
        [Then(@"Updated skill is saved")]
        public void ThenUpdatedSkillIsSaved()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.ValidateAddSkillDetails(driver);
        }
        
        [Then(@"Updated Education is saved")]
        public void ThenUpdatedEducationIsSaved()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.ValidateEditEducation(driver);
        }
        
        [Then(@"Updated Certification is saved")]
        public void ThenUpdatedCertificationIsSaved()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.ValidateEditCertificate(driver);
        }
    }
}
