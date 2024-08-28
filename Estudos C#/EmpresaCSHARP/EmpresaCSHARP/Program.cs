using EmpresaCSHARP;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alunos a = new Alunos();

            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            a.Nota1 = int.Parse(Console.ReadLine());
            a.Nota2 = int.Parse(Console.ReadLine());
            a.Nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"NOTA FINAL: {a.Resultados().ToString()}");

            if (a.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
                Console.WriteLine("REPROVADO");
            Console.WriteLine($"FALTARAM: {a.NotaRestante().ToString()} PONTOS");

        }
    }
}