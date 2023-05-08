namespace Daycoval.Solid.Domain.Entidades
{
    public interface ICliente
    {
        string Cpf { get; set; }
        string Nome { get; set; }
        string Email { get; set; }
        string Celular { get; set; }

        bool ComunicarEmail { get; set; } 
        bool ComunicarSMS { get; set; }

    }
}
