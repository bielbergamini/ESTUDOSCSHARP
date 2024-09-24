using ExercicioVetores;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        /*static void Main(string[] args)
        {
            Livros[] vect = new Livros[10];
            //Console.Write("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

               // Console.WriteLine("Aluguel #1");
                //Console.Write("Nome: ");
                string titulo = (Console.ReadLine());
                //Console.Write("Autor: ");
                string autor = (Console.ReadLine());
                //Console.Write("Estante: ");
                int estante = int.Parse(Console.ReadLine());
                vect[estante] = new Livros(titulo, autor);
            }

           // Console.WriteLine();
           // Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);







                }
            }
        }
        */

        static void Main(string[] args)
        {
            int x = 10;
            Livros.Triple(ref x);
            Console.WriteLine(x);
        }
    }
        
        

}
    
