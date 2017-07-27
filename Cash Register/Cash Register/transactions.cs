using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cash_Register
{

    public class Transactions
    {


        public decimal Buy(decimal Price)
        {
           
            decimal Total = 0;
            Total += Price;
            Tax(ref Total);
            History(ref Total);
            return Total;

        }


        private decimal Tax(ref decimal Total)
        {
            decimal tax = Total * .08m;
           
            Total += tax;
            
            return Total;
        }
        private void  History(ref decimal Total)
        {
            DateTime DayOfTransaction = DateTime.Now;
            using (StreamWriter writetext = new StreamWriter(@"C:\Users\chaimw\Documents\write.txt"))
            {

            
                writetext.WriteLine(DayOfTransaction);
                writetext.WriteLine(Total);
            }
        }

        public decimal makePurchase()
        {
            Console.WriteLine("What would you like to buy. We have:");

            foreach (var product in products)
            {
                Console.WriteLine(product.ItemName);

            }
            string item = Console.ReadLine();
            Console.WriteLine("How many?");
            int quantity = int.Parse(Console.ReadLine());

            var price = products.Find(p => p.ItemName == item);
            decimal purchase = price.Price * quantity;
            decimal subTotal = Buy(purchase);
            Console.WriteLine("Would you like anything else?/n Y//N");
            string answer = Console.ReadLine();
            bool shopping = true;
            if (answer == "Y")
            {
                shopping = true;
                makePurchase();

            }
            else if (answer == "N")
            {
                shopping = false;
                Console.WriteLine("Your total is {0:C}", subTotal);
            }
            else
            {
               makePurchase();
            }
        }
        

    }
}      

       

       







    
   
