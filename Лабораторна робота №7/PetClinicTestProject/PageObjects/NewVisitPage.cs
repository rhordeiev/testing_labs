using OpenQA.Selenium;
using NUnit.Allure.Steps;

public class NewVisitPage : BasePage {
    public NewVisitPage(IWebDriver driver):base(driver){}
    [AllureStep("Select pet's visit date")]
    public void selectDate() {
        driver.FindElement(By.CssSelector("path")).Click();
        driver.FindElement(By.CssSelector(".ng-star-inserted:nth-child(5) > .mat-calendar-body-cell:nth-child(4) > .mat-calendar-body-cell-content")).Click();
    }
    public IWebElement addVisitButton => driver.FindElement(By.CssSelector(".addVisit"));
    public IWebElement descriptionField => driver.FindElement(By.Id("description"));
}