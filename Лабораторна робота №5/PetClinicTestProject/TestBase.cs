using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Reflection;

public class TestBase {
  protected IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  public Pages pages { get; set; }
  public OwnerSection owner { get; set; }
  public VeterinarianSection veterinarian { get; set; }
  public PetTypeSection petTypes { get; set; }
  private IConfigurationRoot configuration { get; set; }

    [SetUp]
    public void SetUp() {
      driver = new ChromeDriver();
      js = (IJavaScriptExecutor)driver;
      vars = new Dictionary<string, object>();
      driver.Navigate().GoToUrl("http://20.82.57.125:8080/");
      pages = new Pages(driver);
      getTestData();
   }
  [TearDown]
  protected void TearDown() {
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
    veterinarian = new VeterinarianSection(configuration);
    configuration.GetSection("veterinarian").Bind(veterinarian);
    petTypes = new PetTypeSection(configuration);
    configuration.GetSection("petTypes").Bind(petTypes);
  }
}