using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenFibonaciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonaci Fibber = new Fibonaci();
            List<int> numbers = Fibber.NumbersInSequenc;
            Fibber.CreateSequence(1, 2);
            List<int> evenNumbers = Fibber.EvenNumbersInSequence;
            foreach(int fib in numbers)
            {
                Fibber.AddEvenFibonaci(fib);
            }
            int totalOfFibs = evenNumbers.Sum();
            Console.WriteLine(totalOfFibs);
            Console.ReadLine();
        }
        public class Fibonaci
        {
            public List<int> NumbersInSequenc = new List<int>();
            public List<int> EvenNumbersInSequence = new List<int>();
            public void CreateSequence(int num1, int num2)
            {
                int num3 = 0;
                while(num1 <= 4000000)
                {
                    num3 = num1 + num2;
                    NumbersInSequenc.Add(num1);
                    num1 = num2;
                    num2 = num3;
                    
                }
                
            }
            public void AddEvenFibonaci(int fib)
            {
                if(fib % 2 == 0)
                {
                    EvenNumbersInSequence.Add(fib);
                }
            }
        }
    }
}
