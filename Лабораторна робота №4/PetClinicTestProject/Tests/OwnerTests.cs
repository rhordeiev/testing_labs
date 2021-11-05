using OpenQA.Selenium;
using NUnit.Framework;

[TestFixture]
public class OwnerTests:TestBase {
  [Test]
  public void addOwnerTestCase() {
    var newOwnerPage = new NewOwnerPage(driver);
    driver.FindElement(By.CssSelector(".ownerTab")).Click();
    driver.FindElement(By.CssSelector(".open li:nth-child(2) span:nth-child(2)")).Click();
    newOwnerPage.firstNameField.Click();
    newOwnerPage.firstNameField.SendKeys("Max");
    newOwnerPage.lastNameField.Click();
    newOwnerPage.lastNameField.SendKeys("Willing");
    newOwnerPage.addressField.Click();
    newOwnerPage.addressField.SendKeys("6812 20th Ave, Brooklyn, NY 11204");
    newOwnerPage.cityField.Click();
    newOwnerPage.cityField.SendKeys("New York");
    newOwnerPage.telephoneField.Click();
    newOwnerPage.telephoneField.SendKeys("1718232111");
    newOwnerPage.addOwnerButton.Click();
  }
}
