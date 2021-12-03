using OpenQA.Selenium;
using NUnit.Framework;
[TestFixture]
public class PetTypeTests:TestBase {
  [Test]
  public void addPetTypeTestCase() {
    var petTypePage = new PetTypePage(driver);
    driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)")).Click();
    Wait();
    int previousPetTypeCount = driver.FindElements(By.CssSelector(".deletePet")).Count;
    petTypePage.addPetTypeButton.Click();
    petTypePage.nameField.Click();
    petTypePage.nameField.Clear();
    petTypePage.nameField.SendKeys("racoon");
    petTypePage.savePetTypeButton.Click();
    Wait();
    int petTypeCount = driver.FindElements(By.CssSelector(".deletePet")).Count;
    Assert.That(previousPetTypeCount + 1, Is.EqualTo(petTypeCount));
  }
  [Test]
  public void editPetTypeTestCase() {
    var petTypePage = new PetTypePage(driver);
    driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)")).Click();
    Wait();
    petTypePage.editPetTypeButton.Click();
    Wait();
    petTypePage.nameField.Click();
    petTypePage.nameField.Clear();
    petTypePage.nameField.SendKeys("mouse");
    petTypePage.updatePetTypeButton.Click();
    Wait();
    int petTypeCount = driver.FindElements(By.XPath("//input[@id=3][@ng-reflect-model='mouse']")).Count;
    Assert.That(petTypeCount, Is.EqualTo(1));
  }
  [Test]
  public void deletePetTypeTestCase() {
    var petTypePage = new PetTypePage(driver);
    driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)")).Click();
    Wait();
    int previousPetTypeCount = driver.FindElements(By.CssSelector(".deletePet")).Count;
    petTypePage.deletePetTypeButton.Click();
    Wait();
    int petTypeCount = driver.FindElements(By.CssSelector(".deletePet")).Count;
    Assert.That(previousPetTypeCount - 1, Is.EqualTo(petTypeCount));
  }
  [Test]
  public void homeButtonTestCase() {
    var petTypePage = new PetTypePage(driver);
    driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)")).Click();
    petTypePage.returnHomeButton.Click();
    Wait();
    int headerExists = driver.FindElements(By.CssSelector("app-welcome")).Count;
    Assert.That(headerExists, Is.GreaterThanOrEqualTo(1));
  }
}
