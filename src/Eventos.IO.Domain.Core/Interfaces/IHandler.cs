using Eventos.IO.Domain.Core.Base;

namespace Eventos.IO.Domain.Core.Interface
{
    public interface IHandler<in T> where T : Message
    {
        void Handle(T message);
    }
}