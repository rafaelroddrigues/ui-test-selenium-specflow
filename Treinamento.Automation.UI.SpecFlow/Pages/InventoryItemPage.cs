using OpenQA.Selenium;
using Treinamento.Automation.UI.SpecFlow.Drivers;

namespace Treinamento.Automation.UI.SpecFlow.Pages
{
    public class InventoryItemPage : Browser
    {
        public void addToCartClick(string produto) => driver.FindElement(By.XPath("//*[@id=\"add-to-cart-" + produto.Replace(" ","-").ToLower() + "\"]")).Click();
    }
}