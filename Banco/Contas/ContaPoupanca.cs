using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{

    public class ContaPoupanca : Conta,ITributavel
    {
        public ContaPoupanca()
        {
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }

        public ContaPoupanca(int numero) : base(numero) { }

        public override void Saca(double valor)
        {   
            if(valor < 0.0)
            {
                throw new ArgumentException();
            }
            if(valor + 0.10 > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= (valor + 0.10);
            }
            
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
    }
}
