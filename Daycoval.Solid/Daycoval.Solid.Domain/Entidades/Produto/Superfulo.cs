namespace Daycoval.Solid.Domain.Entidades
{
    public class Superfulo :BaseProduto, IProduto
    {
        public override decimal ValorImposto { get { return Valor * 0.20m; } }

    }
}