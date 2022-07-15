using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace MARSQA2.Pages
{
    internal class Homepage
    {
            [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/a")]
            public IWebElement signInButton { get; set; }
                
    }
}