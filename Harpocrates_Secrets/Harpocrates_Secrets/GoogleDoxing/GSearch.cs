using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Harpocrates_Secrets.APIKeys;

namespace Harpocrates_Secrets.GoogleDoxing
{
    public class GSearch
    {
       public static void OpenWebBrowser()
        {
            IWebDriver driver = new ChromeDriver(APIKeys.Keys.api["ChromeDriverFolder"]);
            //Navigate to Google
            driver.Navigate().GoToUrl("https://www.google.com");

            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("xecuteautomation");
        }
    }

    public class GoogleDoxingQueries
    {
        static string doxSearch1 = "";
        static string doxSearch2 = "";
        static string doxSearch3 = "";
    }
}
