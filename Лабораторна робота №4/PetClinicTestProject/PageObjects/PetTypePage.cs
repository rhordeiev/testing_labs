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
public class PetTypePage {
    private IWebDriver driver;
    public PetTypePage(IWebDriver driver) {
        this.driver = driver;
    }
    public IWebElement petTypeTab => driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)"));
    public IWebElement addPetTypeButton => driver.FindElement(By.CssSelector(".addPet"));
    public IWebElement editPetTypeButton => driver.FindElement(By.CssSelector("tr:nth-child(4) .editPet"));
    public IWebElement nameField => driver.FindElement(By.Id("name"));
    public string getThirdPetTypeElementValue => driver.FindElement(By.Id("2")).GetAttribute("value");
    public IWebElement savePetTypeButton => driver.FindElement(By.CssSelector(".saveType"));
    public IWebElement updatePetTypeButton => driver.FindElement(By.CssSelector(".updatePetType"));
    public IWebElement deletePetTypeButton => driver.FindElement(By.CssSelector("tr:nth-child(3) .deletePet"));
    public IWebElement returnHomeButton => driver.FindElement(By.CssSelector(".returnHome"));
}