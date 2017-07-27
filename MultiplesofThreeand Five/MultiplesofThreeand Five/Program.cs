using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesofThreeand_Five
{
    class Program
    {    //project euler 1
        static void Main(string[] args)
        {
            CheckIfDivisible CheckIfDivisible = new CheckIfDivisible();
            for (int i = 1; i < 1000; i++)
            {
                List<int> MyNumbers = CheckIfDivisible.MyNumbers;
                CheckIfDivisible.DivideBy(i);
                
            
             
            
            }
            int Total = CheckIfDivisible.Total();
            Console.WriteLine(Total);
            Console.ReadLine();
        }
        public class CheckIfDivisible
        {

            //list of numbers that are divisble by three and 5
            public List<int> MyNumbers = new List<int>();
            //checking...
            public void  DivideBy(int num)
            {
              if(num % 3 == 0)
                {
                    MyNumbers.Add(num);
                }
              else if(num % 5 == 0)
                {
                    MyNumbers.Add(num);
                }
              
            }
            public int Total()
            {
                int sum = MyNumbers.Sum();
                return sum;
            }

       
        }
   }
}
