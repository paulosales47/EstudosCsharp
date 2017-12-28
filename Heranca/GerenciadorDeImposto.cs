using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casa.Financas.Interface;

namespace Casa.Financas.Entidade
{
    public class GerenciadorDeImposto
    {
        public double Total { get; private set; }

        public void Acumula(ITributavel t)
        {
            this.Total += t.CalculaAtributo();
        }
    }
}
