
using TechTalk.SpecFlow;
using AdvanceTask.Pages;
using AdvanceTask.Utility;

namespace SkillSwapSpecFlow.StepDefination
{
    [Binding]
    public class DeleteShareSkillSteps:CommonDriver
    {
        [Given(@"User is logged in to Skill Swap")]
        public void GivenUserIsLoggedInToSkillSwap()
        {
            Login Obj1 = new Login(driver, 2);
            Obj1.LoginPage(driver);
        }
        
        [When(@"Delete Share Skill")]
        public void WhenDeleteShareSkill()
        {
            Managelisting Obj3 = new Managelisting(driver, 2);
            Obj3.NavigateManageListing();
            Obj3.DeleteManageListing();
        }
        
        [Then(@"Share SKill details should be Deleted")]
        public void ThenShareSKillDetailsShouldBeDeleted()
        {
            Managelisting Obj3 = new Managelisting(driver, 2);
            Obj3.ValidateDeleteManageListing();
        }
    }
}
