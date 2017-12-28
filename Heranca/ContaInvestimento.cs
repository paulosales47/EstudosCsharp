using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casa.Financas.Interface;

namespace Casa.Financas.Entidade
{
    public class ContaInvestimento : Conta, ITributavel
    {
        public double CalculaAtributo()
        {
            return this.saldo * 0.03;
        }

        public override void Saca(double valor)
        {
            this.saldo -= valor;
        }
    }
}
