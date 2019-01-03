using System;
using System.Collections.Generic;
using Eventos.IO.Domain.Core.Interface;
using FluentValidation.Results;

namespace Eventos.IO.Domain.Core.Base
{
    public abstract class BaseCommandHandler
    { 
        private readonly IUnitOfWork _unitOfWork;
        protected readonly IBus _bus;

        public BaseCommandHandler(IUnitOfWork unitOfWork, IBus bus)
        {
            _unitOfWork = unitOfWork;
            _bus = bus;
        }

        protected void NotificarValidacoesErro(IEnumerable<ValidationFailure> errors)
        {
            foreach(var error in errors)
            {
                Console.WriteLine(error.ErrorMessage);
            }
        }

        public BaseResponse Commit()
        {
            var response = new BaseResponse();

            try
            {
                var saveResult = _unitOfWork.Save();
                if(saveResult == 0) response.AddError("Nenhum dado alterado");
            }
            catch(Exception e)
            {
                response.AddError(e.Message);                
            }

            return response;
        }
    }
}