using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Treinamento.Automation.UI.SpecFlow.Drivers;
using Treinamento.Automation.UI.SpecFlow.Pages;

namespace Treinamento.Automation.UI.SpecFlow.Steps

{
    [Binding]
    public class Login : Browser
    {

        private LoginPage loginPage = new LoginPage();
        private InventoryPage inventoryPage = new InventoryPage();

        [Given(@"que acesso o site")]
        public void DadoQueAcessoOSite()
        {
            Browser.loadPage("https://www.saucedemo.com/");
        }

        [Then(@"vejo que estou na login page")]
        public void EntaoVejoQueEstouNaLoginPage()
        {
            Assert.That(loginPage.isBotImgExist(), Is.True);
        }

        [When(@"informo as seguintes credenciais")]
        public void QuandoInformoAsSeguintesCredenciais(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.loginSendKeys((string)data.Username, (string)data.Password);
        }

        [When(@"me autentico no sistema")]
        public void QuandoMeAutenticoNoSistema()
        {
            loginPage.loginClick();
        }

        [Then(@"o usuário aparece logado")]
        public void EntaoOUsuarioApareceLogado()
        {
            inventoryPage.menuClick();
            Assert.That(inventoryPage.islogoutExist(), Is.True);
        }

        [Then(@"um erro aparece informando que o usuário está bloqueado")]
        public void EntaoUmErroApareceInformandoQueOUsuarioEstaBloqueado()
        {
            Assert.That(loginPage.getErrorMsg(), Is.EqualTo("Epic sadface: Sorry, this user has been locked out.").After(5000,1000));
        }

    }
}