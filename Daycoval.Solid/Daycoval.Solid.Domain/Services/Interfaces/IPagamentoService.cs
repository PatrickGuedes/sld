using Daycoval.Solid.Domain.Entidades;

namespace Daycoval.Solid.Domain.Services
{
    public interface IPagamentoService
    {
      
        bool FoiPago { get; set; }

        void EfetuarPagamento(ICarrinho carrinho);
    }
}
