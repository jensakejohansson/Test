using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using static Gauge.CSharp.Lib.ExecutionContext;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using nop.framework.nop;
using System.Collections.Generic;

public class ExecutionHooks
{
    [BeforeSuite]
    public void BeforeSuite()
    {
    }

    [AfterSuite]
    public void AfterSuite()
    {
        // Code for after suite
    }

    [BeforeSpec]
    public void BeforeSpec()
    {
    }

    [AfterSpec]
    public void AfterSpec()
    {
        // Code for after spec
    }

    [BeforeScenario]
    public void BeforeScenario()
    {
        var browser = new ChromeDriver();
        DataStoreFactory.ScenarioDataStore.Add("browser", browser);
    }

    [AfterScenario]
    public void AfterScenario()
    {
        var browser = (IWebDriver)DataStoreFactory.ScenarioDataStore.Get("browser");
        if (browser != null) browser.Quit();
    }

    [BeforeStep]
    public void BeforeStep()
    {
        // Code for before step
    }

    [AfterStep]
    public void AfterStep()
    {
        // Code for after step
    }

}