using Daycoval.Solid.Domain.Entidades;

namespace Daycoval.Solid.Domain.Services
{
    public class SmsService : IMensagemService
    {
        readonly ICliente _cliente; 
        public SmsService(ICliente cliente)
        {
            _cliente = cliente;
        }

        public string Mensagem { get; set; }

        public ICliente Cliente { get; set; }

        public void EnviarMensagem(string message)
        {
            //Este método não precisa ser implementado.
        }
    }
}