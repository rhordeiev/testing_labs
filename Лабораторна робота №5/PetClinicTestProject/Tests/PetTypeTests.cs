using NUnit.Framework;

[TestFixture]
public class PetTypeTests:TestBase {
  [Test]
  public void addPetTypeTestCase() {
    pages.menu.openPetTypePage();
    pages.petType.addPetTypeButton.Click();
    Helpers.ClickAndSendKeys(pages.petType.nameField, petTypes.petTypesList[0].name);
    pages.petType.savePetTypeButton.Click();
  }
  [Test]
  public void editPetTypeTestCase() {
    pages.menu.openPetTypePage();
    Helpers.Wait(3000);
    pages.petType.editPetTypeButton.Click();
    Helpers.ClickAndSendKeys(pages.petType.nameField, petTypes.petTypesList[1].name);
    pages.petType.updatePetTypeButton.Click();
    driver.Close();
  }
  [Test]
  public void deletePetTypeTestCase() {
    pages.menu.openPetTypePage();
    Helpers.Wait(3000);
    Assert.That(pages.petType.getThirdPetTypeElementValue, Is.EqualTo(petTypes.petTypesList[2].name));
    pages.petType.deletePetTypeButton.Click();
  }
  [Test]
  public void homeButtonTestCase() {
    pages.menu.openPetTypePage();
    pages.petType.returnHomeButton.Click();
  }
}
