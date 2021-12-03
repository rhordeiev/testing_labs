using OpenQA.Selenium;

public class PetTypePage:BasePage {
    public PetTypePage(IWebDriver driver):base(driver){}
    public IWebElement addPetTypeButton => driver.FindElement(By.CssSelector(".addPet"));
    public IWebElement editPetTypeButton => driver.FindElement(By.CssSelector("tr:nth-child(4) .editPet"));
    public IWebElement nameField => driver.FindElement(By.Id("name"));
    public IWebElement savePetTypeButton => driver.FindElement(By.CssSelector(".saveType"));
    public IWebElement updatePetTypeButton => driver.FindElement(By.CssSelector(".updatePetType"));
    public IWebElement deletePetTypeButton => driver.FindElement(By.CssSelector("tr:nth-child(3) .deletePet"));
    public IWebElement returnHomeButton => driver.FindElement(By.CssSelector(".returnHome"));
}