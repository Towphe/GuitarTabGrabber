using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GuitarTabGrabber
{
    static class PageGrabber
    {
        public static IWebDriver InitiateConnectionChrome()
        {
            IWebDriver driver = new ChromeDriver("C://WebDriver/bin");
            return driver;
        }
        public static void ConnectUrl(IWebDriver driver, string url)
        {
            try
            {
                driver.Navigate().GoToUrl(@url);
                Console.WriteLine("Connected to URL");
            }
            catch
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
