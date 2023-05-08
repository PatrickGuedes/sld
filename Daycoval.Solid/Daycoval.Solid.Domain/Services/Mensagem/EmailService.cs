using Daycoval.Solid.Domain.Entidades;

namespace Daycoval.Solid.Domain.Services
{
    public class EmailService : IMensagemService
    {
        readonly ICliente _cliente;
        public EmailService(ICliente cliente)
        {
            _cliente = cliente;
        }
        public ICliente Cliente { get; set; }

        public void EnviarMensagem(string mensagem)
        {

        }
    }
}
