using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
public class NewVeterinarianPage:BasePage {
    public NewVeterinarianPage(IWebDriver driver):base(driver){}
    public IWebElement firstNameField => driver.FindElement(By.Id("firstName"));
    public IWebElement lastNameField => driver.FindElement(By.Id("lastName"));
    public void selectSpecialty(string specialty) {
        driver.FindElement(By.Id("specialties")).Click();
        var dropdown = new SelectElement(driver.FindElement(By.Id("specialties")));
        dropdown.SelectByText(specialty);
    }
    public IWebElement addVeterinarianButton => driver.FindElement(By.CssSelector(".saveVet"));
}