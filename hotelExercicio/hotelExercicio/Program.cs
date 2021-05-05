using System;

namespace hotelExercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Quarto[] quartos = new Quarto[10];

            int n;

            Console.WriteLine("Quantos quartos serão alugados?");
            n = int.Parse(Console.ReadLine());

        

                for (int i = 0; i < n; i++)
                {

                    string nome, email;
                    int num;

                    Console.WriteLine($"Aluguel numero {i + 1}");
                    Console.WriteLine("Nome:");
                    nome = Console.ReadLine();
                    Console.WriteLine("Email:");
                    email = Console.ReadLine();
                    Console.WriteLine("Numero");
                    num = int.Parse(Console.ReadLine());

                if (quartos[num] == null || quartos[num].Ocupied == false)
                {
                    quartos[num] = new Quarto(nome, email, num);
                }
                else { Console.WriteLine("Quarto ocupado"); }
                    
                }

                Console.WriteLine("Quartos ocupados:");

                for (int i = 0; i < 10; i++)
                {

                   if(quartos[i] != null) Console.WriteLine(quartos[i].status());


                }

            }
         

        
    }
}
