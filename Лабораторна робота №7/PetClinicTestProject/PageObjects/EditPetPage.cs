using OpenQA.Selenium;
using NUnit.Allure.Steps;

public class EditPetPage : PetPage {
    public EditPetPage(IWebDriver driver):base(driver){}
    [AllureStep("Select pet's date")]
    public void selectDate() {
        driver.FindElement(By.CssSelector("path")).Click();
        driver.FindElement(By.CssSelector(".mat-calendar-period-button > .mat-button-wrapper")).Click();
        driver.FindElement(By.CssSelector(".ng-star-inserted:nth-child(1) > .mat-calendar-body-cell:nth-child(3) > .mat-calendar-body-cell-content")).Click();
        driver.FindElement(By.CssSelector(".ng-star-inserted:nth-child(2) > .mat-calendar-body-cell:nth-child(4) > .mat-calendar-body-cell-content")).Click();
        driver.FindElement(By.CssSelector(".ng-star-inserted:nth-child(3) > .mat-calendar-body-cell:nth-child(4) > .mat-calendar-body-cell-content")).Click();
    }
    public IWebElement updatePetButton => driver.FindElement(By.CssSelector(".updatePet"));
}