using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

public class OwnersListPage : BasePage {
    public OwnersListPage(IWebDriver driver):base(driver){}
    public IWebElement getUser(int number){
        return driver.FindElement(By.CssSelector(".petOwner:nth-child(" + number + ") a"));
    }
}