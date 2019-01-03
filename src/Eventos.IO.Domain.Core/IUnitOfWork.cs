namespace Eventos.IO.Domain.Core
{
    public interface IUnitOfWork
    {
        int Save();
    }
}