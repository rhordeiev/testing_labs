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
public class VeterinarianPage {
    private IWebDriver driver;

    public VeterinarianPage(IWebDriver driver) {
        this.driver = driver;
    }
    public IWebElement veterinarianTab => driver.FindElement(By.CssSelector(".vetsTab"));
    public IWebElement veterinarianTabAddNewDropdown => driver.FindElement(By.CssSelector(".open li:nth-child(2) > a"));
    public IWebElement firstNameField => driver.FindElement(By.Id("firstName"));
    public IWebElement lastNameField => driver.FindElement(By.Id("lastName"));
    public void selectSpecialty(string specialty) {
        driver.FindElement(By.Id("specialties")).Click();
        var dropdown = new SelectElement(driver.FindElement(By.Id("specialties")));
        dropdown.SelectByText(specialty);
    }
    public IWebElement addVeterinarianButton => driver.FindElement(By.CssSelector(".saveVet"));
}