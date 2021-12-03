using NUnit.Framework;
using OpenQA.Selenium;
using NUnit.Allure.Attributes;

[TestFixture]
public class VeterinarianTests:TestBase {
  [AllureSuite("Veterinarian")]
  [Test, Description("Checks that veterinarian adds successfully")]
  public void addVeterinarianTestCase() {
    pages.menu.openVeterinariansListPage();
    Helpers.Wait(3000);
    int previousVeterinarianCount = Helpers.FindElementCount(driver, By.Id("vet"));
    pages.menu.openNewVeterinarianPage();
    Helpers.Wait(3000);
    Helpers.ClickAndSendKeys(pages.newVeterinarian.firstNameField, veterinarian.veterinarian.firstName);
    Helpers.ClickAndSendKeys(pages.newVeterinarian.lastNameField, veterinarian.veterinarian.lastName);
    pages.newVeterinarian.selectSpecialty(veterinarian.veterinarian.specialty);
    pages.newVeterinarian.addVeterinarianButton.Click();
    Helpers.Wait(3000);
    pages.menu.openVeterinariansListPage();
    Helpers.Wait(3000);
    int veterinarianCount = Helpers.FindElementCount(driver, By.Id("vet"));
    Assert.That(previousVeterinarianCount + 1, Is.EqualTo(veterinarianCount));
  }
}
