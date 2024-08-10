﻿using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    /* internal class Program
     {

         private static void (string[] args)
         {
             bool completo = false;
             char genero = 'F';
             char letra = '\u0041';
             byte n1 = 126;
             int n2 = 1000;
             int n3 = 2147483647;
             long n4 = 2147483648L;
             float n5 = 4.5f;
             double n6 = 4.5;
             String nome = "Maria Green";
             Object obj1 = "Alex Brown";
             Object obj2 = 4.5f;


             Console.WriteLine(completo);
             Console.WriteLine(genero);
             Console.WriteLine(letra);
             Console.WriteLine(n1);
             Console.WriteLine(n2);
             Console.WriteLine(n3);
             Console.WriteLine(n4);
             Console.WriteLine(n5);
             Console.WriteLine(n6);
             Console.WriteLine(nome);
             Console.WriteLine(obj1);
             Console.WriteLine(obj2);
         }
     }

     public class SaidaDados
     {
         static void Second(string[] args)
         {
             char genero = 'F';
             int idade = 32;
             double saldo = 10.35784;
             String nome = "Maria";
             Console.Write("Bom dia!");
             Console.WriteLine("Boa tarde!");
             Console.WriteLine("Boa noite!");
             Console.WriteLine("---------------------------");
             Console.WriteLine(genero);
             Console.WriteLine(idade);
             Console.WriteLine(saldo);
             Console.WriteLine(nome);
             Console.WriteLine(saldo.ToString("F2"));
             Console.WriteLine(saldo.ToString("F4"));
             Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
         }
     }

      **EXERCICIO: IMPRIMIR ESSES VALORES**
      Produtos:
 Computador, cujo preço é $ 2100,00
 Mesa de escritório, cujo preco é $ 650,50
 Registro: 30 anos de idade, código 5290 e gênero: M
 Medida com oito casas decimais: 53,23456700
 Arredondado(três casas decimais) : 53,235
 Separador decimal invariant culture: 53.235
  */
    public class ExercicioSaidaDados
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;


            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é ${preco1}");
            Console.WriteLine($"{produto2}, cujo preço é ${preco2}");
            Console.WriteLine($"Registro {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine($"Medida com oito casas decimais: {medida}");
            Console.WriteLine($"Arredondado (Três casas decimais) : {medida:F3}");
        }
    }





}
