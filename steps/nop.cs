using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using nop.framework.nop;

namespace nop
{
    public class NopSteps
    {

        [Step("Start application")]
        public void StartApplication()
        {
           
        }

        [Step("Stop application")]
        public void StopApplication()
        {
            
        }
    }
}
