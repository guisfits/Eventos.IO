using System.Collections.Generic;
using System.Linq;

namespace Eventos.IO.Domain.Core.Base
{
    public class BaseResponse
    {
        private bool _success;
        private IList<string> _erros;

        public BaseResponse()
        {
            _success = true;
            _erros = new List<string>();
        }

        public bool Success
        {
            get => _success && !Erros.Any();
        }

        public IEnumerable<string> Erros 
        { 
            get => _erros; 
        }

        public void Fail()
        {
            _success = false;
        }

        public void Fail(string messageError)
        {
            Fail();
            _erros.Add(messageError);
        }
    }
}