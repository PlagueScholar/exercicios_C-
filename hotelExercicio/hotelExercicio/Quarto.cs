using System;
using System.Collections.Generic;
using System.Text;

namespace hotelExercicio
{
    class Quarto
    {
        public string Nome { get; private set;}
        public string Email { get; private set;}
        public bool Ocupied { get; private set;}
        public int Number { get; private set;}

        public Quarto(string nome, string email, int number) {

                Nome = nome;
                Email = email;
                Number = number;
            

            // corrigir posteriormente com tratamento de exceções
            
            this.Ocupied = true;
        }

        /*
        public void setQuarto(string nome, string email, int number) {

            if (number > 10 || number < 1)
            {
                Console.WriteLine("Os números de quartos vão de 1 a 10");
            }
            else { Quarto(nome, email, number); }
        }

        */

        public string status() {

            if (Ocupied) { return $"{Number}: {Nome}, {Email}"; }
            else { return "Quarto Vago"; }
        
        
        }


    }
}
