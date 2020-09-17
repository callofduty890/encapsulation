using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_属性
{
    //通过get访问器将秒转换成小时，通过set访问器将每小时转换为秒
    class TimePeriod
    {
        private double seconds;
        public double Hours
        {
            get{ return seconds / 3600; }//转换成小时
            set 
            {
                if (value>0)
                {
                    seconds = value * 3600;//小时转换成秒
                }
                else
                {
                    Console.WriteLine("Hours的值不能为负数");
                }
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            TimePeriod t = new TimePeriod();
            t.Hours = -6;   //调用set访问器
            t.Hours = 6;    //调用set访问器
            //调用Get访问器
            Console.WriteLine("以小时为单位计算的时间:" + t.Hours);
            Console.ReadKey();
        }
    }
}
