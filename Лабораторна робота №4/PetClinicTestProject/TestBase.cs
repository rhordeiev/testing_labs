using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

public class TestBase {
  protected IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
    driver.Navigate().GoToUrl("http://20.82.57.125:8080/");
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  public void Wait() {
      Thread.Sleep(5000);
    }
}