using System.Collections.Generic;

namespace Daycoval.Solid.Domain.Entidades
{
    public interface ICarrinho
    {
        decimal ValorTotalPedido { get; set; }
        List<IProduto> Produtos { get; set; }
        IPagamento Pagamento { get; set; }
        ICliente Cliente { get; set; }
    }
}
