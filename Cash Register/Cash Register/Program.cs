using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Register
{
    class Program
    {
        static void Main(string[] args)
        {
           
        Console.WriteLine("Welcome to C# Grocery store");
            Console.WriteLine("What would you like to buy. We have:");

            List<Products> products = new List<Products>();
            products.Add(new Products { ItemName = "cucumbers", Price = 1 });
            products.Add(new Products { ItemName = "tomatoes", Price = 2 });
            products.Add(new Products { ItemName = "peppers", Price = 3 });
            products.Add(new Products { ItemName = "Potato", Price = 5 });
            products.Add(new Products { ItemName = "Zuchini", Price = 6 });
          
            foreach (var  Products in products)
            {
                Console.WriteLine(Products.ItemName);

            }

            Transactions Customers = new Transactions();
            bool shopping = true;
            while (shopping)
            {
                Customers.makePurchase();
            }
           


            

            
            

        }



    }
}
