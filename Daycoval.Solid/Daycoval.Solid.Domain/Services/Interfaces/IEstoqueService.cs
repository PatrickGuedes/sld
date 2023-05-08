using Daycoval.Solid.Domain.Entidades;
using System.Collections.Generic;

namespace Daycoval.Solid.Domain.Services
{
    public interface IEstoqueService
    {
        bool FoiEntregue { get; set; }

        void SolicitarProduto(List<IProduto> produto);
        void BaixarEstoque(List<IProduto> produto);
        
    }
}
