using OpenQA.Selenium;

public class OwnerPage {
    private IWebDriver driver;

    public OwnerPage(IWebDriver driver) {
        this.driver = driver;
    }
    public IWebElement addNewPetButton => driver.FindElement(By.CssSelector(".addNewPet"));
    public IWebElement addNewVisitButton => driver.FindElement(By.CssSelector(".addNewVisit"));
    public IWebElement deletePetButton(int number) {
        return driver.FindElement(By.CssSelector("app-pet-list:nth-child(" + number + ") .deletePet"));
    } 
    public IWebElement editPetTypeButton(int number) {
        return driver.FindElement(By.CssSelector("app-pet-list:nth-child(" + number + ") .editPet"));
    }
}