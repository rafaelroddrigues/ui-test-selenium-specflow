using OpenQA.Selenium;
using Treinamento.Automation.UI.SpecFlow.Drivers;

namespace Treinamento.Automation.UI.SpecFlow.Pages
{
    public class InventoryPage : Browser
    {
        private IWebElement menuBtn => driver.FindElement(By.XPath("//*[@id=\"react-burger-menu-btn\"]"));
        private IWebElement menuWindow => driver.FindElement(By.XPath("//*[@id=\"menu_button_container\"]/ div/div[2]"));
        private IWebElement logoutLnk => driver.FindElement(By.XPath("//*[@id=\"logout_sidebar_link\"]"));

        public void menuClick() => menuBtn.Click();
        public bool isMenuWindowVisible() => menuWindow.Displayed;
        public bool islogoutExist() => logoutLnk.Displayed;
        public void getProduto(string produto) => driver.FindElement(By.XPath("//*[text()='" + produto + "']")).Click();
        public string getProdutoPreco(string produto) => driver.FindElement(By.XPath("//*[text()='" + produto + "']/parent::a/../../div/div[@class='inventory_item_price']")).Text;
    }
}