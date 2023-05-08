namespace Daycoval.Solid.Domain.Entidades
{
    public class Cliente : ICliente
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public bool ComunicarEmail { get; set; } = true;
        public bool ComunicarSMS { get; set; } = true;

    }
}