using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

public class PetPage : BasePage {

    public PetPage(IWebDriver driver):base(driver){}
    public void selectPetType(string petType) {
        driver.FindElement(By.Id("type")).Click();
        var dropdown = new SelectElement(driver.FindElement(By.Id("type")));
        dropdown.SelectByText(petType);
    }
    public IWebElement nameField => driver.FindElement(By.Id("name"));
}