using System;
using Eventos.IO.Domain.Core.Base;

namespace Eventos.IO.Domain.Core.Base
{
    public class DomainNotification : Event
    {
        public DomainNotification(string key, string value)
        {
            this.DomainNotificationId = Guid.NewGuid();
            this.Key = key;
            this.Value = value;
            this.Version = 1;    
        }

        public Guid DomainNotificationId { get; private set; }
        public string Key { get; private set; }
        public string Value { get; private set; }
        public int Version { get; private set; }
    }
}