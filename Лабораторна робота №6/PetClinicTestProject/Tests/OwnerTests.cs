using NUnit.Framework;
using OpenQA.Selenium;
using NUnit.Allure.Attributes;

[TestFixture]
public class OwnerTests:TestBase {
  [AllureSuite("Owner")]
  [Test, Description("Checks that owner adds successfully")]
  public void addOwnerTestCase() {
    pages.menu.openOwnersListPage();
    Helpers.Wait(3000);
    int previousOwnerCount = Helpers.FindElementCount(driver, By.CssSelector(".petOwner"));
    pages.menu.openNewOwnerPage();
    Helpers.ClickAndSendKeys(pages.newOwner.firstNameField, owner.owner.firstName);
    Helpers.ClickAndSendKeys(pages.newOwner.lastNameField, owner.owner.lastName);
    Helpers.ClickAndSendKeys(pages.newOwner.addressField, owner.owner.address);
    Helpers.ClickAndSendKeys(pages.newOwner.cityField, owner.owner.city);
    Helpers.ClickAndSendKeys(pages.newOwner.telephoneField, owner.owner.telephone);
    pages.newOwner.addOwnerButton.Click();
    pages.menu.openOwnersListPage();
    Helpers.Wait(3000);
    int ownerCount = Helpers.FindElementCount(driver, By.CssSelector(".petOwner"));
    Assert.That(previousOwnerCount + 1, Is.EqualTo(ownerCount));
  }
}
