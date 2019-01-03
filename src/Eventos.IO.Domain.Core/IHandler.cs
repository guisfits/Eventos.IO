namespace Eventos.IO.Domain.Core
{
    public interface IHandler<in T> where T : Message
    {
        void Handle(T message);
    }
}