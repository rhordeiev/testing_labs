using System.Threading;
using OpenQA.Selenium;
public static class Helpers
{
    public static void Wait(int milliseconds) {
        Thread.Sleep(milliseconds);
    }
    public static void ClickAndSendKeys(IWebElement element, string keys) {
        element.Click();
        element.Clear();
        element.SendKeys(keys);
    }
    public static int FindElementCount(IWebDriver driver, By selector) {
        return driver.FindElements(selector).Count;
    }
}