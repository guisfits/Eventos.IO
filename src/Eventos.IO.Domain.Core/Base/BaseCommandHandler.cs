using System;
using System.Collections.Generic;
using Eventos.IO.Domain.Core.Interface;
using Eventos.IO.Domain.Core.Interfaces;
using FluentValidation.Results;

namespace Eventos.IO.Domain.Core.Base
{
    public abstract class BaseCommandHandler
    { 
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IDomainNotificationHandler<DomainNotification> _notifications;
        protected readonly IBus _bus;

        protected BaseCommandHandler(IUnitOfWork unitOfWork, IBus bus, IDomainNotificationHandler<DomainNotification> notifications)
        {
            _unitOfWork = unitOfWork;
            _bus = bus;
            _notifications = notifications;
        }

        protected void NotificarValidacoesErro(IEnumerable<ValidationFailure> errors)
        {
            foreach(var error in errors)
            {
                Console.WriteLine(error.ErrorMessage);
                _bus.RaiseEvent(new DomainNotification(error.PropertyName, error.ErrorMessage));
            }
        }

        public BaseResponse Commit()
        {
            var response = new BaseResponse();
            if(_notifications.HasNotifications())
            {
                response.Fail();
                return response;
            }

            try
            {
                var saveResult = _unitOfWork.Save();
                if(saveResult > 0) return response;
            
                var errorMessage = "Erro ao salvar os dados no banco";
                _bus.RaiseEvent(new DomainNotification("Commit", errorMessage));
                response.Fail(errorMessage);
            }
            catch(Exception e)
            {
                response.Fail(e.Message);                
            }

            return response;
        }
    }
}