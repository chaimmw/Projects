using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largestPalindrome
{
    class Program
    {        //project euler 4
        static void Main(string[] args)
        {
            CheckIfPalindrome checkIfPalindrome = new CheckIfPalindrome();
            List<int> Palindromes = checkIfPalindrome.Palindromes;
            for (int i = 100; i < 1000; i++)
            {
                for(int j = 100; j < 1000; j++)
                {
                    int product = i * j;
                    
                    checkIfPalindrome.PalindromeChecker(product);
                    
                }
                
            }
            int largestPalindrome = Palindromes.Max();
            Console.WriteLine(largestPalindrome);
            Console.ReadLine();
        }
        public class CheckIfPalindrome
        {

       

            //list of palindromes
        public List<int> Palindromes = new List<int>();
        public void PalindromeChecker(int num)
        {
            int num1 = num;
            int num2 = _reverseNumber(num);
            if (num1 == num2)
            {
                Palindromes.Add(num);
            }

        }
        private int _reverseNumber(int number)
        {
                int reverse = 0;
                int remainder = 0;
                while (number > 0)
                {
                    remainder = number % 10;
                    reverse = (reverse * 10) + remainder;
                    number /= 10;
            
                }
                return reverse;
            }
        }

    }
}
