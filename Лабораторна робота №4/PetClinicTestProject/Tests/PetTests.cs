using OpenQA.Selenium;
using NUnit.Framework;

[TestFixture]
public class PetTests:TestBase {
  [Test]
  public void addPetTestCase() {
    var newPetPage = new NewPetPage(driver);
    var ownersListPage = new OwnersListPage(driver);
    var ownerPage = new OwnerPage(driver);
    driver.FindElement(By.CssSelector(".ownerTab")).Click();
    driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
    Wait();
    ownersListPage.getUser(5).Click();
    Wait();
    int previousPetCount = driver.FindElements(By.CssSelector("app-pet-list")).Count;
    ownerPage.addNewPetButton.Click();
    Wait();
    newPetPage.nameField.Click();
    newPetPage.nameField.SendKeys("Cherry");
    newPetPage.selectDate();
    newPetPage.selectPetType("lizard");
    newPetPage.savePetButton.Click();
    Wait();
    int petCount = driver.FindElements(By.CssSelector("app-pet-list")).Count;
    Assert.That(previousPetCount + 1, Is.EqualTo(petCount));
  }
  [Test]
  public void editPetTestCase() {
    var editPetPage = new EditPetPage(driver);
    var ownersListPage = new OwnersListPage(driver);
    var ownerPage = new OwnerPage(driver);
    driver.FindElement(By.CssSelector(".ownerTab")).Click();
    driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
    Wait();
    ownersListPage.getUser(5).Click();
    Wait();
    int previousPetCount = driver.FindElements(By.XPath("//dd[text() = 'Peaches']")).Count;
    ownerPage.editPetTypeButton(1).Click();
    Wait();
    editPetPage.nameField.Click();
    editPetPage.nameField.Clear();
    editPetPage.nameField.SendKeys("Peaches");
    editPetPage.selectDate();
    editPetPage.selectPetType("snake");
    editPetPage.updatePetButton.Click();
    Wait();
    int petCount = driver.FindElements(By.XPath("//dd[text() = 'Peaches']")).Count;
    Assert.That(previousPetCount + 1, Is.EqualTo(petCount));
  }
  [Test]
  public void deletePetTestCase() {
    var ownersListPage = new OwnersListPage(driver);
    var ownerPage = new OwnerPage(driver);
    driver.FindElement(By.CssSelector(".ownerTab")).Click();
    driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
    Wait();
    ownersListPage.getUser(5).Click();
    Wait();
    int previousPetCount = driver.FindElements(By.CssSelector(".deletePet")).Count;
    ownerPage.deletePetButton(previousPetCount).Click();
    Wait();
    driver.FindElement(By.CssSelector(".ownerTab")).Click();
    driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
    Wait();
    ownersListPage.getUser(5).Click();
    Wait();
    int petCount = driver.FindElements(By.CssSelector(".deletePet")).Count;
    Assert.That(petCount + 1, Is.EqualTo(previousPetCount));
  }
}
