using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_递归方法
{
    class RecursionTest
    {
        public static  int factorial(int n)
        {
            if (n<=1) //递归调用
            {
                return 1;
            }
            else
            {
                return factorial(n - 1) * n;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //递归计算阶乘
            for (int i = 5; i <= 10; i++)
            {
                Console.Write("{0}!={1}\n", i, RecursionTest.factorial(i));
            }
            Console.ReadKey();
        }
    }
}
