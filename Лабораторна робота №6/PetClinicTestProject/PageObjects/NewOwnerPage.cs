using OpenQA.Selenium;

public class NewOwnerPage:BasePage {
    public NewOwnerPage(IWebDriver driver):base(driver){}
    public IWebElement firstNameField => driver.FindElement(By.Id("firstName"));
    public IWebElement lastNameField => driver.FindElement(By.Id("lastName"));
    public IWebElement addressField => driver.FindElement(By.Id("address"));
    public IWebElement cityField => driver.FindElement(By.Id("city"));
    public IWebElement telephoneField => driver.FindElement(By.Id("telephone"));
    public IWebElement addOwnerButton => driver.FindElement(By.CssSelector(".addOwner"));
}