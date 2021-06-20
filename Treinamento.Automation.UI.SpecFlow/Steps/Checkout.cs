using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Treinamento.Automation.UI.SpecFlow.Drivers;
using Treinamento.Automation.UI.SpecFlow.Pages;

namespace Treinamento.Automation.UI.SpecFlow.Steps
{
    [Binding]
    public class Checkout : Browser
    {

        private InventoryPage inventoryPage = new InventoryPage();
        private InventoryItemPage inventoryItemPage = new InventoryItemPage();
        private CartPage cartPage = new CartPage();
        private CheckoutStepOnePage checkoutStepOnePage = new CheckoutStepOnePage();
        private CheckoutStepTwoPage checkoutStepTwoPage = new CheckoutStepTwoPage();
        private CheckoutCompletePage checkoutComplete = new CheckoutCompletePage();

        [When(@"adiciono o produto (.+)")]
        public void QuandoAdicionoOProduto(string produto)
        {
            inventoryPage.getProduto(produto);
            inventoryItemPage.addToCartClick(produto);
        }

        [When(@"visualizo o carrinho")]
        public void QuandoVisualizoOCarrinho()
        {
            cartPage.cartClick();
        }

        [When(@"sigo para as informações do Checkout")]
        public void QuandoSigoParaAsInformacoesDoCheckout()
        {
            cartPage.checkoutCartClick();
        }

        [When(@"insiro as seguintes informações pessoais")]
        public void QuandoInsiroAsSeguintesInformacoesPessoais(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            checkoutStepOnePage.yourInformationSendKeys((string)data.FirstName, (string)data.LastName, (string)data.ZipPostalCode);
        }

        [When(@"sigo para o Overview do Checkout")]
        public void QuandoSigoParaOOverviewDoCheckout()
        {
            checkoutStepOnePage.checkoutYourInformationClick();
        }

        [When(@"finalizo a compra")]
        public void QuandoFinalizoACompra()
        {
            checkoutStepTwoPage.checkoutOverviewClick();
        }

        [Then(@"a página de pedido completo é exibida contendo a mensagem (.+)")]
        public void EntaoAPaginaDePedidoCompletoEExibida(string texto)
        {
            Assert.That(checkoutComplete.getThankYouForYourOrder(), Is.EqualTo(texto));
        }

    }
}