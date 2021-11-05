using OpenQA.Selenium;

public class Pages {
    protected IWebDriver driver;

    public Pages(IWebDriver driver) {
        this.driver = driver;
    }

    public NewOwnerPage newOwner => new NewOwnerPage(driver);
    public NewVeterinarianPage newVeterinarian => new NewVeterinarianPage(driver);
    public PetTypePage petType => new PetTypePage(driver);
    public NavigationComponent menu => new NavigationComponent(driver);
}