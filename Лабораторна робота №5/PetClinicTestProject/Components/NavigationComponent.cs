using OpenQA.Selenium;

public class NavigationComponent {
    private IWebDriver driver;

    public NavigationComponent(IWebDriver driver) {
        this.driver = driver;
    }

    public IWebElement ownerTab => driver.FindElement(By.CssSelector(".ownerTab"));
    public IWebElement ownerTabNewOwnerItem => driver.FindElement(By.CssSelector(".open li:nth-child(2) span:nth-child(2)"));
    public IWebElement veterinarianTab => driver.FindElement(By.CssSelector(".vetsTab"));
    public IWebElement veterinarianTabNewOwnerItem => driver.FindElement(By.CssSelector(".open li:nth-child(2) > a"));
    public IWebElement petTypeTab => driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)"));
    public IWebElement specialtyTab => driver.FindElement(By.CssSelector("li:nth-child(5) > a"));

    public void openNewOwnerPage() {
        ownerTab.Click();
        ownerTabNewOwnerItem.Click();
    }
    public void openNewVeterinarianPage() {
        veterinarianTab.Click();
        veterinarianTabNewOwnerItem.Click();
    }
    public void openPetTypePage() {
        petTypeTab.Click();
    }
    public void openSpecialtyPage() {
        specialtyTab.Click();
    }
}