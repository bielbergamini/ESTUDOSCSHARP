using POO;
using System;
using System.Collections.Concurrent;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.

{
    /*
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoas a, b;
            a = new Pessoas();
            b = new Pessoas();


            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            a.NomeA = (Console.ReadLine());
            Console.Write("Idade: ");
            a.IdadeA = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            b.NomeB = (Console.ReadLine());
            Console.Write("Idade: ");
            b.IdadeB = int.Parse(Console.ReadLine());

            if (a.IdadeA > b.IdadeB)
            {
                Console.WriteLine($"Pessoa mais velha: {a.NomeA}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {b.NomeB}");
            }


        }
    }
    



    namespace MyApp // Note: actual namespace depends on the project name.
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Funcionarios a, b;
                a = new Funcionarios();
                b = new Funcionarios();

                Console.WriteLine("Dados do primeiro funcionário");
                Console.Write("Nome: ");
                a.Nome = (Console.ReadLine());
                Console.Write("Salário: ");
                a.Salario = double.Parse(Console.ReadLine());
                Console.WriteLine("Dados do segundo funcionário");
                Console.Write("Nome: ");
                b.Nome = (Console.ReadLine());
                Console.Write("Salário: ");
                b.Salario = double.Parse(Console.ReadLine());
                Console.WriteLine($"Salário médio = {(a.Salario + b.Salario) / 2}");

            }
        }
    }
    */

    internal class Program
    {
        static void Main(string[] args)

        {
            Funcionario func = new Funcionario();




            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Funcionário: {func.Nome}, {func.SalarioBr - func.Imposto}{CultureInfo.InvariantCulture}");






        }
    }
}





