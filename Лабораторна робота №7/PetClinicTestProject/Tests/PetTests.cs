using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Allure.Attributes;

[TestFixture]
[Parallelizable]
public class PetTests:TestBrowser {
  public PetTests():base(Browser.Chrome){}
  static object[] testDataPet = { "Cherry", "Peaches", "Apricot" };

  [AllureSuite("Pet")]
  [Test, Description("Checks that pet adds successfully")]
  [TestCaseSource(nameof(testDataPet))]
  public void addPetTestCase(string name) {
    pages.menu.openOwnersListPage();
    Helpers.Wait(3000);
    pages.ownersList.getUser(5).Click();
    Helpers.Wait(3000);
    int previousPetCount = Helpers.FindElementCount(driver, By.CssSelector("app-pet-list"));
    pages.owner.addNewPetButton.Click();
    Helpers.Wait(3000);
    Helpers.ClickAndSendKeys(pages.newPet.nameField, name);
    pages.newPet.selectDate();
    pages.newPet.selectPetType(petTypes.petTypesList[2].name);
    pages.newPet.savePetButton.Click();
    Helpers.Wait(3000);
    int petCount = Helpers.FindElementCount(driver, By.CssSelector("app-pet-list"));
    Assert.That(previousPetCount + 1, Is.EqualTo(petCount));
  }
  [AllureSuite("Pet")]
  [Test, Description("Checks that pet updates successfully")]
  [TestCaseSource(nameof(testDataPet))]
  public void editPetTestCase(string name) {
    pages.menu.openOwnersListPage();
    Helpers.Wait(3000);
    pages.ownersList.getUser(5).Click();
    Helpers.Wait(3000);
    int previousPetCount = Helpers.FindElementCount(driver, By.XPath("//dd[text() = '" + name + "']"));
    pages.owner.editPetTypeButton(1).Click();
    Helpers.Wait(3000);
    Helpers.ClickAndSendKeys(pages.editPet.nameField, name);
    pages.editPet.selectDate();
    pages.editPet.selectPetType(petTypes.petTypesList[3].name);
    pages.editPet.updatePetButton.Click();
    Helpers.Wait(3000);
    int petCount = Helpers.FindElementCount(driver, By.XPath("//dd[text() = '" + name + "']"));
    Assert.That(previousPetCount + 1, Is.EqualTo(petCount));
  }
  [AllureSuite("Pet")]
  [Test, Description("Checks that pet deletes successfully")]
  public void deletePetTestCase() {
    pages.menu.openOwnersListPage();
    Helpers.Wait(3000);
    pages.ownersList.getUser(5).Click();
    Helpers.Wait(3000);
    int previousPetCount = Helpers.FindElementCount(driver, By.CssSelector(".deletePet"));
    pages.owner.deletePetButton(previousPetCount).Click();
    Helpers.Wait(3000);
    pages.menu.openOwnersListPage();
    Helpers.Wait(3000);
    pages.ownersList.getUser(5).Click();
    Helpers.Wait(3000);
    int petCount = Helpers.FindElementCount(driver, By.CssSelector(".deletePet"));
    Assert.That(petCount + 1, Is.EqualTo(previousPetCount));
  }
}
