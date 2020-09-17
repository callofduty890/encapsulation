using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_17_封装对象
{
    class OverLoadExample
    {
        public void SamleMothod(double i)
        {
            Console.WriteLine("SamleMothod(double i):{0}", i);
        }
        public void SamleMothod(int i)
        {
            Console.WriteLine("SamleMothod(int i):{0}", i);
        }
        public void SamleMothod(ref int i)
        {
            Console.WriteLine("SamleMothod(ref int i):{0}", i);
        }
        //public void SamleMothod(out int i) { }; //编译错误
    }

    class Program
    {
        static void Main(string[] args)
        {
            OverLoadExample Over = new OverLoadExample();
            int i = 10;double d = 11.1;
            Over.SamleMothod(i); //调用SamleMothod(int i)
            Over.SamleMothod(d);//调用SamleMothod(double i)
            Over.SamleMothod(ref i);//SamleMothod(ref int i)
            Console.ReadKey();

        }
    }
}
