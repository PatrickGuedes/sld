namespace Daycoval.Solid.Domain.Entidades
{
    public abstract class BaseProduto
    {
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public abstract decimal ValorImposto { get; }
        public decimal Valor { get; set; }

    }
}
