using System;

namespace Course
{
    /*
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);

        }
    }
    

    using System;

    namespace MyApp // Note: actual namespace depends on the project name.
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                int m = int.Parse(Console.ReadLine());
                int[,] mat = new int[n, m];

               

            }
        }
    */


    using System;
    using System.Security.Cryptography.X509Certificates;

    namespace MyApp // Note: actual namespace depends on the project name.
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Insira o valor do calculo: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    for (i = 1; i <= 11; i++) // Ajustei para testar até 12, você pode mudar conforme necessário
                    {
                        if (i >= 1 && i <= 10)  // Verifica se o multiplicador está entre 1 e 10
                        {
                            int resultado = n * i;
                            Console.WriteLine($"{n} x {i} = {resultado}");
                        }
                        else
                        {
                            Console.WriteLine($"{n} x {i} está fora do intervalo (1 a 10), cálculo ignorado.");
                        }
                    }



                }

        









            }
        }
    }
}



