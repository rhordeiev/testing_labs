using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Allure.Attributes;

[TestFixture]
public class VisitTests:TestBase {
  [AllureSuite("Veterinarian")]
  [Test, Description("Checks that visit adds successfully")]
  public void addVisitTestCase() {
    pages.menu.openOwnersListPage();
    Helpers.Wait(3000);
    pages.ownersList.getUser(5).Click();
    Helpers.Wait(3000);
    int previousVisitCount = Helpers.FindElementCount(driver, By.CssSelector(".deleteVisit"));
    pages.owner.addNewVisitButton.Click();
    Helpers.Wait(3000);
    pages.newVisit.selectDate();
    Helpers.ClickAndSendKeys(pages.newVisit.descriptionField, visit.visit.description);
    pages.newVisit.addVisitButton.Click();
    Helpers.Wait(3000);
    int visitCount = Helpers.FindElementCount(driver, By.CssSelector(".deleteVisit"));
    Assert.That(previousVisitCount + 1, Is.EqualTo(visitCount));
  }
}
