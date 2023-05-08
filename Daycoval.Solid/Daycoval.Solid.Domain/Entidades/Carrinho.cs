using System.Collections.Generic;
using System.Linq;

namespace Daycoval.Solid.Domain.Entidades
{
    public class Carrinho : ICarrinho
    {
        public Carrinho(List<IProduto> produtos, ICliente cliente, IPagamento pagamento)
        {
            Produtos = produtos;
            Cliente = cliente;
            Pagamento = pagamento;

            CalcularValorTotalPedido();
        }

        public decimal ValorTotalPedido { get; set; }
        public List<IProduto> Produtos { get; set; }
        public ICliente Cliente { get; set; }
        public IPagamento Pagamento { get; set; }


        void CalcularValorTotalPedido()
        {

            ValorTotalPedido = Produtos.Sum(produto => (produto.ValorImposto + produto.Valor) * produto.Quantidade);
        }
    }
}