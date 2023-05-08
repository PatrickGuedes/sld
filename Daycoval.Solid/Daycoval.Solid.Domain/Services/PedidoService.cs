using Daycoval.Solid.Domain.Entidades;

namespace Daycoval.Solid.Domain.Services
{
    public class Pedido : IPedidoService
    {
        readonly ICarrinho _carrinho;
        readonly IPagamentoService _pagamentoService;

        public Pedido(ICarrinho carrinho, IPagamentoService pagamentoService)
        {
            _carrinho = carrinho;
            _pagamentoService = pagamentoService;
        }

        public void EfetuarPedido()
        {
            _pagamentoService.EfetuarPagamento(_carrinho);
            
        }
    }
}