using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa.Financas.Entidade
{
    public abstract class Conta
    {
        public int NumeroConta {get; set;}
        public string Titular { get; set; }
        public double saldo { get; protected set; }

        public abstract void Saca(double valor);
        
        public virtual void Deposita(double valor)
        {
            if (Double.IsInfinity(this.saldo))
            {
                throw new OverflowException("Limite de valor alcançado");
            }

            if (valor < 0)
            {
                throw new ArgumentException("O valor do deposito não pode ser negativo");
            }
            
            this.saldo += valor;
        }


    }


}
