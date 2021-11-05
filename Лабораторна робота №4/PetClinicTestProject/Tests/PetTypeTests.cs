using OpenQA.Selenium;
using NUnit.Framework;
[TestFixture]
public class PetTypeTests:TestBase {
  [Test]
  public void addPetTypeTestCase() {
    var petTypePage = new PetTypePage(driver);
    driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)")).Click();
    petTypePage.addPetTypeButton.Click();
    petTypePage.nameField.Click();
    petTypePage.nameField.Clear();
    petTypePage.nameField.SendKeys("racoon");
    petTypePage.savePetTypeButton.Click();
  }
  [Test]
  public void editPetTypeTestCase() {
    var petTypePage = new PetTypePage(driver);
    driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)")).Click();
    Wait();
    petTypePage.editPetTypeButton.Click();
    petTypePage.nameField.Click();
    petTypePage.nameField.Clear();
    petTypePage.nameField.SendKeys("mouse");
    petTypePage.updatePetTypeButton.Click();
    driver.Close();
  }
  [Test]
  public void deletePetTypeTestCase() {
    var petTypePage = new PetTypePage(driver);
    driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)")).Click();
    Wait();
    Assert.That(petTypePage.getThirdPetTypeElementValue, Is.EqualTo("lizard"));
    petTypePage.deletePetTypeButton.Click();
  }
  [Test]
  public void homeButtonTestCase() {
    var petTypePage = new PetTypePage(driver);
    driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)")).Click();
    petTypePage.returnHomeButton.Click();
  }
}
