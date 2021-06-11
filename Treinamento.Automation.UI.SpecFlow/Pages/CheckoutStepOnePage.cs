using OpenQA.Selenium;
using Treinamento.Automation.UI.SpecFlow.Drivers;

namespace Treinamento.Automation.UI.SpecFlow.Pages
{
    public class CheckoutStepOnePage : Browser
    {
        private IWebElement firstnameTxt => driver.FindElement(By.XPath("//*[@id=\"first-name\"]"));
        private IWebElement lastnameTxt => driver.FindElement(By.XPath("//*[@id=\"last-name\"]"));
        private IWebElement zippostalcodeTxt => driver.FindElement(By.XPath("//*[@id=\"postal-code\"]"));
        private IWebElement checkoutYourInformationBtn => driver.FindElement(By.XPath("//*[@id=\"continue\"]"));

        public void yourInformationSendKeys(string firstname, string lastname, string zippostalcode)
        {
            firstnameTxt.SendKeys(firstname);
            lastnameTxt.SendKeys(lastname);
            zippostalcodeTxt.SendKeys(zippostalcode);
        }
        public void checkoutYourInformationClick() => checkoutYourInformationBtn.Click();
    }
}