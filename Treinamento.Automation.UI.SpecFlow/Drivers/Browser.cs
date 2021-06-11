using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace Treinamento.Automation.UI.SpecFlow.Drivers
{
    public class Browser
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;

        public static IWebDriver getCurrentDriver()
        {
            if (driver == null)
            {
                try
                {
                    ChromeOptions options = new ChromeOptions();
                    driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);
                    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                    driver.Manage().Window.Minimize();
                    driver.Manage().Window.Maximize();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return driver;
        }

        public static void loadPage(String url)
        {
            getCurrentDriver().Url = url;
        }

        public static void closeDriver()
        {
            try
            {
                getCurrentDriver().Close();
                driver = null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
