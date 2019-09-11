using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace nop.framework.nop
{
    public abstract class BaseView
    {
        protected IWebDriver driver;
        protected Dictionary<string, string> elements;
        public string name;

        public BaseView(IWebDriver d)
        {
            driver = d;
        }

        public abstract BaseView GoTo();
    }
}
