using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace QAFramework.Pages
{
    public abstract class BasePage
    {
        #region MenuButtons

        protected const string MainMenuButton = "menu-item-341";
        protected const string AboutUsButton = "menu-item-545";
        protected const string PortfolioButton = "menu-item-506";
        protected const string ContactUsButton = "menu-item-348";
        public IWebElement MainMenu { get; set; }

        public IWebElement AboutUs { get; set; }
        public IWebElement Portfolio { get; set; }
        public IWebElement ContactUs { get; set; }

        #endregion

        protected const string LogoButton = "logo";
        public IWebElement Logo { get; set; }

        protected IWebDriver WebDriver;

        protected BasePage()
        {
            WebDriver = GetWebDriver();
        }

        protected void FindMenuButtons()
        {
            MainMenu = FindElement(MainMenuButton);
            AboutUs = FindElement(AboutUsButton);
            Portfolio = FindElement(PortfolioButton);
            ContactUs = FindElement(ContactUsButton);
            Logo = FindElement(LogoButton);
        }

        protected void GoToUrl(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }

        protected IWebElement FindElement(string id)
        {
            var element = WebDriver.FindElement(By.Id(id));
            return element;
        }

        private IWebDriver GetWebDriver() 
        {
            var driver = new FirefoxDriver();
            return driver;
        }
    }
}
