using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Banco
{
    class ContaBancaria
    {
        public int Numero { get; private set;}
        public string Nome { get; set;}
        public double _saldo { get; private set; }

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public ContaBancaria(int numero, string nome, double saldo) : this(numero,nome)
        {
            _saldo = saldo;
        }

        public void Deposito(double valor) {
            if (valor>0) _saldo += valor;
            else Console.WriteLine("Valor inválido, insira um valor superior a 0.");
        }

        public void Saque(double valor)
        {
            if (valor > 0)  _saldo -= (valor+5);
            else Console.WriteLine("Valor inválido, insira um valor superior a 0.");
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular:" + Nome + ", Saldo: $" + _saldo ;
        }


    }
}
