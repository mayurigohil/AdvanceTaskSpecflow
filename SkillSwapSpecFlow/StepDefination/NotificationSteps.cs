using TechTalk.SpecFlow;
using AdvanceTask.Pages;
using AdvanceTask.Utility;

namespace SkillSwapSpecFlow.StepDefination
{
    [Binding]
    public class NotificationSteps:CommonDriver
    {
        [Given(@"User is logs in to ShareSkill")]
        public void GivenUserIsLogsInToShareSkill()
        {
            Login Obj1 = new Login(driver, 2);
            Obj1.LoginPage(driver);
        }
        
        [Given(@"Navigate to Notification Module")]
        public void GivenNavigateToNotificationModule()
        {
            Notification obj1 = new Notification(driver);
            obj1.NotificationPage();
        }

        [Then(@"Click on Load More to validated data displayed")]
        public void ThenClickOnLoadMoreToValidatedDataDisplayed()
        {
            Notification obj1 = new Notification(driver);
            obj1.ValidateLoadMore();
        }

        [Then(@"Click on Show Less to validate hidden data")]
        public void ThenClickOnShowLessToValidateHiddenData()
        {
            Notification obj1 = new Notification(driver);
            obj1.ValidateLoadMore();
            obj1.ValidateShowLess();
        }

    }
}
