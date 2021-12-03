using NUnit.Framework;
using OpenQA.Selenium;
using NUnit.Allure.Attributes;

[TestFixture]
public class PetTypeTests:TestBase {
  [AllureSuite("PetType")]
  [Test, Description("Checks that pet type adds successfully")]
  public void addPetTypeTestCase() {
    pages.menu.openPetTypePage();
    Helpers.Wait(3000);
    int previousPetTypeCount = Helpers.FindElementCount(driver, By.CssSelector(".deletePet"));
    pages.petType.addPetTypeButton.Click();
    Helpers.ClickAndSendKeys(pages.petType.nameField, petTypes.petTypesList[0].name);
    pages.petType.savePetTypeButton.Click();
    Helpers.Wait(3000);
    int petTypeCount = Helpers.FindElementCount(driver, By.CssSelector(".deletePet"));
    Assert.That(previousPetTypeCount + 1, Is.EqualTo(petTypeCount));
  }
  [AllureSuite("PetType")]
  [Test, Description("Checks that pet type updates successfully")]
  public void editPetTypeTestCase() {
    pages.menu.openPetTypePage();
    Helpers.Wait(3000);
    pages.petType.editPetTypeButton.Click();
    Helpers.Wait(3000);
    Helpers.ClickAndSendKeys(pages.petType.nameField, petTypes.petTypesList[1].name);
    pages.petType.updatePetTypeButton.Click();
    Helpers.Wait(3000);
    int petTypeCount = Helpers.FindElementCount(driver, By.XPath("//input[@id=3][@ng-reflect-model='mouse']"));
    Assert.That(petTypeCount, Is.EqualTo(1));
  }
  [AllureSuite("PetType")]
  [Test, Description("Checks that pet type deletes successfully")]
  public void deletePetTypeTestCase() {
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
