using OpenQA.Selenium;

public class Pages {
    protected IWebDriver driver;

    public Pages(IWebDriver driver) {
        this.driver = driver;
    }

    public NewOwnerPage newOwner => new NewOwnerPage(driver);
    public OwnerPage owner => new OwnerPage(driver);
    public OwnersListPage ownersList => new OwnersListPage(driver);
    public NewVeterinarianPage newVeterinarian => new NewVeterinarianPage(driver);
    public PetTypePage petType => new PetTypePage(driver);
    public NewPetPage newPet => new NewPetPage(driver);
    public EditPetPage editPet => new EditPetPage(driver);
    public NewVisitPage newVisit => new NewVisitPage(driver);
    public NavigationComponent menu => new NavigationComponent(driver);
}