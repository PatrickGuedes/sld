using Daycoval.Solid.Domain.Entidades;
using System.Collections.Generic;
using Xunit;

namespace Solid.Domain.Tests
{
    public class CarrinhoTests
    {

        [Fact]
        public void CalcularValorTotalPedido_CalculoCorretoDeTodosOsProdutosConsiderandoImpostosDiversos()
        {
            List<IProduto> produtos = new List<IProduto>()
            {
                new Alimento{ Descricao = "Arroz", Quantidade = 2, Valor = 1},
                new Eletronico{ Descricao = "TV", Quantidade = 1, Valor = 1},
                new Superfulo { Descricao = "Boneca", Quantidade = 1, Valor = 1},
            };

            var esperado = 4.55m;


            ICarrinho carrinho = new Carrinho(produtos, new Cliente(), new Dinheiro());


            Assert.Equal(esperado, carrinho.ValorTotalPedido);

        }

        [Theory]
        [InlineData(2, 6, 13.8)]
        public void CalcularValorTotalPedido_CalculoCorretoDaQuantidadePeloValor(int quantidade, decimal valor, decimal esperado)
        {
            List<IProduto> produtos = new List<IProduto>()
            {
                new Alimento{ Descricao = "Banana", Quantidade = quantidade, Valor = valor}
            };

            ICarrinho carrinho = new Carrinho(produtos, new Cliente(), new Dinheiro());


            Assert.Equal(esperado, carrinho.ValorTotalPedido);

        }

    }
}