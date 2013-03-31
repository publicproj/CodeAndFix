using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace QAFramework.Pages
{
    public class MainPage : BasePage
    {
        private const string ManinPageUrl = "http://scrum.ultradev.net/";
        
        public MainPage()
        {
            GoToUrl(ManinPageUrl);
            FindMenuButtons();
        }

         
    }
}
