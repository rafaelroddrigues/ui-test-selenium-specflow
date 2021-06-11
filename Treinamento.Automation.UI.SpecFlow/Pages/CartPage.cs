using OpenQA.Selenium;
using Treinamento.Automation.UI.SpecFlow.Drivers;

namespace Treinamento.Automation.UI.SpecFlow.Pages
{
    public class CartPage : Browser
    {
        private IWebElement cartLnk => driver.FindElement(By.XPath("//*[@id=\"shopping_cart_container\"]/ a"));
        private IWebElement checkoutCartBtn => driver.FindElement(By.XPath("//*[@id=\"checkout\"]"));

        public void cartClick() => cartLnk.Click();
        public void checkoutCartClick() => checkoutCartBtn.Click();
    }
}