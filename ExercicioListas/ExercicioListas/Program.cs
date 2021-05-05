using System;
using System.Collections.Generic;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lista = new List<Employee>();
            int id_aux;
            string nome_aux;
            double salario_aux;



            Console.WriteLine("How many employees will be registered");
            int i = int.Parse(Console.ReadLine());

            for (; i > 0; i--)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.WriteLine("Id:");
                id_aux = int.Parse(Console.ReadLine());
                if (lista.Find(emp => emp.Id == id_aux) != null)
                {
                    Console.WriteLine("Id já utilizado, insira outro");
                    i++;
                }
                else
                {
                    Console.WriteLine("Name:");
                    nome_aux = Console.ReadLine();
                    Console.WriteLine("Salary:");
                    salario_aux = double.Parse(Console.ReadLine());
                    lista.Add(new Employee(id_aux, nome_aux, salario_aux));
                }
            }

            Console.WriteLine("Enter the id of the employee that will have a salary increase");
          
                        id_aux = int.Parse(Console.ReadLine());
                        if (lista.Find(emp => emp.Id == id_aux) == null){
                            Console.WriteLine("Non-Existing ID");
                        }
                        else {
                            Console.WriteLine("Enter the percentage");
                            double p = double.Parse(Console.ReadLine());
                            lista.Find(emp => emp.Id == id_aux).updateSalario(p);
                        }


            foreach (Employee obj in lista)
            {
                Console.WriteLine(obj);

            }



        }
    }
}
