using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class TotalizadorDeContas
    {
        public double valorTotal {  get; set; }

        public void Soma(Conta conta)
        {
            valorTotal += conta.Saldo;
        }

        Conta c1 = new ContaCorrente();
        ContaPoupanca C2 = new ContaPoupanca(); 
        TotalizadorDeContas conta = new TotalizadorDeContas();
        
    }
}
