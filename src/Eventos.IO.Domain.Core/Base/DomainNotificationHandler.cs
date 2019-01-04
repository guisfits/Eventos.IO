using System;
using System.Collections.Generic;
using System.Linq;
using Eventos.IO.Domain.Core.Interfaces;

namespace Eventos.IO.Domain.Core.Base
{
    public class DomainNotificationHandler : IDomainNotificationHandler<DomainNotification>, IDisposable
    {
        private List<DomainNotification> _notifications;

        public DomainNotificationHandler()
        {
            _notifications = new List<DomainNotification>();
        }
        
        public void Handle(DomainNotification message)
        {
            _notifications.Add(message);
        }

        public List<DomainNotification> GetNotifications()
        {
            return _notifications;
        }

        public bool HasNotifications()
        {
            return _notifications.Any();
        }

        public void Dispose()
        {
            _notifications = new List<DomainNotification>();
        }
    }
}