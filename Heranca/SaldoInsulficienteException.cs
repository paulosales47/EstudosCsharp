using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa.Financas.ExceptionEntidade
{
    public sealed class SaldoInsulficienteException : Exception
    {
        public override string Message { get; }

        public SaldoInsulficienteException(string Message)
        {
            this.Message = Message;
        }

    }
}
