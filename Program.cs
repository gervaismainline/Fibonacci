using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            int temp = 0;
            int sum = 0;
            while(temp < 4000000)
            {
                temp = fib(i);
                Console.WriteLine(temp + "\n");
                if (temp % 2 == 0 && temp < 4000000)
                {
                    sum += temp;
                }
                i++;
            }
            Console.WriteLine(sum);

        }
        public static int fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if(n == 1)
            {
                return 1;
            }
            else
            {
                return (fib(n - 2) + fib(n - 1));
            }
        }
    }
}
