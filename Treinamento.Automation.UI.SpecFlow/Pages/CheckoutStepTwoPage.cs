using OpenQA.Selenium;
using Treinamento.Automation.UI.SpecFlow.Drivers;

namespace Treinamento.Automation.UI.SpecFlow.Pages
{
    public class CheckoutStepTwoPage : Browser
    {
        private IWebElement checkoutOverviewBtn => driver.FindElement(By.XPath("//*[@id=\"finish\"]"));

        public void checkoutOverviewClick() => checkoutOverviewBtn.Click();
    }
}