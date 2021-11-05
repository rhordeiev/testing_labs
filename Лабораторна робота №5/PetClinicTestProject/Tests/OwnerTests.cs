using NUnit.Framework;
using System;

[TestFixture]
public class OwnerTests:TestBase {
  [Test]
  public void addOwnerTestCase() {
    pages.menu.openNewOwnerPage();
    Console.WriteLine(owner.owner.firstName);
    Helpers.ClickAndSendKeys(pages.newOwner.firstNameField, owner.owner.firstName);
    Helpers.ClickAndSendKeys(pages.newOwner.lastNameField, owner.owner.lastName);
    Helpers.ClickAndSendKeys(pages.newOwner.addressField, owner.owner.address);
    Helpers.ClickAndSendKeys(pages.newOwner.cityField, owner.owner.city);
    Helpers.ClickAndSendKeys(pages.newOwner.telephoneField, owner.owner.telephone);
    pages.newOwner.addOwnerButton.Click();
  }
}
