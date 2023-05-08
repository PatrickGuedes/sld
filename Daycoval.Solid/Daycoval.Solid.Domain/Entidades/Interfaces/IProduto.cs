namespace Daycoval.Solid.Domain.Entidades
{
    public interface IProduto
    {
        string Descricao { get; set; }
        decimal Valor { get; set; }
        int Quantidade { get; set; }
        decimal ValorImposto { get; }
    }


}
