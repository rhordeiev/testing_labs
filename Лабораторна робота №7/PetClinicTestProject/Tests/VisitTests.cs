using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Allure.Attributes;

[TestFixture]
[Parallelizable]
public class VisitTests:TestBrowser {
  static object[] testDataVisit = { "First Visit", "Second Visit", "Third Visit" };

  public VisitTests():base(Browser.Chrome){}

  [AllureSuite("Veterinarian")]
  [Test, Description("Checks that visit adds successfully")]
  [TestCaseSource(nameof(testDataVisit))]
  public void addVisitTestCase(string description) {
    pages.menu.openOwnersListPage();
    Helpers.Wait(3000);
    pages.ownersList.getUser(5).Click();
    Helpers.Wait(3000);
    int previousVisitCount = Helpers.FindElementCount(driver, By.CssSelector(".deleteVisit"));
    pages.owner.addNewVisitButton.Click();
    Helpers.Wait(3000);
    pages.newVisit.selectDate();
    Helpers.ClickAndSendKeys(pages.newVisit.descriptionField, description);
    pages.newVisit.addVisitButton.Click();
    Helpers.Wait(3000);
    int visitCount = Helpers.FindElementCount(driver, By.CssSelector(".deleteVisit"));
    Assert.That(previousVisitCount + 1, Is.EqualTo(visitCount));
  }
}
