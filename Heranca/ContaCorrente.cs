using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casa.Financas.ExceptionEntidade;

namespace Casa.Financas.Entidade
{
    class ContaCorrente : Conta
    {
        public override void Saca(double valor)
        {
            if(valor > this.saldo)
            {
                throw new SaldoInsulficienteException("Saldo Insulficiente");
            }

            else if(valor < 0)
            {
                throw new ArgumentException("O valor do saque não pode ser negativo");
            }

            this.saldo -= valor;
        }

        public override void Deposita(double valor)
        {
            if (Double.IsInfinity(this.saldo))
            {
                throw new OverflowException("Limite de valor alcançado");
            }

            this.saldo += valor;
            
        }

    }
}
