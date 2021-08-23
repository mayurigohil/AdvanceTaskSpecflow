using TechTalk.SpecFlow;
using AdvanceTask.Pages;
using AdvanceTask.Utility;

namespace SkillSwapSpecFlow.StepDefination
{
    [Binding]
    public class ChatHistorySteps:CommonDriver
    {
        [Given(@"User Logged in to Share Skill")]
        public void GivenUserLoggedInToShareSkill()
        {
            Login Obj1 = new Login(driver, 2);
            Obj1.LoginPage(driver);
        }
        
        [When(@"Clicked on Chat History")]
        public void WhenClickedOnChatHistory()
        {
            Chat Obj2 = new Chat(driver);
            Obj2.ChatHistory();
        }
        
        [Then(@"Chat History should be displayed")]
        public void ThenChatHistoryShouldBeDisplayed()
        {
            Chat Obj2 = new Chat(driver);
            Obj2.ValidateChat();
        }
    }
}
