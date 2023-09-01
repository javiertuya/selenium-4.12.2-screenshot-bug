using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Giis.Samples.Selema.Mstest2
{
    [TestClass]
    public class TestScreenshotBug
    {

        [TestMethod]
        public void TestScreenshot()
        {
            ChromeOptions opt = new ChromeOptions();
            opt.AddArgument("--headless");
            IWebDriver driver = new ChromeDriver(opt);
            driver.Navigate().GoToUrl("https://www.selenium.dev/");
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("../../../../screenshot.png", ScreenshotImageFormat.Png);
            driver.Close();
        }
    }
}
