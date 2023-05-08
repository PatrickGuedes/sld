using Daycoval.Solid.Domain.Entidades;

namespace Daycoval.Solid.Domain.Services
{
    public interface IMensagemService
    {
        ICliente Cliente { get; set; }
        void EnviarMensagem(string mensagem);
    }
}
