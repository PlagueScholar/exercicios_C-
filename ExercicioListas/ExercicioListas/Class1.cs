using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListas
{
    class Employee
    {
        public int Id { get; private set;}
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Employee(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void updateSalario(double prcnt){
            if (prcnt <= 0) {
                Console.WriteLine("Insira um valor maior que 0");
            }
            else{
                Salario += Salario * (prcnt / 100);
            }


        }

        public override string ToString()
        {
            return Id+","+ Nome + ", " + Salario;
        }
    }

}
