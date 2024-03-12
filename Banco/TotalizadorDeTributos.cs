using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
   
    internal class TotalizadorDeTributos
    {
        public double Total { get; set; }

        public void Adiciona(ITributavel t)
        {
            this.Total += t.CalculaTributo();
        }
        public void Acumula (ITributavel t)
        {
            Total += t.CalculaTributo();
        }
        public void Acumula (ContaPoupanca cp)
        {
            Total += cp.CalculaTributo();
        }
        public void Acumula(ContaInvestimento ci)
        {
            Total += ci.CalculaTributo();
        }
    }
}
