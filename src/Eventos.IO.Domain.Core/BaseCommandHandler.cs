using System;
using System.Collections.Generic;
using FluentValidation.Results;

namespace Eventos.IO.Domain.Core
{
    public abstract class BaseCommandHandler
    { 
        private readonly IUnitOfWork _unitOfWork;

        public BaseCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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