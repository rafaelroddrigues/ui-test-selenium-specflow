using OpenQA.Selenium;
using Treinamento.Automation.UI.SpecFlow.Drivers;

namespace Treinamento.Automation.UI.SpecFlow.Pages
{
    public class LoginPage : Browser
    {
        private IWebElement botImg => driver.FindElement(By.XPath("//*[@id=\"root\"]/ div/div[2]/div[1]/div[2]"));
        private IWebElement usernameTxt => driver.FindElement(By.XPath("//*[@id=\"user-name\"]"));
        private IWebElement passwordTxt => driver.FindElement(By.XPath("//*[@id=\"password\"]"));
        private IWebElement loginBtn => driver.FindElement(By.XPath("//*[@id=\"login-button\"]"));
        private IWebElement errorMsg => driver.FindElement(By.XPath("//*[@id=\"login_button_container\"]/ div/form/div[3]/h3"));

        public bool isBotImgExist() => botImg.Displayed;
        public void loginSendKeys(string username, string password)
        {
            usernameTxt.SendKeys(username);
            passwordTxt.SendKeys(password);
        }
        public void loginClick() => loginBtn.Click();
        public string getErrorMsg() => errorMsg.Text;
    }
}