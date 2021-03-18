using System;
using System.Collections.Generic;
using Execicio_Udemy_Aula_133.Entites;
using System.Globalization;
namespace Execicio_Udemy_Aula_133    
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> List = new List<Product>();

            Console.Write("Enter the number of products: ");
            int number = int.Parse(Console.ReadLine());

            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used of imported (c/u/i)? ");
                char choice = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if(choice == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customfee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    List.Add(new ImportedProduct(name, price, customfee));
                }
                else if( choice == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacturedate = DateTime.Parse(Console.ReadLine());
                    List.Add(new UsedProduct(name, price, manufacturedate));
                }
                else
                {
                    List.Add(new Product(name, price));
                }              
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in List)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
