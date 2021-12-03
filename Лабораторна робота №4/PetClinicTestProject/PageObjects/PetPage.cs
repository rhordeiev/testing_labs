using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

public class PetPage {
    protected IWebDriver driver;

    public PetPage(IWebDriver driver) {
        this.driver = driver;
    }
    public void selectPetType(string petType) {
        driver.FindElement(By.Id("type")).Click();
        var dropdown = new SelectElement(driver.FindElement(By.Id("type")));
        dropdown.SelectByText(petType);
    }
    public IWebElement nameField => driver.FindElement(By.Id("name"));
}