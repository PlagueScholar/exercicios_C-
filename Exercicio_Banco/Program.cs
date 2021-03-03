using System;

namespace Exercicio_Banco
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;
            string nome;
            char deposito_in;

            ContaBancaria conta;

            Console.WriteLine("Entre o numero da conta");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre o nome do titular");
            nome = Console.ReadLine();

            Console.WriteLine("Havera deposito inicial ? (s/n)");
            deposito_in = char.Parse(Console.ReadLine());


            if (deposito_in == 's' || deposito_in == 'S')
            {
                Console.WriteLine("Insira o valor do deposito inicial");
                conta = new ContaBancaria(numero, nome, double.Parse(Console.ReadLine())); 
            }

            else
            {
                conta = new ContaBancaria(numero, nome);
            }

            Console.WriteLine("Dados da conta: \n" + conta);

            Console.WriteLine("Insira uma valor para deposito");
            conta.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados: \n" + conta);

            Console.WriteLine("Insira uma valor para saque");
            conta.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados: \n" + conta);



        }
    }
}
