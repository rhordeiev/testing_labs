using OpenQA.Selenium;
using NUnit.Framework;
[TestFixture]
public class VeterinarianTests:TestBase {
  [Test]
  public void addVeterinarianTestCase() {
    var newVeterinarianPage = new NewVeterinarianPage(driver);
    driver.FindElement(By.CssSelector(".vetsTab")).Click();
    driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
    Wait();
    int previousVeterinarianCount = driver.FindElements(By.Id("vet")).Count;
    driver.FindElement(By.CssSelector(".vetsTab")).Click();
    driver.FindElement(By.CssSelector(".open li:nth-child(2) > a")).Click();
    Wait();
    newVeterinarianPage.firstNameField.Click();
    newVeterinarianPage.firstNameField.SendKeys("Karen");
    newVeterinarianPage.lastNameField.Click();
    newVeterinarianPage.lastNameField.SendKeys("Berkly");
    newVeterinarianPage.selectSpecialty("dentistry");
    newVeterinarianPage.addVeterinarianButton.Click();
    Wait();
    driver.FindElement(By.CssSelector(".vetsTab")).Click();
    driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
    Wait();
    int veterinarianCount = driver.FindElements(By.Id("vet")).Count;
    Assert.That(previousVeterinarianCount + 1, Is.EqualTo(veterinarianCount));
  }
}
