
using TechTalk.SpecFlow;
using AdvanceTask.Pages;
using AdvanceTask.Utility;


namespace SkillSwapSpecFlow.StepDefination
{
    [Binding]
    public class DeleteProfileSteps:CommonDriver
    {
        [Given(@"User logged in to Mars")]
        public void GivenUserLoggedInToMars()
        {
            Login Obj1 = new Login(driver, 2);
            Obj1.LoginPage(driver);
        }
        
        [When(@"Delete Certification")]
        public void WhenDeleteCertification()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.DeleteCerticateDetails(driver);
        }
        
        [When(@"Delete Education")]
        public void WhenDeleteEducation()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.DeleteEducation(driver);
        }
        
        [Then(@"Deletes the Language")]
        public void ThenDeletesTheLanguage()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.DeleteLanguageDetails(driver);
        }
        
        [Then(@"Deletes the Skill")]
        public void ThenDeletesTheSkill()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.DeleteSkillDetails(driver);
        }
        
        [Then(@"skill is Certification")]
        public void ThenSkillIsCertification()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.ValidateDeleteCertificate(driver);
        }
        
        [Then(@"skill is Education")]
        public void ThenSkillIsEducation()
        {
            ProfilePage obj6 = new ProfilePage(driver, 2);
            obj6.ValidateDeleteEducation(driver);
        }
    }
}
