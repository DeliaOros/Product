using System;
using System.Collections.Generic;
using System.Text;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(Product.Categories.Fruit, 2018, 12, 04, 3, 21, 14);
            product1.Name = "apple";
            product1.Producer = "Livada";
            product1.Weight = 0.50f;
            Console.WriteLine(product1.ToString());

            Console.WriteLine("----------------------------------------------------------------------------------");
           
            Product product2 = new Product(Product.Categories.Beverages, 2017, 3, 2, 3, 44, 8);
            product2.Name = "coffee";
            product2.Producer = "Columbia";
            product2.Weight = .250f;
            Console.WriteLine(product2.ToString());

            Console.WriteLine("----------------------------------------------------------------------------------");


            Product product3 = new Product(Product.Categories.Dairy, 2018, 2, 3, 5, 6, 7);
            product3.Name = "coffee";
            product3.Producer = "Columbia";
            product3.Weight = .250f;
            Console.WriteLine(product3.ToString());

            Console.WriteLine("----------------------------------------------------------------------------------");

        }
    }
}
