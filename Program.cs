using Projeto_Aula_142.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Aula_142
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> prodList = new List<Product>();

            Console.Write("Enter the number of products: ");
            int Entry = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Entry; i++)
            {
                Console.WriteLine($"Product #{i} data: ");

                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string Name = Console.ReadLine();

                Console.Write("Price: ");
                double Price = double.Parse(Console.ReadLine());

                if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime Manufacture = DateTime.Parse(Console.ReadLine());
                    prodList.Add(new UsedProduct(Name, Price, Manufacture));
                }
                else if (ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double Customs = double.Parse(Console.ReadLine());
                    prodList.Add(new ImportedProduct(Name, Price, Customs));
                }
                else
                {
                    prodList.Add(new Product(Name, Price));
                }
            }

            Console.WriteLine();

            Console.WriteLine("PRICE TAGS:");

            foreach (Product obj in prodList)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
