using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

public class OwnersListPage {
    private IWebDriver driver;

    public OwnersListPage(IWebDriver driver) {
        this.driver = driver;
    }
    public IWebElement getUser(int number){
        return driver.FindElement(By.CssSelector(".petOwner:nth-child(" + number + ") a"));
    }
}