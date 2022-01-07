/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using System.Collections.Generic;
using Aula219_Comparison.Entities;

namespace Aula219_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            // Expressao Lambda - Declaracao de Funcao Anonima
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            //Comparison<Product> comp = CompareProducts;

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
            //list.Sort(comp);
            //list.Sort(CompareProducts); // Ordena a lista

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        // Metodo auxiliar para comparar dois produtos
        /*static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }*/
    }
}
