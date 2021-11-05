using OpenQA.Selenium;
using NUnit.Framework;

[TestFixture]
public class NavigationTests:TestBase {
  [Test]
  public void ownerTabTestCase() {
    driver.FindElement(By.CssSelector(".ownerTab")).Click();
    driver.FindElement(By.CssSelector(".open li:nth-child(2) span:nth-child(2)")).Click();
  }
  [Test]
  public void veterinarianTabTestCase() {
    driver.FindElement(By.CssSelector(".vetsTab")).Click();
    driver.FindElement(By.CssSelector(".open li:nth-child(2) > a")).Click();
  }
  [Test]
  public void petTypeTabTestCase() {
    driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)")).Click();
  }
  [Test]
  public void specialtiesTabTestCase() {
    driver.FindElement(By.CssSelector("li:nth-child(5) > a")).Click();
  }
}
