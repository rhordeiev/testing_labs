using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
public class SpecialtiesPage {
    private IWebDriver driver;
    public SpecialtiesPage(IWebDriver driver) {
        this.driver = driver;
    }
    public IWebElement specialtiesTab => driver.FindElement(By.CssSelector("li:nth-child(5) > a"));
}