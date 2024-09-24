using Listas;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    /* static void Main(string[] args)
     {
         List<string> list = new List<string>();

         list.Add("Maria");
         list.Add("Alex");

         foreach (string obj in list)
         {
             Console.WriteLine(obj);
         }
         Console.WriteLine($"Contagem lista: {list.Count}");

         string s1 = list.Find(x => x[0] == 'X');
         Console.WriteLine($"First A: {s1}");
     }
    */

    using System;
    using System.Globalization;
    using System.Collections.Generic;

    namespace Course
    {
        class Program
        {
            static void Main(string[] args)
            {

                Console.Write("How many employees will be registered? ");
                int n = int.Parse(Console.ReadLine());

                List<Employee> list = new List<Employee>();

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Employee #" + i + ":");
                    Console.Write("Id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Salary: ");
                    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Employee(id, name, salary));
                    Console.WriteLine();
                }

                Console.Write("Enter the employee id that will have salary increase : ");
                int searchId = int.Parse(Console.ReadLine());

                Employee emp = list.Find(x => x.Id == searchId);
                if (emp != null)
                {
                    Console.Write("Enter the percentage: ");
                    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    emp.IncreaseSalary(percentage);
                }
                else
                {
                    Console.WriteLine("This id does not exist!");
                }

                Console.WriteLine();
                Console.WriteLine("Updated list of employees:");
                foreach (Employee obj in list)
                {
                    Console.WriteLine(obj);
                }
            }
        }
    }

