﻿namespace Banco
{
    public  class Cliente
    {
        private string v;

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; private set; }
    }
}