using OpenQA.Selenium;
using NUnit.Allure.Steps;

public class NavigationComponent {
    private IWebDriver driver;

    public NavigationComponent(IWebDriver driver) {
        this.driver = driver;
    }

    public IWebElement ownerTab => driver.FindElement(By.CssSelector(".ownerTab"));
    public IWebElement ownerTabNewOwnerItem => driver.FindElement(By.CssSelector(".open li:nth-child(2) span:nth-child(2)"));
    public IWebElement veterinarianTab => driver.FindElement(By.CssSelector(".vetsTab"));
    public IWebElement veterinarianTabNewOwnerItem => driver.FindElement(By.CssSelector(".open li:nth-child(2) > a"));
    public IWebElement listItem => driver.FindElement(By.CssSelector(".open li:nth-child(1) > a"));
    public IWebElement petTypeTab => driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)"));

    [AllureStep("Open owners list page")]
    public void openOwnersListPage() {
        ownerTab.Click();
        listItem.Click();
    }
    [AllureStep("Open veterinarians list page")]
    public void openVeterinariansListPage() {
        veterinarianTab.Click();
        listItem.Click();
    }
    [AllureStep("Open new owner page")]
    public void openNewOwnerPage() {
        ownerTab.Click();
        ownerTabNewOwnerItem.Click();
    }
    [AllureStep("Open new veterinarian page")]
    public void openNewVeterinarianPage() {
        veterinarianTab.Click();
        veterinarianTabNewOwnerItem.Click();
    }
    [AllureStep("Open pet type page")]
    public void openPetTypePage() {
        petTypeTab.Click();
    }
}