using OpenQA.Selenium;

public class NewVisitPage : BasePage {
    public NewVisitPage(IWebDriver driver):base(driver){}
    public void selectDate() {
        driver.FindElement(By.CssSelector("path")).Click();
        driver.FindElement(By.CssSelector(".ng-star-inserted:nth-child(5) > .mat-calendar-body-cell:nth-child(4) > .mat-calendar-body-cell-content")).Click();
    }
    public IWebElement addVisitButton => driver.FindElement(By.CssSelector(".addVisit"));
    public IWebElement descriptionField => driver.FindElement(By.Id("description"));
}