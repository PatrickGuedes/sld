using Daycoval.Solid.Domain.Entidades;

namespace Daycoval.Solid.Domain.Services
{
    public class PagamentoDinheiroService : IPagamentoService
    {
        public bool FoiPago { get; set; }

        public void EfetuarPagamento(ICarrinho carrinho)
        {
            FoiPago = true;
        }
    }
}
