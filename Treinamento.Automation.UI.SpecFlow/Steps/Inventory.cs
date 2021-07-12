using System.Collections.Generic;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Treinamento.Automation.UI.SpecFlow.Drivers;
using Treinamento.Automation.UI.SpecFlow.Pages;

namespace Treinamento.Automation.UI.SpecFlow.Steps

{
    [Binding]
    public class Inventory : Browser
    {

        private InventoryPage inventoryPage = new InventoryPage();

        [Then(@"o preço unitário dos seguintes produtos devem ter os valores")]
        public void EntaoOPrecoUnitarioDosSeguintesProdutosDevemTerOsValores(Table table)
        {
            IEnumerable<dynamic> t = table.CreateDynamicSet();
            foreach (var data in t)
            {
                Assert.That(inventoryPage.getProdutoPreco(data.Produto), Is.EqualTo(data.Preco));
            }
        }

    }
}