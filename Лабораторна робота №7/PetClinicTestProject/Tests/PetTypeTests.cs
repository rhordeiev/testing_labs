using NUnit.Framework;
using OpenQA.Selenium;
using NUnit.Allure.Attributes;

[TestFixture]
[Parallelizable]
public class PetTypeTests:TestBrowser {
  public PetTypeTests():base(Browser.Chrome){}
  static object[] testDataPetType = { "lizard", "rabbit", "hamster" };
  [AllureSuite("PetType")]
  [Test, Description("Checks that pet type adds successfully")]
  [TestCaseSource(nameof(testDataPetType))]
  public void addPetTypeTestCase(string petType) {
    pages.menu.openPetTypePage();
    Helpers.Wait(3000);
    int previousPetTypeCount = Helpers.FindElementCount(driver, By.CssSelector(".deletePet"));
    pages.petType.addPetTypeButton.Click();
    Helpers.ClickAndSendKeys(pages.petType.nameField, petType);
    pages.petType.savePetTypeButton.Click();
    Helpers.Wait(3000);
    int petTypeCount = Helpers.FindElementCount(driver, By.CssSelector(".deletePet"));
    Assert.That(previousPetTypeCount + 1, Is.EqualTo(petTypeCount));
  }
  [AllureSuite("PetType")]
  [Test, Description("Checks that pet type updates successfully")]
  [TestCaseSource(nameof(testDataPetType))]
  public void editPetTypeTestCase(string petType) {
    pages.menu.openPetTypePage();
    Helpers.Wait(3000);
    pages.petType.editPetTypeButton.Click();
    Helpers.Wait(3000);
    Helpers.ClickAndSendKeys(pages.petType.nameField, petType);
    pages.petType.updatePetTypeButton.Click();
    Helpers.Wait(3000);
    int petTypeCount = Helpers.FindElementCount(driver, By.XPath("//input[@id=3][@ng-reflect-model='" + petType + "']"));
    Assert.That(petTypeCount, Is.EqualTo(1));
  }
  [AllureSuite("PetType")]
  [Test, Description("Checks that pet type deletes successfully")]
  [TestCaseSource(nameof(testDataPetType))]
  public void deletePetTypeTestCase(string petType) {
    pages.menu.openPetTypePage();
    Helpers.Wait(3000);
    int previousPetTypeCount = Helpers.FindElementCount(driver, By.CssSelector(".deletePet"));
    pages.petType.deletePetTypeButton.Click();
    Helpers.Wait(3000);
    int petTypeCount = Helpers.FindElementCount(driver, By.CssSelector(".deletePet"));
    Assert.That(previousPetTypeCount - 1, Is.EqualTo(petTypeCount));
  }
  [AllureSuite("PetType")]
  [Test, Description("Checks that return to home page button works successfully")]
  public void homeButtonTestCase() {
    pages.menu.openPetTypePage();
    pages.petType.returnHomeButton.Click();
    Helpers.Wait(3000);
    int headerExists = Helpers.FindElementCount(driver, By.CssSelector("app-welcome"));
    Assert.That(headerExists, Is.GreaterThanOrEqualTo(1));
  }
}
