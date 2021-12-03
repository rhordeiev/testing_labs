using NUnit.Framework;
using OpenQA.Selenium;
using NUnit.Allure.Attributes;

[TestFixture]
[Parallelizable]
public class VeterinarianTests:TestBrowser {
  public VeterinarianTests():base(Browser.Firefox){}
  static object[] testDataVeterinarian = { "Tom", "Nick", "Phill" };

  [AllureSuite("Veterinarian")]
  [Test, Description("Checks that veterinarian adds successfully")]
  [TestCaseSource(nameof(testDataVeterinarian))]
  public void addVeterinarianTestCase(string firstName) {
    pages.menu.openVeterinariansListPage();
    Helpers.Wait(3000);
    int previousVeterinarianCount = Helpers.FindElementCount(driver, By.Id("vet"));
    pages.menu.openNewVeterinarianPage();
    Helpers.Wait(3000);
    Helpers.ClickAndSendKeys(pages.newVeterinarian.firstNameField, firstName);
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
