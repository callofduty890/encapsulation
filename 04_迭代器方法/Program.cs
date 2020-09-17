using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _04_迭代器方法
{


    class Program
    {
        static void Main(string[] args)
        {
            foreach (int item in Fibs())
            {
                if (item < 1000)
                {
                    Console.Write("{0}\t", item);
                }
                else
                {
                    break;
                }
            }
            Console.ReadLine();
        }

        public static IEnumerable<int> Fibs()
        {
            int f1 = 1, f2 = 1;
            while (true)
            {
                yield return f1;
                yield return f2;
                f1 += f2;f2 += f1;
            }
        }

    }
}
