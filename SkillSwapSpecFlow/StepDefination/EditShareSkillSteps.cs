
using TechTalk.SpecFlow;
using AdvanceTask.Pages;
using AdvanceTask.Utility;


namespace SkillSwapSpecFlow.StepDefination
{
    [Binding]
    public class EditShareSkillSteps:CommonDriver
    {
        [Given(@"User is logged in to ShareSkill")]
        public void GivenUserIsLoggedInToShareSkill()
        {
            Login Obj1 = new Login(driver, 2);
            Obj1.LoginPage(driver);
        }
        
        [When(@"Edit Share Skill with Skill Exhcange")]
        public void WhenEditShareSkillWithSkillExhcange()
        {
            Managelisting EditProfile = new Managelisting(driver, 2);
            EditProfile.NavigateManageListing();
            EditProfile.EditManageListing();
            ShareSkill Obj2 = new ShareSkill(driver, 2);
            Obj2.ShareSkillPage();
            Obj2.SelectCategory();
            Obj2.SelectSubCategory();
            Obj2.EnterTag();
            Obj2.ShareSkillPageRemaining();
            Obj2.SkillExchange();
        }
        
        [When(@"Update Share Skill as Active")]
        public void WhenUpdateShareSkillAsActive()
        {
            ShareSkill Obj2 = new ShareSkill(driver, 2);
            Obj2.ActiveShareSkill();
            Obj2.SaveShareSkill();
        }
        
        [When(@"Update Share Skill as Hidden")]
        public void WhenUpdateShareSkillAsHidden()
        {
            ShareSkill Obj2 = new ShareSkill(driver, 2);
            Obj2.HiddenshareSkill();
            Obj2.SaveShareSkill();
        }
        
        [When(@"Edit Share Skill with Credit")]
        public void WhenEditShareSkillWithCredit()
        {
            ShareSkill Obj2 = new ShareSkill(driver, 2);
            Obj2.ShareSkillPage();
            Obj2.SelectCategory();
            Obj2.SelectSubCategory();
            Obj2.EnterTag();
            Obj2.ShareSkillPageRemaining();
            Obj2.EditCreditExchange();
        }
        
        [Then(@"Active Share SKill details should be Updated")]
        public void ThenActiveShareSKillDetailsShouldBeUpdated()
        {
            Managelisting Obj3 = new Managelisting(driver, 2);
            Obj3.ManageListingsActive();
        }
        
        [Then(@"Share SKill details should be Updated as Hidden")]
        public void ThenShareSKillDetailsShouldBeUpdatedAsHidden()
        {
            Managelisting Obj3 = new Managelisting(driver, 2);
            Obj3.ManageListingHidden();
        }

        [Then(@"Share Skill should be Updated to Skill Exchange")]
        public void ThenShareSkillShouldBeUpdatedToSkillExchange()
        {
            Managelisting Obj3 = new Managelisting(driver, 2);
            Obj3.ManageListingSkillExchange();
        }

        [Then(@"Share Skill should be Updated to Credit")]
        public void ThenShareSkillShouldBeUpdatedToCredit()
        {
            Managelisting Obj3 = new Managelisting(driver, 2);
            Obj3.ManageListingCredit();
        }

    }
}
