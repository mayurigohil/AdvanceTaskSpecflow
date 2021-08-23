using TechTalk.SpecFlow;
using AdvanceTask.Pages;
using AdvanceTask.Utility;


namespace SkillSwapSpecFlow.StepDefination
{
    [Binding]
    public class SearchSteps:CommonDriver
    {
        [Given(@"User logs in to ShareSkill")]
        public void GivenUserLogsInToShareSkill()
        {
            Login Obj1 = new Login(driver, 2);
            Obj1.LoginPage(driver);
        }

        [Then(@"Enter Search Category & Category data is loaded")]
        public void ThenEnterSearchCategoryCategoryDataIsLoaded()
        {
            SearchSkill Search = new SearchSkill(driver, 2);
            Search.SearchSkillCategory();
        }

        [Then(@"Enter Search SubCategory & SubCategory data is loaded")]
        public void ThenEnterSearchSubCategorySubCategoryDataIsLoaded()
        {
            SearchSkill Search = new SearchSkill(driver, 2);
            Search.SearchSkillSub();
        }

    }
}
