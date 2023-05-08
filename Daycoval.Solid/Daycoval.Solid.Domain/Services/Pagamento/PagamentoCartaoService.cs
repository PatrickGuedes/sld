using Daycoval.Solid.Domain.Entidades;

namespace Daycoval.Solid.Domain.Services
{
    public class PagamentoCartaoService : IPagamentoService 
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public bool FoiPago { get; set; }

        public void EfetuarPagamento(ICarrinho carrinho)
        {
            FoiPago = true;

            //Não é necessário implementar este método.
        }

        
    }
}