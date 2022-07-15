using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace MARSQA2.Pages
{
    internal class Loginpage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[1]/input")]
        public IWebElement emailAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[2]/input")]
        public IWebElement passWord { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        public IWebElement loginButton { get; set; }

        public void Loginsteps()
        {
            emailAddress.SendKeys("roshanfer80@gmail.com");
            passWord.SendKeys("Producetaka1");
            loginButton.Click();
        }
    }
}