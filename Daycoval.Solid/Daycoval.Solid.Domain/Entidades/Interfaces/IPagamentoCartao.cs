namespace Daycoval.Solid.Domain.Entidades
{
    public interface IPagamentoCartao : IPagamento
    {
        string NomeImpressoCartao { get; set; }
        string AnoExpiracao { get; set; }
        string MesExpiracao { get; set; }
    }
}
