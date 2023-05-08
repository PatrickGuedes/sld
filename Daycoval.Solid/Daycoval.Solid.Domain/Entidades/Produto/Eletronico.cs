namespace Daycoval.Solid.Domain.Entidades
{
    public class Eletronico :BaseProduto, IProduto
    {
        public override decimal ValorImposto { get { return Valor * 0.05m; } }

    }
}