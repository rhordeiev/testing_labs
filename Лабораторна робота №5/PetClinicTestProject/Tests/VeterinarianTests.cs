using NUnit.Framework;

[TestFixture]
public class VeterinarianTests:TestBase {
  [Test]
  public void addVeterinarianTestCase() {
    pages.menu.openNewVeterinarianPage();
    Helpers.Wait(3000);
    Helpers.ClickAndSendKeys(pages.newVeterinarian.firstNameField, veterinarian.veterinarian.firstName);
    Helpers.ClickAndSendKeys(pages.newVeterinarian.lastNameField, veterinarian.veterinarian.lastName);
    pages.newVeterinarian.selectSpecialty(veterinarian.veterinarian.specialty);
    pages.newVeterinarian.addVeterinarianButton.Click();
  }
}
