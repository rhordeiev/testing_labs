using System.Collections.Generic;
using OpenQA.Selenium;
using NUnit.Framework;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Reflection;
using NUnit.Allure.Core;
using System;
using Allure.Commons;
using NUnit.Framework.Interfaces;

[AllureNUnit]
public class TestBase {
  protected IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  // private IJavaScriptExecutor js;
  public Pages pages { get; set; }
  public OwnerSection owner { get; set; }
  public PetSection pets { get; set; }
  public VeterinarianSection veterinarian { get; set; }
  public PetTypeSection petTypes { get; set; }
  public VisitSection visit { get; set; }
  private IConfigurationRoot configuration { get; set; }

    [OneTimeSetUp]
    public void SetUp() {
      getTestData();
   }
  [TearDown]
  protected void TearDown() {
    if(TestContext.CurrentContext.Result.Outcome != ResultState.Success) {
      var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
      var filename = TestContext.CurrentContext.Test.MethodName + "_screenshot_" + DateTime.Now.Ticks + ".png";
      var path = $"C:\\Users\\win34\\Desktop\\Якість програмного забезпечення та тестування\\Лабораторна робота №6\\PetClinicTestProject\\TestResults\\{filename}";
      screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
      AllureLifecycle.Instance.AddAttachment(filename, "image/png", path);
    }
    driver.Quit();
  }
  private void getTestData() {
    var outputDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    var testDataPath = Path.Combine(outputDirectory, @"..\..\..\TestData");
    configuration = new ConfigurationBuilder()
        .SetBasePath(testDataPath)
        .AddJsonFile("TestDataStorage.json", optional: false, reloadOnChange: true)
        .Build();
    owner = new OwnerSection(configuration);
    configuration.GetSection("owner").Bind(owner);
    pets = new PetSection(configuration);
    configuration.GetSection("pets").Bind(pets);
    veterinarian = new VeterinarianSection(configuration);
    configuration.GetSection("veterinarian").Bind(veterinarian);
    petTypes = new PetTypeSection(configuration);
    configuration.GetSection("petTypes").Bind(petTypes);
    visit = new VisitSection(configuration);
    configuration.GetSection("visit").Bind(visit);
  }
}