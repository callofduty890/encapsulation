using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using _02_动态链接库;

namespace _01_外部方法
{
    //class MyPath
    //{
    //    //1.引用空间：using System.Runtime.InteropServices;
    //    //2.指定动态链接库：指定DLL的位置（在系统路径中/在当前EXE下/指定路径）
    //    [DllImport("kernel32.dll", SetLastError = true)] //引用 C++动态链接库
    //    public static extern int GetCurrentDirectory(int BufSize, StringBuilder buf);


    //    [DllImport("kernel32.dll", SetLastError = true)] //引用 C++动态链接库
    //    public static extern bool RemoveDirectory(string name);

    //}

    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(255);

            MyPath.GetCurrentDirectory(255, sb);

            Console.WriteLine(sb.ToString());

            Console.ReadLine();
        }
    }
}
