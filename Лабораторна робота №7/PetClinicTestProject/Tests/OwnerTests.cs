using NUnit.Framework;
using OpenQA.Selenium;
using NUnit.Allure.Attributes;

[TestFixture]
[Parallelizable]
public class OwnerTests:TestBrowser {
  public OwnerTests():base(Browser.Firefox){}
  static object[] testDataOwner = { "Max", "Sam", "Jack" };

  [AllureSuite("Owner")]
  [Test, Description("Checks that owner adds successfully")]
  [TestCaseSource(nameof(testDataOwner))]
  public void addOwnerTestCase(string firstName) {
    pages.menu.openOwnersListPage();
    Helpers.Wait(3000);
    int previousOwnerCount = Helpers.FindElementCount(driver, By.CssSelector(".petOwner"));
    pages.menu.openNewOwnerPage();
    Helpers.ClickAndSendKeys(pages.newOwner.firstNameField, firstName);
    Helpers.ClickAndSendKeys(pages.newOwner.lastNameField, owner.owner.lastName);
    Helpers.ClickAndSendKeys(pages.newOwner.addressField, owner.owner.address);
    Helpers.ClickAndSendKeys(pages.newOwner.cityField, owner.owner.city);
    Helpers.ClickAndSendKeys(pages.newOwner.telephoneField, owner.owner.telephone);
    pages.newOwner.addOwnerButton.Click();
    pages.menu.openOwnersListPage();
    Helpers.Wait(3000);
    int ownerCount = Helpers.FindElementCount(driver, By.CssSelector(".petOwner"));
    Assert.That(previousOwnerCount + 1, Is.EqualTo(ownerCount));
    // pages.menu.openNewOwnerPage();
    // Helpers.ClickAndSendKeys(pages.newOwner.firstNameField, firstName);
    // Helpers.ClickAndSendKeys(pages.newOwner.lastNameField, owner.owner.lastName);
    // Helpers.ClickAndSendKeys(pages.newOwner.addressField, owner.owner.address);
    // Helpers.ClickAndSendKeys(pages.newOwner.cityField, owner.owner.city);
    // Helpers.ClickAndSendKeys(pages.newOwner.telephoneField, owner.owner.telephone);
    // pages.newOwner.addOwnerButton.Click();
  }
}
