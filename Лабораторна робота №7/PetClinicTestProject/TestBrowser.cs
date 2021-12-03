using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using System.Collections.Generic;

public enum Browser {
    Chrome,
    Firefox,
    Opera
}

[TestFixture]
public class TestBrowser:TestBase {
    private Browser browserType;
    public TestBrowser(Browser browser) {
        browserType = browser;
    }
    [SetUp]
    public void initializeBrowser() {
      chooseBrowser(browserType);
      driver.Navigate().GoToUrl("http://20.50.171.10:8080/");
      pages = new Pages(driver);
    }
    private void chooseBrowser(Browser browserType) {
      Dictionary<string, object> additionalSelenoidCapabilities = new Dictionary<string, object>();
      additionalSelenoidCapabilities["name"] = "Pet Clinic";
      additionalSelenoidCapabilities["enableVNC"] = true;  
      additionalSelenoidCapabilities["enableVideo"] = true;
      switch(browserType) {
          case Browser.Chrome:
            var chrome_options = new ChromeOptions();                    
            chrome_options.AddAdditionalOption("selenoid:options", additionalSelenoidCapabilities);
            chrome_options.AddArgument("no-sandbox");
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), chrome_options.ToCapabilities(), TimeSpan.FromMinutes(8));
            break;
          case Browser.Firefox:
            var firefox_options = new FirefoxOptions();                    
            firefox_options.AddAdditionalOption("selenoid:options", additionalSelenoidCapabilities);
            firefox_options.AddArgument("no-sandbox");
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), firefox_options.ToCapabilities(), TimeSpan.FromMinutes(8));
            break;
          case Browser.Opera:
            var opera_options = new OperaOptions();                    
            opera_options.AddAdditionalOption("selenoid:options", additionalSelenoidCapabilities);
            opera_options.AddArgument("no-sandbox");
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), opera_options.ToCapabilities(), TimeSpan.FromMinutes(8));
            break;
          default:
            driver = new ChromeDriver();
            break;
        }
    }
}