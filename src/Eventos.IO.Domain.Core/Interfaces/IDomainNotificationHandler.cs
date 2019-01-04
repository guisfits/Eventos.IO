using System.Collections.Generic;
using Eventos.IO.Domain.Core.Base;
using Eventos.IO.Domain.Core.Interface;

namespace Eventos.IO.Domain.Core.Interfaces
{
    public interface IDomainNotificationHandler<T> : IHandler<T> where T : Message
    {
        bool HasNotifications();
        List<T> GetNotifications(); 
    }
}