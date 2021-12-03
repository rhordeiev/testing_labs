using OpenQA.Selenium;
using NUnit.Allure.Steps;

public class NewPetPage : PetPage{
    public NewPetPage(IWebDriver driver):base(driver){}
    [AllureStep("Select pet's date")]
    public void selectDate() {
        driver.FindElement(By.CssSelector(".mat-datepicker-toggle-default-icon")).Click();
        driver.FindElement(By.CssSelector(".mat-calendar-period-button > .mat-button-wrapper")).Click();
        driver.FindElement(By.CssSelector(".ng-star-inserted:nth-child(1) > .mat-calendar-body-cell:nth-child(2) > .mat-calendar-body-cell-content")).Click();
        driver.FindElement(By.CssSelector(".ng-star-inserted:nth-child(4) > .mat-calendar-body-cell:nth-child(3) > .mat-calendar-body-cell-content")).Click();
        driver.FindElement(By.CssSelector(".ng-star-inserted:nth-child(4) > .mat-calendar-body-cell:nth-child(2) > .mat-calendar-body-cell-content")).Click();
    }
    public IWebElement savePetButton => driver.FindElement(By.CssSelector(".savePet"));
}