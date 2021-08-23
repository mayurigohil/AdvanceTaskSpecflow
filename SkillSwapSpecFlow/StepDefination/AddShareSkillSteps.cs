
using TechTalk.SpecFlow;
using AdvanceTask.Pages;
using AdvanceTask.Utility;


namespace SkillSwapSpecFlow.StepDefination
{
    [Binding]
    public class AddShareSkillSteps:CommonDriver
    {
        [Given(@"User is logged in to Share Skill")]
        public void GivenUserIsLoggedInToShareSkill()
        {
            Login Obj1 = new Login(driver, 2);
            Obj1.LoginPage(driver);
        }
        
        [When(@"Add Share Skill with Skill Exhcange")]
        public void WhenAddShareSkillWithSkillExhcange()
        {
            ShareSkill Obj2 = new ShareSkill(driver, 2);
            Obj2.ShareSkillPage();
            Obj2.SelectCategory();
            Obj2.SelectSubCategory();
            Obj2.EnterTag();
            Obj2.ShareSkillPageRemaining();
            Obj2.SkillExchange();
          
        }
        
        [When(@"Select Share Skill as Active")]
        public void WhenSelectShareSkillAsActive()
        {
            ShareSkill Obj2 = new ShareSkill(driver, 2);
            Obj2.ActiveShareSkill();
            Obj2.SaveShareSkill();
        }
        
        [When(@"Select Share Skill as Hide")]
        public void WhenSelectShareSkillAsHide()
        {
            ShareSkill Obj2 = new ShareSkill(driver, 2);
            Obj2.HiddenshareSkill();
            Obj2.SaveShareSkill();
        }
        
        [When(@"Add Share Skill with Credit")]
        public void WhenAddShareSkillWithCredit()
        {
            ShareSkill Obj2 = new ShareSkill(driver, 2);
            Obj2.ShareSkillPage();
            Obj2.SelectCategory();
            Obj2.SelectSubCategory();
            Obj2.EnterTag();
            Obj2.ShareSkillPageRemaining();
            Obj2.EditCreditExchange();
        }
        
        [Then(@"Active Share SKill details should be saved")]
        public void ThenActiveShareSKillDetailsShouldBeSaved()
        {
            Managelisting Obj3 = new Managelisting(driver, 2);
            Obj3.ManageListingsActive();
        }
        
        [Then(@"Share SKill details should be Hidden")]
        public void ThenShareSKillDetailsShouldBeHidden()
        {
            Managelisting Obj3 = new Managelisting(driver, 2);
            Obj3.ManageListingHidden();
        }

        [Then(@"Share Skill should be Skill Exchange")]
        public void ThenShareSkillShouldBeSkillExchange()
        {
            Managelisting Obj3 = new Managelisting(driver, 2);
            Obj3.ManageListingSkillExchange();
        }

        [Then(@"Share Skill should be Credit")]
        public void ThenShareSkillShouldBeCredit()
        {
            Managelisting Obj3 = new Managelisting(driver, 2);
            Obj3.ManageListingCredit();
        }

    }
}
