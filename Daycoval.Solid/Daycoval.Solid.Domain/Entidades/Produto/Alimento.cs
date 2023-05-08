namespace Daycoval.Solid.Domain.Entidades
{
    public class Alimento : BaseProduto, IProduto
    {
        public override decimal ValorImposto { get  { return Valor * 0.15m; } }

    }
}