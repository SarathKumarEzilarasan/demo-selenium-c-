using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDAutomationFramework.Pages
{
    public class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@name='search_query']")]
        private IWebElement searchTextbox;

        //By searchTextbox = By.XPath("//*[@name='search_query']");

        public ResultPage searchText(string text)
        {
            //driver.FindElement(searchTextbox).SendKeys(text);
            //driver.FindElement(searchTextbox).SendKeys(Keys.Enter);
            searchTextbox.SendKeys(text);
            searchTextbox.SendKeys(Keys.Enter);
            return new ResultPage(driver);
        }

    }
}
