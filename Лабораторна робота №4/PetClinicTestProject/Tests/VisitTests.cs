using OpenQA.Selenium;
using NUnit.Framework;

[TestFixture]
public class VisitTests:TestBase {
  [Test]
  public void addVisitTestCase() {
    var newVisitPage = new NewVisitPage(driver);
    var ownersListPage = new OwnersListPage(driver);
    var ownerPage = new OwnerPage(driver);
    driver.FindElement(By.CssSelector(".ownerTab")).Click();
    driver.FindElement(By.CssSelector(".open li:nth-child(1) span:nth-child(2)")).Click();
    Wait();
    ownersListPage.getUser(5).Click();
    Wait();
    int previousVisitCount = driver.FindElements(By.CssSelector(".deleteVisit")).Count;
    ownerPage.addNewVisitButton.Click();
    Wait();
    newVisitPage.selectDate();
    newVisitPage.descriptionField.Click();
    newVisitPage.descriptionField.SendKeys("New visit");
    newVisitPage.addVisitButton.Click();
    Wait();
    int visitCount = driver.FindElements(By.CssSelector(".deleteVisit")).Count;
    Assert.That(previousVisitCount + 1, Is.EqualTo(visitCount));
  }
}
