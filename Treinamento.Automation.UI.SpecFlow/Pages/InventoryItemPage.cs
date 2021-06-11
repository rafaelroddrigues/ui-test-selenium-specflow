using OpenQA.Selenium;
using Treinamento.Automation.UI.SpecFlow.Drivers;

namespace Treinamento.Automation.UI.SpecFlow.Pages
{
    public class InventoryItemPage : Browser
    {
        private IWebElement addToCartBtn => driver.FindElement(By.XPath("//*[@id=\"add-to-cart-sauce-labs-backpack\"]"));

        public void addToCartClick() => addToCartBtn.Click();
    }
}