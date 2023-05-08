using Daycoval.Solid.Domain.Entidades;
using System.Collections.Generic;

namespace Daycoval.Solid.Domain.Services
{
    public class EstoqueService : IEstoqueService
    {

        public bool FoiEntregue { get; set; }

        public void SolicitarProduto(List<IProduto> produto)
        {
            //Este método não precisa ser implementado.
        }

        public void BaixarEstoque(List<IProduto> produto)
        {
            //Este método não precisa ser implementado.
        }
    }
}