using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente : Conta, ITributavel
    {
        private static int totalDeContas = 0;

        public ContaCorrente()
        {
            ContaCorrente.totalDeContas++;
        }
        public static int ProximaConta()
        {
            return ContaCorrente.totalDeContas + 1;
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }

        public override void Deposita(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.Saldo += valor;
            }

        }
        public override void Saca(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            if (valor + 0.10 > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= (valor + 0.10);
            }

        }
    }
}
