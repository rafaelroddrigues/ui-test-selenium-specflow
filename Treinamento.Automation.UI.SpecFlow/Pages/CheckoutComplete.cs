using OpenQA.Selenium;
using Treinamento.Automation.UI.SpecFlow.Drivers;

namespace Treinamento.Automation.UI.SpecFlow.Pages
{
    public class CheckoutCompletePage : Browser
    {
        private IWebElement thankYouForYourOrderTxt => driver.FindElement(By.XPath("//*[@id=\"checkout_complete_container\"]/ h2"));

        public string getThankYouForYourOrder() => thankYouForYourOrderTxt.Text;
    }
}