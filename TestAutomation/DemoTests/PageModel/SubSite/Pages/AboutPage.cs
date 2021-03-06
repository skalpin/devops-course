﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.Utilities;
using Magenic.Maqs.Utilities.Helper;
using Magenic.Maqs.BaseSeleniumTest.Extensions;
using System;

namespace PageModel.SubSite.Pages
{
    /// <summary>
    /// Page object for the login page
    /// </summary>
    public class AboutPage : BaseSubSitePage
    {
        /// <summary>
        /// The page url
        /// </summary>
        private static readonly string PageUrl = SeleniumConfig.GetWebSiteBase().Trim('/') + "/static/BasicSite/About.html";

        public LazyElement AboutTable
        {
            get { return new LazyElement(this.testObject, By.CssSelector("#AboutTable"), "AboutTable"); }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model1" /> class.
        /// </summary>
        /// <param name="webDriver">The selenium web driver</param>
        public AboutPage(SeleniumTestObject testObject)
            : base(testObject)
        {
        }

        /// <summary>
        /// Verify we are on the login page
        /// </summary>
        public override bool IsPageLoaded()
        {
            return this.testObject.WebDriver.Wait().UntilElementExist(AboutTable.By);
        }
    }
}
