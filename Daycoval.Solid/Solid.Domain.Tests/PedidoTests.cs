using Daycoval.Solid.Domain.Entidades;
using Daycoval.Solid.Domain.Services;
using System.Collections.Generic;
using Xunit;

namespace Solid.Domain.Tests
{
    public class PedidoTests
    {
        List<IProduto> produtos = new List<IProduto>()
            {
                new Alimento{ Descricao = "Arroz", Quantidade = 2, Valor = 1},
                new Eletronico{ Descricao = "TV", Quantidade = 1, Valor = 1},
                new Superfulo { Descricao = "Boneca", Quantidade = 1, Valor = 1},
            };


        [Fact]
        public void CalcularValorTotalPedido_Pagamento()
        {
            var esperado = true;


            ICarrinho carrinho = new Carrinho(this.produtos, new Cliente(), new Dinheiro());

            IPagamentoService pagamento = new PagamentoDinheiroService();

            IPedidoService pedido = new Pedido(carrinho, pagamento);

            pedido.EfetuarPedido();


            Assert.Equal(esperado, pagamento.FoiPago);

        }
    }
}
