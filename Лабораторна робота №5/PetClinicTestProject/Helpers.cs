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
}