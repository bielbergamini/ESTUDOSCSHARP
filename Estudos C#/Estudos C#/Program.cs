using System;
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
    
    using System;

    namespace MyApp 
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int a = 10;
                Console.WriteLine(a);

                a += 2;
                Console.WriteLine(a);

                a *= 3;
                Console.WriteLine(a);

                string s = "ABC";
                Console.WriteLine(s);

                s += "DEF";
                Console.WriteLine(s);

            }
        }
    }
    
     using System;

    namespace MyApp
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int a = 10;
                a++;
                    Console.WriteLine(a);

                int b = 10;
                b--;
                Console.WriteLine(b);

            }
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);

            double c;
            int d;

            c = 5.1;
            d = (int)c;

            Console.WriteLine(d);

            int e = 5;
            int f = 2;

            double resultado = (double) e / f;

            Console.WriteLine(resultado);


        }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double )10 / 8;

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(a);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
    


    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();


            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];


            Console.WriteLine("Você digitou :");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
    


    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse (vet[2]);
            double altura = double.Parse (vet[3], CultureInfo.InvariantCulture);



            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.WriteLine(vet);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }

    

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");

            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");

            int quartos = int.Parse (Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");

            double preco = double.Parse (Console.ReadLine());

            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha)");

            string[] strings = Console.ReadLine().Split (' ');
            string sobrenome = strings[0];
            int idade = int.Parse(strings[1]);
            double altura = double.Parse (strings[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(strings);
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("SOMA = " + soma);

        }
    }




}










