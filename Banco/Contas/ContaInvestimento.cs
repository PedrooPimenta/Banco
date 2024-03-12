using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaInvestimento : Conta, ITributavel
    {
        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }
        public override void Deposita(double valor)
        {
           
        }

        public override void Saca(double valor)
        {
           
        }
    }
}
