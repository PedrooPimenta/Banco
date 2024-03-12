using System;

namespace Banco
{
    public abstract class Conta
    {
        private static int numeroDeContas;
        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }

        public override string ToString()
        {
            return "Titular - " + this.Titular.Nome;
        }

        public static int ProximoNumero()
        {
            return numeroDeContas + 1;
        }

        public int Numero { get; internal set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; internal set; }

        public Conta(int numero, double saldo, Cliente titular)
        {
            Numero = numero;
            Saldo = saldo;
            Titular = titular;
        }

        public Conta(int numero)
        {
            Numero = numero;
        }

        public abstract void Deposita(double valor);
       

        public abstract void Saca(double valor);
        
    }
}